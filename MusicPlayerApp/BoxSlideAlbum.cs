using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    class BoxSlideAlbum
    {
        public System.Windows.Forms.Panel panelBox;
        public List<SinglePlaylist> bar;

        public System.Drawing.Size panelSize = new System.Drawing.Size(824, 250);
    

        public string path_nextslide = @"E:\coding\c#\MusicPlayerApp\iconNimage\nextslide.png";
        public string path_backslide = @"E:\coding\c#\MusicPlayerApp\iconNimage\backslide.png";
        public string path_nextslided = @"E:\coding\c#\MusicPlayerApp\iconNimage\nextslided.png";
        public string path_backslided = @"E:\coding\c#\MusicPlayerApp\iconNimage\nextslided.png";
        public BoxSlideAlbum()
        {
            this.panelBox = new System.Windows.Forms.Panel();
            this.bar = new List<SinglePlaylist>();
        }
        public BoxSlideAlbum(List<string> paths, string title, System.Drawing.Point point)
        {
            this.panelBox = new System.Windows.Forms.Panel();
            //this.panelBox.BackColor = System.Drawing.Color.Red;
            this.panelBox.Location = point;
            this.panelBox.Size = this.panelSize;
            FormBoxCate boxCate = new FormBoxCate();
            boxCate.TopLevel = false;
            this.panelBox.Controls.Add(boxCate);
            boxCate.Show();
            //this.panelBox.AutoScroll = false;
            //this.panelBox.VerticalScroll.Enabled = false;
            //this.panelBox.VerticalScroll.Visible = false;
            //this.panelBox.VerticalScroll.Maximum = 0;
            //this.panelBox.AutoScroll = true;

        }
    }
}
