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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void helicopterImage_MouseHover(object sender, EventArgs e)
        {
            helicopterImage.Width = 250;
            helicopterImage.Height = 170;

        }

        private void helicopterImage_MouseLeave(object sender, EventArgs e)
        {
            helicopterImage.Width = 220;
            helicopterImage.Height = 155;
        }

        private void carImage_MouseHover(object sender, EventArgs e)
        {
            carImage.Width = 250;
            carImage.Height = 170;
        }

        private void carImage_MouseLeave(object sender, EventArgs e)
        {
            carImage.Width = 220;
            carImage.Height = 155;
        }

        private void Select_Load(object sender, EventArgs e)
        {

        }

        private void carImage_Click(object sender, EventArgs e)
        {
            Flags.flagCar = true;
            this.Hide();
            Choose carGame = new Choose();
            carGame.Show();
        }

        private void helicopterImage_Click(object sender, EventArgs e)
        {
            Flags.flagHeli = true;
            this.Hide();
            Choose carGame = new Choose();
            carGame.Show();
        }
    }
    public static class Flags
    {
        public static bool flagCar = false;
        public static bool flagHeli = false;
    }
}
