using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planet_simulation
{
    public partial class video : Form
    {
        private bool setStartFormShownBeOnce = false;

        public video()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = @"C:\planet simulation\voideo\v.mp4";
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (setStartFormShownBeOnce)
            {
                return;
            }
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                
                axWindowsMediaPlayer1.close();
                 this.Hide();
                 var start = new Start();
                 start.Show();
                setStartFormShownBeOnce = true;
            }
        }
    }
}
