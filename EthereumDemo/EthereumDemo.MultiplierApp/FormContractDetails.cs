using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthereumDemo.MultiplierApp
{
    public partial class FormContractDetails : Form
    {
        public FormContractDetails()
        {
            InitializeComponent();
        }

        public string ABI { get; set; }
        public string Bytecode { get; set; }

        private void FormContractDetails_Load(object sender, EventArgs e)
        {
            var abi = @"[
{
    ""constant"": false,
    ""inputs"": [
    {
        ""name"": ""a"",
        ""type"": ""uint256""
    }
    ],
    ""name"": ""multiply"",
    ""outputs"": [
    {
        ""name"": ""d"",
        ""type"": ""uint256""
    }
    ],
    ""payable"": false,
    ""stateMutability"": ""nonpayable"",
    ""type"": ""function""
},
{
    ""inputs"": [
    {
        ""name"": ""multiplier"",
        ""type"": ""uint256""
    }
    ],
    ""payable"": false,
    ""stateMutability"": ""nonpayable"",
    ""type"": ""constructor""
}
]";
            var byteCode = "0x6060604052341561000f57600080fd5b6040516020806100f283398101604052808051906020019091905050806000819055505060b1806100416000396000f300606060405260043610603f576000357c0100000000000000000000000000000000000000000000000000000000900463ffffffff168063c6888fa1146044575b600080fd5b3415604e57600080fd5b606260048080359060200190919050506078565b6040518082815260200191505060405180910390f35b60008054820290509190505600a165627a7a723058208a3b159a780cfcca3b0e15574ff612b28d95386ed88897c84db9bfcfb7f855f00029";
                           
            textBoxABI.Text = abi.Replace("\\r", Environment.NewLine);
            textBoxBytecode.Text = byteCode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ABI = textBoxABI.Text.Replace(Environment.NewLine, "");
            this.Bytecode = textBoxBytecode.Text;
            this.Close();
        }
    }
}
