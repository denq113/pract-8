using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = textBox1.Text.Length;
            int b = textBox2.Text.Length;
            if (a > b)
            {
                label4.Text = label1.Text;
            }
            else if (b > a)
            {
                label4.Text = label2.Text;
            }
            else
            {
                label4.Text = "Ошибка они одинаковой длины";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
