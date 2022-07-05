using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        public string d;
        public string numInTextbox;
        public bool flag;
        public Form1()
        {
            InitializeComponent();
        }


        private void Button22_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                TextBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = B.Text;
            }
            else TextBox1.Text += B.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            d = B.Text;
            numInTextbox = TextBox1.Text;
            flag = true;
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double res = 0;
            num1 = Convert.ToDouble(numInTextbox);
            num2 = Convert.ToDouble(TextBox1.Text);
            if (d == "+") {
                res = num1 + num2;
            }
            if (d == "-")
            {
                res = num1 - num2;
            }
            if (d == "*")
            {
                res = num1 * num2;
            }
            if (d == "/")
            {
                res = num1 / num2;
            }
            if (d == "%")
            {
                res = num1 / num2 * 100;
            }
            d = "=";
            flag = true;
            TextBox1.Text = res.ToString();
               
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            double num3, res;
            num3 = Convert.ToDouble(TextBox1.Text);
            res = Math.Sqrt(num3);
            TextBox1.Text = res.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double num3, res;
            num3 = Convert.ToDouble(TextBox1.Text);
            res = Math.Pow(num3, 2);
            TextBox1.Text = res.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            double num3, res;
            num3 = Convert.ToDouble(TextBox1.Text);
            res = 1 / num3;
            TextBox1.Text = res.ToString();
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            double num3, res;
            num3 = Convert.ToDouble(TextBox1.Text);
            res = -1 * num3;
            TextBox1.Text = res.ToString();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            TextBox1.Text += ",";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text  = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1);
            if (TextBox1.Text == "")
            {
                TextBox1.Text = "0";
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
