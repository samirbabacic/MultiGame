
namespace Helicopter_Shooter_Game
{
    partial class Choose
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
            this.easy = new System.Windows.Forms.PictureBox();
            this.medium = new System.Windows.Forms.PictureBox();
            this.hard = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hard)).BeginInit();
            this.SuspendLayout();
            // 
            // easy
            // 
            this.easy.Image = global::Helicopter_Shooter_Game.Properties.Resources.easy;
            this.easy.Location = new System.Drawing.Point(20, 37);
            this.easy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(180, 50);
            this.easy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.easy.TabIndex = 0;
            this.easy.TabStop = false;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // medium
            // 
            this.medium.Image = global::Helicopter_Shooter_Game.Properties.Resources.medium;
            this.medium.Location = new System.Drawing.Point(20, 120);
            this.medium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(180, 50);
            this.medium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medium.TabIndex = 1;
            this.medium.TabStop = false;
            this.medium.Click += new System.EventHandler(this.medium_Click);
            // 
            // hard
            // 
            this.hard.Image = global::Helicopter_Shooter_Game.Properties.Resources.hard;
            this.hard.Location = new System.Drawing.Point(20, 206);
            this.hard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(180, 50);
            this.hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hard.TabIndex = 2;
            this.hard.TabStop = false;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(29, 283);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 3;
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(219, 327);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Choose";
            this.Text = "Choose";
            this.Load += new System.EventHandler(this.Choose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox easy;
        private System.Windows.Forms.PictureBox medium;
        private System.Windows.Forms.PictureBox hard;
        private System.Windows.Forms.Label lbl;
    }
}