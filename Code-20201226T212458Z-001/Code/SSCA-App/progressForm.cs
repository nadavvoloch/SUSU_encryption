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
    public partial class progressForm : Form
    {
        OpenFileDialog openFileDialog1;

        public progressForm()
        {
            InitializeComponent();
        }

        private void lblProgress_Click(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = @"check-Encrypted.txt";
            string sourcePath = TBPath.Text;
            string targetPath = @"\\" + textBox1.Text + @"\c$";
            //string targetPath = @"\\192.168.56.102\c$";

            // Use Path class to manipulate file and directory paths.
            //string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            try
            {
                File.Copy(sourcePath, destFile, true);
                MessageBox.Show("File was sent successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message + "");
            }
        }
    }
}
