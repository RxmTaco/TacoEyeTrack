using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using TacoEyeTrack.Properties;

namespace TacoEyeTrack
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }


        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.boxL.Text = Settings.Default["urlL"].ToString();
            this.boxR.Text = Settings.Default["urlR"].ToString();
            this.addressBox.Text = Settings.Default["ip"].ToString();
            this.portBox.Text = Settings.Default["port"].ToString();
        }
        

        private void btnset_Click(object sender, EventArgs e)
        {
            Settings.Default["urlL"] = boxL.Text;
            Settings.Default["urlR"] = boxR.Text;
            Settings.Default["ip"] = addressBox.Text;
            Settings.Default.port = Convert.ToInt32(portBox.Text);
            Settings.Default.Save();
            Console.WriteLine("Saved addresses: ", Settings.Default["urlL"].ToString(), Settings.Default["urlR"].ToString());
        }
    }
}
