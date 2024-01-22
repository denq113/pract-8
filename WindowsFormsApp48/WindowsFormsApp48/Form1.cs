using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           char a = textBox1.Text[0];
           int b = textBox2.Text.Length - 1;
           char c = textBox2.Text[b];
            if (c == a)
            {
                label5.Text = "Верно";
            }
            else
            {
                label5.Text = "Неверно";
            }
        }
    }
}
