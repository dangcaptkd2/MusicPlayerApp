using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayerApp
{
    public partial class FormSearchSong : Form
    {
        public FormSearchSong()
        {
            InitializeComponent();
            //search("hello");
        }
        private string path_ad = "music\\music_ads\\";
        private string path_vietnam = "music\\VietNam\\";
        public playSomething cat5;
        public PlayList playlist;
        private string get_name(string path_song)
        {
            //"E:\coding\c#\MusicPlayerApp\MusicPlayerApp\bin\Debug\music\music_ads\1_Hết thật rồi - T.R.I.mp3"
            string[] subs = path_song.Split('\\');
            string[] a = subs[subs.Length - 1].Substring(0, subs[subs.Length - 1].Length - 4).Split('_');
            string nameNartist = a[a.Length - 1];
            List<string> result = new List<string>();
            return nameNartist.Split('-')[0];
            
        }
        private string get_index(string path_song)
        {
            //"E:\coding\c#\MusicPlayerApp\MusicPlayerApp\bin\Debug\music\music_ads\1_Hết thật rồi - T.R.I.mp3"
            string[] subs = path_song.Split('\\');
            string[] a = subs[subs.Length - 1].Substring(0, subs[subs.Length - 1].Length - 4).Split('_');
            return a[0];
        }
        private List<string> search(string query)  // 0: path parent 1: path song 2: path image 3: index
        {
            bool isfind = false;
            List<string> result = new List<string>();
            string path_image = "music\\NoneCoverPage.jpg";
            string path_parent;
            string path_song;
            string index;
            DirectoryInfo dirInfo = new DirectoryInfo(this.path_ad);
            FileInfo[] childFiles = dirInfo.GetFiles();
            foreach (FileInfo childFile in childFiles)
            {
                string path = childFile.FullName;
                string name = get_name(path);
                if (name.ToLower().Trim() == query.ToLower().Trim())
                {
                    index = get_index(path);
                    path_parent = path_ad;
                    path_song = path;
                    isfind = true;
                    result.Add(path_parent);
                    result.Add(path_song);
                    result.Add(path_image);
                    result.Add(index);
                    return result;
                }
            }

            DirectoryInfo country = new DirectoryInfo(this.path_vietnam);
            DirectoryInfo[] countries = country.GetDirectories();
            foreach (DirectoryInfo childFolder in countries)
            {
               // MessageBox.Show(childFolder.FullName);
                DirectoryInfo category = new DirectoryInfo(childFolder.FullName);
                DirectoryInfo[] cate = category.GetDirectories();
                foreach(DirectoryInfo playlist in cate)
                {
                    //MessageBox.Show(playlist.FullName);
                    DirectoryInfo song = new DirectoryInfo(playlist.FullName);
                    path_parent = playlist.FullName;
                    FileInfo[] songs = song.GetFiles();

                    foreach (FileInfo a_song in songs)
                    {
                        // MessageBox.Show(a_song.FullName);
                        string path = a_song.FullName;
                        if (path.EndsWith("CoverPage.jpg"))
                            path_image = path;
                    }
                    foreach (FileInfo a_song in songs)
                    {
                        // MessageBox.Show(a_song.FullName);
                        string path = a_song.FullName;
                        string name = get_name(path);
                        if (name.ToLower().Trim() == query.ToLower().Trim())
                        {
                            index = get_index(path);
                            path_song = path;
                            isfind = true;
                            result.Add(path_parent);
                            result.Add(path_song);
                            result.Add(path_image);
                            result.Add(index);
                            return result;
                        }
                    }
                }


            }
            return null;
        }
        public FormSearchSong(string query, playSomething dog)
        {
            InitializeComponent();
            //MessageBox.Show(query);
            List<string> result = search(query);
            if (result == null)
            {
                this.uc_lq1.Visible = false;
                this.uc_lq2.Visible = false;
                this.uc_lq3.Visible = false;
                this.uc_result_search.Visible = false;
                this.lbl_lienquan.Visible = false;
                Panel x = new Panel();
                x.Location = new Point(19, 109);
                x.Size = new Size(860, 250);
                FindNoSong a = new FindNoSong();
                a.TopLevel = false;
                x.Controls.Add(a);
                a.Show();

                this.Controls.Add(x);
            }
            else
            {
                //MessageBox.Show(result[3]);
                Song a = new Song(result[1]);
                this.uc_result_search.Profile_artist = a.name;
                this.uc_result_search.Profile_author = a.artist;
                this.uc_result_search.Profile_avatar = new Bitmap(result[2]);
                this.playlist = new PlayList(result[0], Int32.Parse(result[3])-1);
                this.cat5 = dog;
                this.uc_result_search.Click += Uc_result_search_Click;
                
            }
            

        }

        private void Uc_result_search_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.cat5.check_isplayin();
            this.cat5.current_playlist = this.playlist;
            this.cat5.play();

        }
    }
}
