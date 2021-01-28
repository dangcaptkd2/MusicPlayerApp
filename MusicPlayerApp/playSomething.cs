using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MusicPlayerApp
{
    public class playSomething
    {
        public PlayList current_playlist;
        private PictureBox pic_next;
        private PictureBox pic_back;
        private PictureBox pic_play_pause;
        private Button btn_listsong;
        private Label lbl_artistNname;
        private PictureBox pic_shuffle;
        private PictureBox pic_repeat;
        private Panel panel_showlistsong;
        int is_plus_playstatechange = 0;
       /// MusicPlayerApp.MainForm hello;

        private string path_icon_play = @"iconNimage\play.png";
        private string path_icon_pause = @"iconNimage\pause2.png";
        private string path_icon_shuffle = @"iconNimage\shuffle.png";
        private string path_icon_shuffled = @"iconNimage\shuffled.png";
        private string path_icon_repeat = @"iconNimage\repeat.png";
        private string path_icon_repeated = @"iconNimage\repeated.png";
        public playSomething()
        {

            //this.hello = new MainForm();
            
            //this.current_playlist = new PlayList();
            //this.pic_back = null;
            //this.pic_next = null;
            //this.pic_play_pause = null;
            //this.btn_listsong = null;
            //this.lbl_artistNname = null;
            //this.pic_shuffle = null;
            //this.pic_repeat = null;

        }
        public void setText_for_btn_listsong(int amount)
        {
            this.btn_listsong.Text = string.Format("Danh sách phát({0})", amount);
        }
        public void setup_when_play_song()
        {
            string name = current_playlist.playlist[current_playlist.current_song].name;
            string artist = current_playlist.playlist[current_playlist.current_song].artist;
            pic_play_pause.Image = new Bitmap(path_icon_pause);
            this.lbl_artistNname.Text = string.Format("{0} - {1}", name, artist);
            if (is_plus_playstatechange == 0)
            {
                this.current_playlist.main_singer.PlayStateChange += Main_singer_PlayStateChange;
                is_plus_playstatechange = 1;
            }
        }
        public void setup_when_play_song_2()
        {
            string name = current_playlist.playlist[current_playlist.current_song].name;
            string artist = current_playlist.playlist[current_playlist.current_song].artist;
            pic_play_pause.Image = new Bitmap(path_icon_pause);
            this.lbl_artistNname.Text = string.Format("{0} - {1}", name, artist);
        }
        private void Main_singer_PlayStateChange(int NewState)
        {
            //throw new NotImplementedException();
            
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                if (this.current_playlist.isShuffleRepeat == 0)
                {
                    pic_play_pause.Image = new Bitmap(path_icon_play);
                    //this.lbl_artistNname.Text = "";
                    if (current_playlist.current_song == current_playlist.amount - 1)
                        current_playlist.current_song = 0;
                    else
                        current_playlist.current_song += 1;
                    this.current_playlist = new PlayList(this.current_playlist.path, this.current_playlist.current_song);
                    this.current_playlist.play_song();
                    setup_when_play_song();
                }
                else if (this.current_playlist.isShuffleRepeat == 1)
                {
                    //MessageBox.Show("end1");
                    pic_play_pause.Image = new Bitmap(path_icon_play);
                    Random _random = new Random();
                    this.current_playlist = new PlayList(this.current_playlist.path);
                    current_playlist.current_song = _random.Next(0, current_playlist.amount);
                    current_playlist.play_song();
                    setup_when_play_song();
                    //MessageBox.Show("hello" + " " + this.current_playlist.current_song.ToString());
                }
                else
                {
                    pic_play_pause.Image = new Bitmap(path_icon_play);
                    this.current_playlist = new PlayList(this.current_playlist.path, this.current_playlist.current_song);
                    this.current_playlist.play_song();
                    setup_when_play_song();
                    //MessageBox.Show("end2" + " " + this.current_playlist.current_song.ToString());
                    //this.current_playlist.play_song();
                    //MessageBox.Show("end3" + " " + this.current_playlist.current_song.ToString());
                    //setup_when_play_song_2();
                    //MessageBox.Show("end4" + " " + this.current_playlist.current_song.ToString());
                }
            }
            
        }

        public playSomething(PlayList playlist, PictureBox next, PictureBox back, PictureBox play_pause, Button listsong, Label lbl,
            PictureBox shuffle, PictureBox repeat)
        {
            this.current_playlist = playlist;
            this.pic_next = next;
            this.pic_back = back;
            this.pic_play_pause = play_pause;
            this.btn_listsong = listsong;
            this.lbl_artistNname = lbl;
            this.pic_shuffle = shuffle;
            this.pic_repeat = repeat;

            this.pic_next.Click += Pic_next_Click;
            this.pic_back.Click += Pic_back_Click;
            this.pic_play_pause.Click += Pic_play_pause_Click;
            this.pic_shuffle.Click += Pic_shuffle_Click;
            this.pic_repeat.Click += Pic_repeat_Click;        
        }
        public playSomething(PictureBox next, PictureBox back, PictureBox play_pause, Button listsong, Label lbl,
            PictureBox shuffle, PictureBox repeat)
        {
            this.current_playlist = null;
            this.pic_next = next;
            this.pic_back = back;
            this.pic_play_pause = play_pause;
            this.btn_listsong = listsong;
            this.lbl_artistNname = lbl;
            this.pic_shuffle = shuffle;
            this.pic_repeat = repeat;

            this.pic_next.Click += Pic_next_Click;
            this.pic_back.Click += Pic_back_Click;
            this.pic_play_pause.Click += Pic_play_pause_Click;
            this.pic_shuffle.Click += Pic_shuffle_Click;
            this.pic_repeat.Click += Pic_repeat_Click;
        }
        public playSomething(PictureBox next, PictureBox back, PictureBox play_pause, Button listsong, Label lbl,
            PictureBox shuffle, PictureBox repeat, Panel panel)
        {
            this.current_playlist = null;
            this.pic_next = next;
            this.pic_back = back;
            this.pic_play_pause = play_pause;
            this.btn_listsong = listsong;
            this.lbl_artistNname = lbl;
            this.pic_shuffle = shuffle;
            this.pic_repeat = repeat;
            this.panel_showlistsong = panel;

            this.pic_next.Click += Pic_next_Click;
            this.pic_back.Click += Pic_back_Click;
            this.pic_play_pause.Click += Pic_play_pause_Click;
            this.pic_shuffle.Click += Pic_shuffle_Click;
            this.pic_repeat.Click += Pic_repeat_Click;

            
        }
        private void Pic_repeat_Click(object sender, EventArgs e)
        {
            if (this.current_playlist != null)
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
        }

        private void Pic_shuffle_Click(object sender, EventArgs e)
        {
            if (this.current_playlist != null)
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
        }

        private void Pic_play_pause_Click(object sender, EventArgs e)
        {
            if (this.current_playlist != null)
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
        }
        private void Pic_back_Click(object sender, EventArgs e)
        {
            if (this.current_playlist != null)
            {
                if (current_playlist.current_song == 0)
                    current_playlist.current_song = current_playlist.amount - 1;
                else
                    current_playlist.current_song -= 1;
                current_playlist.play_song();
                setup_when_play_song();
            }
        }

        private void Pic_next_Click(object sender, EventArgs e)
        {
            if (this.current_playlist != null)
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
                    current_playlist.current_song = _random.Next(0, current_playlist.amount);
                }
                current_playlist.play_song();
                setup_when_play_song();
            }
        }
        public void check_isplayin()
        {
            if (this.current_playlist != null && this.current_playlist.main_singer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                this.current_playlist.main_singer.controls.stop();
                this.pic_play_pause.Image = new Bitmap(path_icon_play);
            }
        }
        private void setup_showlistsong()
        {
            this.panel_showlistsong.Controls.Clear();
            int x = 5;
            int y = 5;
            List<UserControl2> list_uc_listsong = new List<UserControl2>();
            for (int i = 0; i < this.current_playlist.playlist.Count; i++)
            {
                playSomething cat4 = this;
                UserControl2 uc_listsong = new UserControl2(i, cat4);
                //MessageBox.Show(i.ToString()+' '+this.current_playlist.playlist[i].name);
                uc_listsong.Profile_artist = this.current_playlist.playlist[i].name;
                uc_listsong.Profile_author = this.current_playlist.playlist[i].artist;
                uc_listsong.Profile_avatar = this.current_playlist.CoverPage;
                uc_listsong.Location = new Point(x, y);
                uc_listsong.Click += Uc_listsong_Click;
                list_uc_listsong.Add(uc_listsong);
                this.panel_showlistsong.Controls.Add(list_uc_listsong[i]);

                y += 50;
            }
        }
        public void play()
        {
            this.current_playlist.play_song();
            setText_for_btn_listsong(this.current_playlist.amount);
            setup_when_play_song();
            setup_showlistsong();
        }

        private void Uc_listsong_Click(object sender, EventArgs e)
        {
            UserControl2 uc = sender as UserControl2;
            check_isplayin();
            current_playlist.current_song = uc.Profile_index;
            play();
        }
        public void stopMusic()
        {
            this.current_playlist.main_singer.controls.pause();
            this.pic_play_pause.Image = new Bitmap(path_icon_play);
        }
    }
}
