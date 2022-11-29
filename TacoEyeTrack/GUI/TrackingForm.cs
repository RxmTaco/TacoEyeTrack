using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;
using AForge.Video;
using Aspose.Imaging.FileFormats.Tiff.FileManagement;
using MoreLinq;
using OpenMod.Core.Helpers;
using Rug.Osc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using TacoEyeTrack.Properties;

namespace TacoEyeTrack
{
    public partial class TrackingForm : Form
    {
        public Bitmap bmp1 { get; set; }
        public Bitmap bmp2 { get; set; }

        string url;
        string url2;

        MJPEGStream stream1;
        MJPEGStream stream2;

        System.Drawing.PointF centerL;
        System.Drawing.PointF centerR;
        System.Drawing.PointF zeroL;
        System.Drawing.PointF zeroR;
        System.Drawing.PointF avgL;
        System.Drawing.PointF avgR;
        System.Drawing.PointF center;

        int blinkL = 0;
        int blinkR = 0;
        
        float[] pointsLX;
        float[] pointsLY;
        float[] pointsRX;
        float[] pointsRY;
        PointF smoothPointL;
        PointF smoothPointR;

        OscSender sender;
        
        public TrackingForm()
        {
            InitializeComponent();

            pointsLX = new float[100];
            pointsLY = new float[100];
            pointsRX = new float[100];
            pointsRY = new float[100];
            
            //Get urls
            if (Settings.Default.urlL.Length == 0)
                url = "No Source";
            else
                url = Settings.Default["urlL"].ToString();

            if (Settings.Default.urlR.Length == 0)
                url2 = "No Source";
            else
                url2 = Settings.Default["urlR"].ToString();

            //Start stream
            stream1 = new MJPEGStream(url);
            stream1.NewFrame += PlayerControl1_NewFrame;

            stream2 = new MJPEGStream(url2);
            stream2.NewFrame += PlayerControl2_NewFrame;

            stream1.Start();
            stream2.Start();

            //OSC
            IPAddress ip;
            string ipString = Settings.Default["ip"].ToString();
            int port = Settings.Default.port;
            ip = IPAddress.Parse(ipString);

            //New sender
            sender = new OscSender(ip, port);

            //Connect to socket
            sender.Connect();
        }

        public void Smoothing(float lx, float ly, float rx, float ry)
        {
            int smoothingIterations = Settings.Default.smoothingIterations;
            
            if (smoothingIterations > 1)
            {
                //Add new points to array and shift all other points so newest point is at 0 position
                float[] tempLX = new float[smoothingIterations];
                float[] tempLY = new float[smoothingIterations];
                float[] tempRX = new float[smoothingIterations];
                float[] tempRY = new float[smoothingIterations];
                tempLX = pointsLX;
                tempLY = pointsLY;
                tempRX = pointsRX;
                tempRY = pointsRY;
                Array.Copy(tempLX, 0, pointsLX, 1, pointsLX.Length - 1);
                Array.Copy(tempLY, 0, pointsLY, 1, pointsLY.Length - 1);
                Array.Copy(tempRX, 0, pointsRX, 1, pointsRX.Length - 1);
                Array.Copy(tempRY, 0, pointsRY, 1, pointsRY.Length - 1);

                pointsLX[0] = new float[] { lx }[0];
                pointsLY[0] = new float[] { ly }[0];
                pointsRX[0] = new float[] { rx }[0];
                pointsRY[0] = new float[] { ry }[0];

                //Smoothing algorithm

                //Get average of all points

                float sumLX = 0;
                float sumLY = 0;
                float sumRX = 0;
                float sumRY = 0;

                for (int i = 0; i < smoothingIterations; i++)
                {
                    sumLX += pointsLX[i];
                    sumLY += pointsLY[i];
                    sumRX += pointsRX[i];
                    sumRY += pointsRY[i];
                }
                smoothPointL.X = sumLX / smoothingIterations;
                smoothPointL.Y = sumLY / smoothingIterations;
                smoothPointR.X = sumRX / smoothingIterations;
                smoothPointR.Y = sumRY / smoothingIterations;

                for (int i = 0; i < smoothingIterations; i++)
                {
                    Console.Write(pointsLX[i] + " " + pointsLY[i]);
                    Console.Write(" | ");
                    Console.WriteLine(pointsRX[i] + " " + pointsRY[i]);
                }
            }
            else
            {
                smoothPointL.X = lx;
                smoothPointL.Y = ly;
                smoothPointR.X = rx;
                smoothPointR.Y = ry;
            }
            pointsLX.Consume();
            pointsLY.Consume();
            pointsRX.Consume();
            pointsRX.Consume();
            
            Console.Write("LeftAverage " + smoothPointL);
            Console.WriteLine("RightAverage " + smoothPointR);
        }

