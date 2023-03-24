using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylatorn___Inlämning
{
    public partial class Kalkylatorn : Form
    {
        string Uträkning = "";
        int svaret = 0;
        int metod = 0;
        double num1;
        double sum;
        int räkna = 0;
        public Kalkylatorn()
        {
            InitializeComponent();

        }

        private void tbxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(!(tbxOutput.Text == ""))
            {
                tbxOutput.Text += "0";
            }
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxOutput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxOutput.Text += "2";
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxOutput.Text += "3";
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxOutput.Text += "4";
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxOutput.Text += "5";
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxOutput.Text += "6";
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxOutput.Text += "7";
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxOutput.Text += "8";
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxOutput.Text += "9";
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (tbxOutput.Text != "" && räkna == 0)
            {
                num1 = double.Parse(tbxOutput.Text);
                sum = num1;
                tbxOutput.Text = "";
            }
            else if (tbxOutput.Text != "" && räkna > 0)
            {
                num1 = sum;
                sum = num1 + double.Parse(tbxOutput.Text);
                tbxOutput.Text = "";
            }
            räkna++;

    }

    private void btnLikamed_Click(object sender, EventArgs e)
        {
            if (tbxOutput.Text != "")
            {
                sum = sum + double.Parse(tbxOutput.Text);
                tbxOutput.Text = sum.ToString();
                räkna = 0;
            }
            
        }
    }
}
