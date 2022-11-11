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
            this.SuspendLayout();
            // 
            // urlL
            // 
            this.urlL.AutoSize = true;
            this.urlL.Location = new System.Drawing.Point(12, 54);
            this.urlL.Name = "urlL";
            this.urlL.Size = new System.Drawing.Size(25, 13);
            this.urlL.TabIndex = 1;
            this.urlL.Text = "Left";
            // 
            // urlR
            // 
            this.urlR.AutoSize = true;
            this.urlR.Location = new System.Drawing.Point(238, 54);
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
            // TrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.urlR);
            this.Controls.Add(this.urlL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrackingForm";
            this.Text = "TrackingForm";
            this.Load += new System.EventHandler(this.TrackingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label urlL;
        private System.Windows.Forms.Label urlR;
        private System.Windows.Forms.Button btnload;
    }
}