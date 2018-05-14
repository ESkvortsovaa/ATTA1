using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1._1._26
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
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                name = dialog.FileName;
            }
            label9.Text = dialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BL.FileWork file = new BL.FileWork(name);
            file.SumInt(out int sum, out int kol, out double sum2, out double kol2);
            label6.Text = Convert.ToString(kol);
            label5.Text =Convert.ToString(sum);
            label8.Text = Convert.ToString(kol2);
            label7.Text = Convert.ToString(sum2);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
