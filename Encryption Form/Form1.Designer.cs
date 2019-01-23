namespace Encryption_Form
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butEncryptText = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butFileDecrypt = new System.Windows.Forms.Button();
            this.butEncryptFile = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(525, 538);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text-To-File Encryption";
            // 
            // butEncryptText
            // 
            this.butEncryptText.Location = new System.Drawing.Point(610, 574);
            this.butEncryptText.Name = "butEncryptText";
            this.butEncryptText.Size = new System.Drawing.Size(156, 84);
            this.butEncryptText.TabIndex = 2;
            this.butEncryptText.Text = "Encrypt Text";
            this.butEncryptText.UseVisualStyleBackColor = true;
            this.butEncryptText.Click += new System.EventHandler(this.butEncryptText_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Txt Files (*.txt; *.rtf)|*.txt; *.rtf\"";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importTextToolStripMenuItem,
            this.selectFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importTextToolStripMenuItem
            // 
            this.importTextToolStripMenuItem.Name = "importTextToolStripMenuItem";
            this.importTextToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.importTextToolStripMenuItem.Text = "Import Text";
            this.importTextToolStripMenuItem.Click += new System.EventHandler(this.importTextToolStripMenuItem_Click);
            // 
            // selectFileToolStripMenuItem
            // 
            this.selectFileToolStripMenuItem.Name = "selectFileToolStripMenuItem";
            this.selectFileToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.selectFileToolStripMenuItem.Text = "Select File";
            this.selectFileToolStripMenuItem.Click += new System.EventHandler(this.selectFileToolStripMenuItem_Click);
            // 
            // butFileDecrypt
            // 
            this.butFileDecrypt.Location = new System.Drawing.Point(899, 217);
            this.butFileDecrypt.Name = "butFileDecrypt";
            this.butFileDecrypt.Size = new System.Drawing.Size(211, 84);
            this.butFileDecrypt.TabIndex = 4;
            this.butFileDecrypt.Text = "File Decrypt";
            this.butFileDecrypt.UseVisualStyleBackColor = true;
            this.butFileDecrypt.Click += new System.EventHandler(this.butFileDecrypt_Click);
            // 
            // butEncryptFile
            // 
            this.butEncryptFile.Location = new System.Drawing.Point(610, 217);
            this.butEncryptFile.Name = "butEncryptFile";
            this.butEncryptFile.Size = new System.Drawing.Size(211, 84);
            this.butEncryptFile.TabIndex = 3;
            this.butEncryptFile.Text = "Encrypt File";
            this.butEncryptFile.UseVisualStyleBackColor = true;
            this.butEncryptFile.Click += new System.EventHandler(this.butEncryptFile_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(610, 120);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(500, 31);
            this.textBoxPath.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(610, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "File-To-File Encrypt/Decrypt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.butFileDecrypt);
            this.Controls.Add(this.butEncryptFile);
            this.Controls.Add(this.butEncryptText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butEncryptText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFileToolStripMenuItem;
        private System.Windows.Forms.Button butFileDecrypt;
        private System.Windows.Forms.Button butEncryptFile;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label2;
    }
}

