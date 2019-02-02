using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        SoundPlayer correctSound = new SoundPlayer(@"C:\Users\Stefan\Downloads\CORRECT ANSWER SOUND EFFECT.wav");
        SoundPlayer incorrectSound = new SoundPlayer(@"C:\Users\Stefan\Downloads\False question incorrect answer sound effect.wav");
        int n1, n2, minus1, minus2, multi1, multi2, div1, div2;
        int timeLeft;

        private void Sound1(object sender, EventArgs e)
        {
            NumericUpDown numeric = sender as NumericUpDown;
            if (numeric.Value != n1 + n2)
            {
                incorrectSound.Play();
            }
            else
            {
                correctSound.Play();
            }
        }

        private void Sound2(object sender, EventArgs e)
        {
            NumericUpDown numeric = sender as NumericUpDown;
            if (numeric.Value != minus1 - minus2)
            {
                incorrectSound.Play();
            }
            else
            {
                correctSound.Play();
            }
        }

        private void Sound3(object sender, EventArgs e)
        {
            NumericUpDown numeric = sender as NumericUpDown;
            if (numeric.Value != multi1 * multi2)
            {
                incorrectSound.Play();
            }
            else
            {
                correctSound.Play();
            }
        }

        private void Sound4(object sender, EventArgs e)
        {
            NumericUpDown numeric = sender as NumericUpDown;
            if (numeric.Value != div1 / div2)
            {
                incorrectSound.Play();
            }
            else
            {
                correctSound.Play();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
            timeLabel.BackColor = Color.LightGray;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (CheckAnswear())
            {
                timer1.Stop();
                MessageBox.Show("Congratulations. You got all the answears right");
                startButton.Enabled = true;
            }
            else if(timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                if (timeLeft >= 1 && timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers
                timer1.Stop();
                correctSound.Stop();
                incorrectSound.Stop();
                timeLabel.BackColor = Color.LightGray;
                timeLabel.Text = "Time's up";
                MessageBox.Show("You didnt finish in time. Sorry");
                sum.Value = n1 + n2;
                difference.Value = minus1 - minus2;
                product.Value = multi1 * multi2;
                quotient.Value = div1 / div2;
                startButton.Enabled = true;
            }
        }

        private bool CheckAnswear()
        {
            return (n1 + n2 == sum.Value) && (minus1 - minus2 == difference.Value) && (multi1 * multi2 == product.Value) && (div1 / div2 == quotient.Value);
        }

        private void answear_enter(object sender, EventArgs e)
        {
            NumericUpDown answearBox = sender as NumericUpDown;

            if (answearBox != null)
            {
                int lengthOfAnswear = answearBox.Value.ToString().Length;
                answearBox.Select(0, lengthOfAnswear);
            }
        }

        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'n1' and 'n2'.
            n1 = random.Next(51);
            n2 = random.Next(51);
            minus1 = random.Next(1, 101);
            minus2 = random.Next(1, minus1);
            multi1 = random.Next(2, 11);
            multi2 = random.Next(2, 11);
            div2 = random.Next(2, 11);
            int temp = random.Next(2, 11);
            div1 = div2 * temp;

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = n1.ToString();
            plusRightLabel.Text = n2.ToString();
            minusLeftLabel.Text = minus1.ToString();
            minusRightLabel.Text = minus2.ToString();
            timesLeftLabel.Text = multi1.ToString();
            timesRightLabel.Text = multi2.ToString();
            divideLeftLabel.Text = div1.ToString();
            divideRightLabel.Text = div2.ToString();


            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;
            difference.Value = 0;
            product.Value = 0;
            quotient.Value = 0;

            //Start timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }
    }
}
