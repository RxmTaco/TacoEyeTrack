using AForge.Video;
using TacoEyeTrack.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TacoEyeTrack
{
    public partial class EyeTracker : Form
    {
        public EyeTracker()
        {
            InitializeComponent();
        }

        private void EyeTrackVR_Load(object sender, EventArgs e)
        {
            loadform(new SettingsForm());
        }

        private void Panel_Settings_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadform(object Form)
        {
            //Load forms into main panel view
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock= DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            loadform(new SettingsForm());
            Thread.Sleep(1);
            if (Application.OpenForms["CroppingForm"] != null)
                Application.OpenForms["CroppingForm"].Close();
            if (Application.OpenForms["TrackingForm"] != null)
                Application.OpenForms["TrackingForm"].Close();
        }

        private void btntracking_Click(object sender, EventArgs e)
        {
            loadform(new TrackingForm());
            Thread.Sleep(1);
            if (Application.OpenForms["CroppingForm"] != null)
            Application.OpenForms["CroppingForm"].Close();
            if (Application.OpenForms["SettingsForm"] != null)
                Application.OpenForms["SettingsForm"].Close();
        }

        private void btncropping_Click(object sender, EventArgs e)
        {
            loadform(new CroppingForm());
            Thread.Sleep(1);
            if (Application.OpenForms["TrackingForm"] != null)
                Application.OpenForms["TrackingForm"].Close();
            if (Application.OpenForms["SettingsForm"] != null)
                Application.OpenForms["SettingsForm"].Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //Application exit
            Application.ExitThread();
            Thread.Sleep(100);
            Environment.Exit(Environment.ExitCode);
            Application.Exit();
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            //Window minimize to task bar

            this.WindowState = FormWindowState.Minimized;
        }
        
        //*** Mouse move event for window drag ***//
        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void EyeTrackVR_ControlRemoved(object sender, ControlEventArgs e)
        {
            
        }
    }
}