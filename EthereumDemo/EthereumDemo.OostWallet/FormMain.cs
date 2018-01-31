using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts.CQS;
using Nethereum.Geth;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthereumDemo.OostWallet
{
    public partial class FormMain : Form
    {
        private const string TEST_NET_URL = "https://rinkeby.infura.io";
        private const string LIVE_NET_URL = "https://mainnet.infura.io";

        private const string TEST_NET_CONTRACT = "0x797CccE0917E30c1b3c620DbB28892dFd940F6CF";
        private const string LIVE_NET_CONTRACT = "0x2ef06079656f2ab9034b6252978c44104b7b2cc1";

        private string _activeNetUrl;
        private string _activeNetContract;
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxPublicKey.Text = "";
            textBoxPrivateKey.Text = "";

            _activeNetUrl = TEST_NET_URL;
            _activeNetContract = TEST_NET_CONTRACT;

            //_activeNetUrl = LIVE_NET_URL;
            //_activeNetContract = LIVE_NET_CONTRACT;
        }

        private async void buttonConnect_Click(object sender, EventArgs e)
        {
            var account = textBoxPublicKey.Text;
            var web3 = new Web3Geth(_activeNetUrl);

            var balanceOfFunctionMessage = new BalanceOfFunction()
            {
                Owner = account
            };

            var balanceHandler = web3.Eth.GetContractQueryHandler<BalanceOfFunction>();
            var balance = await balanceHandler.QueryAsync<BigInteger>(balanceOfFunctionMessage, _activeNetContract);
            this.labelBalance.Text = Web3.Convert.FromWei(balance, 8).ToString();
            numericUpDownAmount.Maximum = Web3.Convert.FromWei(balance, 8);
        }

        private async void buttonTransfer_Click(object sender, EventArgs e)
        {
            var privateKey = textBoxPrivateKey.Text;
            var receiverAddress = textBoxReceiver.Text;

            var contractAddress = _activeNetContract;

            var account = new Account(privateKey);
            var web3 = new Web3(account, _activeNetUrl);

            Log("Getting contract.");
            var contract = web3.Eth.GetContract<ContractMessage>(contractAddress);

            var tokenAmount = new BigInteger(numericUpDownAmount.Value * 100000000);    

            Log("Creating transaction message for " + numericUpDownAmount.Value + " OOST.");

            var transactionMessage = new TransferFunction()
            {
                FromAddress = account.Address,
                TokenAmount = tokenAmount,
                To = receiverAddress,
                GasPrice = new BigInteger(1000000000), // Gelijk aan 1 GWEI
                Gas = new BigInteger(210000)           // Maximale Gas limiet
            };

            var transferHandler = web3.Eth.GetContractTrasactionHandler<TransferFunction>();

            var transferReceipt = await transferHandler.SendRequestAndWaitForReceiptAsync(transactionMessage,
                contractAddress);

            Log("Transaction finished.");
            Log("Gas used: " + transferReceipt.GasUsed.Value);
            Log("Updating balance.");

            var balanceOfFunctionMessage = new BalanceOfFunction()
            {
                Owner = account.Address
            };

            var balanceHandler = web3.Eth.GetContractQueryHandler<BalanceOfFunction>();
            var balance = await balanceHandler.QueryAsync<BigInteger>(balanceOfFunctionMessage, _activeNetContract);
            this.labelBalance.Text = Web3.Convert.FromWei(balance, 8).ToString();
            numericUpDownAmount.Maximum = Web3.Convert.FromWei(balance, 8);
        }

        private void Log(string message)
        {
            textBoxLog.Text += message;
            textBoxLog.Text += Environment.NewLine;
        }

        private void textBoxPublicKey_TextChanged(object sender, EventArgs e)
        {
            textBoxPrivateKey.Text = "";
        }
    }


    [Function("balanceOf", "uint256")]
    public class BalanceOfFunction : ContractMessage
    {

        [Parameter("address", "_owner", 1)]
        public string Owner { get; set; }
    }

    [Function("transfer", "bool")]
    public class TransferFunction : ContractMessage
    {
        [Parameter("address", "_to", 1)]
        public string To { get; set; }

        [Parameter("uint256", "_value", 2)]
        public BigInteger TokenAmount { get; set; }
    }
}
