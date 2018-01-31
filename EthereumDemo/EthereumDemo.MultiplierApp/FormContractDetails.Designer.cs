namespace EthereumDemo.MultiplierApp
{
    partial class FormContractDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBytecode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxABI = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 662);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bytecode";
            // 
            // textBoxBytecode
            // 
            this.textBoxBytecode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBytecode.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBytecode.Location = new System.Drawing.Point(283, 662);
            this.textBoxBytecode.Multiline = true;
            this.textBoxBytecode.Name = "textBoxBytecode";
            this.textBoxBytecode.Size = new System.Drawing.Size(1174, 417);
            this.textBoxBytecode.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1117, 1119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 80);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxABI
            // 
            this.textBoxABI.Font = new System.Drawing.Font("Consolas", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxABI.Location = new System.Drawing.Point(283, 30);
            this.textBoxABI.Name = "textBoxABI";
            this.textBoxABI.Size = new System.Drawing.Size(1160, 604);
            this.textBoxABI.TabIndex = 8;
            this.textBoxABI.Text = "";
            // 
            // FormContractDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 1211);
            this.Controls.Add(this.textBoxABI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBytecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormContractDetails";
            this.Text = "FormContractDetails";
            this.Load += new System.EventHandler(this.FormContractDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBytecode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textBoxABI;
    }
}