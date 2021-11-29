using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW__5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100;
            int result = 0;
            while(a<500)
            {
                result = result + a;
                a++;
            }
            label1.Text=("Сумма целых чисел от 100 до 500 ="+result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int result = a;
            int c = 0;
            if (a<500)
            {
                while (a < 500)
                {
                    c = c + a;
                    a++;
                    label3.Text=("Сумма целых чисел от " + result + " до 500 = " + c);
                }
            }
            else
            {
                label3.Text = ("Error!!! a>b");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox2.Text);
            int a = b;
            int result = 0;
            for (int i = -10; i < a + 1; i = i + 1)
                result = result + i;
            label7.Text = ("Сумма целых чисел от -10 до " + b + " = " + result);
        }
    }
}
