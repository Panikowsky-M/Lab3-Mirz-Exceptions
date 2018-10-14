using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, res;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a + b;
                textBox3.Text = "+(a,b)= " + res.ToString();
            }
            else MessageBox.Show("Невозможно выполнить операцию!\r\n" +
                             "Проверьте аргументы.", "Проверьте ввод !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, res;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a - b;
                textBox3.Text = "-(a,b)= " + res.ToString();
            }
            else MessageBox.Show("Ошибка ввода!\r\n" +
                             "Недопустимые а и б.","Недоп-е аргументы" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b, res;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a == 0 && b == 0) { MessageBox.Show("0/0 Неопределено", "Неопределенность!", MessageBoxButtons.OK); return; }
                if(b == 0) { MessageBox.Show("const/0 = inf", "Деление на 0", MessageBoxButtons.OK); return; }
                res = a/b;
                textBox3.Text = "/(a,b)= " + res.ToString();
            }
            else MessageBox.Show("Недопустимые аргументы!\r\n" +
                             "Проверьте а и б.", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, res;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a == 0 && b == 0) { MessageBox.Show("0/0 Неопределено", "Неопределенность!", MessageBoxButtons.OK); return; }
                if (b == 0) { MessageBox.Show("const/0 = inf", "Деление на 0", MessageBoxButtons.OK); return; }
                res = a * b;
                textBox3.Text = "multi(a,b)= " + res.ToString();
            }
            else MessageBox.Show("Недопустимые аргументы!\r\n" +
                             "Проверьте а и б.", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, res;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a%b;
                textBox3.Text = "mod(a,b)= " + res.ToString();
            }
            else MessageBox.Show("Ошибка ввода!\r\n" +
                             "Проверьте а и б.", "Недоп-е аргументы!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a == b) { textBox3.Text = "==(" + a.ToString() + "," + b.ToString() + "): true"; }
                else textBox3.Text = "==(" + a.ToString() + "," + b.ToString() + "): false";
            }
            else MessageBox.Show("Недопустимые аргументы!\r\n" +
                             "Проверьте а и б.", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a > b) {textBox3.Text = ">(" + a.ToString() +"," + b.ToString() + "): true"+"\r\n"; }
            else textBox3.Text = ">("+a.ToString()+","+b.ToString()+"): false";
            }
            else MessageBox.Show("Недопустимые аргументы!\r\n" +
                             "Проверьте а и б.", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a < b) { textBox3.Text = "<(" + a.ToString() + "," + b.ToString() + "): true"+"\r\n"; }
                else textBox3.Text = "<(" + a.ToString() + "," + b.ToString() + "): false"+"\r\n";
            }
            else MessageBox.Show("Недопустимые аргументы!\r\n" +
                             "Проверьте а и б.", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a >= b) { textBox3.Text = ">=(" + a.ToString() + "," + b.ToString() + "): true" + "\r\n"; }
                else textBox3.Text = ">=(" + a.ToString() + "," + b.ToString() + "): false" + "\r\n";
            }
            else MessageBox.Show("Недопустимые аргументы!\r\n" +
                             "Проверьте а и б.", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a <= b) { textBox3.Text = "<=(" + a.ToString() + "," + b.ToString() + "): true" + "\r\n"; }
                else textBox3.Text = "<=(" + a.ToString() + "," + b.ToString() + "): false" + "\r\n";
            }
            else MessageBox.Show("Недопустимые аргументы!\r\n" +
                             "Проверьте а и б.", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    }
