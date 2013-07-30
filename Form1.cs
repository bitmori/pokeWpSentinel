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
        private ScheduleTimer TickTimer;
        private WPCollection wpc;
        private string confpath;

        public mainform()
        {
            this.TickTimer = new ScheduleTimer();
            this.TickTimer.Elapsed += new ScheduledEventHandler(TickTimer_Elapsed);
            this.wpc = new WPCollection();
            this.wpc.wp = new List<WP>();
            this.confpath = Application.StartupPath + "\\conf.json";
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            ODlg1.Filter = "Image Formats (*.bmp;*.jpg;*.jpeg;*.png;)|" +
            "*.bmp;*.jpg;*.jpeg;;*.png;|Bitmaps (*.bmp)|*.bmp|" +
            "JPEGs (*.jpg)|*.jpg;*.jpeg|PNGs (*.png)|*.png";//All Files (*.*)|*.*
            ODlg1.InitialDirectory = @"C:\";

            //foreach (ColumnHeader ch in list1.Columns) { ch.Width = -2; }
            //list1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            getConf();
            foreach (WP w in wpc.wp)
            {
                ListViewItem i = list1.Items.Add(w.Path);
                i.SubItems.Add(w.hr.ToString());
                i.SubItems.Add(w.min.ToString());
                TickTimer.AddEvent(new ScheduledTime("Daily", w.hr.ToString()+":"+w.min.ToString()));
            }

            TickTimer.Start();
            StartUp();
        }

        private void mainform_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.ToString() == "UserClosing") 
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (pathBox.Text.Length == 0)
            {
                MessageBox.Show("Invalid wallpaper file.");
                return;
            }
            int index = wpc.wp.FindIndex(w => (w.hr == hourBox.Value && w.min == minuteBox.Value));
            if (index >= 0)
            {
                MessageBox.Show("This time has been assigned a task.");
                return;
            }
            ListViewItem x = list1.Items.Add(pathBox.Text);
            x.SubItems.Add(hourBox.Value.ToString());
            x.SubItems.Add(minuteBox.Value.ToString());

            wpc.wp.Add(new WP() { Path = pathBox.Text, hr = (int)hourBox.Value, min = (int)minuteBox.Value });
            setConf();
            resetTickTimer();
            StartUp();
        }

        private void RemBtn_Click(object sender, EventArgs e)
        {
            //int index = list1.Items.IndexOf(list1.SelectedItems[0]);
            wpc.wp.Remove(new WP() { Path = list1.SelectedItems[0].SubItems[0].Text, hr = Convert.ToInt32(list1.SelectedItems[0].SubItems[1].Text), min = Convert.ToInt32(list1.SelectedItems[0].SubItems[2].Text) });
            list1.Items.Remove(list1.SelectedItems[0]);

            setConf();
            resetTickTimer();
            StartUp();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == ODlg1.ShowDialog())
            {
                pathBox.Text = ODlg1.FileName;
            }
        }

    }
}
