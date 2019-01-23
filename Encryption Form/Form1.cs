using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encryption_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void importTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK){
                path = openFileDialog1.FileName;
            }
            richTextBox1.Text = File.ReadAllText(path);
        }

        private void selectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK){
                path = openFileDialog1.FileName;
            }
            textBoxPath.Text = "path";
        }

        private void butFileDecrypt_Click(object sender, EventArgs e)
        {
            //Use Decryp method(file)
        }

        private void butEncryptFile_Click(object sender, EventArgs e)
        {
            //Use Encrypt method(file)
        }

        private void butEncryptText_Click(object sender, EventArgs e)
        {
            //Use Encrypt method(text)
        }
    }
}
