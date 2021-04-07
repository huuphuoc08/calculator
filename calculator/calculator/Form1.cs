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
    public partial class Form1 : Form
    {
        
        string sign;
        double tam1;
        double tam2;
        int doikitu = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void clear()
        {

        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd0.Text;
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd1.Text;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd2.Text;
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd3.Text;
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd4.Text;
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd5.Text;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd6.Text;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd7.Text;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd8.Text;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd9.Text;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            sign = "+";
            tam1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdEqual_Click(object sender, EventArgs e)
        {
            tam2 = double.Parse(txtBox.Text);
            double result;
            if (sign == "+")
            {
                result = tam1 + tam2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "-")
            {
                result = tam1 - tam2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "*")
            {
                result = tam1 * tam2;
                txtBox.Text = result.ToString();
            }
            else
            {
                result = tam1 / tam2;
                txtBox.Text = result.ToString();
            }
           

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {

            txtBox.Text = "";
            tam1 = 0;
            tam2 = 0;
            sign = "";
        }

        private void cmdTan_Click_1(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Tan(v).ToString();
        }

        private void cmdCos_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Cos(v).ToString();
        }

        private void cmdSin_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Sin(v).ToString();
        }

        private void cmdSquare_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Pow(v, 2).ToString();
        }

        private void cmdSqrt_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Sqrt(v).ToString();
        }

        private void cmdSubtract_Click(object sender, EventArgs e)
        {
            sign = "-";
            tam1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdMultiply_Click(object sender, EventArgs e)
        {
            sign = "*";
            tam1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdDivide_Click(object sender, EventArgs e)
        {
            sign = "/";
            tam1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int kitu;
            kitu = e.KeyChar;
            if (kitu >= 48 && kitu <= 57 || kitu == 8 || kitu == 32 || kitu == 46)
            {
                if (kitu == 46) ++doikitu;
                if (doikitu > 1) { e.Handled = true; --doikitu; }
            }
            else e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtBox.Text);

            int gt = 1;

            for (int i = 1; i <= n; i++)
            {
                gt = gt * i;
            }
            txtBox.Text = gt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pt1 a = new pt1();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pt2 a = new pt2();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

    }
}
