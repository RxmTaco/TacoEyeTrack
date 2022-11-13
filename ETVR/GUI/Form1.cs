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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ETVR
{
    public partial class EyeTrackVR : Form
    {
            

        public EyeTrackVR()
        {
            InitializeComponent();
        }

        private void EyeTrackVR_Load(object sender, EventArgs e)
        {
            //Load into settings menu
            loadform(new SettingsForm());
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Header_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Settings_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadform(object Form)
        {
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
        }

        private void btntracking_Click(object sender, EventArgs e)
        {
            loadform(new TrackingForm());
        }

        private void btncropping_Click(object sender, EventArgs e)
        {
            loadform(new CroppingForm());
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //Application exit
            TrackingForm form = new TrackingForm();
            Stream form1 = new Stream();
            form1.videoStop();

            Application.ExitThread();
            Thread.Sleep(100);
            Application.Exit();
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            //Window minimize to task bar
            this.WindowState = FormWindowState.Minimized;
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

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
    }
}