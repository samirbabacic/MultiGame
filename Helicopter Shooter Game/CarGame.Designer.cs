namespace Helicopter_Shooter_Game
{
    partial class CarGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 519);
            this.panel1.TabIndex = 0;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Helicopter_Shooter_Game.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(220, 407);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Tag = "carLeft";
            // 
            // explosion
            // 
            this.explosion.BackColor = System.Drawing.Color.Transparent;
            this.explosion.Image = global::Helicopter_Shooter_Game.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(150, 353);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 4;
            this.explosion.TabStop = false;
            // 
            // award
            // 
            this.award.Image = global::Helicopter_Shooter_Game.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(113, 197);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 5;
            this.award.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = global::Helicopter_Shooter_Game.Properties.Resources.carGreen;
            this.AI1.Location = new System.Drawing.Point(56, 40);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 2;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carLeft";
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.Image = global::Helicopter_Shooter_Game.Properties.Resources.carGrey;
            this.AI2.Location = new System.Drawing.Point(382, 41);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 100);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI2.TabIndex = 3;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carRight";
            // 
            // roadTrack1
            // 
            this.roadTrack1.BackColor = System.Drawing.Color.Black;
            this.roadTrack1.Image = global::Helicopter_Shooter_Game.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, -519);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(475, 519);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.BackColor = System.Drawing.Color.Black;
            this.roadTrack2.Image = global::Helicopter_Shooter_Game.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(475, 519);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 0;
            this.roadTrack2.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.Location = new System.Drawing.Point(59, 557);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(385, 23);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score : 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(206, 601);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 30);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Helicopter_Shooter_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 669);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.panel1);
            this.Name = "Helicopter_Shooter_Game";
            this.Text = "Car Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox roadTrack2;
    }
}

