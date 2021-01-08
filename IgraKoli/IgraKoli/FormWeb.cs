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
using System.Windows.Media;

namespace IgraKoli
{
    public partial class IgraKoli : Form
    {

        int roadSpeed;
        int trafficSpeed;
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
     
      
     

        
        private void keyisdown(object sender, KeyEventArgs e)
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

        private void keyisup(object sender, KeyEventArgs e)
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

        private void gameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            score++;
            if (goleft == true && player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 422)
            {
                player.Left += playerSpeed;
            }
            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;
            if(roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }
            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            AI1.Top += roadSpeed;
            AI2.Top += roadSpeed;
            if(AI1.Top > 530)
            {
                changeAICars(AI1);
            }
            if(AI2.Top > 530)
            {
                changeAICars(AI2);
            }
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }
            if(score > 40 && score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }
            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed =22;
            }
            if(score >= 2000)
            {
                award.Image = Properties.Resources.gold;
                roadSpeed = 25;
                trafficSpeed = 27;
            }
        }
        private void changeAICars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 9);
            if(carImage == 1)
            {
                tempCar.Image = Properties.Resources.carGreen;
            }
            else if (carImage == 2)
            {
                tempCar.Image = Properties.Resources.carGrey;
            }
            else if (carImage == 3)
            {
                tempCar.Image = Properties.Resources.ambulance;
            }
            else if (carImage == 4)
            {
                tempCar.Image = Properties.Resources.carOrange;
            }
            else if (carImage == 5)
            {
                tempCar.Image = Properties.Resources.carPink;
            }
            else if (carImage == 6)
            {
                tempCar.Image = Properties.Resources.TruckWhite;
            }
            else if (carImage == 7)
            {
                tempCar.Image = Properties.Resources.CarRed;
            }
            else if (carImage == 8)
            {
                tempCar.Image = Properties.Resources.TruckBlue;
            }
            else if(carImage == 9)
            {
                tempCar.Image = Properties.Resources.carYellow;
            }
            tempCar.Top = carPosition.Next(100, 400) * -1;
            if((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
           else if((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }
        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-7, 0);
            explosion.BackColor = System.Drawing.Color.Transparent;
            award.Visible = true;
            award.BringToFront();
            btnStart.Enabled = true;
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
            AI1.Left = carPosition.Next(2, 200);
            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(245, 422);
            gameTimer.Start();
        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void playSound()
        {
            var filepath = @"D:\downloads\C_sharp_top_down_car_racing_game_resources_mooict\hit.wav";
            MediaPlayer crash = new MediaPlayer();
            crash.Volume = 1;
            crash.Open(new Uri(filepath));
            crash.Play();
        }
    }
}
