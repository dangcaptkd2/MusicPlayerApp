using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class Song
    {
        public string path;
        public string name;
        public string artist;
        public System.Windows.Forms.PictureBox avatar;
        public Song()
        {
            this.path = null;
            this.name = null;
            this.artist = null;
            this.avatar = null;
        }
        public Song(string path_playlist)
        {
            this.avatar = null;
            this.path = path_playlist;

            string[] subs = this.path.Split('\\');
            string[] a = subs[subs.Length - 1].Substring(0, subs[subs.Length - 1].Length - 4).Split('_');
            string nameNartist = a[a.Length - 1];
            this.artist = nameNartist.Split('-')[1];
            this.name = nameNartist.Split('-')[0];
        }
    }
}
