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
    public partial class Game : Form
    {
        bool getUp, getDown, shot, gameOver;
        int score = 0;
        public int speed = 8;
        int UFOspeed = 10;

        Random rand = new Random();
        int playerspeed = 7;
        int index = 0;
        public Game()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            
            if(getUp == true && player.Top > 0)
            {
                player.Top -= playerspeed;
            }
            if(getDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += playerspeed;
            }
            ufo.Left -= UFOspeed;

            if(ufo.Left + ufo.Width < 0)
            {
                ChangeUFO();
            }

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "pillar")
                {
                    if(score > 10)
                    {
                        speed = 17;
                        UFOspeed = 18;
                    }
                    x.Left -= speed;
                    if(x.Left < -200)
                    {
                        x.Left = 1000;
                    }
                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameOver();
                    }
                }
                if(x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;
                    if(x.Left > 900)
                    {
                        RemoveBullet((PictureBox)x);
                    }

                    if(ufo.Bounds.IntersectsWith(x.Bounds))
                    {
                        RemoveBullet((PictureBox)x);
                        score += 1;
                        ChangeUFO();
                    }
                }
            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                GameTimer.Stop();
                    DialogResult res = MessageBox.Show("Do you want to exit this game ?", "Exit Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Hide();
                    Menu form2 = new Menu();
                    form2.Show();
                 
                }
                if (res == DialogResult.Cancel)
                {
                    GameTimer.Start();
                    Select select = new Select();
                    Flags.flagHeli = false;
                }
            }
            if(e.KeyCode == Keys.Up)
            {
                getUp = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                getDown = true;
            }
            if(e.KeyCode == Keys.Space && shot == false)
            {
                MakeBullet();
                shot = true;
            }
        }
        public void ExitGame()
        {
            
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                getUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                getDown = false;
            }
            if (shot == true)
            {
                shot = false;
            }
            if(e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

        }
        private void RestartGame()
        {
            getUp = false;
            shot = false;
            getDown = false;
            gameOver = false;
            score = 0;
            speed = 8;
            UFOspeed = 10;
            txtScore.Text = "Score: " + score;
            ChangeUFO();
            player.Top = 125;
            pillar1.Left = 637;
            pillar2.Left = 269;
            GameTimer.Start();
        }
        private void GameOver()
        {
            GameTimer.Stop();
            txtScore.Text = "Score: " + score + "\nGame over. Press enter to retry.";
            gameOver = true;

        }
        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();

        }
        private void MakeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Maroon;
            bullet.Height = 5;
            bullet.Width = 10;

            bullet.Left = player.Left + player.Width;
            bullet.Top = player.Top + player.Height;

            bullet.Tag = "bullet";

            this.Controls.Add(bullet);
        }
        private void ChangeUFO()
        {
            if(index > 3)
            {
                index = 1;
            }
            else
            {
                index += 1;
            }


            switch(index)
            {
                case 1:
                    ufo.Image = Properties.Resources.alien1;
                    break;
                case 2:
                    ufo.Image = Properties.Resources.alien2;
                    break;
                case 3:
                    ufo.Image = Properties.Resources.alien3;
                    break;

            }

            ufo.Left = 1000;
            ufo.Top = rand.Next(20, this.ClientSize.Height - ufo.Height);

        }
    }
}
