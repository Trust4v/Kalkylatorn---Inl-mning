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
        public Kalkylatorn()
        {
            InitializeComponent();

        }

        private void tbxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Uträkning += "0";
            tbxOutput.Text = Uträkning;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Uträkning += "1";
            tbxOutput.Text = Uträkning;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Uträkning += "2";
            tbxOutput.Text = Uträkning;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Uträkning += "3";
            tbxOutput.Text = Uträkning;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Uträkning += "4";
            tbxOutput.Text = Uträkning;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Uträkning += "5";
            tbxOutput.Text = Uträkning;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Uträkning += "6";
            tbxOutput.Text = Uträkning;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Uträkning += "7";
            tbxOutput.Text = Uträkning;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Uträkning += "8";
            tbxOutput.Text = Uträkning;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Uträkning += "9";
            tbxOutput.Text = Uträkning;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (tbxOutput.Text != "")
            {
                num1 = double.Parse(Uträkning);
                Uträkning = "";
                tbxOutput.Text = Uträkning;
                metod = 1;
            }
            else
            {
                num1 = double.Parse(Uträkning);
                sum = num1 + double.Parse(Uträkning);
                Uträkning = sum.ToString();
                tbxOutput.Text = Uträkning;
            }
        }

        private void btnLikamed_Click(object sender, EventArgs e)
        {
            if (metod==1)
            {
                sum = num1 + double.Parse(Uträkning);
                Uträkning = sum.ToString();
                tbxOutput.Text = Uträkning;
            }
            
        }
    }
}
