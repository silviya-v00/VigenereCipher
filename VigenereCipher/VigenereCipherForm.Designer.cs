
namespace VigenereCipher
{
    partial class VigenereCipherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VigenereCipherForm));
            this.step1Label = new System.Windows.Forms.Label();
            this.step2Label = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.step1TextBox = new System.Windows.Forms.TextBox();
            this.step2TextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.checkBoxPreservePunctuation = new System.Windows.Forms.CheckBox();
            this.operationButton = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripEncryptionButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDecryptionButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripRetryButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripExitButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelInstructions = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownAlphabetButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulgarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // step1Label
            // 
            this.step1Label.AutoSize = true;
            this.step1Label.Enabled = false;
            this.step1Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step1Label.Location = new System.Drawing.Point(87, 59);
            this.step1Label.Name = "step1Label";
            this.step1Label.Size = new System.Drawing.Size(92, 24);
            this.step1Label.TabIndex = 12;
            this.step1Label.Text = "Plain text:";
            // 
            // step2Label
            // 
            this.step2Label.AutoSize = true;
            this.step2Label.Enabled = false;
            this.step2Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step2Label.Location = new System.Drawing.Point(527, 59);
            this.step2Label.Name = "step2Label";
            this.step2Label.Size = new System.Drawing.Size(106, 24);
            this.step2Label.TabIndex = 13;
            this.step2Label.Text = "Cipher text:";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Enabled = false;
            this.keyLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.keyLabel.Location = new System.Drawing.Point(87, 323);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(38, 24);
            this.keyLabel.TabIndex = 14;
            this.keyLabel.Text = "Key";
            // 
            // step1TextBox
            // 
            this.step1TextBox.Enabled = false;
            this.step1TextBox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step1TextBox.Location = new System.Drawing.Point(91, 99);
            this.step1TextBox.MinimumSize = new System.Drawing.Size(226, 200);
            this.step1TextBox.Multiline = true;
            this.step1TextBox.Name = "step1TextBox";
            this.step1TextBox.Size = new System.Drawing.Size(226, 200);
            this.step1TextBox.TabIndex = 8;
            this.step1TextBox.TextChanged += new System.EventHandler(this.step1TextBox_TextChanged);
            // 
            // step2TextBox
            // 
            this.step2TextBox.Enabled = false;
            this.step2TextBox.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.step2TextBox.Location = new System.Drawing.Point(531, 99);
            this.step2TextBox.MinimumSize = new System.Drawing.Size(226, 200);
            this.step2TextBox.Multiline = true;
            this.step2TextBox.Name = "step2TextBox";
            this.step2TextBox.Size = new System.Drawing.Size(226, 200);
            this.step2TextBox.TabIndex = 9;
            this.step2TextBox.TextChanged += new System.EventHandler(this.step2TextBox_TextChanged);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Enabled = false;
            this.keyTextBox.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.keyTextBox.Location = new System.Drawing.Point(91, 367);
            this.keyTextBox.MinimumSize = new System.Drawing.Size(4, 50);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(666, 50);
            this.keyTextBox.TabIndex = 10;
            this.keyTextBox.TextChanged += new System.EventHandler(this.keyTextBox_TextChanged);
            this.keyTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.keyTextBox_Validating);
            // 
            // checkBoxPreservePunctuation
            // 
            this.checkBoxPreservePunctuation.BackColor = System.Drawing.Color.AliceBlue;
            this.checkBoxPreservePunctuation.Checked = true;
            this.checkBoxPreservePunctuation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPreservePunctuation.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxPreservePunctuation.Enabled = false;
            this.checkBoxPreservePunctuation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPreservePunctuation.ForeColor = System.Drawing.Color.Black;
            this.checkBoxPreservePunctuation.Location = new System.Drawing.Point(91, 423);
            this.checkBoxPreservePunctuation.Name = "checkBoxPreservePunctuation";
            this.checkBoxPreservePunctuation.Size = new System.Drawing.Size(510, 50);
            this.checkBoxPreservePunctuation.TabIndex = 15;
            this.checkBoxPreservePunctuation.Text = "Preserve whitespaces and non-letter characters";
            this.checkBoxPreservePunctuation.UseVisualStyleBackColor = false;
            // 
            // operationButton
            // 
            this.operationButton.BackColor = System.Drawing.Color.SkyBlue;
            this.operationButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.operationButton.Enabled = false;
            this.operationButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.operationButton.Location = new System.Drawing.Point(370, 174);
            this.operationButton.Name = "operationButton";
            this.operationButton.Size = new System.Drawing.Size(108, 41);
            this.operationButton.TabIndex = 11;
            this.operationButton.Text = "Encrypt";
            this.operationButton.UseVisualStyleBackColor = false;
            this.operationButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripEncryptionButton
            // 
            this.toolStripEncryptionButton.BackColor = System.Drawing.Color.SkyBlue;
            this.toolStripEncryptionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripEncryptionButton.Enabled = false;
            this.toolStripEncryptionButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripEncryptionButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEncryptionButton.Image")));
            this.toolStripEncryptionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEncryptionButton.Name = "toolStripEncryptionButton";
            this.toolStripEncryptionButton.Size = new System.Drawing.Size(98, 24);
            this.toolStripEncryptionButton.Text = "Encryption";
            this.toolStripEncryptionButton.Click += new System.EventHandler(this.toolStripEncryptionButton_Click);
            // 
            // toolStripDecryptionButton
            // 
            this.toolStripDecryptionButton.BackColor = System.Drawing.Color.SkyBlue;
            this.toolStripDecryptionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDecryptionButton.Enabled = false;
            this.toolStripDecryptionButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDecryptionButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDecryptionButton.Image")));
            this.toolStripDecryptionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDecryptionButton.Name = "toolStripDecryptionButton";
            this.toolStripDecryptionButton.Size = new System.Drawing.Size(102, 24);
            this.toolStripDecryptionButton.Text = "Decryption";
            this.toolStripDecryptionButton.Click += new System.EventHandler(this.toolStripDecryptionButton_Click);
            // 
            // toolStripRetryButton
            // 
            this.toolStripRetryButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripRetryButton.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripRetryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripRetryButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripRetryButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRetryButton.Image")));
            this.toolStripRetryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRetryButton.Name = "toolStripRetryButton";
            this.toolStripRetryButton.Size = new System.Drawing.Size(53, 24);
            this.toolStripRetryButton.Text = "Retry";
            this.toolStripRetryButton.Click += new System.EventHandler(this.toolStripRetryButton_Click);
            // 
            // toolStripExitButton
            // 
            this.toolStripExitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripExitButton.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripExitButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripExitButton.ForeColor = System.Drawing.Color.Black;
            this.toolStripExitButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExitButton.Image")));
            this.toolStripExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExitButton.Name = "toolStripExitButton";
            this.toolStripExitButton.Size = new System.Drawing.Size(60, 24);
            this.toolStripExitButton.Text = "Exit";
            this.toolStripExitButton.Click += new System.EventHandler(this.toolStripExitButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripExitButton,
            this.toolStripLabelInstructions,
            this.toolStripSeparator1,
            this.toolStripDropDownAlphabetButton,
            this.toolStripSeparator2,
            this.toolStripEncryptionButton,
            this.toolStripSeparator3,
            this.toolStripDecryptionButton,
            this.toolStripSeparator4,
            this.toolStripRetryButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelInstructions
            // 
            this.toolStripLabelInstructions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripLabelInstructions.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabelInstructions.Name = "toolStripLabelInstructions";
            this.toolStripLabelInstructions.Size = new System.Drawing.Size(261, 24);
            this.toolStripLabelInstructions.Text = "Choose alphabet and operation:";
            // 
            // toolStripDropDownAlphabetButton
            // 
            this.toolStripDropDownAlphabetButton.BackColor = System.Drawing.Color.SkyBlue;
            this.toolStripDropDownAlphabetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownAlphabetButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.bulgarianToolStripMenuItem});
            this.toolStripDropDownAlphabetButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownAlphabetButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownAlphabetButton.Image")));
            this.toolStripDropDownAlphabetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownAlphabetButton.Name = "toolStripDropDownAlphabetButton";
            this.toolStripDropDownAlphabetButton.Size = new System.Drawing.Size(103, 24);
            this.toolStripDropDownAlphabetButton.Text = "Alphabet:";
            this.toolStripDropDownAlphabetButton.Click += new System.EventHandler(this.toolStripDropDownAlphabetButton_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.latinToolStripMenuItem_Click);
            // 
            // bulgarianToolStripMenuItem
            // 
            this.bulgarianToolStripMenuItem.Name = "bulgarianToolStripMenuItem";
            this.bulgarianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bulgarianToolStripMenuItem.Text = "Bulgarian";
            this.bulgarianToolStripMenuItem.Click += new System.EventHandler(this.cyrilicToolStripMenuItem_Click);
            // 
            // VigenereCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(845, 501);
            this.Controls.Add(this.checkBoxPreservePunctuation);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.step2Label);
            this.Controls.Add(this.step1Label);
            this.Controls.Add(this.operationButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.step2TextBox);
            this.Controls.Add(this.step1TextBox);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VigenereCipherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vigenere Cipher";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox step1TextBox;
        private System.Windows.Forms.TextBox step2TextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button operationButton;
        private System.Windows.Forms.Label step1Label;
        private System.Windows.Forms.Label step2Label;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelInstructions;
        private System.Windows.Forms.ToolStripButton toolStripEncryptionButton;
        private System.Windows.Forms.ToolStripButton toolStripDecryptionButton;
        private System.Windows.Forms.ToolStripButton toolStripRetryButton;
        private System.Windows.Forms.ToolStripButton toolStripExitButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.CheckBox checkBoxPreservePunctuation;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownAlphabetButton;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulgarianToolStripMenuItem;
    }
}

