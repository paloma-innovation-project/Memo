using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
        }

        private string FileRead(string path)
        {
            //string path = @"C:\Users\MORIMOTOS\Desktop\新しいフォルダー (2)\test.txt";
            var enc = System.Text.Encoding.GetEncoding("shift-jis");
            System.IO.StreamReader sr = new System.IO.StreamReader(path, enc);
            //System.IO.StreamReader sr = new System.IO.StreamReader(path);
            string txt = sr.ReadToEnd();
            return txt;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = FileRead(openFileDialog1.FileName);
            }
        }
    }
}
