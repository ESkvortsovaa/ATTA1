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
using BL;

namespace _1._1._26
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string[] B = textBox1.Text.Split(' ');
            ////char[] H = textBox1.Text.ToCharArray(); //в массив char 
            //string[] B = textBox1.Text.Split(' '); // в массив string 
            //int i = 0;
            //foreach (char c in H)
            //{
            //    B[i] = c.ToString(); i++;
            //}

            Numbers Numbers2 = new Numbers(B);

            textBox2.Text = Numbers2.FindSummaForInt().ToString();
            textBox3.Text = Numbers2.FindCountForInt().ToString();
            textBox4.Text = Numbers2.FindSummaForDoubl().ToString();
            textBox5.Text = Numbers2.FindCountForDoubl().ToString();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            //MessageBox.Show("Файл открыт");
           // label7.Text = openFileDialog1.FileName;
        }
    }
}
