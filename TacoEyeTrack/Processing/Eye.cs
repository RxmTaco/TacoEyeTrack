using AForge.Imaging;
using AForge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;
using TacoEyeTrack.Properties;
using System.Windows.Media.Imaging;
using dnlib.PE;
using System.Windows.Controls;
using AForge.Math.Geometry;

namespace TacoEyeTrack.Processing
{
    internal class Eye
    {
        public Eye() 
        {
        }
        
        public static Bitmap Crop(Bitmap bmp)
        {
            Crop crop = new Crop(new Rectangle(
            Settings.Default.startPointL.X,
            Settings.Default.startPointL.Y,
            Settings.Default.endPointL.X - Settings.Default.startPointL.X,
            Settings.Default.endPointL.Y - Settings.Default.startPointL.Y));
            Bitmap newImage = crop.Apply(bmp);

            return newImage;
        }
        
        public static Bitmap Gray(Bitmap bmp) 
        {
            Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap newImage = grayscale.Apply(bmp);

            return newImage;
        }

        public static Bitmap Rotate(Bitmap bmp)
        {
            RotateBicubic rotation = new RotateBicubic(Settings.Default.rotationL, true);
            rotation.FillColor = Color.White;
            Bitmap newImage = rotation.Apply(bmp);
            
            return newImage;
        }

        public static Bitmap Resize(Bitmap bmp, int width, int height)
        {
            ResizeBilinear resize = new ResizeBilinear(width, height);
            Bitmap newImage = resize.Apply(bmp);
            
            return newImage;
        }

        public static Bitmap Threshold(Bitmap bmp, int thresholdValue)
        {
            Threshold threshold = new Threshold(thresholdValue);
            Bitmap newImage = threshold.Apply(bmp);

            return newImage;
        }

        public static Bitmap Invert(Bitmap bmp) 
        { 
            Invert invert = new Invert();
            Bitmap newImage = invert.Apply(bmp);

            return newImage;
        }

        public static Bitmap Blur(Bitmap bmp, int blurValue)
        {
            GaussianBlur blur = new GaussianBlur(blurValue);
            Bitmap newImage = blur.Apply(bmp);

            return newImage;
        }

        public static List<IntPoint> edgePoints(Bitmap bmp)
        {
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(bmp);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            List<IntPoint> leftPoints, rightPoints;

            //Store hull points
            List<IntPoint> hull = new List<IntPoint>();
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
                    hull = hullFinder.FindHull(edgePoints);
                }
            }
            return hull;
        }

        public static PointF AveragePoint(List<IntPoint> points)
        {
            avg = new PointF((float)hull.Average(p => p.X), (float)hull.Average(p => p.Y));
        }

        public static float GetLidRatio(Bitmap bmp)
        {
            SusanCornersDetector scd = new SusanCornersDetector();
            List<IntPoint> corners = new List<IntPoint>();
            corners.AddRange(scd.ProcessImage(bmp));

            float min = 0;
            float max = 0;
            
            //minimum and maximum Y
            if (corners.Count > 0)
            {
                min = (float)corners.Min(p => p.Y);
                max = (float)corners.Max(p => p.Y);
            }
            float ratio = min / max;
            return ratio;
        }
    }
}
