﻿using AForge.Controls;
using AForge.Video;
using ETVR.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace ETVR
{
    public partial class CroppingForm : Form
    {

        public Bitmap bmp { get; set; }
        public Bitmap bmp2 { get; set; }

        MJPEGStream stream1;
        MJPEGStream stream2;

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
            pictureBox1.Image = bmp;
        }

        public void playerControl2_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            bmp2 = (Bitmap)eventArgs.Frame.Clone();
            pictureBox2.Image = bmp2;
        }


        private void CroppingForm_Load(object sender, EventArgs e)
        {
        }
    }
}