        public void SendOsc(float lx, float ly, float rx, float ry, int lb, int rb)
        {
            /*IPAddress ip;
            string ipString = Settings.Default["ip"].ToString();
            int port = Settings.Default.port;
            ip = IPAddress.Parse(ipString);

            //New sender
            sender = new OscSender(ip, port);

            //Connect to socket
            sender.Connect();
            */

            int c = 100; //map range
            OscMessage LX = new OscMessage(Settings.Default["leftEyeX"].ToString(), (lx - c) / c); 
            OscMessage LY = new OscMessage(Settings.Default["leftEyeY"].ToString(), (ly - c) / c);
            OscMessage RX = new OscMessage(Settings.Default["rightEyeX"].ToString(), (rx - c) / c);
            OscMessage RY = new OscMessage(Settings.Default["rightEyeY"].ToString(), (ry - c) / c);
            OscMessage LB;
            OscMessage RB;

            if (Settings.Default.blinkMode == false) 
            { 
                LB = new OscMessage(Settings.Default["leftBlink"].ToString(), lb);
                RB = new OscMessage(Settings.Default["rightBlink"].ToString(), rb);
            }
            else
            {
                if(lb == 1)
                    LB = new OscMessage(Settings.Default["leftBlink"].ToString(), true);
                else
                    LB = new OscMessage(Settings.Default["leftBlink"].ToString(), false);
                if(rb == 1)
                    RB = new OscMessage(Settings.Default["rightBlink"].ToString(), true);
                else
                    RB = new OscMessage(Settings.Default["rightBlink"].ToString(), false);
            }

            /*
            Console.Write("LX" + (lx - c) / c + " | " + lx + " | ");
            Console.Write("LY" + (ly - c) / c + " | " + ly + " | ");
            Console.Write("RX" + (rx - c) / c + " | " + rx + " | ");
            Console.WriteLine("RY" + (ry - c) / c + " | " + ry + " | ");
            
            Console.Write(LB);
            Console.WriteLine(RB);
            */

            sender.Send(LX);
            sender.Send(LY);
            sender.Send(RX);
            sender.Send(RY);
            sender.Send(LB);
            sender.Send(RB);

            //sender.Dispose();
            //sender = null;
        }

        public void PlayerControl1_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Get images from stream
            bmp1 = (Bitmap)eventArgs.Frame.Clone();

            //Cropping
            Crop crop = new Crop(new Rectangle(
            Settings.Default.startPointL.X,
            Settings.Default.startPointL.Y,
            Settings.Default.endPointL.X - Settings.Default.startPointL.X,
            Settings.Default.endPointL.Y - Settings.Default.startPointL.Y));
            Bitmap newImage = crop.Apply(bmp1);

            //Grayscale filter (BT709)
            Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = grayscale.Apply(newImage);

            //Rotation
            RotateBicubic rotation = new RotateBicubic(Settings.Default.rotationL, true);
            rotation.FillColor = Color.White;
            grayImage = rotation.Apply(grayImage);

