using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Calculator
{
    public partial class Form1 : Form
    {
        decimal n1 = 0.0m, n2 = 0.0m, sum = 0.0m;

        private void addValue(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (n1 == 0.0m)
            {
                num1.Text = screenNumber.Text;
                n1 = Convert.ToDecimal(screenNumber.Text);
                screenNumber.Text = null;
            }
            else if (n2 == 0.0m)
            {
                num2.Text = screenNumber.Text;
                n2 = Convert.ToDecimal(screenNumber.Text);
                screenNumber.Text = null;
            }
            else
            {
                MessageBox.Show("Please clear the numbers before adding new numbers.", "Error");
                screenNumber.Text = null;
            }
        }

        private void clearNums(object sender, EventArgs e)
        {
            if (n1 != 0.0m && n2 != 0.0m || operationsSign != null)
            {
                n1 = 0.0m;
                n2 = 0.0m;
                sum = 0.0m;
                num1.Text = Convert.ToString(0);
                num2.Text = Convert.ToString(0);
                totalSum.Text = Convert.ToString(0);
                operationsSign.Text = null;
            }
            else if (n1 != 0.0m && n2 == 0.0m)
            {
                n1 = 0.0m;
                num1.Text = Convert.ToString(0);
            }
            else if (n1 == 0.0m && n2 != 0.0m)
            {
                n2 = 0.0m;
                num2.Text = Convert.ToString(0);
            }
            else
            {
                MessageBox.Show("There are no numbers to clear", "Please enter a number.");
            }
        }

        private void clearNumOnScreen(object sender, EventArgs e)
        {
            if (screenNumber.Text != null)
            {
                screenNumber.Text = null;
            }
        }

        private void newOperations(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string x = btn.Text;
            if (n1 == 0.0m)
            {
                n1 = Convert.ToDecimal(screenNumber.Text);
                num1.Text = Convert.ToString(string.Format("{0:n}", n1));
                operationsSign.Text = x;
                screenNumber.Text = null;
            }
            if (sum != 0.0m)
            {
                n1 = sum;
                num1.Text = Convert.ToString(string.Format("{0:n}", n1));
                num2.Text = Convert.ToString(0);
                totalSum.Text = Convert.ToString(0);
                operationsSign.Text = x;
                screenNumber.Text = null;
                n2 = 0.0m;
            }
        }

        private void onEquals(object sender, EventArgs e)
        {
            string op = operationsSign.Text;
            if (n1 == 0.0m)
            {
                MessageBox.Show("Please enter a number", "No number entered");
            }
            else
            {
                n2 = Convert.ToDecimal(screenNumber.Text);
                num2.Text = Convert.ToString(string.Format("{0:n}", n2));
            }

            switch (op)
            {
                case "+":
                    sum = n1 + n2;
                    screenNumber.Text = Convert.ToString(string.Format("{0:n}", sum));
                    totalSum.Text = Convert.ToString(string.Format("{0:n}", sum));
                    break;
                case "-":
                    sum = n1 - n2;
                    screenNumber.Text = Convert.ToString(string.Format("{0:n}", sum));
                    totalSum.Text = Convert.ToString(string.Format("{0:n}", sum));
                    break;
                case "x":
                    sum = n1 * n2;
                    screenNumber.Text = Convert.ToString(string.Format("{0:n}", sum));
                    totalSum.Text = Convert.ToString(string.Format("{0:n}", sum));
                    break;
                case "/":
                    if (n1 == 0.0m || n2 == 0.0m)
                    {
                        MessageBox.Show("Cannot divide numbers by 0", "Error");
                    }
                    sum = n1 / n2;
                    screenNumber.Text = Convert.ToString(string.Format("{0:n}", sum));
                    totalSum.Text = Convert.ToString(string.Format("{0:n}", sum));
                    break;
                case "%":
                    sum = (n1 / n2) * 100;
                    screenNumber.Text = Convert.ToString(string.Format("{0:n}", sum));
                    totalSum.Text = Convert.ToString(string.Format("{0:n}", sum));
                    break;
            }
        }

        private void backSpace_Click(object sender, EventArgs e)
        {
            int strLength = screenNumber.Text.Length;
            string num = screenNumber.Text;

            if (strLength >= 1)
            {
                screenNumber.Text = num.Substring(0, strLength - 1);
            }
            else
            {
                MessageBox.Show("Screen does not conatain a number", "Error");
            }
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (screenNumber.Text == "0")
            {
                screenNumber.Text = null;
            }

            List<Keys> keys = new List<Keys>()
            {
                Keys.NumPad0,
                Keys.NumPad1,
                Keys.NumPad2,
                Keys.NumPad3,
                Keys.NumPad4,
                Keys.NumPad5,
                Keys.NumPad6,
                Keys.NumPad7,
                Keys.NumPad8,
                Keys.NumPad9
            };

             #region NumPad
            if (e.KeyCode == keys[0])
            {
                screenNumber.Text += "0";
            }
            else if (e.KeyCode == keys[1])
            {
                screenNumber.Text += "1";
            }
            else if (e.KeyCode == keys[2])
            {
                screenNumber.Text += "2";
            }
            else if (e.KeyCode == keys[3])
            {
                screenNumber.Text += "3";
            }
            else if (e.KeyCode == keys[4])
            {
                screenNumber.Text += "4";
            }
            else if (e.KeyCode == keys[5])
            {
                screenNumber.Text += "5";
            }
            else if (e.KeyCode == keys[6])
            {
                screenNumber.Text += "6";
            }
            else if (e.KeyCode == keys[7])
            {
                screenNumber.Text += "7";
            }
            else if (e.KeyCode == keys[8])
            {
                screenNumber.Text += "8";
            }
            else if (e.KeyCode == keys[9])
            {
                screenNumber.Text += "9";
            }
            else if (e.KeyCode == Keys.Add)
            {
                addButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                subtractButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                timesButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                divideButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                sum1.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                backSpace.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.C)
            {
                clearNumsBtn.PerformClick();
                screenNumClear.PerformClick(); 
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                dot.PerformClick();
            }
            else
            {
             
            }
            #endregion
        }

        public Form1()
        {
            InitializeComponent();
            screenNumber.Text = "0";
            this.KeyPreview = true;
        }

        private void numAddOnScreen(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (screenNumber.Text == "0")
            {
                screenNumber.Text = null;
            }
            screenNumber.Text += button.Text;
        }
    }
}
