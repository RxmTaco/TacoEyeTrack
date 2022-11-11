using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETVR.Properties;

namespace ETVR
{
    public partial class TrackingForm : Form
    {
        public string boxL { get; set; }
        public string boxR { get; set; }

        public TrackingForm()
        {
            InitializeComponent();
        }

        private void TrackingForm_Load(object sender, EventArgs e)
        {
            this.urlL.Text = Settings.Default["urlL"].ToString();
            this.urlR.Text = Settings.Default["urlR"].ToString();
        }

        private void btnload_Click(object sender, EventArgs e)
        { 
        }
    }
}
