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
using System.Security;
using System.Diagnostics;


namespace SSCA_App
{
    public partial class Form1 : Form
    {
        
        OpenFileDialog openFileDialog1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (Stream str = openFileDialog1.OpenFile())
                    {
                        TBPath.Text = filePath;
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (Stream str = openFileDialog1.OpenFile())
                    {
                        TBdic.Text = filePath;
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Dictionary dictionary = new Dictionary();
            dictionary.loadDictionary();
            if (CBAction.Text == "")
                MessageBox.Show("Action must be selected");
            if(CBAction.Text == "Encryption")
            {
                Encryption enc = new Encryption(dictionary, Convert.ToInt32(TBKeysN.Value), Convert.ToInt32(TBKeysM.Value), Convert.ToInt32(TBKeysD.Value), TBPath.Text);
                enc.generateSet();
                MessageBox.Show("Encryption was success");
            }
            if (CBAction.Text == "Decryption")
            {
                Decryption dec = new Decryption(dictionary, Convert.ToInt32(TBKeysN.Value), Convert.ToInt32(TBKeysM.Value), Convert.ToInt32(TBKeysD.Value), TBPath.Text);
                dec.translation();
                MessageBox.Show("Decryption was success");
            }
            if (CBAction.Text == "Send file")
            {
                progressForm pf = new progressForm();
                pf.ShowDialog();
            }
        }
    }
}

