using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonGame
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            //change button's back color to red
            exitButton.BackColor = Color.Red;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            //reset button's back color to white
            exitButton.BackColor = Color.White;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startGameButton_MouseEnter(object sender, EventArgs e)
        {
            //change button's color to green
            startGameButton.BackColor = Color.Green;
        }

        private void startGameButton_MouseLeave(object sender, EventArgs e)
        {
            //reset button's color to white
            startGameButton.BackColor = Color.White;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            //close mainscreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //open simon game
            SimonGame sg = new SimonGame();
            f.Controls.Add(sg);
        }
    }
}
