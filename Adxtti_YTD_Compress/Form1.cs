using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeWalker.GameFiles;

namespace Adxtti_YTD_Compress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "YTD files (*.ytd)|*.ytd"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFileDialog.FileNames;
                label2.Text = $".YTD'S LOADED: {files.Length}";
                listBox1.Items.Clear();

                foreach (string file in files)
                {
                    listBox1.Items.Add(file);
                    label4.Text = "Progress: Files loaded";
                }

                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
                MessageBox.Show("Your textures will compress to 1/2 of their size, meaning 2048x2048 to 1024x1024. Please define an output directory next.", "Compression Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button4.Enabled = true;
            }
            else
            {
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label2.Text = ".YTD'S LOADED: 0";
            checkBox1.Enabled = false;
            checkBox1.Checked = false;
            checkBox2.Enabled = false;
            checkBox2.Checked = false;
            label4.Text = "Progress: No files loaded";
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
