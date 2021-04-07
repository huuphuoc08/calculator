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
    public partial class pt1 : Form
    {
        public pt1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            

            if (a == 0)
            {
                if (b == 0)
                    textBox3.Text="Phương trình vô số nghiệm!";
                else
                    textBox3.Text ="Phương trình vô nghiệm!";
            }
            else
            {
                double x = (-b / a);
                textBox3.Text = x.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        

    }
}