            //Resize
            ResizeBilinear resize = new ResizeBilinear(pictureBox1.Width, pictureBox1.Height);
            grayImage = resize.Apply(grayImage);

            pictureBox1.Image = new Bitmap(grayImage);
            /* FILTERING *********************************************************************************/

            /*Gamma
            GammaCorrection gammaL = new GammaCorrection((sliderR.ManipulatorPosition + 1) * 5);
            gammaL.ApplyInPlace(grayImage);
            */

            /*Noise
            IRandomNumberGenerator generator = new UniformGenerator(new Range(-30, 0));
            AdditiveNoise filter = new AdditiveNoise(generator);
            filter.ApplyInPlace(grayImage);
            */

            //Thresholding
            int rounded = (int)Math.Round((sliderL.ManipulatorPosition + 1) * 250, 0);
            Threshold threshold = new Threshold(rounded);
            threshold.ApplyInPlace(grayImage);

            //invert
            Invert invert = new Invert();
            invert.ApplyInPlace(grayImage);

            //Preview image
            pictureBox3.Image = new Bitmap(grayImage);

            //*Blob size filtering
            BlobsFiltering filter = new BlobsFiltering();
            filter.CoupledSizeFiltering = false;
            filter.MinWidth = (int)((WidthL.ManipulatorPosition + 1) * 100);
            filter.MinHeight = (int)((HeightL.ManipulatorPosition + 1) * 100);
            filter.ApplyInPlace(grayImage);

            /* BLOB DETECTION *****************************************************************************/

            //Initialize blob counter
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(grayImage);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            List<IntPoint> leftPoints, rightPoints;

            //Lock image for drawing
            BitmapData data = grayImage.LockBits(
                new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                ImageLockMode.ReadWrite, grayImage.PixelFormat);

            //Store hull points
            List<IntPoint> edgePointsL = new List<IntPoint>();
            List<IntPoint> hull = new List<IntPoint>();
            foreach (Blob blob in blobs)
            {
                blobCounter.GetBlobsLeftAndRightEdges(blob, out leftPoints, out rightPoints);
                if (leftPoints.Count > 0 && rightPoints.Count > 0)
                {
                    // get blob's edge points
                    edgePointsL = new List<IntPoint>();
                    edgePointsL.AddRange(leftPoints);
                    edgePointsL.AddRange(rightPoints);

                    // blob's convex hull
                    GrahamConvexHull hullFinder = new GrahamConvexHull();
                    hull = hullFinder.FindHull(edgePointsL);

                    // create graphics and draw the hull

                    Drawing.Polygon(data, hull, Color.White);
                }
            }
            
            //Get average point
            if (edgePointsL.Count > 0)
            {
                if (Settings.Default.blobMode == true) //Check wether hull tracking mode is enabled
                    avgL = new PointF((float)hull.Average(p => p.X), (float)hull.Average(p => p.Y));                    //Hull average
                else
                    avgL = new PointF((float)edgePointsL.Average(p => p.X), (float)edgePointsL.Average(p => p.Y));      //Blob average
            }
            
            if (edgePointsL.Count < 5) //Check blink state
                blinkL = 1;
            else 
                blinkL = 0;
            
            centerL = new PointF(avgL.X - zeroL.X + center.X, avgL.Y - zeroL.Y + center.Y);

            Smoothing(centerL.X, centerL.Y, centerR.X, centerR.Y);

            grayImage.UnlockBits(data);

            pictureBox8.Image = null;
            using (var paint = new PaintEventArgs(pictureBox8.CreateGraphics(), pictureBox8.ClientRectangle))
            {
                if (blinkL == 1)
                {
                    paint.Graphics.FillRectangle(Brushes.Purple, pictureBox8.ClientRectangle);
                    paint.Dispose();
                }
                else
                {
                    Pen pen = new Pen(System.Drawing.Color.DarkBlue, 10);
                    paint.Graphics.DrawEllipse(pen, smoothPointL.X - 20, smoothPointL.Y - 20, 40, 40);
                    pen.Dispose();
                    paint.Dispose();
                }
            }

