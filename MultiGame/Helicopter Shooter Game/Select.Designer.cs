
namespace Helicopter_Shooter_Game
{
    partial class Select
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.carImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.helicopterImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helicopterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.carImage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 366);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Game";
            // 
            // carImage
            // 
            this.carImage.Image = global::Helicopter_Shooter_Game.Properties.Resources.cargame;
            this.carImage.Location = new System.Drawing.Point(34, 54);
            this.carImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carImage.Name = "carImage";
            this.carImage.Size = new System.Drawing.Size(223, 156);
            this.carImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carImage.TabIndex = 0;
            this.carImage.TabStop = false;
            this.carImage.Tag = "carImagee";
            this.carImage.Click += new System.EventHandler(this.carImage_Click);
            this.carImage.MouseLeave += new System.EventHandler(this.carImage_MouseLeave);
            this.carImage.MouseHover += new System.EventHandler(this.carImage_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.helicopterImage);
            this.panel2.Location = new System.Drawing.Point(294, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 366);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(15, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Helicopter Shooting Game";
            // 
            // helicopterImage
            // 
            this.helicopterImage.Image = global::Helicopter_Shooter_Game.Properties.Resources.helgame;
            this.helicopterImage.Location = new System.Drawing.Point(45, 54);
            this.helicopterImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.helicopterImage.Name = "helicopterImage";
            this.helicopterImage.Size = new System.Drawing.Size(223, 156);
            this.helicopterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helicopterImage.TabIndex = 0;
            this.helicopterImage.TabStop = false;
            this.helicopterImage.Tag = "helicopterImagee";
            this.helicopterImage.Click += new System.EventHandler(this.helicopterImage_Click);
            this.helicopterImage.MouseLeave += new System.EventHandler(this.helicopterImage_MouseLeave);
            this.helicopterImage.MouseHover += new System.EventHandler(this.helicopterImage_MouseHover);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Select";
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Select_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helicopterImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox helicopterImage;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox carImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}