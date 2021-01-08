using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgraKoli
{
    public partial class IgraKoli : Form
    {
        int roadSpeed;
        int trafficSpeed = 15;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;
        public IgraKoli()
        {
            InitializeComponent();
            resetGame();
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void timerEvent(object sender, EventArgs e)
        {
            if(goleft == true && player.Left >10)
            {
                player.Left -= playerSpeed;
            }
            if(goright==true && player.Left < 415)
            {
                player.Left += playerSpeed;
            }
            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }
            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
         
           
        }
        private void changeAIcars(PictureBox tempCar)
        {

        }
        private void gameOver()
        {

        }

        private void resetGame()
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;
            roadSpeed = 12;
            trafficSpeed = 15;
            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(5, 200);
            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(242, 422);
            timerzaIgru.Start();
        }

        
    }
}
