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
        Encrypt encode;
        Decryp  decode;

        public Form1()
        {
            encode = new Encrypt();
            decode = new Decryp();

            InitializeComponent();
        }

    //------SELECT FILE---------------------------------//

        private void selectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Selects a file.
            string path = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK){
                path = openFileDialog1.FileName;
            }
            textBoxPath.Text = path;

            //Import text to the richTextBox1
            richTextBox1.Text = File.ReadAllText(path);
        }

    //------TEXT----------------------------------------//
        
        private void btnEncryptText_Click_1(object sender, EventArgs e)
        {
            //Use Encrypt method on richTextBox1
            richTextBox1.Text = encode.encodeText(richTextBox1.Text);
        }

        private void btnDecryptText_Click(object sender, EventArgs e)
        {
            //Use Decrypt method on richTextBox1
            richTextBox1.Text = decode.decodeText(richTextBox1.Text);
        }

    //------FILE----------------------------------------//

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            //Use Encrypt method(file)
            encode.encodeFile(textBoxPath.Text);
        }
                        
        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            //Use Decryp method(file)
            decode.decodeFile(textBoxPath.Text);
        }

    //------SAVE----------------------------------------//

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            string path = textBoxPath.Text;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK){
                 //overwrite file with text in richTextBox1 message;
                File.WriteAllText(richTextBox1.Text, textBoxPath.Text);
            }//end if
        }

    //------EXIT----------------------------------------//

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }//class
}//name
