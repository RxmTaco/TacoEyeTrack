using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using TacoEyeTrack.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace TacoEyeTrack
{
    public partial class CroppingForm : Form
    {

        public Bitmap bmp { get; set; }
        public Bitmap bmp2 { get; set; }

        MJPEGStream stream1;
        MJPEGStream stream2;

        System.Drawing.Point endPointL;
        System.Drawing.Point startPointL;

        System.Drawing.Point endPointR;
        System.Drawing.Point startPointR;

        public string url1;
        public string url2;

        public CroppingForm()
        {
            InitializeComponent();

            //Get urls
            if (Settings.Default.urlL.Length == 0)
                url1 = "No Source";
            else
                url1 = Settings.Default["urlL"].ToString();

            if (Settings.Default.urlR.Length == 0)
                url2 = "No Source";
            else
                url2 = Settings.Default["urlR"].ToString();

            //Start stream
            stream1 = new MJPEGStream(url1);
            stream1.NewFrame += PlayerControl1_NewFrame;

            stream2 = new MJPEGStream(url2);
            stream2.NewFrame += PlayerControl2_NewFrame;

            stream1.Start();
            stream2.Start();
        }

        public void PlayerControl1_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
            //Image from stream
            bmp = (Bitmap)eventArgs.Frame.Clone();

            using (var graphics = Graphics.FromImage(bmp))
            {
                Pen pen = new Pen(Color.Red, 3);

                //Draw rectangle
                graphics.DrawLine(pen, startPointL.X, startPointL.Y, endPointL.X, startPointL.Y);   //top
                graphics.DrawLine(pen, endPointL.X, startPointL.Y, endPointL.X, endPointL.Y);       //right
                graphics.DrawLine(pen, startPointL.X, startPointL.Y, startPointL.X, endPointL.Y);   //left
                graphics.DrawLine(pen, startPointL.X, endPointL.Y, endPointL.X, endPointL.Y);       //bottom

                pen.Dispose();
            }
            
            pictureBox1.Image = bmp;
        }

        public void PlayerControl2_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Image from stream
            bmp2 = (Bitmap)eventArgs.Frame.Clone();

            using (var graphics = Graphics.FromImage(bmp2))
            {
                Pen pen = new Pen(Color.Red, 3);

                //Draw rectangle
                graphics.DrawLine(pen, startPointR.X, startPointR.Y, endPointR.X, startPointR.Y);   //top
                graphics.DrawLine(pen, endPointR.X, startPointR.Y, endPointR.X, endPointR.Y);       //right
                graphics.DrawLine(pen, startPointR.X, startPointR.Y, startPointR.X, endPointR.Y);   //left
                graphics.DrawLine(pen, startPointR.X, endPointR.Y, endPointR.X, endPointR.Y);       //bottom

                pen.Dispose();
            }
            
            pictureBox2.Image = bmp2;
        }


        private void CroppingForm_Load(object sender, EventArgs e)
        {
            //Set variables from settings on load
            endPointL = Settings.Default.endPointL;
            endPointR = Settings.Default.endPointR;
            startPointL = Settings.Default.startPointL;
            startPointR = Settings.Default.startPointR;
        }
        
        public void PictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Get start point
            if ((e.Button == MouseButtons.Left) && (onBox1 == true) && pictureBox1.Image != null)
            {
                System.Drawing.Image b = pictureBox1.Image;
                int x = b.Width * e.X / pictureBox1.Width;
                int y = b.Height * e.Y / pictureBox1.Height;
                startPointL = new System.Drawing.Point(x, y);
                Settings.Default.startPointL = startPointL;
                Settings.Default.Save();
            }
        }
        
        private void PictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Track end point
            while ((e.Button == MouseButtons.Left) && (onBox1 == true) && pictureBox1.Image != null)
            {
                System.Drawing.Image b = pictureBox1.Image;
                int x = b.Width * e.X / pictureBox1.Width;
                int y = b.Height * e.Y / pictureBox1.Height;
                endPointL = new System.Drawing.Point(x, y);
                Settings.Default.endPointL = endPointL;
                Settings.Default.Save();
                break;
            }
        }

        private void PictureBox2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Get start point
            if ((e.Button == MouseButtons.Left) && (onBox2 == true) && pictureBox2.Image != null)
            {
                System.Drawing.Image b = pictureBox2.Image;
                int x = b.Width * e.X / pictureBox2.Width;
                int y = b.Height * e.Y / pictureBox2.Height;
                startPointR = new System.Drawing.Point(x, y);
                Settings.Default.startPointR = startPointR;
                Settings.Default.Save();
            }
        }

        private void PictureBox2_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Track end point
            while ((e.Button == MouseButtons.Left) && (onBox2 == true) && pictureBox2.Image != null)
            {
                System.Drawing.Image b = pictureBox2.Image;
                int x = b.Width * e.X / pictureBox2.Width;
                int y = b.Height * e.Y / pictureBox2.Height;
                endPointR = new System.Drawing.Point(x, y);
                Settings.Default.endPointR = endPointR;
                Settings.Default.Save();
                break;
            }
        }

        //***Checking if mouse is on picturebox***//
        bool onBox1 = false;
        bool onBox2 = false;

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            onBox1 = true;
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            onBox2 = true;
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            onBox2 = false;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            onBox1 = false;
        }

        private void CroppingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream1.Stop();
            stream2.Stop();
        }
    }
}
