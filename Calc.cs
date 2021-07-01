using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
        
    {
        public Form1()
        {
            InitializeComponent();
        }
        char sign; // Знак
        string a; // Первое число
        string b; // Второе число
        bool check_sign = false; // Для выполнения действия, если не нажали "="
        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            check_sign = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += ',';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (check_sign) { calculate(); } // Пригодится в дальнейшем
            sign = '+';
            a = textBox1.Text;
            textBox1.Text += "+";
            check_sign = true;
        }
        public void calculate()
        {
            int i = a.Length + 1;
            while (i < textBox1.Text.Length)
            {
                b += textBox1.Text[i]; // Добавляем в переменную b, все цифры после знака
                i++;
            }
            if (sign == '+') { textBox1.Text = Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(b)); }
            if (sign == '-') { textBox1.Text = Convert.ToString(Convert.ToDouble(a) - Convert.ToDouble(b)); }
            if (sign == '*') { textBox1.Text = Convert.ToString(Convert.ToDouble(a) * Convert.ToDouble(b)); }
            if (sign == '/') { textBox1.Text = Convert.ToString(Convert.ToDouble(a) / Convert.ToDouble(b)); }
            if (sign == 'M')
            {
                if (Convert.ToDouble(a) > Convert.ToDouble(b))
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(b));
                }
                else if((Convert.ToDouble(a) < Convert.ToDouble(b)))
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(a));
                }
                else if (Convert.ToDouble(a) == Convert.ToDouble(b))
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(a));
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (check_sign) { calculate(); }
            sign = '*';
            a = textBox1.Text;
            textBox1.Text += "*";
            check_sign = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (check_sign) { calculate(); }
            sign = '-';
            a = textBox1.Text;
            textBox1.Text += "-";
            check_sign = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (check_sign) { calculate(); }
            sign = '/';
            a = textBox1.Text;
            textBox1.Text += "/";
            check_sign = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            calculate();
            check_sign = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (check_sign) { calculate(); }
            sign = 'M';
            a = textBox1.Text;
            textBox1.Text += "`";
            check_sign = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sign = '#';
            a = textBox1.Text;
            textBox1.Text = null;
            check_sign = false;
            textBox1.Text += "-"+a;
            check_sign = true;
        }
    }
}
