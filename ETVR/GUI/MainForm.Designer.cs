namespace ETVR
{
    partial class EyeTrackVR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EyeTrackVR));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnhide = new System.Windows.Forms.Button();
            this.btncropping = new System.Windows.Forms.Button();
            this.btntracking = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 37);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(964, 583);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Settings_Paint);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeaderPanel.BackgroundImage")));
            this.HeaderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeaderPanel.Controls.Add(this.btnclose);
            this.HeaderPanel.Controls.Add(this.btnhide);
            this.HeaderPanel.Controls.Add(this.btncropping);
            this.HeaderPanel.Controls.Add(this.btntracking);
            this.HeaderPanel.Controls.Add(this.btnsettings);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(964, 37);
            this.HeaderPanel.TabIndex = 2;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            this.HeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseMove);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Black;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(922, 0);
            this.btnclose.Margin = new System.Windows.Forms.Padding(0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 37);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnhide
            // 
            this.btnhide.BackColor = System.Drawing.Color.Black;
            this.btnhide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhide.BackgroundImage")));
            this.btnhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhide.FlatAppearance.BorderSize = 0;
            this.btnhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhide.ForeColor = System.Drawing.Color.White;
            this.btnhide.Location = new System.Drawing.Point(883, 0);
            this.btnhide.Margin = new System.Windows.Forms.Padding(0);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(39, 37);
            this.btnhide.TabIndex = 4;
            this.btnhide.Text = "-";
            this.btnhide.UseVisualStyleBackColor = false;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // btncropping
            // 
            this.btncropping.BackColor = System.Drawing.Color.Purple;
            this.btncropping.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btncropping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncropping.ForeColor = System.Drawing.SystemColors.Control;
            this.btncropping.Location = new System.Drawing.Point(224, 5);
            this.btncropping.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btncropping.Name = "btncropping";
            this.btncropping.Size = new System.Drawing.Size(93, 26);
            this.btncropping.TabIndex = 2;
            this.btncropping.Text = "CROPPING";
            this.btncropping.UseVisualStyleBackColor = false;
            this.btncropping.Click += new System.EventHandler(this.btncropping_Click);
            // 
            // btntracking
            // 
            this.btntracking.BackColor = System.Drawing.Color.Purple;
            this.btntracking.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btntracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntracking.ForeColor = System.Drawing.SystemColors.Control;
            this.btntracking.Location = new System.Drawing.Point(118, 5);
            this.btntracking.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btntracking.Name = "btntracking";
            this.btntracking.Size = new System.Drawing.Size(93, 26);
            this.btntracking.TabIndex = 1;
            this.btntracking.Text = "TRACKING";
            this.btntracking.UseVisualStyleBackColor = false;
            this.btntracking.Click += new System.EventHandler(this.btntracking_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.Purple;
            this.btnsettings.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsettings.Location = new System.Drawing.Point(12, 6);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(93, 26);
            this.btnsettings.TabIndex = 0;
            this.btnsettings.Text = "SETTINGS";
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // EyeTrackVR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(964, 620);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Alaska", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EyeTrackVR";
            this.Text = "EyeTrackVR";
            this.Load += new System.EventHandler(this.EyeTrackVR_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button btncropping;
        private System.Windows.Forms.Button btntracking;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnhide;
        private System.Windows.Forms.Button btnclose;
    }
}