            //post final
            pictureBox6.Image = grayImage;

            //Send OSC
            SendOsc(smoothPointL.X, smoothPointL.Y, smoothPointR.X, smoothPointR.Y, blinkL, blinkR);
        }

        public void PlayerControl2_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Get images from stream
            bmp2 = (Bitmap)eventArgs.Frame.Clone();

            //Cropping
            Crop crop = new Crop(new Rectangle(
            Settings.Default.startPointR.X,
            Settings.Default.startPointR.Y,
            Settings.Default.endPointR.X - Settings.Default.startPointR.X,
            Settings.Default.endPointR.Y - Settings.Default.startPointR.Y));
            Bitmap newImage = crop.Apply(bmp2);

            //Grayscale filter (BT709)
            Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = grayscale.Apply(newImage);

            //Rotation
            RotateBicubic rotation = new RotateBicubic(Settings.Default.rotationR, true);
            rotation.FillColor = Color.White;
            grayImage = rotation.Apply(grayImage);

            //Resize
            ResizeBilinear resize = new ResizeBilinear(pictureBox1.Width, pictureBox1.Height);
            grayImage = resize.Apply(grayImage);

            pictureBox2.Image = new Bitmap(grayImage);

            /* FILTERING *********************************************************************************/

            /*Gamma
            GammaCorrection gammaL = new GammaCorrection((sliderR.ManipulatorPosition + 1) * 5);
            gammaL.ApplyInPlace(grayImage);
            */

            /*Noise
            IRandomNumberGenerator generator = new UniformGenerator(new Range(-30, 0));
            AdditiveNoise filter = new AdditiveNoise(generator);
            filter.ApplyInPlace(grayImage);
            */

            //Thresholding
            int rounded = (int)Math.Round((sliderR.ManipulatorPosition + 1) * 250, 0);
            Threshold threshold = new Threshold(rounded);
            threshold.ApplyInPlace(grayImage);

            //invert
            Invert invert = new Invert();
            invert.ApplyInPlace(grayImage);

            //Preview image
            pictureBox4.Image = new Bitmap(grayImage);

            //*Blob size filtering
            BlobsFiltering filter = new BlobsFiltering();
            filter.CoupledSizeFiltering = false;
            filter.MinWidth = (int)((WidthR.ManipulatorPosition + 1) * 100);
            filter.MinHeight = (int)((HeightR.ManipulatorPosition + 1) * 100);
            filter.ApplyInPlace(grayImage);

            /* BLOB DETECTION *****************************************************************************/

            //Initialize blob counter
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(grayImage);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            List<IntPoint> leftPoints, rightPoints;

            //Lock image for drawing
            BitmapData data = grayImage.LockBits(
                new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                ImageLockMode.ReadWrite, grayImage.PixelFormat);

            List<IntPoint> edgePointsR = new List<IntPoint>();
            List<IntPoint> hull = new List<IntPoint>();

            foreach (Blob blob in blobs)
            {
                blobCounter.GetBlobsLeftAndRightEdges(blob, out leftPoints, out rightPoints);
                if (leftPoints.Count > 0 && rightPoints.Count > 0)
                {
                    // get blob's edge points
                    edgePointsR = new List<IntPoint>();
                    edgePointsR.AddRange(leftPoints);
                    edgePointsR.AddRange(rightPoints);

                    // blob's convex hull
                    GrahamConvexHull hullFinder = new GrahamConvexHull();
                    hull = hullFinder.FindHull(edgePointsR);

                    // create graphics and draw the hull

                    Drawing.Polygon(data, hull, Color.White);
                }
            }
            
