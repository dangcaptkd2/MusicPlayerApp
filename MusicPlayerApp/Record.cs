using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.VisualBasic;
using System.Media;
namespace MusicPlayerApp
{
    public partial class Record : Form
    {

        public Record()
        {
            InitializeComponent();
        }
        public System.Media.SoundPlayer myplayer;
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        string path = "listsong_karaoke";

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pic_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Record_Load(object sender, EventArgs e)
        {
            //panel2.Hide();
            //panel3.Hide();
            axWindowsMediaPlayer1.Hide();
        }
        //private void bt_save_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog sfd = new SaveFileDialog();
        //    //record("pause recsound", "", 0, 0);
        //    sfd.Filter = "wawe|*.wav";
        //    if(sfd.ShowDialog()== DialogResult.OK)
        //    {
        //        record("save recsound "+ sfd.FileName, "", 0, 0);
        //        record("close recsound", "", 0, 0);
        //    }

        //}
        //private void bt_play_Click(object sender, EventArgs e)
        //{
        //    string path2;
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.Filter = "wawe|*.wav";
        //    if(ofd.ShowDialog()==DialogResult.OK)
        //    {
        //        myplayer = new System.Media.SoundPlayer();
        //        myplayer.SoundLocation = ofd.FileName;
        //        path2 = path + "//" + cB_listsong.SelectedItem.ToString() + ".mp4";
        //        axWindowsMediaPlayer1.URL = path2;
        //        timer1.Start();
        //        count_down.Restart();
        //        myplayer.Play(); 
        //        lb_rec.Text = "playing...";
        //    }
        //}
        System.Diagnostics.Stopwatch count_down = new System.Diagnostics.Stopwatch();

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed  = count_down.Elapsed;
            lb_time.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours),
                elapsed.TotalMinutes, elapsed.TotalSeconds);
        }

        //private void bt_timkiem_Click(object sender, EventArgs e)
        //{
        //    string path2 = "";
        //    if (cB_listsong.SelectedItem==null)
        //    {
        //        MessageBox.Show("vui lòng chọn bài hát ");
        //    }
        //    else
        //    {
        //        pictureBox1.Hide();
        //        axWindowsMediaPlayer1.Show();
        //        path2 = path + "//" + cB_listsong.SelectedItem.ToString() + ".mp4";
        //        axWindowsMediaPlayer1.URL = path2;
        //        record("open new Type waveaudio Alias recsound", "", 0, 0);
        //        record("record recsound", "", 0, 0);
        //        lb_rec.Text = "recording.....";
        //        lb_rec.ForeColor = System.Drawing.Color.Red;
        //        timer1.Start();
        //        count_down.Start();
        //        //MessageBox.Show(cB_listsong.SelectedItem.ToString());
        //    }
        //}
        private void lbl_trangchu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void bt_stop_Click(object sender, EventArgs e)
        //{
        //    //if(bt_play.Focus()==true)
        //    //{
        //    //    timer1.Stop();
        //    //    count_down.Stop();
        //    //}
        //    //count_down.Restart();
        //    //count_down.Stop();
        //    //timer1.Stop();
        //    //lb_rec.Text = "record";
        //    //lb_rec.ForeColor = System.Drawing.Color.Black;
        //    //record("pause recsound", "", 0, 0);
        //    //axWindowsMediaPlayer1.Ctlcontrols.stop();
        //}

        private void pic_record_Click(object sender, EventArgs e)
        {
            string path2 = "";
            if (cB_listsong.SelectedItem == null)
            {
                MessageBox.Show("vui lòng chọn bài hát ");
            }
            else
            {
                pictureBox1.Hide();
                axWindowsMediaPlayer1.Show();
                path2 = path + "//" + cB_listsong.SelectedItem.ToString() + ".mp4";
                axWindowsMediaPlayer1.URL = path2;
                record("open new Type waveaudio Alias recsound", "", 0, 0);
                record("record recsound", "", 0, 0);
                lb_rec.Text = "recording.....";
                lb_rec.ForeColor = System.Drawing.Color.Red;
                timer1.Start();
                count_down.Start();
                //MessageBox.Show(cB_listsong.SelectedItem.ToString());
            }
        }
        private void pic_stoprecord_Click(object sender, EventArgs e)
        {
           
            if (pic_playrecord.Focus() == true)
            {
                timer1.Stop();
                count_down.Stop();
                //myplayer.Stop();
            }
            count_down.Restart();
            count_down.Stop();
            timer1.Stop();
            lb_rec.Text = "record";
            lb_rec.ForeColor = System.Drawing.Color.Black;
            record("pause recsound", "", 0, 0);
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pic_saverecord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //record("pause recsound", "", 0, 0);
            sfd.Filter = "wawe|*.wav";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                record("save recsound " + sfd.FileName, "", 0, 0);
                record("close recsound", "", 0, 0);
            }
        }

        private void pic_playrecord_Click(object sender, EventArgs e)
        {
            string path2;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "wawe|*.wav";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                myplayer = new System.Media.SoundPlayer();
                myplayer.SoundLocation = ofd.FileName;
                //path2 = path + "//" + cB_listsong.SelectedItem.ToString() + ".mp4";
                //axWindowsMediaPlayer1.URL = path2;
                timer1.Start();
                count_down.Restart();
                myplayer.Play();
                lb_rec.Text = "playing...";
            }
        }
    }
}
