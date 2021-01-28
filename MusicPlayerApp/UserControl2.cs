using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        private int index;
        private playSomething cat4;
        public Image Profile_avatar
        {
            get { return this.pic_avatar.Image; }
            set { this.pic_avatar.Image = value; }
        }
        public string Profile_artist
        {
            get { return this.lbl_name.Text; }
            set { this.lbl_name.Text = value; }
        }
        public string Profile_author
        {
            get { return this.lbl_author.Text; }
            set { this.lbl_author.Text = value; }
        }
        public int Profile_index
        {
            get { return this.index; }
            set { this.index = value; }
        }
        public playSomething ProfileCat
        {
            get { return this.cat4; }
            set { this.cat4 = value; }
        }
        public UserControl2(int i)
        {
            InitializeComponent();
            this.index = i;
        }
        public UserControl2(int i, playSomething dog5)
        {
            InitializeComponent();
            this.index = i;
            this.cat4 = dog5;
        }

        private void pic_avatar_Click(object sender, EventArgs e)
        {
            cat4.check_isplayin();
            cat4.current_playlist.current_song = this.index;
            cat4.play();
        }
    }
}
