using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh5_11_2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            txtEng.Text = "";
            txtMar.Text = "";
            txtHindi.Text = "";
            txtMaths.Text = "";
            txtScience.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox1.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String div = " ", result = " ";
            int m1 = Convert.ToInt32(txtEng.Text);
            int m2 = Convert.ToInt32(txtMar.Text);
            int m3 = Convert.ToInt32(txtHindi.Text);
            int m4 = Convert.ToInt32(txtMaths.Text);
            int m5 = Convert.ToInt32(txtScience.Text);

            int total = m1 + m2 + m3 + m4 + m5;
            float per = total * 100 / 500.0f;
            if(m1 >=35 && m2 >=35 && m3 >=35 & m4 >=35 && m5 >= 35)
            {
                result = "PASS";
                if (per >= 60)
                {
                    div = "I";
                }
                else if (per >= 45)
                {
                    div = "II";
                }
                else
                    div = "III";
                
            }
            else
            {
                result = "FALL";
                    div = "NA";
            }

            textBox3.Text = total.ToString();
            textBox4.Text = per.ToString();
            textBox5.Text =div;
            textBox6.Text = result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
