namespace TriangleForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            if (a == 0 || b == 0 || c == 0)
            {
                MessageBox.Show("����� �� ����� ���� 0!", "������");
            }
            else
            {
                bool error = false;
                if (a + b > c)
                    error = false;
                else
                    error = true;
                if ((a + c > b))
                    error = false;
                else
                    error = true;
                if (c + a > b)
                    error = false;
                else
                    error = true;

                if (error == true)
                {
                    MessageBox.Show("������ ��� ����� � ����� ������ ��������", "������");
                }
                else
                {
                    double d = a + b + c;
                    if (d % 2 == 0)
                    {
                        label2.Text = ("T���������� ��������������;");
                    }
                    else if ((a == b) || (b == c) || (c == a))
                    {
                        label2.Text = ("T���������� ��������������;");
                    }
                    else label2.Text = ("T���������� ��������������;");
                    double p = d / 2;
                    double ot = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    label2.Text += ("\n������� ������������=" + ot);

                    label2.Text += ("\n�������� ������������=" + d);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new Form2();
            a.Show();
            Hide();
        }
    }
}
