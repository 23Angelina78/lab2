using static System.Net.Mime.MediaTypeNames;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt9 = " Коваль Ангеліна";
            textBox9.Text = txt9.ToString();

            string txt6 = " КН21-1";
            textBox6.Text = txt6.ToString();

            string astr, bstr, cstr;

            astr = textBox1.Text;
            bstr = textBox2.Text;
            cstr = textBox3.Text;

            double a, b, c;

            a = Convert.ToInt32(astr);
            b = Convert.ToInt32(bstr);
            c = Convert.ToInt32(cstr);


            if (a == 0 && b != 0 && c != 0)
            {
                double x;
                string txt = " Відповіді для х2 немає";

                x = -c / b;
                textBox7.Text = x.ToString();
                textBox8.Text = txt.ToString();
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                string txt = " Ваша відповідь c != 0" + "(" + c + " != 0)";
                textBox7.Text = txt.ToString();
            }
            else if (a == 0 && b == 0 && c == 0)
            {
                string txt = " Відповіді для х2 немає";
                string txt2 = " Відповіді для х1 немає";

                textBox8.Text = txt.ToString();
                textBox7.Text = txt2.ToString();
            }
            else if (a != 0 && b != 0 && c == 0)
            {
                double x1, x2;

                x1 = 0;
                x2 = -b / a;

                textBox8.Text = x1.ToString();
                textBox7.Text = x2.ToString();
            }
            else
            {

                double D;

                D = Math.Pow(b, 2) - (4 * a * c);

                textBox4.Text = D.ToString();

                if (D == 0)
                {
                    string txt = " Відповіді для х2 немає";

                    double x = -b / (2 * a);

                    textBox7.Text = x.ToString();
                    textBox8.Text = txt.ToString();
                }
                else if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                    textBox7.Text = x1.ToString();
                    textBox8.Text = x2.ToString();
                }
                else if (D < 0)
                {
                    string txt = " Відповіді для х2 немає";
                    string txt2 = " Відповіді для х1 немає";

                    textBox8.Text = txt.ToString();
                    textBox7.Text = txt2.ToString();
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
