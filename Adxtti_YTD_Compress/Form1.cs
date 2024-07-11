using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            }
        }
    }
}
