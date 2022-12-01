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

namespace TacoEyeTrack.Processing
{
    internal class Blink
    {
        public Blink() 
        {
        }
        public static Bitmap Threshold(Bitmap bmp, int threshold)
        {
            Threshold lidThreshold = new Threshold(threshold);
            lidThreshold.Apply(bmp);
            
            return bmp;
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
