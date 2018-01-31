namespace EthereumDemo.MultiplierApp
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonDeploy = new System.Windows.Forms.Button();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDoMultiply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxContractAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownFactor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.Location = new System.Drawing.Point(0, 553);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(1464, 506);
            this.textBoxLog.TabIndex = 0;
            // 
            // buttonDeploy
            // 
            this.buttonDeploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeploy.Location = new System.Drawing.Point(1112, 182);
            this.buttonDeploy.Name = "buttonDeploy";
            this.buttonDeploy.Size = new System.Drawing.Size(340, 88);
            this.buttonDeploy.TabIndex = 1;
            this.buttonDeploy.Text = "Deploy Contract";
            this.buttonDeploy.UseVisualStyleBackColor = true;
            this.buttonDeploy.Click += new System.EventHandler(this.buttonDeploy_Click);
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrivateKey.Location = new System.Drawing.Point(296, 110);
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(1156, 56);
            this.textBoxPrivateKey.TabIndex = 2;
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublicKey.Location = new System.Drawing.Point(296, 32);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(1156, 56);
            this.textBoxPublicKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 51);
            this.label2.TabIndex = 5;
            this.label2.Text = "Private Key";
            // 
            // buttonDoMultiply
            // 
            this.buttonDoMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoMultiply.Location = new System.Drawing.Point(1112, 454);
            this.buttonDoMultiply.Name = "buttonDoMultiply";
            this.buttonDoMultiply.Size = new System.Drawing.Size(340, 80);
            this.buttonDoMultiply.TabIndex = 6;
            this.buttonDoMultiply.Text = "Run Multiplier";
            this.buttonDoMultiply.UseVisualStyleBackColor = true;
            this.buttonDoMultiply.Click += new System.EventHandler(this.buttonDoMultiply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 51);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contract Address";
            // 
            // textBoxContractAddress
            // 
            this.textBoxContractAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContractAddress.Location = new System.Drawing.Point(354, 301);
            this.textBoxContractAddress.Name = "textBoxContractAddress";
            this.textBoxContractAddress.Size = new System.Drawing.Size(1098, 56);
            this.textBoxContractAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 51);
            this.label4.TabIndex = 9;
            this.label4.Text = "Multiply This";
            // 
            // numericUpDownFactor
            // 
            this.numericUpDownFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFactor.Location = new System.Drawing.Point(354, 379);
            this.numericUpDownFactor.Name = "numericUpDownFactor";
            this.numericUpDownFactor.Size = new System.Drawing.Size(120, 56);
            this.numericUpDownFactor.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 1059);
            this.Controls.Add(this.numericUpDownFactor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxContractAddress);
            this.Controls.Add(this.buttonDoMultiply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPublicKey);
            this.Controls.Add(this.textBoxPrivateKey);
            this.Controls.Add(this.buttonDeploy);
            this.Controls.Add(this.textBoxLog);
            this.Name = "FormMain";
            this.Text = "Multiply on the blockchain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonDeploy;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDoMultiply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContractAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownFactor;
    }
}

