using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Video;
using ETVR.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace ETVR
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

        public CroppingForm()
        {
            InitializeComponent();

            stream1 = new MJPEGStream(Settings.Default["urlL"].ToString());

            stream1.NewFrame += playerControl1_NewFrame;


            stream2 = new MJPEGStream(Settings.Default["urlR"].ToString());

            stream2.NewFrame += playerControl2_NewFrame;

            stream1.Start();
            stream2.Start();
        }

        public void playerControl1_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            bmp = (Bitmap)eventArgs.Frame.Clone();

            using (var graphics = Graphics.FromImage(bmp))
            {
                Pen pen = new Pen(Color.Red, 3);
                
                graphics.DrawLine(pen, startPointL.X, startPointL.Y, endPointL.X, startPointL.Y);   //top
                graphics.DrawLine(pen, endPointL.X, startPointL.Y, endPointL.X, endPointL.Y);       //right
                graphics.DrawLine(pen, startPointL.X, startPointL.Y, startPointL.X, endPointL.Y);   //left
                graphics.DrawLine(pen, startPointL.X, endPointL.Y, endPointL.X, endPointL.Y);       //bottom

                pen.Dispose();
            }
            
            pictureBox1.Image = bmp;
        }

        public void playerControl2_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            bmp2 = (Bitmap)eventArgs.Frame.Clone();

            using (var graphics = Graphics.FromImage(bmp2))
            {
                Pen pen = new Pen(Color.Red, 3);

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
            
        }
        
        public void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && (onBox1 == true))
            {
                System.Drawing.Image b = pictureBox1.Image;
                int x = b.Width * e.X / pictureBox1.Width;
                int y = b.Height * e.Y / pictureBox1.Height;
                startPointL = new System.Drawing.Point(x, y);
            }
        }
        
        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            while ((e.Button == MouseButtons.Left) && (onBox1 == true))
            {
                System.Drawing.Image b = pictureBox1.Image;
                int x = b.Width * e.X / pictureBox1.Width;
                int y = b.Height * e.Y / pictureBox1.Height;
                endPointL = new System.Drawing.Point(x, y);
                break;
            }
        }

        private void pictureBox2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && (onBox2 == true))
            {
                System.Drawing.Image b = pictureBox2.Image;
                int x = b.Width * e.X / pictureBox2.Width;
                int y = b.Height * e.Y / pictureBox2.Height;
                startPointR = new System.Drawing.Point(x, y);
            }
        }

        private void pictureBox2_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            while ((e.Button == MouseButtons.Left) && (onBox2 == true))
            {
                System.Drawing.Image b = pictureBox2.Image;
                int x = b.Width * e.X / pictureBox2.Width;
                int y = b.Height * e.Y / pictureBox2.Height;
                endPointR = new System.Drawing.Point(x, y);
                break;
            }
        }
        bool onBox1 = false;
        bool onBox2 = false;

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            onBox1 = true;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            onBox2 = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            onBox2 = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            onBox1 = false;
        }
    }
}
