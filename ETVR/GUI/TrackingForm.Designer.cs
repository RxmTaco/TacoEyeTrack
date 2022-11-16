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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.blobWidthR = new System.Windows.Forms.Label();
            this.blobWidthL = new System.Windows.Forms.Label();
            this.WidthR = new AForge.Controls.SliderControl();
            this.WidthL = new AForge.Controls.SliderControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.blobHeightR = new System.Windows.Forms.Label();
            this.blobHeightL = new System.Windows.Forms.Label();
            this.HeightR = new AForge.Controls.SliderControl();
            this.HeightL = new AForge.Controls.SliderControl();
            this.pictureBox5 = new AForge.Controls.PictureBox();
            this.pictureBox6 = new AForge.Controls.PictureBox();
            this.pictureBox8 = new AForge.Controls.PictureBox();
            this.rotateSliderL = new AForge.Controls.SliderControl();
            this.rotateSliderR = new AForge.Controls.SliderControl();
            this.pictureBox7 = new AForge.Controls.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // urlL
            // 
            this.urlL.AutoSize = true;
            this.urlL.ForeColor = System.Drawing.SystemColors.Control;
            this.urlL.Location = new System.Drawing.Point(10, 54);
            this.urlL.MaximumSize = new System.Drawing.Size(200, 20);
            this.urlL.Name = "urlL";
            this.urlL.Size = new System.Drawing.Size(25, 13);
            this.urlL.TabIndex = 1;
            this.urlL.Text = "Left";
            // 
            // urlR
            // 
            this.urlR.AutoSize = true;
            this.urlR.ForeColor = System.Drawing.SystemColors.Control;
            this.urlR.Location = new System.Drawing.Point(411, 54);
            this.urlR.MaximumSize = new System.Drawing.Size(200, 20);
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
            this.sliderL.Location = new System.Drawing.Point(6, 70);
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
            this.sliderR.Location = new System.Drawing.Point(414, 70);
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
            this.sliderValL.ForeColor = System.Drawing.SystemColors.Control;
            this.sliderValL.Location = new System.Drawing.Point(327, 70);
            this.sliderValL.Name = "sliderValL";
            this.sliderValL.Size = new System.Drawing.Size(45, 13);
            this.sliderValL.TabIndex = 8;
            this.sliderValL.Text = "sliderval";
            // 
            // sliderValR
            // 
            this.sliderValR.AutoSize = true;
            this.sliderValR.ForeColor = System.Drawing.SystemColors.Control;
            this.sliderValR.Location = new System.Drawing.Point(735, 70);
            this.sliderValR.Name = "sliderValR";
            this.sliderValR.Size = new System.Drawing.Size(45, 13);
            this.sliderValR.TabIndex = 9;
            this.sliderValR.Text = "sliderval";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = null;
            this.pictureBox2.Location = new System.Drawing.Point(414, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = null;
            this.pictureBox4.Location = new System.Drawing.Point(600, 157);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 180);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = null;
            this.pictureBox3.Location = new System.Drawing.Point(199, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 180);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(196, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filtering Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(604, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filtering Threshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(604, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Blob Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(196, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Blob Width";
            // 
            // blobWidthR
            // 
            this.blobWidthR.AutoSize = true;
            this.blobWidthR.ForeColor = System.Drawing.SystemColors.Control;
            this.blobWidthR.Location = new System.Drawing.Point(735, 99);
            this.blobWidthR.Name = "blobWidthR";
            this.blobWidthR.Size = new System.Drawing.Size(45, 13);
            this.blobWidthR.TabIndex = 19;
            this.blobWidthR.Text = "sliderval";
            // 
            // blobWidthL
            // 
            this.blobWidthL.AutoSize = true;
            this.blobWidthL.ForeColor = System.Drawing.SystemColors.Control;
            this.blobWidthL.Location = new System.Drawing.Point(327, 99);
            this.blobWidthL.Name = "blobWidthL";
            this.blobWidthL.Size = new System.Drawing.Size(45, 13);
            this.blobWidthL.TabIndex = 18;
            this.blobWidthL.Text = "sliderval";
            // 
            // WidthR
            // 
            this.WidthR.Location = new System.Drawing.Point(414, 99);
            this.WidthR.ManipulatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.WidthR.ManipulatorPosition = 0F;
            this.WidthR.Name = "WidthR";
            this.WidthR.NegativeAreaBrush = System.Drawing.Color.DarkGray;
            this.WidthR.PositiveAreaBrush = System.Drawing.Color.DarkGray;
            this.WidthR.ResetPositionOnMouseRelease = false;
            this.WidthR.Size = new System.Drawing.Size(184, 23);
            this.WidthR.TabIndex = 17;
            this.WidthR.Text = "sliderControl2";
            this.WidthR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WidthR_MouseDown);
            this.WidthR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WidthR_MouseUp);
            // 
            // WidthL
            // 
            this.WidthL.Location = new System.Drawing.Point(6, 99);
            this.WidthL.ManipulatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.WidthL.ManipulatorPosition = 0F;
            this.WidthL.Name = "WidthL";
            this.WidthL.NegativeAreaBrush = System.Drawing.Color.DarkGray;
            this.WidthL.PositiveAreaBrush = System.Drawing.Color.DarkGray;
            this.WidthL.ResetPositionOnMouseRelease = false;
            this.WidthL.Size = new System.Drawing.Size(184, 23);
            this.WidthL.TabIndex = 16;
            this.WidthL.Text = "sliderControl1";
            this.WidthL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WidthL_MouseDown);
            this.WidthL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WidthL_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(604, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Blob Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(196, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Blob Height";
            // 
            // blobHeightR
            // 
            this.blobHeightR.AutoSize = true;
            this.blobHeightR.ForeColor = System.Drawing.SystemColors.Control;
            this.blobHeightR.Location = new System.Drawing.Point(735, 128);
            this.blobHeightR.Name = "blobHeightR";
            this.blobHeightR.Size = new System.Drawing.Size(45, 13);
            this.blobHeightR.TabIndex = 25;
            this.blobHeightR.Text = "sliderval";
            // 
            // blobHeightL
            // 
            this.blobHeightL.AutoSize = true;
            this.blobHeightL.ForeColor = System.Drawing.SystemColors.Control;
            this.blobHeightL.Location = new System.Drawing.Point(327, 128);
            this.blobHeightL.Name = "blobHeightL";
            this.blobHeightL.Size = new System.Drawing.Size(45, 13);
            this.blobHeightL.TabIndex = 24;
            this.blobHeightL.Text = "sliderval";
            // 
            // HeightR
            // 
            this.HeightR.Location = new System.Drawing.Point(414, 128);
            this.HeightR.ManipulatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HeightR.ManipulatorPosition = 0F;
            this.HeightR.Name = "HeightR";
            this.HeightR.NegativeAreaBrush = System.Drawing.Color.DarkGray;
            this.HeightR.PositiveAreaBrush = System.Drawing.Color.DarkGray;
            this.HeightR.ResetPositionOnMouseRelease = false;
            this.HeightR.Size = new System.Drawing.Size(184, 23);
            this.HeightR.TabIndex = 23;
            this.HeightR.Text = "sliderControl2";
            this.HeightR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeightR_MouseDown);
            this.HeightR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeightR_MouseUp);
            // 
            // HeightL
            // 
            this.HeightL.Location = new System.Drawing.Point(6, 128);
            this.HeightL.ManipulatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HeightL.ManipulatorPosition = 0F;
            this.HeightL.Name = "HeightL";
            this.HeightL.NegativeAreaBrush = System.Drawing.Color.DarkGray;
            this.HeightL.PositiveAreaBrush = System.Drawing.Color.DarkGray;
            this.HeightL.ResetPositionOnMouseRelease = false;
            this.HeightL.Size = new System.Drawing.Size(184, 23);
            this.HeightL.TabIndex = 22;
            this.HeightL.Text = "sliderControl1";
            this.HeightL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeightL_MouseDown);
            this.HeightL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeightL_MouseUp);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = null;
            this.pictureBox5.Location = new System.Drawing.Point(600, 343);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(180, 180);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = null;
            this.pictureBox6.Location = new System.Drawing.Point(199, 343);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(180, 180);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Image = null;
            this.pictureBox8.Location = new System.Drawing.Point(13, 343);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(180, 180);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 28;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox8_Paint);
            // 
            // rotateSliderL
            // 
            this.rotateSliderL.IsHorizontal = false;
            this.rotateSliderL.Location = new System.Drawing.Point(385, 157);
            this.rotateSliderL.ManipulatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rotateSliderL.ManipulatorPosition = 0F;
            this.rotateSliderL.Name = "rotateSliderL";
            this.rotateSliderL.NegativeAreaBrush = System.Drawing.Color.DarkGray;
            this.rotateSliderL.PositiveAreaBrush = System.Drawing.Color.DarkGray;
            this.rotateSliderL.ResetPositionOnMouseRelease = false;
            this.rotateSliderL.Size = new System.Drawing.Size(22, 366);
            this.rotateSliderL.TabIndex = 32;
            this.rotateSliderL.Text = "Rotate Left Image";
            this.rotateSliderL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rotateSliderL_MouseDown);
            this.rotateSliderL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rotateSliderL_MouseUp);
            // 
            // rotateSliderR
            // 
            this.rotateSliderR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rotateSliderR.IsHorizontal = false;
            this.rotateSliderR.Location = new System.Drawing.Point(786, 157);
            this.rotateSliderR.ManipulatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rotateSliderR.ManipulatorPosition = 0F;
            this.rotateSliderR.Name = "rotateSliderR";
            this.rotateSliderR.NegativeAreaBrush = System.Drawing.Color.DarkGray;
            this.rotateSliderR.PositiveAreaBrush = System.Drawing.Color.DarkGray;
            this.rotateSliderR.ResetPositionOnMouseRelease = false;
            this.rotateSliderR.Size = new System.Drawing.Size(22, 366);
            this.rotateSliderR.TabIndex = 33;
            this.rotateSliderR.Text = "Rotate Right Image";
            this.rotateSliderR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rotateSliderR_MouseDown);
            this.rotateSliderR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rotateSliderR_MouseUp);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Image = null;
            this.pictureBox7.Location = new System.Drawing.Point(414, 343);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(180, 180);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox7_Paint);
            // 
            // TrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(820, 550);
            this.Controls.Add(this.rotateSliderR);
            this.Controls.Add(this.rotateSliderL);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.blobHeightR);
            this.Controls.Add(this.blobHeightL);
            this.Controls.Add(this.HeightR);
            this.Controls.Add(this.HeightL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blobWidthR);
            this.Controls.Add(this.blobWidthL);
            this.Controls.Add(this.WidthR);
            this.Controls.Add(this.WidthL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label blobWidthR;
        private System.Windows.Forms.Label blobWidthL;
        private AForge.Controls.SliderControl WidthR;
        private AForge.Controls.SliderControl WidthL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label blobHeightR;
        private System.Windows.Forms.Label blobHeightL;
        private AForge.Controls.SliderControl HeightR;
        private AForge.Controls.SliderControl HeightL;
        private AForge.Controls.PictureBox pictureBox5;
        private AForge.Controls.PictureBox pictureBox6;
        private AForge.Controls.PictureBox pictureBox8;
        private AForge.Controls.SliderControl rotateSliderL;
        private AForge.Controls.SliderControl rotateSliderR;
        private AForge.Controls.PictureBox pictureBox7;
    }
}