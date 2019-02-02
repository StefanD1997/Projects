using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceBetweenPlanets
{
    public partial class Form1 : Form
    {
        double x, y, z, sum, sum2;
        double distance, revolution, sumMass1;

        private void ClearKm_Click(object sender, EventArgs e)
        {
            if (z != 0 && sum2 != 0)
            {
                z = 0.00;
                sum2 = 0.00;
                zTb.Text = null;
                sumKmLabel.Text = null;
            }
            else
            {
                MessageBox.Show("There are no numbers to clear", "Error");
            }
            
        }

        private void clearMassNums_Click(object sender, EventArgs e)
        {
            if (distance != 0 && revolution != 0)
            {
                distance = 0;
                revolution = 0;
                distanceLabelInt.Text = "0";
                revolutionLabelInt.Text = "0";
                sumMassLabel.Text = "0";
                clearMassNums.Visible = false;
            }
            else
            {
                MessageBox.Show("There are no numbers to clear", "Error");
            }
        }

        private void sumMass_Click(object sender, EventArgs e)
        {
            if (dTb.Text != null && rTb.Text != null)
            {
                distance = Convert.ToDouble(dTb.Text);
                revolution = Convert.ToDouble(rTb.Text);
                distanceLabelInt.Text = Convert.ToString(string.Format("{0:n}", distance) + " km");
                revolutionLabelInt.Text = Convert.ToString(string.Format("{0:n}", revolution) + " day/s");
                sumMass1 = massFormula(distance, revolution);
                sumMassLabel.Text = Convert.ToString(string.Format("{0:n}", sumMass1));
                clearMassNums.Visible = true;
            }
            else
            {
                MessageBox.Show("There are no numbers to calculate", "Error");
            }
        }

        private void clearAu_Click(object sender, EventArgs e)
        {
            if (x != 0 && y != 0 && sum != 0)
            {
                x = 0.00;
                y = 0.00;
                sum = 0.00;
                xTb.Text = null;
                yTb.Text = null;
                sumAuLabel.Text = null;
            }
            else if (x != 0 && y == 0)
            {
                x = 0;
            }
            else
            {
                MessageBox.Show("There are no numbers to clear", "Error");
            }
            
        }

        private void sumKm_Click(object sender, EventArgs e)
        {
            if (sum != 0 && zTb.Text == "")
            {
                zTb.Text = sumAuLabel.Text;
                z = sum;
                sum2 = z * 150000000;
                sumKmLabel.Text = Convert.ToString(string.Format("{0:n}", sum2) + " km");
            }
            else if (zTb.Text != null)
            {
                z = Convert.ToDouble(zTb.Text);
                sum2 = z * 150000000;
                sumKmLabel.Text = Convert.ToString(string.Format("{0:n}", sum2) + " km");
            }
            else
            {
                MessageBox.Show("Please Enter a number", "Error");
            }
        }

        public Form1()
        {
            InitializeComponent();
            xTb.Text = null;
            yTb.Text = null;
            zTb.Text = null;
        }

        private void sumAu_Click(object sender, EventArgs e)
        {
            if (xTb.Text != null && yTb != null)
            {
                x = Convert.ToDouble(dTb.Text);
                y = Convert.ToDouble(yTb.Text);
                if (x > y)
                {
                    sum = x - y;
                }
                else
                {
                    sum = y - x;
                }
                sumAuLabel.Text = Convert.ToString(sum) + " AU";
            }
            else
            {
                MessageBox.Show("Please Enter both numbers", "Error");
            }
        }

        private double massFormula(double x, double y)
        {
            double m;
            const double G = 0.0000000000667;
            const double pi = 3.1415;
            y *= 86400;
            //m = ((4 * ((Math.Pow(pi, 2)) / G))) * ((Math.Pow(x, 3) / (Math.Pow(y, 2))));
            m = (4 * Math.Pow(pi, 2) * Math.Pow(x, 3)) / (G * Math.Pow(y, 2));
            return m;
        }
    }
}
