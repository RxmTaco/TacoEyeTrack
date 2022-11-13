using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETVR.Properties;

namespace ETVR
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EyeTrackVR());

            Stream s = new Stream();
            Thread backgroundThread = new Thread(new ThreadStart(Stream));
            backgroundThread.Start();
        }
    }
}
