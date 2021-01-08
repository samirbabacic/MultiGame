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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void start_MouseEnter(object sender, EventArgs e)
        {
            start.BorderStyle = BorderStyle.Fixed3D;
        }

        private void start_Click(object sender, EventArgs e)
        {
           Select form = new Select();
            form.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void start_MouseLeave(object sender, EventArgs e)
        {
            start.BorderStyle = BorderStyle.None;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HowToPlayCarGame form = new HowToPlayCarGame();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.None;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.None;
        }
    }
}
