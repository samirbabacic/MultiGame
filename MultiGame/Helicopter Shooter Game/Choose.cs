using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helicopter_Shooter_Game
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void easy_Click(object sender, EventArgs e)
        {
            Select select = new Select();
            if (Flags.flagHeli == true)
            {
                Game game = new Game();
                game.speed = 8;
                game.Show();
                this.Hide();
            }
            else if(Flags.flagCar==true)
            {
                CarGame game = new CarGame();
                game.playerSpeed = 12;
                game.Show();
                this.Hide();
            }
        }

        private void medium_Click(object sender, EventArgs e)
        {
            Select select = new Select();
            if (Flags.flagHeli == true)
            {
                Game game = new Game();
                game.speed = 12;
                game.Show();
                this.Hide();
            }
            else if (Flags.flagCar == true)
            {
                CarGame game = new CarGame();
                game.playerSpeed = 16;
                game.Show();
                this.Hide();
            }
        }

        private void hard_Click(object sender, EventArgs e)
        {
            Select select = new Select();
            if (Flags.flagHeli == true)
            {
                Game game = new Game();
                game.speed = 20;
                game.Show();
                this.Hide();
            }
            else if (Flags.flagCar == true)
            {
                CarGame game = new CarGame();
                game.playerSpeed = 23;
                game.Show();
                this.Hide();
            }
        }

        private void Choose_Load(object sender, EventArgs e)
        {
            lbl.Text = Flags.flagHeli.ToString();
        }
    }
}
