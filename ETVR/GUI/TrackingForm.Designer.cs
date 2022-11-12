namespace ETVR
{
    partial class TrackingForm
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
            this.urlL = new System.Windows.Forms.Label();
            this.urlR = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.sliderL = new AForge.Controls.SliderControl();
            this.sliderR = new AForge.Controls.SliderControl();
            this.sliderValL = new System.Windows.Forms.Label();
            this.sliderValR = new System.Windows.Forms.Label();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.pictureBox2 = new AForge.Controls.PictureBox();
            this.pictureBox4 = new AForge.Controls.PictureBox();
            this.pictureBox3 = new AForge.Controls.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // urlL
            // 
            this.urlL.AutoSize = true;
            this.urlL.Location = new System.Drawing.Point(12, 54);
            this.urlL.MaximumSize = new System.Drawing.Size(130, 20);
            this.urlL.Name = "urlL";
            this.urlL.Size = new System.Drawing.Size(25, 13);
            this.urlL.TabIndex = 1;
            this.urlL.Text = "Left";
            // 
            // urlR
            // 
            this.urlR.AutoSize = true;
            this.urlR.Location = new System.Drawing.Point(401, 54);
            this.urlR.MaximumSize = new System.Drawing.Size(130, 20);
            this.urlR.Name = "urlR";
            this.urlR.Size = new System.Drawing.Size(32, 13);
            this.urlR.TabIndex = 2;
            this.urlR.Text = "Right";
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.Gray;
            this.btnload.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnload.FlatAppearance.BorderSize = 0;
            this.btnload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnload.Location = new System.Drawing.Point(13, 13);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 23);
            this.btnload.TabIndex = 3;
            this.btnload.Text = "Reload";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // sliderL
            // 
            this.sliderL.Location = new System.Drawing.Point(12, 70);
            this.sliderL.ManipulatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sliderL.ManipulatorPosition = 0F;
            this.sliderL.Name = "sliderL";
            this.sliderL.NegativeAreaBrush = System.Drawing.Color.DarkGray;
            this.sliderL.PositiveAreaBrush = System.Drawing.Color.DarkGray;
            this.sliderL.ResetPositionOnMouseRelease = false;
            this.sliderL.Size = new System.Drawing.Size(184, 23);
            this.sliderL.TabIndex = 4;
            this.sliderL.Text = "sliderControl1";
            this.sliderL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sliderL_MouseDown);
            this.sliderL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sliderL_MouseUp);
            // 
            // sliderR
            // 
            this.sliderR.Location = new System.Drawing.Point(404, 70);
            this.sliderR.ManipulatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sliderR.ManipulatorPosition = 0F;
            this.sliderR.Name = "sliderR";
            this.sliderR.NegativeAreaBrush = System.Drawing.Color.DarkGray;
            this.sliderR.PositiveAreaBrush = System.Drawing.Color.DarkGray;
            this.sliderR.ResetPositionOnMouseRelease = false;
            this.sliderR.Size = new System.Drawing.Size(184, 23);
            this.sliderR.TabIndex = 5;
            this.sliderR.Text = "sliderControl2";
            this.sliderR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sliderR_MouseDown);
            this.sliderR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sliderR_MouseUp);
            // 
            // sliderValL
            // 
            this.sliderValL.AutoSize = true;
            this.sliderValL.Location = new System.Drawing.Point(151, 51);
            this.sliderValL.Name = "sliderValL";
            this.sliderValL.Size = new System.Drawing.Size(45, 13);
            this.sliderValL.TabIndex = 8;
            this.sliderValL.Text = "sliderval";
            // 
            // sliderValR
            // 
            this.sliderValR.AutoSize = true;
            this.sliderValR.Location = new System.Drawing.Point(543, 51);
            this.sliderValR.Name = "sliderValR";
            this.sliderValR.Size = new System.Drawing.Size(45, 13);
            this.sliderValR.TabIndex = 9;
            this.sliderValR.Text = "sliderval";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = null;
            this.pictureBox2.Location = new System.Drawing.Point(404, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = null;
            this.pictureBox4.Location = new System.Drawing.Point(590, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 180);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = null;
            this.pictureBox3.Location = new System.Drawing.Point(201, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 180);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // TrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sliderValR);
            this.Controls.Add(this.sliderValL);
            this.Controls.Add(this.sliderR);
            this.Controls.Add(this.sliderL);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.urlR);
            this.Controls.Add(this.urlL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrackingForm";
            this.Text = "TrackingForm";
            this.Load += new System.EventHandler(this.TrackingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label urlL;
        private System.Windows.Forms.Label urlR;
        private System.Windows.Forms.Button btnload;
        private AForge.Controls.SliderControl sliderL;
        private AForge.Controls.SliderControl sliderR;
        private System.Windows.Forms.Label sliderValL;
        private System.Windows.Forms.Label sliderValR;
        private AForge.Controls.PictureBox pictureBox1;
        private AForge.Controls.PictureBox pictureBox2;
        private AForge.Controls.PictureBox pictureBox4;
        private AForge.Controls.PictureBox pictureBox3;
    }
}