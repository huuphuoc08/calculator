using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class pt2 : Form
    {
        public pt2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c;
            double delta, x1, x2;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            c = float.Parse(textBox3.Text);
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        textBox4.Text = "Phương Trình Có Vô Số Nghiệm!";
                    else
                        textBox4.Text = "Phương Trình Vô Nghiệm!";
                }
                else
                {
                    textBox4.Text = "Phương Trình Có 1 Nghiệm!";
                    x1 = (-c) / b;
                    textBox5.Text = x1.ToString();
                }
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    textBox4.Text = "Phương Trình Có 2 Nghiệm Phân Biệt!";
                    textBox5.Text = x1.ToString();
                    textBox6.Text = x2.ToString();
                }
                else
                    if (delta == 0)
                    {
                        textBox4.Text = "Phương Trình Có 1 Nghiệm Duy Nhất!";
                        x1 = (-b) / (2 * a);
                        textBox5.Text = x1.ToString();
                    }
                    else
                        textBox4.Text = "Phương Trình Vô Nghiệm!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = ""; 
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

      

        
    }
}
