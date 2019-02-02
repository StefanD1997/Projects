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

namespace MatchingGame
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        SoundPlayer Match = new SoundPlayer(@"C:\Users\Stefan\Downloads\CORRECT ANSWER SOUND EFFECT.wav");
        SoundPlayer NoMatch = new SoundPlayer(@"C:\Users\Stefan\Downloads\False question incorrect answer sound effect.wav");

        int minutes = 0, seconds = 0;

        // firstClicked points to the first Label control 
        // that the player clicks, but it will be null 
        // if the player hasn't clicked a label yet
        Label firstClicked = null;

        // secondClicked points to the second Label control 
        // that the player clicks
        Label secondClicked = null;

        List<string> icons = new List<string>()
        {
            "`", "`", "F", "F", ".", ".", "l", "l",
            "d", "d", "s", "s", "y", "y", "x", "x"
        };

        public Form1()
        {
            InitializeComponent();

            AssignIconsToAquares();
            timer2.Start();
        }

        private void AssignIconsToAquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count());
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (secondClicked != null) return;

            // The timer is only on after two non-matching 
            // icons have been shown to the player, 
            // so ignore any clicks if the timer is running
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            // If the clicked label is black, the player clicked
            // an icon that's already been revealed --
            // ignore the click
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.White)
                    return;

                clickedLabel.ForeColor = Color.White;
            }

            // If firstClicked is null, this is the first icon 
            // in the pair that the player clicked,
            // so set firstClicked to the label that the player 
            // clicked, change its color to black, and return
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.White;

                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.White;

            CheckForWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked.ForeColor = Color.Green;
                secondClicked.ForeColor = Color.Green;
                Match.Play();
                firstClicked = null;
                secondClicked = null;

                return;
            }
            else
            {
                firstClicked.ForeColor = Color.Red;
                secondClicked.ForeColor = Color.Red;
                NoMatch.Play();
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (seconds < 60)
            {
                seconds++;
            }
            else
            {
                minutes++;
                seconds = 0;
            }
        }

        private string Time(int minutes, int seconds)
        {
            if (minutes == 1)
            {
                return minutes.ToString() + " minute " + seconds.ToString() + " seconds";
            }
            else if (minutes == 0)
            {
                return seconds.ToString() + " seconds";
            }
            else
            {
                return minutes.ToString() + " minutes " + seconds.ToString() + " seconds";
            }
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            firstClicked.ForeColor = Color.Green;
            secondClicked.ForeColor = Color.Green;
            Match.PlaySync();

            timer2.Stop();
            MessageBox.Show("You matched all the icons!", "Congratulations");
            MessageBox.Show(Time(minutes, seconds), "Your time");
            Close();
        }

    }
}
