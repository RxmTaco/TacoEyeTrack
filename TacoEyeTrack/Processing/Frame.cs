﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacoEyeTrack.Processing
{
    internal class Frame
    {
    }
    public static (Bitmap, Bitmap, Bitmap, Bitmap, Bitmap, Bitmap, Bitmap, Bitmap) GetFrames(Bitmap bmp)
    {
        Processing.Eye.Crop(bmp);
        
        return bmp;
    }
}