            //Get average point
            if (edgePointsR.Count > 0)
            {
                if (Settings.Default.blobMode == true) //Check wether hull tracking mode is enabled
                    avgR = new PointF((float)hull.Average(p => p.X), (float)hull.Average(p => p.Y));                    //Hull average
                else
                    avgR = new PointF((float)edgePointsR.Average(p => p.X), (float)edgePointsR.Average(p => p.Y));      //Blob average
            }

            if (edgePointsR.Count < 5) //Check blink state
                blinkR = 1;
            else 
                blinkR = 0;

            centerR = new PointF(avgR.X - zeroR.X + center.X, avgR.Y - zeroR.Y + center.Y);

            Smoothing(centerL.X, centerL.Y, centerR.X, centerR.Y);

            grayImage.UnlockBits(data);

            pictureBox7.Image = null;

            using (var paint = new PaintEventArgs(pictureBox7.CreateGraphics(), pictureBox7.ClientRectangle))
            {
                if (blinkR == 1)
                {
                    paint.Graphics.FillRectangle(Brushes.Purple, pictureBox7.ClientRectangle);
                    paint.Dispose();
                }
                else
                {
                    Pen pen = new Pen(System.Drawing.Color.DarkBlue, 10);
                    paint.Graphics.DrawEllipse(pen, centerR.X - 20, centerR.Y - 20, 40, 40);
                    pen.Dispose();
                    paint.Dispose();
                }
            }

            //post final
            pictureBox5.Image = grayImage;

