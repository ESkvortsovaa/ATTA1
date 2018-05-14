﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;



namespace _3._1._26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {

            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(OpenFile.FileName, ".txt"))
                {
                    SortStudents STD = new SortStudents(OpenFile.FileName);
                    string output = label1.Text;
                    Name = STD.SearchFive();
                    label1.Text = output + Environment.NewLine + Name;
                }
                else MessageBox.Show("Ошибка!");
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
