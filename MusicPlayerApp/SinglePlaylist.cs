using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace MusicPlayerApp
{
    class SinglePlaylist
    {
        private playSomething cat3;

        public PictureBox pic_album;
        public Label lbl_name;
        public Label lbl_author;
        public Panel panel;
        public string path_playlist;
        public PlayList playlist;
        public Bitmap CoverPage;


        public Size pic_size = new Size(152, 152);
        public int y_lbl_name = 160;
        public int y_lbl_author = 170;
        public int fontsize_name_label = 10;
        public int fontsize_author_label = 8;


        public bool istwoline = false;

        public string path_none_image = "music\\NoneCoverPage.jpg";
        public SinglePlaylist()
        {
            this.pic_album = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.path_playlist = null;
            this.playlist = new PlayList();
            this.CoverPage = null;
            this.panel = new System.Windows.Forms.Panel();
        }
        public string process_big_name(string name)
        {
            string[] sub2 = name.Split(' ');
            string temp = "";
            for (int i = 0; i < sub2.Length; i++)
            {
                string t = temp + sub2[i] + ' ';
                if (t.Length-1 < 18)
                    temp = temp + sub2[i] + ' ';
                else
                {
                    string temp2 = "";
                    for (int j = i; j < sub2.Length; j++)
                    {
                        temp2 = temp2 + sub2[j] + ' ';
                    }
                    temp = temp + '\n' + temp2;
                    break;
                }
            }
            return temp;
        }
        public void setup_nameNauthor(System.Drawing.Point point)
        {
            string[] sub = this.path_playlist.Split('\\');
            string[] nameNauthor = sub[sub.Length - 1].Split('_');
            string name = nameNauthor[0];
            string author = nameNauthor[1];
            if (name.Length > 20)
            {
                name = process_big_name(name);
                this.istwoline = true;
            }

            lbl_name.AutoSize = true;
            lbl_name.Text = name;
            lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", fontsize_name_label);
            lbl_name.Location = new System.Drawing.Point(0, y_lbl_name);
                            
            lbl_author.Text = author;
            lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", fontsize_author_label);
            if(this.istwoline)
                this.y_lbl_author = this.y_lbl_name + this.lbl_name.Height+15;
            else
                this.y_lbl_author = this.y_lbl_name + this.lbl_name.Height;
            lbl_author.Location = new System.Drawing.Point(0, y_lbl_author);
      
        }
        public SinglePlaylist(string path_playlist, Point point, playSomething dog2)
        {
            this.cat3 = dog2;

            this.pic_album = new PictureBox();
            this.pic_album.Image = new Bitmap(path_none_image);
            this.lbl_name = new Label();
            this.lbl_author = new Label();
            this.panel = new Panel();
            this.playlist = new PlayList();

            this.panel.Location = point;
            this.panel.Size = new Size(152, 220);
            this.panel.BackColor = Color.WhiteSmoke;

            this.pic_album.Size = pic_size;
            this.pic_album.Location = new Point(0, 0);
            this.pic_album.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_album.Click += Pic_album_Click;

            this.path_playlist = path_playlist;
            
            DirectoryInfo dirInfo = new DirectoryInfo(this.path_playlist);
            FileInfo[] childFiles = dirInfo.GetFiles();
            foreach (FileInfo childFile in childFiles)
            {
                string path = childFile.FullName;
                if (path.EndsWith(".mp3"))
                {
                    Song a = new Song(childFile.FullName);
                    this.playlist.playlist.Add(a);
                }
                if (path.EndsWith("CoverPage.jpg"))
                {
                    //MessageBox.Show(path);
                    this.CoverPage = new Bitmap(path);
                    this.pic_album.Image = this.CoverPage;
                }
            }
            this.playlist = new PlayList(this.path_playlist);
            setup_nameNauthor(point);
            this.panel.Controls.Add(this.pic_album);
            this.panel.Controls.Add(this.lbl_name);
            this.panel.Controls.Add(this.lbl_author);
           // System.Windows.Forms.MessageBox.Show(this.lbl_name.Text);
        }
        private void Pic_album_Click(object sender, EventArgs e)
        {
            this.cat3.check_isplayin();
            this.cat3.current_playlist = this.playlist;
            this.cat3.play();
            
        }
    }
}
