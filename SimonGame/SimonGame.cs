using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SimonGame
{
    public partial class SimonGame : UserControl
    {
        //global int to keep track of player progress
        int guess;

        //random number generator
        Random randGen = new Random();

        public SimonGame()
        {
            InitializeComponent();

            //clear the pattern list
            Form1.pattern.Clear();


        }

        public void GameOver()
        {
            Form1.mistakeSound.Play();
        }

        public void ComputerTurn()
        {
            //pick a random number
            int color1 = randGen.Next(0,4);

            //add the random number to the pattern list
            Form1.pattern.Add(color1);

            //loop that lights up the buttons after checking the pattern
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                //light up correct button
                if (Form1.pattern[i] == 0)
                {
                    greenButton.BackColor = Color.Lime;
                    Form1.greenSound.Play();
                }
                if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    Form1.redSound.Play();
                }
                if (Form1.pattern[i] == 2)
                {
                    blueButton.BackColor = Color.LightBlue;
                    Form1.blueSound.Play();
                }
                if (Form1.pattern[i] == 3)
                {
                    yellowButton.BackColor = Color.Gold;
                    Form1.yellowSound.Play();

                }
                Refresh();
                Thread.Sleep(1000);

                //reset the colors of the buttons
                greenButton.BackColor = Color.DarkGreen;
                redButton.BackColor = Color.DarkRed;
                blueButton.BackColor = Color.DarkBlue;
                yellowButton.BackColor = Color.DarkGoldenrod;
                Refresh();
            }
            guess = 0;
        }

        private void SimonGame_Load(object sender, EventArgs e)
        {
            //initialize computer turn
            ComputerTurn();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 0)
            {
                greenButton.BackColor = Color.Lime;
                Form1.greenSound.Play();
                Refresh();
                Thread.Sleep(1000);
                greenButton.BackColor = Color.DarkGreen;
                Refresh();
                guess++;
            }
            else
            {
                Form1.mistakeSound.Play();

                //close simon game
                Form f = this.FindForm();
                f.Controls.Remove(this);

                //open game over
                GameOver go = new GameOver();
                f.Controls.Add(go);
            }
            if (guess == Form1.pattern.Count())
            {
                ComputerTurn();
            }

        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 1)
            {
                redButton.BackColor = Color.Red;
                Form1.redSound.Play();
                Refresh();
                Thread.Sleep(1000);
                redButton.BackColor = Color.DarkRed;
                Refresh();
                guess++;
            }
            else
            {
                Form1.mistakeSound.Play();

                //close simon game
                Form f = this.FindForm();
                f.Controls.Remove(this);

                //open game over
                GameOver go = new GameOver();
                f.Controls.Add(go);
            }
            if (guess == Form1.pattern.Count())
            {
                ComputerTurn();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 2)
            {
                blueButton.BackColor = Color.LightBlue;
                Form1.blueSound.Play();
                Refresh();
                Thread.Sleep(1000);
                blueButton.BackColor = Color.DarkBlue;
                Refresh();
                guess++;
            }
            else
            {
                Form1.mistakeSound.Play();

                //close simon game
                Form f = this.FindForm();
                f.Controls.Remove(this);

                //open game over
                GameOver go = new GameOver();
                f.Controls.Add(go);
            }
            if (guess == Form1.pattern.Count())
            {
                ComputerTurn();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 3)
            {
                yellowButton.BackColor = Color.Gold;
                Form1.yellowSound.Play();
                Refresh();
                Thread.Sleep(1000);
                yellowButton.BackColor = Color.DarkGoldenrod;
                Refresh();
                guess++;
            }
            else
            {
                Form1.mistakeSound.Play();

                //close simon game
                Form f = this.FindForm();
                f.Controls.Remove(this);

                //open game over
                GameOver go = new GameOver();
                f.Controls.Add(go);
            }
            if (guess == Form1.pattern.Count())
            {
                ComputerTurn();
            }
        }
    }
}
