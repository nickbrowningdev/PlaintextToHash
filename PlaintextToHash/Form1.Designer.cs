namespace PlaintextToHash
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.txtPlaintextInput = new System.Windows.Forms.TextBox();
            this.txtHashOutput = new System.Windows.Forms.TextBox();
            this.HashList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaintext:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hash:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hash Algorithm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status:";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(415, 158);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(111, 34);
            this.BtnCalculate.TabIndex = 4;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(415, 198);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(111, 34);
            this.BtnConfirm.TabIndex = 5;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // txtPlaintextInput
            // 
            this.txtPlaintextInput.Location = new System.Drawing.Point(83, 6);
            this.txtPlaintextInput.Multiline = true;
            this.txtPlaintextInput.Name = "txtPlaintextInput";
            this.txtPlaintextInput.Size = new System.Drawing.Size(463, 62);
            this.txtPlaintextInput.TabIndex = 6;
            // 
            // txtHashOutput
            // 
            this.txtHashOutput.Location = new System.Drawing.Point(83, 88);
            this.txtHashOutput.Multiline = true;
            this.txtHashOutput.Name = "txtHashOutput";
            this.txtHashOutput.Size = new System.Drawing.Size(463, 62);
            this.txtHashOutput.TabIndex = 7;
            // 
            // HashList
            // 
            this.HashList.FormattingEnabled = true;
            this.HashList.Items.AddRange(new object[] {
            "SHA256",
            "SHA384",
            "SHA512"});
            this.HashList.Location = new System.Drawing.Point(126, 164);
            this.HashList.Name = "HashList";
            this.HashList.Size = new System.Drawing.Size(121, 24);
            this.HashList.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 254);
            this.Controls.Add(this.HashList);
            this.Controls.Add(this.txtHashOutput);
            this.Controls.Add(this.txtPlaintextInput);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TextBox txtPlaintextInput;
        private System.Windows.Forms.TextBox txtHashOutput;
        private System.Windows.Forms.ComboBox HashList;
    }
}

