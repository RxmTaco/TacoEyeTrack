using System;
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
using AForge.Video;
using ETVR.Properties;

namespace ETVR
{
    public partial class Stream
    {
        public Bitmap bmp { get; set; }
        public Bitmap bmp2 { get; set; }

        MJPEGStream stream1;
        MJPEGStream stream2;

        public Stream()
        {
            stream1 = new MJPEGStream(Settings.Default["urlL"].ToString());

            stream1.NewFrame += playerControl1_NewFrame;


            stream2 = new MJPEGStream(Settings.Default["urlR"].ToString());

            stream2.NewFrame += playerControl2_NewFrame;

            stream1.Start();
            stream2.Start();
        }

        public void playerControl1_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Source video
            bmp = (Bitmap)eventArgs.Frame.Clone();
            bmp.Dispose();
        }

        public void playerControl2_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Source video
            bmp2 = (Bitmap)eventArgs.Frame.Clone();
            bmp2.Dispose();
        }

        public void videoStop()
        {
            stream1.SignalToStop();
            stream2.SignalToStop();

            stream1.WaitForStop();
            stream2.WaitForStop();

            stream1.Stop();
            stream2.Stop();
        }
    }
}