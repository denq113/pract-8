using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            for (int i = 0; i < textBox1.Text.Length; i++) 
            {
                string j = Convert.ToString(textBox1.Text[i]);
                if (j == "a"|| j == "у"||j == "о" ||j == "ы" || j == "э" || j == "я" ||j == "ю" || j == "ё" || j == "и" || j == "е")
                {
                    a++;
                }
            }
            int f = textBox1.Text.Length;
            double b = a*100/f*1.0 ;
            label2.Text = b.ToString() + "%";
           
        }
    }
}
