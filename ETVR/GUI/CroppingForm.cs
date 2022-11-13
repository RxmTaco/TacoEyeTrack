using AForge.Controls;
using AForge.Video;
using ETVR.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETVR
{
    public partial class CroppingForm : Form
    {
        Stream s = new Stream();

        public CroppingForm()
        {
            InitializeComponent();
            pictureBox1.Image = s.bmp;
            pictureBox2.Image = s.bmp2;
        }

        public void playerControl1_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Source video
            pictureBox1.Image = s.bmp;
        }

        public void playerControl2_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Source video
            pictureBox2.Image = s.bmp2;
        }


        private void CroppingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