            //Send OSC
            SendOsc(smoothPointL.X, smoothPointL.Y, smoothPointR.X, smoothPointR.Y, blinkL, blinkR);
        }
        //Draw Left tracked blob
        public void PictureBox8_Paint(object sender, PaintEventArgs e)
        {
            if (blinkL == 1)
            {
                e.Graphics.FillRectangle(Brushes.Purple, pictureBox8.ClientRectangle);
                e.Dispose();
            }
            else
            {
                Pen pen = new Pen(System.Drawing.Color.DarkBlue, 10);
                e.Graphics.DrawEllipse(pen, smoothPointL.X - 20, smoothPointL.Y - 20, 40, 40);
                pen.Dispose();
                e.Dispose();
            }
        }
        //Draw Right tracked blob
        private void PictureBox7_Paint(object sender, PaintEventArgs e)
        {
            if (blinkR == 1)
            {
                e.Graphics.FillRectangle(Brushes.Purple, pictureBox7.ClientRectangle);
                e.Dispose();
            }
            else
            {
                Pen pen = new Pen(System.Drawing.Color.DarkBlue, 10);
                e.Graphics.DrawEllipse(pen, smoothPointR.X - 20, smoothPointR.Y - 20, 40, 40);
                pen.Dispose();
                e.Dispose();
            }
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            zeroL = avgL;
            zeroR = avgR;
            center = new PointF(pictureBox8.Width / 2, pictureBox8.Height / 2);


            this.label5.Text = "X: " + centerL.X.ToString() + "Y: " + centerL.Y.ToString();
            this.label6.Text = "X: " + centerR.X.ToString() + "Y: " + centerR.Y.ToString();
        }

        private void TrackingForm_Load(object sender, EventArgs e)
        {
            //Load all variables from settings
            this.urlL.Text = url;
            this.urlR.Text = url2;

            this.label5.Text = "X: " + centerL.X.ToString() + "Y: " + centerL.Y.ToString();
            this.label6.Text = "X: " + centerR.X.ToString() + "Y: " + centerR.Y.ToString();

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

            this.rotateSliderR.ManipulatorPosition = (float)((Settings.Default.rotationR / 180) - 1);
            this.rotateSliderL.ManipulatorPosition = (float)((Settings.Default.rotationL / 180) - 1);
            
            this.blobMode.Checked = Settings.Default.blobMode;

            this.smoothBox.Text = (Settings.Default.smoothingIterations - 1).ToString();
        }

        private void SliderL_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["sliderL"] = sliderL.ManipulatorPosition;
            this.sliderValL.Text = sliderL.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void SliderL_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["sliderL"] = sliderL.ManipulatorPosition;
            this.sliderValL.Text = sliderL.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void SliderR_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["sliderR"] = sliderR.ManipulatorPosition;
            this.sliderValR.Text = sliderR.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void SliderR_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["sliderR"] = sliderR.ManipulatorPosition;
            this.sliderValR.Text = sliderR.ManipulatorPosition.ToString();
            Settings.Default.Save();
        }

        private void WidthL_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["blobWidthL"] = WidthL.ManipulatorPosition;
            this.blobWidthL.Text = ((int)((WidthL.ManipulatorPosition + 1) * 100)).ToString();
            Settings.Default.Save();
        }

        private void WidthL_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["blobWidthL"] = WidthL.ManipulatorPosition;
            this.blobWidthL.Text = ((int)((WidthL.ManipulatorPosition + 1) * 100)).ToString();
            Settings.Default.Save();
        }

        private void HeightL_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["blobHeightL"] = HeightL.ManipulatorPosition;
            this.blobHeightL.Text = ((int)((HeightL.ManipulatorPosition + 1) * 100)).ToString();
            Settings.Default.Save();
        }

        private void HeightL_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["blobHeightL"] = HeightL.ManipulatorPosition;
            this.blobHeightL.Text = ((int)((HeightL.ManipulatorPosition + 1) * 100)).ToString();
            Settings.Default.Save();
        }

        private void WidthR_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["blobWidthR"] = WidthR.ManipulatorPosition;
            this.blobWidthR.Text = ((int)((WidthR.ManipulatorPosition + 1) * 100)).ToString();
            Settings.Default.Save();
        }

        private void WidthR_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["blobWidthR"] = WidthR.ManipulatorPosition;
            this.blobWidthR.Text = ((int)((WidthR.ManipulatorPosition + 1) * 100)).ToString();
            Settings.Default.Save();
        }

        private void HeightR_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default["blobHeightR"] = HeightR.ManipulatorPosition;
            this.blobHeightR.Text = ((int)((HeightR.ManipulatorPosition + 1) * 100)).ToString();
            Settings.Default.Save();
        }

        private void HeightR_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default["blobHeightR"] = HeightR.ManipulatorPosition;
            this.blobHeightR.Text = ((int)((HeightR.ManipulatorPosition + 1) * 100)).ToString();
            Settings.Default.Save();
        }

        private void RotateSliderL_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default.rotationL = (float)((rotateSliderL.ManipulatorPosition + 1) * 180);
            Settings.Default.Save();
        }

        private void RotateSliderL_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default.rotationL = (float)((rotateSliderL.ManipulatorPosition + 1) * 180);
            Settings.Default.Save();
        }

        private void RotateSliderR_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.Default.rotationR = (float)((rotateSliderR.ManipulatorPosition + 1) * 180);
            Settings.Default.Save();
        }

        private void RotateSliderR_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.Default.rotationR = (float)((rotateSliderR.ManipulatorPosition + 1) * 180);
            Settings.Default.Save();
        }
        private void BlobMode_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["blobMode"] = blobMode.Checked;
            Settings.Default.Save();
        }

        private void SmoothBox_TextChanged(object sender, EventArgs e)
        {
            if (smoothBox.Text != "" && int.Parse(smoothBox.Text) < 100)
            {
                Settings.Default["smoothingIterations"] = int.Parse(smoothBox.Text) + 1;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default["smoothingIterations"] = 1;
                Settings.Default.Save();
            }
            if (smoothBox.Text != "" && int.Parse(smoothBox.Text) >= 100)
            {
                Settings.Default["smoothingIterations"] = 1;
                Settings.Default.Save();
                smoothBox.Text = "0";
                Exception ex = new Exception("Smoothing iterations must be less than 100, this amount of delay will have your eyes moving next year");
                MessageBox.Show(ex.Message, "Bruh", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TrackingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream1.Stop();
            stream2.Stop();
        }
    }
}