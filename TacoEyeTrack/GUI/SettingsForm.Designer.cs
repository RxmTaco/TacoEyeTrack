namespace TacoEyeTrack
{
    partial class SettingsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.boxR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxL = new System.Windows.Forms.TextBox();
            this.btnset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rightEyeY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rightEyeX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.leftEyeY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.leftEyeX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rightBlink = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.leftBlink = new System.Windows.Forms.TextBox();
            this.modeInt = new System.Windows.Forms.CheckBox();
            this.modeBool = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Right Eye Source";
            // 
            // boxR
            // 
            this.boxR.Location = new System.Drawing.Point(11, 70);
            this.boxR.Name = "boxR";
            this.boxR.Size = new System.Drawing.Size(170, 20);
            this.boxR.TabIndex = 6;
            this.boxR.Text = "http://192.168.1.xx/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left Eye Source";
            // 
            // boxL
            // 
            this.boxL.Location = new System.Drawing.Point(11, 28);
            this.boxL.Name = "boxL";
            this.boxL.Size = new System.Drawing.Size(170, 20);
            this.boxL.TabIndex = 4;
            this.boxL.Text = "http://192.168.1.xx/";
            // 
            // btnset
            // 
            this.btnset.BackColor = System.Drawing.Color.Purple;
            this.btnset.FlatAppearance.BorderSize = 0;
            this.btnset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnset.Location = new System.Drawing.Point(702, 499);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(86, 39);
            this.btnset.TabIndex = 9;
            this.btnset.Tag = "";
            this.btnset.Text = "Save";
            this.btnset.UseVisualStyleBackColor = false;
            this.btnset.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "OSC Address";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(11, 113);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(170, 20);
            this.addressBox.TabIndex = 10;
            this.addressBox.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "OSC Port";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(11, 157);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(170, 20);
            this.portBox.TabIndex = 12;
            this.portBox.Text = "9000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(569, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Right Eye Y";
            // 
            // rightEyeY
            // 
            this.rightEyeY.Location = new System.Drawing.Point(568, 157);
            this.rightEyeY.Name = "rightEyeY";
            this.rightEyeY.Size = new System.Drawing.Size(220, 20);
            this.rightEyeY.TabIndex = 20;
            this.rightEyeY.Text = "/avatar/parameters/RightEyeY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(569, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Right Eye X";
            // 
            // rightEyeX
            // 
            this.rightEyeX.Location = new System.Drawing.Point(568, 113);
            this.rightEyeX.Name = "rightEyeX";
            this.rightEyeX.Size = new System.Drawing.Size(220, 20);
            this.rightEyeX.TabIndex = 18;
            this.rightEyeX.Text = "/avatar/parameters/RightEyeX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(569, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Left Eye Y";
            // 
            // leftEyeY
            // 
            this.leftEyeY.Location = new System.Drawing.Point(568, 70);
            this.leftEyeY.Name = "leftEyeY";
            this.leftEyeY.Size = new System.Drawing.Size(220, 20);
            this.leftEyeY.TabIndex = 16;
            this.leftEyeY.Text = "/avatar/parameters/LeftEyeY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(569, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Left Eye X";
            // 
            // leftEyeX
            // 
            this.leftEyeX.Location = new System.Drawing.Point(568, 28);
            this.leftEyeX.Name = "leftEyeX";
            this.leftEyeX.Size = new System.Drawing.Size(220, 20);
            this.leftEyeX.TabIndex = 14;
            this.leftEyeX.Text = "/avatar/parameters/LeftEyeX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(569, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Right Blink";
            // 
            // rightBlink
            // 
            this.rightBlink.Location = new System.Drawing.Point(568, 246);
            this.rightBlink.Name = "rightBlink";
            this.rightBlink.Size = new System.Drawing.Size(220, 20);
            this.rightBlink.TabIndex = 24;
            this.rightBlink.Text = "/avatar/parameters/RightEyeLid";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(569, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Left Blink";
            // 
            // leftBlink
            // 
            this.leftBlink.Location = new System.Drawing.Point(568, 202);
            this.leftBlink.Name = "leftBlink";
            this.leftBlink.Size = new System.Drawing.Size(220, 20);
            this.leftBlink.TabIndex = 22;
            this.leftBlink.Text = "/avatar/parameters/LeftEyeLid";
            // 
            // modeInt
            // 
            this.modeInt.AutoSize = true;
            this.modeInt.ForeColor = System.Drawing.SystemColors.Control;
            this.modeInt.Location = new System.Drawing.Point(633, 272);
            this.modeInt.Name = "modeInt";
            this.modeInt.Size = new System.Drawing.Size(37, 17);
            this.modeInt.TabIndex = 26;
            this.modeInt.Text = "int";
            this.modeInt.UseVisualStyleBackColor = true;
            this.modeInt.CheckedChanged += new System.EventHandler(this.modeInt_CheckedChanged);
            // 
            // modeBool
            // 
            this.modeBool.AutoSize = true;
            this.modeBool.ForeColor = System.Drawing.SystemColors.Control;
            this.modeBool.Location = new System.Drawing.Point(676, 272);
            this.modeBool.Name = "modeBool";
            this.modeBool.Size = new System.Drawing.Size(46, 17);
            this.modeBool.TabIndex = 27;
            this.modeBool.Text = "bool";
            this.modeBool.UseVisualStyleBackColor = true;
            this.modeBool.CheckedChanged += new System.EventHandler(this.modeBool_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(565, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Blink value:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.modeBool);
            this.Controls.Add(this.modeInt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rightBlink);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.leftBlink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rightEyeY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rightEyeX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.leftEyeY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.leftEyeX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.btnset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox boxR;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox boxL;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox rightEyeY;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox rightEyeX;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox leftEyeY;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox leftEyeX;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox rightBlink;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox leftBlink;
        private System.Windows.Forms.CheckBox modeInt;
        private System.Windows.Forms.CheckBox modeBool;
        private System.Windows.Forms.Label label11;
    }
}