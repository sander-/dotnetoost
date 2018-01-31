using Nethereum.Contracts.CQS;
using Nethereum.Geth;
using Nethereum.Hex.HexTypes;
using Nethereum.Web3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthereumDemo.MultiplierApp
{
    public partial class FormMain : Form
    {
        FormContractDetails contractDetails = new FormContractDetails();

        public FormMain()
        {
            InitializeComponent();
        }

        private async void buttonDeploy_Click(object sender, EventArgs e)
        {
            
            var result = contractDetails.ShowDialog();
            if (result == DialogResult.OK)
            {
                var abi = contractDetails.ABI;
                var byteCode = contractDetails.Bytecode;
                var account = textBoxPublicKey.Text;
                var privateKey = textBoxPrivateKey.Text;

                var multiplier = 7;
                var web3 = new Web3Geth("http://localhost:8545");

                var unlockAccountResult = web3.Personal.UnlockAccount.SendRequestAsync(account, privateKey, 120);

                Log("Account opened.");

                var transactionHash = await web3.Eth.DeployContract.SendRequestAsync(abi, byteCode,
                    account, new HexBigInteger(900000), multiplier);

                Log("Contract deployed.");
                Log("Transaction hash: " + transactionHash);

                var mineResult = await web3.Miner.Start.SendRequestAsync(1);

                var receipt = await web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transactionHash);

                Log("Waiting for mining of the block.");

                while (receipt == null)
                {
                    Thread.Sleep(5000);
                    receipt = await web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transactionHash);
                }

                mineResult = await web3.Miner.Stop.SendRequestAsync();

                Log("Block mined.");

                var contractAddress = receipt.ContractAddress;

                Log("Contract address: " + contractAddress);

                textBoxContractAddress.Text = contractAddress;
            }
            else
            {
                MessageBox.Show("Afgebroken");
            }
        }

        private void Log(string message)
        {
            textBoxLog.Text += message;
            textBoxLog.Text += Environment.NewLine;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Vervang deze sleutels voor de sleutels geleverd via Ganache
            textBoxPublicKey.Text = "0x12da4fd18ef2eee6e3cb4db81438528bcbe8e414";
            textBoxPrivateKey.Text = "143b0874dece3e45237f518f60d6161706e14ba3ad60a1a7994d2d9dc24961ee";
        }

        private void buttonDoMultiply_Click(object sender, EventArgs e)
        {
            var account = textBoxPublicKey.Text;
            var privateKey = textBoxPrivateKey.Text;
            var contractAddress = textBoxContractAddress.Text;
            var abi = contractDetails.ABI;
            var factor = (int)numericUpDownFactor.Value;

            var web3 = new Web3Geth("http://localhost:8545");

            Log("Account opened.");

            var unlockAccountResult = web3.Personal.UnlockAccount.SendRequestAsync(account, privateKey, 120);

            var contract = web3.Eth.GetContract(abi, contractAddress);
                        
            var multiplyFunction = contract.GetFunction("multiply");

            Log("Calling multiply");
            var result = multiplyFunction.CallAsync<int>(factor);

            Log("Result: " + result.Result);
        }
    }
}
