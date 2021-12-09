using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenereCipher
{
    public partial class VigenereCipherForm : System.Windows.Forms.Form
    {
        private ErrorProvider errorProvider;

        public VigenereCipherForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            errorProvider.SetIconAlignment(keyTextBox, ErrorIconAlignment.MiddleRight);
            errorProvider.SetIconPadding(keyTextBox, 2);
        }

        private void toolStripDropDownAlphabetButton_Click(object sender, EventArgs e)
        {
            toolStripDropDownAlphabetButton.Text = "Alphabet:";
            toolStripEncryptionButton.Enabled = false;
            toolStripDecryptionButton.Enabled = false;
        }

        private void SetProperties()
        {
            toolStripLabelInstructions.Enabled = false;
            toolStripDropDownAlphabetButton.Enabled = false;
            toolStripEncryptionButton.Enabled = false;
            toolStripDecryptionButton.Enabled = false;
            step1TextBox.Enabled = true;
            step2TextBox.Enabled = false;
            step2TextBox.Text = "";
            keyTextBox.Enabled = true;
            operationButton.Enabled = true;
            step1Label.Enabled = true;
            step2Label.Enabled = true;
            keyLabel.Enabled = true;
            checkBoxPreservePunctuation.Enabled = true;
        }

        private void SetButtonProperties()
        {
            toolStripEncryptionButton.Enabled = true;
            toolStripDecryptionButton.Enabled = true;
        }

        private void latinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownAlphabetButton.Text = "English";
            SetButtonProperties();
        }

        private void cyrilicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownAlphabetButton.Text = "Bulgarian";
            SetButtonProperties();
        }

        private void toolStripEncryptionButton_Click(object sender, EventArgs e)
        {
            SetProperties();
            step1Label.Text = "Plain text:";
            step2Label.Text = "Cipher text:";
            operationButton.Text = "Encrypt";
        }

        private void toolStripDecryptionButton_Click(object sender, EventArgs e)
        {
            SetProperties();
            step1Label.Text = "Cipher text:";
            step2Label.Text = "Plain text:";
            operationButton.Text = "Decrypt";
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            step2TextBox.Enabled = true;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string alphabet = "";
                string bg = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ";
                string eng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string input = step1TextBox.Text;
                string key = keyTextBox.Text;
                bool isChecked = checkBoxPreservePunctuation.Checked;
                string output = "";

                if (toolStripDropDownAlphabetButton.Text.Equals("English"))
                    alphabet = eng;
                else if (toolStripDropDownAlphabetButton.Text.Equals("Bulgarian"))
                    alphabet = bg;

                if (operationButton.Text.Equals("Encrypt"))
                    output = Cipher.Encipher(alphabet, input, key, isChecked);
                else if (operationButton.Text.Equals("Decrypt"))
                    output = Cipher.Decipher(alphabet, input, key, isChecked);

                if (output.Equals("Wrong alphabet!"))
                    WrongAlphabet();
                else
                {
                    step2TextBox.Text = output;
                    toolStripLabelInstructions.Enabled = true;
                    toolStripDropDownAlphabetButton.Enabled = true;
                    toolStripEncryptionButton.Enabled = true;
                    toolStripDecryptionButton.Enabled = true;
                }
            }
        }

        private void toolStripRetryButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void WrongAlphabet()
        {
            step1TextBox.Text = "";
            keyTextBox.Text = "";
            step2TextBox.Text = "";
            MessageBox.Show("These are not letters from " + toolStripDropDownAlphabetButton.Text + " alphabet.",
                            "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void keyTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = keyTextBox.Text;
            bool result = true;
            foreach (char ch in input)
            {
                if (!Char.IsLetter(ch) && !Char.IsWhiteSpace(ch))
                {
                    result = false;
                    break;
                }
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                e.Cancel = true;
                keyTextBox.Focus();
                errorProvider.SetError(keyTextBox, "Key should not be empty!");
            }
            else if (!result)
            {
                e.Cancel = true;
                keyTextBox.Focus();
                errorProvider.SetError(keyTextBox, "Key should contain only letters and white spaces!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(keyTextBox, "");
            }
        }

        private void step1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (step1TextBox.TextLength > 250)
                step1TextBox.ScrollBars = ScrollBars.Vertical;
        }

        private void step2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (step2TextBox.TextLength > 250)
                step2TextBox.ScrollBars = ScrollBars.Vertical;
        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (keyTextBox.TextLength > 180)
                keyTextBox.ScrollBars = ScrollBars.Vertical;
        }
    }
}
