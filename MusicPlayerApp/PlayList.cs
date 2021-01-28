using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace MusicPlayerApp
{
    public class PlayList
    {
        public string path;
        public int amount;
        public List<Song> playlist;
        public int current_song;
        public WMPLib.WindowsMediaPlayer main_singer;
        public bool isPlayin;
        public int isShuffleRepeat; //    0: nothing 1: shuffle 2: repeat 
        public Image CoverPage;
        public string path_none_image = "music\\NoneCoverPage.jpg";
        public PlayList()
        {
            this.path = null;
            this.amount = 0;
            this.playlist = new List<Song>();
            this.current_song = 0;
            this.main_singer = new WMPLib.WindowsMediaPlayer();
            this.isPlayin = false;
            this.isShuffleRepeat = 0;
        }
        public PlayList(string path_playlist, int cur_song = 0)
        {
            this.main_singer = new WMPLib.WindowsMediaPlayer();
            this.playlist = new List<Song>();
            this.path = path_playlist;
            this.current_song = cur_song;
            this.isPlayin = false;
            this.isShuffleRepeat = 0;
            this.CoverPage = new Bitmap(this.path_none_image);
            //this.main_singer.PlayStateChange += Main_singer_PlayStateChange1;

            DirectoryInfo dirInfo = new DirectoryInfo(this.path);
            FileInfo[] childFiles = dirInfo.GetFiles();
            foreach (FileInfo childFile in childFiles)
            {
                string path_song = childFile.FullName;
                if (path_song.EndsWith(".mp3"))
                {
                    Song a = new Song(childFile.FullName);
                    this.playlist.Add(a);
                }
                if (path_song.EndsWith("CoverPage.jpg"))
                {
                    this.CoverPage = new Bitmap(path_song);
                }
            }
            this.playlist = this.playlist.OrderBy(o => o.path).ToList();
            this.amount = this.playlist.Count;
        }

        //private void Main_singer_PlayStateChange1(int NewState)
        //{
        //    if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
        //    {
        //        pic_play_pause.Image = new Bitmap(path_icon_play);
        //    }
        //}
        public void play_song()
        {
            Song a = this.playlist[current_song];
            this.main_singer.URL = a.path;
            this.isPlayin = true;
        }
    }
}
