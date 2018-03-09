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
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();

            outputLabel.Text = "You Lost.  Your score was " + Form1.pattern.Count();
        }

        private void quitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            //launch mainscreen
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }
    }
}
