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

            leftEyeX.Text = Settings.Default["leftEyeX"].ToString();
            leftEyeY.Text = Settings.Default["leftEyeY"].ToString();
            rightEyeX.Text = Settings.Default["rightEyeX"].ToString();
            rightEyeY.Text = Settings.Default["rightEyeY"].ToString();
            leftBlink.Text = Settings.Default["leftBlink"].ToString();
            rightBlink.Text = Settings.Default["rightBlink"].ToString();

            if (Settings.Default.blinkMode == false)
            {
                modeInt.Checked = true;
                modeBool.Checked = false;
            }
            else
            {
                modeInt.Checked = false;
                modeBool.Checked = true;
            }
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            Settings.Default["leftEyeX"] = leftEyeX.Text;
            Settings.Default["leftEyeY"] = leftEyeY.Text;
            Settings.Default["rightEyeX"] = rightEyeX.Text;
            Settings.Default["rightEyeY"] = rightEyeY.Text;
            Settings.Default["leftBlink"] = leftBlink.Text;
            Settings.Default["rightBlink"] = rightBlink.Text;

            Settings.Default["urlL"] = boxL.Text;
            Settings.Default["urlR"] = boxR.Text;
            Settings.Default["ip"] = addressBox.Text;
            Settings.Default.port = Convert.ToInt32(portBox.Text);
            Settings.Default.Save();
        }

        private void modeInt_CheckedChanged(object sender, EventArgs e)
        {
            if (modeInt.Checked == true)
            {
                Settings.Default["blinkMode"] = false;
                Settings.Default.Save();
                modeBool.Checked = false;
            }
        }

        private void modeBool_CheckedChanged(object sender, EventArgs e)
        {
            if (modeBool.Checked == true)
            {
                Settings.Default["blinkMode"] = true;
                Settings.Default.Save();
                modeInt.Checked = false;
            }
        }
    }
}
