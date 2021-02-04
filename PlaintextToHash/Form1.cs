using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlaintextToHash;

namespace PlaintextToHash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            switch (HashList.Text)
            {
                case "SHA256":
                    txtHashOutput.Text = Hashing.ComputeHash(txtPlaintextInput.Text, Supported_HA.SHA256, null);
                    break;
                case "SHA384":
                    txtHashOutput.Text = Hashing.ComputeHash(txtPlaintextInput.Text, Supported_HA.SHA384, null);
                    break;
                case "SHA512":
                    txtHashOutput.Text = Hashing.ComputeHash(txtPlaintextInput.Text, Supported_HA.SHA512, null);
                    break;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            switch (HashList.Text)
            {
                case "SHA256":
                    label4.Text = (Hashing.Confirm(txtPlaintextInput.Text, txtHashOutput.Text, Supported_HA.SHA256)) ? "Status: Correct" : "Status: Incorrect";
                    break;
                case "SHA384":
                    label4.Text = (Hashing.Confirm(txtPlaintextInput.Text, txtHashOutput.Text, Supported_HA.SHA384)) ? "Status: Correct" : "Status: Incorrect";
                    break;
                case "SHA512":
                    label4.Text = (Hashing.Confirm(txtPlaintextInput.Text, txtHashOutput.Text, Supported_HA.SHA512)) ? "Status: Correct" : "Status: Incorrect";
                    break;
            }
        }
    }
}
