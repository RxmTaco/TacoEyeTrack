using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Shell;
using AForge.Controls;
using AForge.Imaging.Filters;
using AForge.Video;
using ETVR.Properties;

namespace ETVR
{
    public partial class TrackingForm : Form
    {
        public Bitmap bmp { get; set; }
        public Bitmap bmp2 { get; set; }

        public Bitmap bmp3 { get; set; }
        public Bitmap bmp4 { get; set; }


        MJPEGStream stream1;
        MJPEGStream stream2;

        MJPEGStream stream3;
        MJPEGStream stream4;


        public TrackingForm()
        {
            InitializeComponent();

            stream1 = new MJPEGStream(Settings.Default["urlL"].ToString());

            stream1.NewFrame += playerControl1_NewFrame;


            stream2 = new MJPEGStream(Settings.Default["urlR"].ToString());

            stream2.NewFrame += playerControl2_NewFrame;


            stream3 = new MJPEGStream(Settings.Default["urlL"].ToString());

            stream3.NewFrame += playerControl3_NewFrame;


            stream4 = new MJPEGStream(Settings.Default["urlR"].ToString());

            stream4.NewFrame += playerControl4_NewFrame;



            stream1.Start();
            stream2.Start();
            stream3.Start();
            stream4.Start();
        }

        public void playerControl1_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Source video
            bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;
        }

        public void playerControl2_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Source video
            bmp2 = (Bitmap)eventArgs.Frame.Clone();
            pictureBox2.Image = bmp2;
        }


        public void playerControl3_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Edited Stream
            bmp3 = (Bitmap)eventArgs.Frame.Clone();

            SaturationCorrection filterL = new SaturationCorrection(sliderL.ManipulatorPosition);
            filterL.ApplyInPlace(bmp3);

            pictureBox3.Image = bmp3;
        }

        public void playerControl4_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Edited Stream
            bmp4 = (Bitmap)eventArgs.Frame.Clone();

            SaturationCorrection filterR = new SaturationCorrection(sliderR.ManipulatorPosition);
            filterR.ApplyInPlace(bmp4);

            pictureBox4.Image = bmp4;
        }

        private void btnload_Click(object sender, EventArgs e)
        {

        }

        private void TrackingForm_Load(object sender, EventArgs e)
        {
            this.urlL.Text = Settings.Default["urlL"].ToString();
            this.urlR.Text = Settings.Default["urlR"].ToString();

            this.sliderL.ManipulatorPosition = Settings.Default.sliderL;
            this.sliderR.ManipulatorPosition = Settings.Default.sliderR;

            this.sliderValL.Text = Settings.Default["sliderL"].ToString();
            this.sliderValR.Text = Settings.Default["sliderR"].ToString();
        }

        

        private void sliderL_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["sliderL"] = sliderL.ManipulatorPosition;
            this.sliderValL.Text = sliderL.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void sliderL_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["sliderL"] = sliderL.ManipulatorPosition;
            this.sliderValL.Text = sliderL.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void sliderR_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["sliderR"] = sliderR.ManipulatorPosition;
            this.sliderValR.Text = sliderR.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void sliderR_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["sliderR"] = sliderR.ManipulatorPosition;
            this.sliderValR.Text = sliderR.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }


    }
}
