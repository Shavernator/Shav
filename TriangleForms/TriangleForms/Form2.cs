using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace TriangleForms
{
    public partial class Form2 : Form
    {
        //a + Pow(b, 2) + c;
        public Form2()
        {
            InitializeComponent();
        }
        int a, b, c;
        double D;
        double ot;
        private void button1_Click(object sender, EventArgs e)
        {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);

            D = Pow(b, 2) - 4 * a * c;

            if (D < 0)
            {
                label6.Text = "Кол-во корней: " + 0;
                label7.Text = "Результат:-";
            }
            else if (D == 0)
            {
                label6.Text = "Кол-во корней: " + 1;
                ot = (-b + Sqrt(D)) / (2 * a);
                label7.Text = "Результат:" + ot;
            }
            else
            {
                label6.Text = "Кол-во корней: " + 2;
                ot = (-b + Sqrt(D)) / (2 * a);
                label7.Text = "Результат: x1=" + ot;
                ot = (-b - Sqrt(D)) / (2 * a);
                label7.Text += ";\n x2=" + ot;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);

            if (D < 0)
            {
                label6.Text = "Кол-во корней: " + 0;
                label7.Text = "Результат:-";
            }
            else if (D == 0)
            {
                label6.Text = "Кол-во корней: " + 1;
                ot = (-b + Sqrt(D)) / (2 * a);
                label7.Text = "Результат:" + ot;
            }
            else
            {
                label6.Text = "Кол-во корней: " + 2;
                ot = (-b + Sqrt(D)) / (2 * a);
                label7.Text = "Результат: x1=" + ot;
                ot = (-b - Sqrt(D)) / (2 * a);
                label7.Text += ";\n x2=" + ot;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label6.Text = "Кол-во корней:";
            label7.Text = "Результат:";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу подготовил:\n Сергеев Данил\n для Практической работы", "Справка");
        }
    }
}
