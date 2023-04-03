﻿using System;
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
    //tänk om klar
    //Nytt system eller nått klar
    //+/- knappen klar
    // 1/x knappen klar
    // nu uträkning måste klicka C klar

    public partial class Kalkylatorn : Form
    {
        #region Variabler
        string Uträkning = "";
        int metod = 0;
        double num1;
        double sum;
        string sumS;
        bool latest = false;
        bool viaPlus = false;
        double memory;
        
        public Kalkylatorn()
        {
            InitializeComponent();

        }
        #endregion
        #region Lika med
        private void btnLikamed_Click(object sender, EventArgs e)
        {
            if (Uträkning != "" || metod > 6)
            {
                if (!(metod > 6))
                {
                    num1 = double.Parse(Uträkning); 
                }
                switch (metod)
                {
                    case 1:
                        sum += num1;
                        break;
                    case 2:
                        sum -= num1;
                        break;
                    case 3:
                        if (num1 == 0)
                        {
                            MessageBox.Show("Du kan inte dividera med 0");
                        }
                        else
                        sum /= num1;
                        break;
                    case 4:
                        sum *= num1;
                        break;                    
                    case 5:
                        if (!latest)
                        {
                            sum = Math.Pow(sum, num1);
                        }                        
                        break;
                    case 6:
                        if (sum != 0)
                        {
                            sum = Math.Pow(sum, -1);
                        }
                        else
                        {
                            MessageBox.Show("Du kan inte dividera med 0");
                        }                        
                        break;
                    case 7:
                        if (sum >=0)
                        {
                            sum = Math.Sqrt(sum); 
                        }
                        else
                        {
                            MessageBox.Show("Du kan inte ta roten ur ett negativt tal");
                        }
                        break;
                    default:
                        sum = num1;
                        break;
                }
                if (!viaPlus)
                {
                    latest = true;
                }
                viaPlus = false;
                   
                tbxOutput.Text = sum.ToString();
                
            }
        }
        #endregion
        #region Inmatningsknappar
        private void btn0_Click_1(object sender, EventArgs e)
        {
            if (latest)
            {
                btnC.PerformClick();
            }
            if ((sender as Button).Text == "0")
            {
                if (Uträkning != "0")
                {
                    Uträkning += (sender as Button).Text;
                }
            }
            else
            {
                if (Uträkning == "0")
                {
                    Uträkning = Uträkning.Remove(Uträkning.Length - 1, 1);
                }
                Uträkning += (sender as Button).Text;

            }
            tbxOutput.Text = Uträkning;
        }
        private void btnKomma_Click(object sender, EventArgs e)
        {
            if (!Uträkning.Contains(","))
            {
                if (Uträkning == "")
                {
                    Uträkning += "0,";
                }
                else
                {
                    Uträkning += ",";
                }
            }
            tbxOutput.Text = Uträkning;
        }
        #endregion
        #region Metoder
        private void btnPlus_MouseClick(object sender, MouseEventArgs e)
        {

            if (metod <= 5 && !latest)
            {
                viaPlus = true;
                btnLikamed.PerformClick();
            }
            else
            {
                latest = false;
            }

            if ((sender as Button).Text == "+")
            {
                metod = 1;
            }
            else if ((sender as Button).Text == "-")
            {
                metod = 2;
            }
            else if ((sender as Button).Text == "/")
            {
                metod = 3;
            }
            else if ((sender as Button).Text == "*")
            {
                metod = 4;
            }            
            else if ((sender as Button).Text == "^x")
            {
                metod = 5;
            }
            else if ((sender as Button).Text == "1/x")
            {
                metod = 6;
            }
            else if ((sender as Button).Text == "√")
            {
                metod = 7;
            }
            if (metod > 5)
            {
                btnLikamed.PerformClick();
            }
            Uträkning = "";
        }
        private void btnInvers_Click(object sender, EventArgs e)
        {
            if (!latest)
            {
                Uträkning = (double.Parse(Uträkning) * -1).ToString();
                tbxOutput.Text = Uträkning;
            }
            else
            {
                sum *= -1;
                tbxOutput.Text = sum.ToString();
            }
            
        }
        #endregion
        #region Delete knappar 

        private void btnPil_Click(object sender, EventArgs e)
        {
            if (Uträkning != "" && !latest)
            {
                Uträkning = Uträkning.Remove(Uträkning.Length - 1, 1);
                tbxOutput.Text = Uträkning;
            }
            else if (sum!= 0)
            {
                sumS = sum.ToString();
                sumS = sumS.Remove(sumS.Length - 1, 1);
                if (sumS != "-")
                {
                    sum = double.Parse(sumS); 
                }
                else
                {
                    sum = 0;
                }
                tbxOutput.Text = sum.ToString();
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            sum = 0;
            metod = 0;
            num1 = 0;
            Uträkning = "";
            tbxOutput.Text = Uträkning;
            latest = false;
            viaPlus = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            Uträkning = "";
            tbxOutput.Text = Uträkning;
        }
        #endregion
        #region Memory
        private void btnMS_Click(object sender, EventArgs e)
        {
            if (tbxOutput.Text != "")
            {
                memory = double.Parse(tbxOutput.Text);
                lblMemory.Text = "Memory: " + memory;
                btnMC.Enabled = true;
                btnMR.Enabled = true;
                btnMPlus.Enabled = true;
                btnMMinus.Enabled = true;
            }            
        }
        private void btnMR_Click(object sender, EventArgs e)
        {
            Uträkning = memory.ToString();
            tbxOutput.Text = Uträkning;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memory = 0;
            lblMemory.Text = "Memory: ";
            btnMC.Enabled = false;
            btnMR.Enabled = false;
            btnMPlus.Enabled = false;
            btnMMinus.Enabled = false;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            if (Uträkning != "")
            {
                memory += double.Parse(tbxOutput.Text);
                lblMemory.Text = "Memory: " + memory; 
            }
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            if (Uträkning != "")
            {
                memory -= double.Parse(tbxOutput.Text);
                lblMemory.Text = "Memory: " + memory; 
            }
        }
        #endregion        
    }
}