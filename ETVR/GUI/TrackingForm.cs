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
using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;
using AForge.Math;
using AForge.Video;
using ETVR.Properties;
using System.Windows.Data;
using System.Drawing.Imaging;
using AForge.Math.Random;
//using Aspose.Imaging;

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


            /* FILTERING *********************************************************************************/


            //Grayscale filter (BT709)
            Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = grayscale.Apply(bmp3);

            /*Gamma
            GammaCorrection gammaL = new GammaCorrection((sliderR.ManipulatorPosition + 1) * 5);
            gammaL.ApplyInPlace(grayImage);
            */

            /*Noise
            IRandomNumberGenerator generator = new UniformGenerator(new Range(-30, 0));
            AdditiveNoise filter = new AdditiveNoise(generator);
            filter.ApplyInPlace(grayImage);
            */

            int rounded = (int)Math.Round((sliderR.ManipulatorPosition + 1) * 250, 0);
            Threshold threshold = new Threshold(rounded);
            threshold.ApplyInPlace(grayImage);

            pictureBox3.Image = new Bitmap(grayImage);

            //*Blob size filtering
            BlobsFiltering filter = new BlobsFiltering();
            filter.CoupledSizeFiltering = true;
            filter.MinWidth = (int)(WidthR.ManipulatorPosition + 1) * 100;
            filter.MinHeight = (int)(HeightR.ManipulatorPosition + 1) * 100;
            filter.ApplyInPlace(grayImage);

            /* BLOB DETECTION *****************************************************************************/

            /*

            // process image with blob counter
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(bmp3);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            // create convex hull searching algorithm
            GrahamConvexHull hullFinder = new GrahamConvexHull();

            // lock image to draw on it
            BitmapData data = bmp3.LockBits(
                new Rectangle(0, 0, bmp3.Width, bmp3.Height),
                    ImageLockMode.ReadWrite, bmp3.PixelFormat);

            
            // process each blob
            foreach (Blob blob in blobs)
            {
                List <IntPoint> leftPoints, rightPoints, edgePoints = default;

                // get blob's edge points
                blobCounter.GetBlobsLeftAndRightEdges(blob,
                out leftPoints, out rightPoints);

                edgePoints.AddRange(leftPoints);
                edgePoints.AddRange(rightPoints);

                // blob's convex hull
                List<IntPoint> hull = hullFinder.FindHull(edgePoints);

                Drawing.Polygon(data, hull, Color.Red);
            }
            

            bmp3.UnlockBits(data);

            */

            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(grayImage);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            List<IntPoint> leftPoints, rightPoints;

            BitmapData data = grayImage.LockBits(
                new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                ImageLockMode.ReadWrite, grayImage.PixelFormat);

            foreach (Blob blob in blobs)
            {
                blobCounter.GetBlobsLeftAndRightEdges(blob, out leftPoints, out rightPoints);
                if (leftPoints.Count > 0 && rightPoints.Count > 0)
                {
                    // get blob's edge points
                    List<IntPoint> edgePoints = new List<IntPoint>();
                    edgePoints.AddRange(leftPoints);
                    edgePoints.AddRange(rightPoints);

                    // blob's convex hull
                    GrahamConvexHull hullFinder = new GrahamConvexHull();
                    List<IntPoint> hull = hullFinder.FindHull(edgePoints);

                    // create graphics and draw the hull

                    Drawing.Polygon(data, hull, Color.White);
                }
            }

            grayImage.UnlockBits(data);

            //post final
            pictureBox6.Image = grayImage;
        }

        public void playerControl4_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Stream
            bmp4 = (Bitmap)eventArgs.Frame.Clone();

            /* FILTERING *********************************************************************************/

            //Grayscale filter (BT709)
            Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = grayscale.Apply(bmp4);

            /*Gamma
            GammaCorrection gammaL = new GammaCorrection((sliderR.ManipulatorPosition + 1) * 5);
            gammaL.ApplyInPlace(grayImage);
            */

            /*Noise
            IRandomNumberGenerator generator = new UniformGenerator(new Range(-30, 0));
            AdditiveNoise filter = new AdditiveNoise(generator);
            filter.ApplyInPlace(grayImage);
            */

            int rounded = (int)Math.Round((sliderR.ManipulatorPosition + 1) * 250, 0);
            Threshold threshold = new Threshold(rounded);
            threshold.ApplyInPlace(grayImage);

            pictureBox4.Image = new Bitmap(grayImage);

            //*Blob size filtering
            BlobsFiltering filter = new BlobsFiltering();
            filter.CoupledSizeFiltering = true;
            filter.MinWidth = (int)(WidthR.ManipulatorPosition + 1) * 100;
            filter.MinHeight = (int)(HeightR.ManipulatorPosition + 1) * 100;
            filter.ApplyInPlace(grayImage);

            /* BLOB DETECTION *****************************************************************************/


            /*
             // process image with blob counter
             BlobCounter blobCounter = new BlobCounter();
             blobCounter.ProcessImage(grayImage);
             Blob[] blobs = blobCounter.GetObjectsInformation();

             // create convex hull searching algorithm
             GrahamConvexHull hullFinder = new GrahamConvexHull();

             // lock image to draw on it
             BitmapData data = grayImage.LockBits(
                 new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                     ImageLockMode.ReadWrite, grayImage.PixelFormat);


             // process each blob
             foreach (Blob blob in blobs)
             {
                 List<IntPoint> leftPoints, rightPoints, edgePoints = default;

                 // get blob's edge points
                 blobCounter.GetBlobsLeftAndRightEdges(blob,
                 out leftPoints, out rightPoints);

                 edgePoints.AddRange(leftPoints);
                 edgePoints.AddRange(rightPoints);

                 // blob's convex hull
                 List<IntPoint> hull = hullFinder.FindHull(edgePoints);

                 Drawing.Polygon(data, hull, Color.Red);
             }


            grayImage.UnlockBits(data);
            */

            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(grayImage);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            List<IntPoint> leftPoints, rightPoints;

            BitmapData data = grayImage.LockBits(
                new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                ImageLockMode.ReadWrite, grayImage.PixelFormat);

            foreach (Blob blob in blobs)
            {
                blobCounter.GetBlobsLeftAndRightEdges(blob, out leftPoints, out rightPoints);
                if (leftPoints.Count > 0 && rightPoints.Count > 0)
                {
                    // get blob's edge points
                    List<IntPoint> edgePoints = new List<IntPoint>();
                    edgePoints.AddRange(leftPoints);
                    edgePoints.AddRange(rightPoints);

                    // blob's convex hull
                    GrahamConvexHull hullFinder = new GrahamConvexHull();
                    List<IntPoint> hull = hullFinder.FindHull(edgePoints);

                    // create graphics and draw the hull
                    
                    Drawing.Polygon(data, hull, Color.White);
                }
            }

            grayImage.UnlockBits(data);

            //post final
            pictureBox5.Image = grayImage;
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
            this.WidthL.ManipulatorPosition = Settings.Default.blobWidthL;
            this.WidthR.ManipulatorPosition = Settings.Default.blobWidthR;
            this.HeightL.ManipulatorPosition = Settings.Default.blobHeightL;
            this.HeightR.ManipulatorPosition = Settings.Default.blobHeightR;

            this.sliderValL.Text = Settings.Default["sliderL"].ToString();
            this.sliderValR.Text = Settings.Default["sliderR"].ToString();
            this.blobHeightL.Text = Settings.Default["blobHeightL"].ToString();
            this.blobHeightR.Text = Settings.Default["blobHeightR"].ToString();
            this.blobWidthL.Text = Settings.Default["blobWidthL"].ToString();
            this.blobWidthR.Text = Settings.Default["blobWidthR"].ToString();
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

        private void WidthL_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["blobWidthL"] = WidthL.ManipulatorPosition;
            this.blobWidthL.Text = WidthL.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void WidthL_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["blobWidthL"] = WidthL.ManipulatorPosition;
            this.blobWidthL.Text = WidthL.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void HeightL_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["blobHeightL"] = HeightL.ManipulatorPosition;
            this.blobHeightL.Text = HeightL.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void HeightL_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["blobHeightL"] = HeightL.ManipulatorPosition;
            this.blobHeightL.Text = HeightL.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void WidthR_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["blobWidthR"] = WidthR.ManipulatorPosition;
            this.blobWidthR.Text = WidthR.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void WidthR_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["blobWidthR"] = WidthR.ManipulatorPosition;
            this.blobWidthR.Text = WidthR.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void HeightR_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["blobHeightR"] = HeightR.ManipulatorPosition;
            this.blobHeightR.Text = HeightR.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void HeightR_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["blobHeightR"] = HeightR.ManipulatorPosition;
            this.blobHeightR.Text = HeightR.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }
    }
}
