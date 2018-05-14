using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BL;


namespace _2._1._26
{
    public partial class Form1 : Form
    {
       string name = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            //OpenFileDialog dialog = new OpenFileDialog();

            //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    name = dialog.FileName;
            //}
            label1.Text = OpenFile.FileName;
        }

        private void Positive_Click(object sender, EventArgs e)
        {
            try
            {
                Delete Delete = new Delete(OpenFile.FileName);
                if (Regex.IsMatch(OpenFile.FileName, ".txt"))
                {
                    label2.Text = OpenFile.FileName;
                    Delete.DeleterPositiveOfFile();
                }
            }
            catch
            {
                MessageBox.Show("В обрабатываемых данных найдена ошибка");
            }
            
        }

        private void Negative_Click(object sender, EventArgs e)
        {
            try
            {
                Delete Delete = new Delete(OpenFile.FileName);
                if (Regex.IsMatch(OpenFile.FileName, ".txt"))
                {
                    label2.Text = OpenFile.FileName;
                    Delete.DeleterNegativeOfFile();
                }
            }
            catch
            {
                MessageBox.Show("В обрабатываемых данных найдена ошибка");
            }
        }

        private void Even_Click(object sender, EventArgs e)
        {
            try
            {
                Delete Delete = new Delete(OpenFile.FileName);
                if (Regex.IsMatch(OpenFile.FileName, ".txt"))
                {
                    label2.Text = OpenFile.FileName;
                    Delete.DeleterEvenOfFile();
                }
            }
            catch
            {
                MessageBox.Show("В обрабатываемых данных найдена ошибка");
            }
        }

        private void Odd_Click(object sender, EventArgs e)
        {
            try
            {
                Delete Delete = new Delete(OpenFile.FileName);
                if (Regex.IsMatch(OpenFile.FileName, ".txt"))
                {
                    label2.Text = OpenFile.FileName;
                    Delete.DeleterOddOfFile();
                }
            }
            catch
            {
                MessageBox.Show("В обрабатываемых данных найдена ошибка");
            }
        }
    }
}
