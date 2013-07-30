using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Schedule;
using Newtonsoft.Json;

namespace pokeTools
{
    public partial class mainform : Form
    {
        //private ScheduleTimer TickTimer;
        //private WPCollection wpc;
        //private string confpath;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern bool SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        static void setWallpaper(string wallpaper)
        {
            if(wallpaper.Length > 0) SystemParametersInfo(20, 0, wallpaper, 0x1);
        }

        private void getConf()
        {
            if (File.Exists(confpath))
            {
                wpc = JsonConvert.DeserializeObject<WPCollection>(File.ReadAllText(confpath));
            }
        }

        private void setConf()
        {
            File.WriteAllText(confpath, JsonConvert.SerializeObject(this.wpc));
        }

        private void resetTickTimer()
        {
            TickTimer.Stop();
            TickTimer.EventStorage = new NullEventStorage();
            foreach (WP w in wpc.wp)
            {
                TickTimer.AddEvent(new ScheduledTime("Daily", w.hr.ToString() + ":" + w.min.ToString()));
            }
            TickTimer.Start();
        }

        private void StartUp()
        {
            double t = DateTime.Now.Hour + DateTime.Now.Minute * 0.01;
            double closeT = -1, tempT = 0;
            string wpath = "";
            foreach (WP w in wpc.wp)
            {
                tempT = w.hr + w.min * 0.01;
                if (tempT <= t && tempT > closeT)
                {
                    wpath = w.Path;
                    closeT = tempT;
                }
            }
            setWallpaper(wpath);
        }

        private void TickTimer_Elapsed(object sender, ScheduledEventArgs e)
        {
            int hr = e.EventTime.Hour;
            int min = e.EventTime.Minute;
            foreach (WP w in wpc.wp)
            {
                if (w.hr == hr && w.min == min)
                {
                    setWallpaper(w.Path);
                    break;
                }
            }
        }

    }
}
