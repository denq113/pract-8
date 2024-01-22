using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int b = textBox1.Text.Length;
            int g = 1;
            string[] c = new string[b];
            for (int i = 0; i < b; i++)
            {
                c[i] = Convert.ToString(textBox1.Text[b-g]);
                g++;
            }
           label2.Text=string.Join("", c);
        }
    }
}
