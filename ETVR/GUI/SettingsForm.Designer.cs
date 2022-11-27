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
            this.blobMode = new System.Windows.Forms.CheckBox();
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
            this.btnset.Location = new System.Drawing.Point(11, 183);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(64, 23);
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
            // blobMode
            // 
            this.blobMode.AutoSize = true;
            this.blobMode.ForeColor = System.Drawing.SystemColors.Control;
            this.blobMode.Location = new System.Drawing.Point(187, 28);
            this.blobMode.Name = "blobMode";
            this.blobMode.Size = new System.Drawing.Size(121, 17);
            this.blobMode.TabIndex = 14;
            this.blobMode.Text = "Enable Hull tracking";
            this.blobMode.UseVisualStyleBackColor = true;
            this.blobMode.CheckedChanged += new System.EventHandler(this.BlobMode_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.blobMode);
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
        private System.Windows.Forms.CheckBox blobMode;
    }
}