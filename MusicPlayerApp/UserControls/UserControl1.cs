using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp.UserControls
{
    public partial class SingleBar : UserControl
    {
        public SingleBar()
        {
            InitializeComponent();
        }
        private string path_icon_play = @"E:\coding\c#\MusicPlayerApp\iconNimage\play.png";
        private string path_icon_pause = @"E:\coding\c#\MusicPlayerApp\iconNimage\pause2.png";
        private string path_icon_shuffle = @"E:\coding\c#\MusicPlayerApp\iconNimage\shuffle.png";
        private string path_icon_shuffled = @"E:\coding\c#\MusicPlayerApp\iconNimage\shuffled.png";
        private string path_icon_repeat = @"E:\coding\c#\MusicPlayerApp\iconNimage\repeat.png";
        private string path_icon_repeated = @"E:\coding\c#\MusicPlayerApp\iconNimage\repeated.png";
        private PlayList current_playlist;
        public int curren_song_index;
        private string path_playlist;

        private Timer timer_show_listsong;
        bool hidden_panel_show_listsong;
        private Panel panel_listsong;
        public void setText_for_btn_listsong(int amount)
        {
            btn_listsong.Text = string.Format("Danh sách phát({0})", amount);
        }
        public void setup_when_play_song()
        {
            string name = current_playlist.playlist[current_playlist.current_song].name;
            string artist = current_playlist.playlist[current_playlist.current_song].artist;
            pic_play_pause.Image = new Bitmap(path_icon_pause);
            lbl_show_artistNsongname.Text = string.Format("{0} - {1}", name, artist);
        }
        //public Image ProfilePic_next
        //{
        //    get { return pic_nextsong.Image; }
        //    set { pic_nextsong.Image = value; }
        //}
        //public Image ProfilePic_last
        //{
        //    get { return pic_lastsong.Image; }
        //    set { pic_lastsong.Image = value; }
        //}
        //public Image ProfilePic_shuffle
        //{
        //    get { return pic_shuffle.Image; }
        //    set { pic_shuffle.Image = value; }
        //}
        //public Image ProfilePic_repeat
        //{
        //    get { return pic_repeat.Image; }
        //    set { pic_repeat.Image = value; }
        //}
        //public Image ProfilePic_playpause
        //{
        //    get { return pic_play_pause.Image; }
        //    set { pic_play_pause.Image = value; }
        //}
        //public string ProfileLbl_artist_author
        //{
        //    get { return lbl_show_artistNsongname.Text; }
        //    set{ lbl_show_artistNsongname.Text = value; }
        //}
        //public string ProfileBtn_listsong
        //{
        //    get { return btn_listsong.Text; }
        //    set { btn_listsong.Text = value; }
        //}
        public string ProfilePath_playlist
        {
            get { return this.current_playlist.path; }
            set
            {
                this.path_playlist = value;
                //this.current_playlist = new PlayList(temp);
                //this.current_playlist = new PlayList(value); 
            }
        }
        public int ProfileIndex_playlist
        {
            get { return this.current_playlist.current_song; }
            set { this.current_playlist.current_song = value; }
        }
        public Timer ProfileTimer_showlistsong
        {
            get { return this.timer_show_listsong; }
            set { this.timer_show_listsong = value; }
        }
        //public bool ProfileHidden_showlistsong
        //{
        //    get { return this.hidden_panel_show_listsong; }
        //    set { this.hidden_panel_show_listsong = value; }
        //}
        //public Panel ProfilePanel_listsong
        //{
        //    get { return this.panel_listsong; }
        //    set { this.panel_listsong = value; }
        //}
        public void playsong()
        {
            this.current_playlist = new PlayList(this.path_playlist);
           // this.curren_song_index = index_current_song;
           // this.current_playlist.current_song = this.curren_song_index;
            this.current_playlist.play_song();
            setup_when_play_song();
            setText_for_btn_listsong(this.current_playlist.amount);
        }
        private void SingleBar_Load(object sender, EventArgs e)
        {
            this.lbl_show_artistNsongname.Text = "";
        }

        private void pic_nextsong_Click(object sender, EventArgs e)
        {
            if (current_playlist.playlist != null)
            {
                if (current_playlist.isShuffleRepeat == 0)
                {
                    if (current_playlist.current_song == current_playlist.amount - 1)
                        current_playlist.current_song = 0;
                    else
                        current_playlist.current_song += 1;
                }
                else if (current_playlist.isShuffleRepeat == 1)
                {
                    Random _random = new Random();
                    current_playlist.current_song = _random.Next(0, current_playlist.amount - 1);
                }
                current_playlist.play_song();
                setup_when_play_song();
            }
        }

        private void pic_lastsong_Click(object sender, EventArgs e)
        {
            if (current_playlist.current_song == 0)
                current_playlist.current_song = current_playlist.amount - 1;
            else
                current_playlist.current_song -= 1;
            current_playlist.play_song();
            setup_when_play_song();
        }

        private void pic_play_pause_Click(object sender, EventArgs e)
        {
            if (current_playlist.main_singer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                current_playlist.main_singer.controls.pause();
                pic_play_pause.Image = new Bitmap(path_icon_play);
            }
            else
            {
                current_playlist.main_singer.controls.play();
                if (current_playlist.isPlayin)
                    pic_play_pause.Image = new Bitmap(path_icon_pause);
            }
        }

        private void pic_shuffle_Click(object sender, EventArgs e)
        {
            if (current_playlist.isShuffleRepeat == 0)
            {
                current_playlist.isShuffleRepeat = 1;
                pic_shuffle.Image = new Bitmap(path_icon_shuffled);
            }
            else if (current_playlist.isShuffleRepeat == 1)
            {
                current_playlist.isShuffleRepeat = 0;
                pic_shuffle.Image = new Bitmap(path_icon_shuffle);
            }
            else if (current_playlist.isShuffleRepeat == 2)
            {
                current_playlist.isShuffleRepeat = 1;
                pic_shuffle.Image = new Bitmap(path_icon_shuffled);
                pic_repeat.Image = new Bitmap(path_icon_repeat);
            }
        }

        private void pic_repeat_Click(object sender, EventArgs e)
        {
            if (current_playlist.isShuffleRepeat == 0)
            {
                current_playlist.isShuffleRepeat = 2;
                pic_repeat.Image = new Bitmap(path_icon_repeated);
            }
            else if (current_playlist.isShuffleRepeat == 1)
            {
                current_playlist.isShuffleRepeat = 2;
                pic_repeat.Image = new Bitmap(path_icon_repeated);
                pic_shuffle.Image = new Bitmap(path_icon_shuffle);
            }
            else if (current_playlist.isShuffleRepeat == 2)
            {
                current_playlist.isShuffleRepeat = 0;
                pic_repeat.Image = new Bitmap(path_icon_repeat);
            }
        }

        private void btn_listsong_Click(object sender, EventArgs e)
        {
            this.timer_show_listsong.Start();
        }
    }
}
