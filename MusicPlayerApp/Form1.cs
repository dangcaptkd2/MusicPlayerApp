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
using System.Drawing;


namespace MusicPlayerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private int numberImagead = 1;
        private int MaxnumberImagead = 4;
        private PictureBox pic_ad;

        public bool hidden_showlistsong;
        public int height_panel_showlistsong;

        private playSomething cat;

        private PlayList current_playlist;

        private int TimeToSleep;  // minute
  
        //public string path_playlist_ad = @"E:\coding\c#\MusicPlayerApp\music\music_ads\";
        public string path_playlist_ad = "music\\music_ads\\";

        /// ////////////////////
        //private static string path_nhactre = "E:\\coding\\c#\\MusicPlayerApp\\music\\VietNam\\Nhạc trẻ\\";
        private static string path_nhactre = "music\\VietNam\\Nhạc trẻ\\";
        // nhac tre
        private string path_nhactre_nhoAcoustic = path_nhactre + "Nhớ Acoustic_V.A";
        private string path_nhactre_thuquadongsang = path_nhactre + "Thu Qua Đông Sang (E.P)_Bằng Cường";
        private string path_nhactre_VpopGirl = path_nhactre + "V-Pop Girl Power _ V.A";
        /// ///////////////////
        //private static string path_nhactrinh = "E:\\coding\\c#\\MusicPlayerApp\\music\\VietNam\\Nhạc Trịnh\\";
        private static string path_nhactrinh = "music\\VietNam\\Nhạc Trịnh\\";
        // nhac trinh
        private string path_nhactrinh_tuoinaochoem = path_nhactrinh + "Còn Tuổi Nào Cho Em - Nhạc Trịnh Tuyển Chọn _ V.A";
        private string path_nhactrinh_nhactrinhhaynhat = path_nhactrinh + "Nhạc Trịnh Hay Nhất _ V.A";
        private string path_nhactrinh_thientucat = path_nhactrinh + "Thiên Từ Ca _ Bằng Cường, Thu Đặng";
        /// ///////////////////
       // private static string path_trutinh = "E:\\coding\\c#\\MusicPlayerApp\\music\\VietNam\\Trữ tình\\";
        private static string path_trutinh = "music\\VietNam\\Trữ tình\\";
        // tru tinh
        private string path_trutinh_lkBolero = path_trutinh + "Liên Khúc Trữ Tình Bolero Hay Nhất _ V.A";
        private string path_trutinh_nhactrutinhhaynhatveme = path_trutinh + "Nhạc Trữ Tình Hay Nhất Về Mẹ _ V.A";
        private string path_trutinh_tutinhquehuong = path_trutinh + "Tự Tình Quê Hương _ Nguyễn Hân";
        private string path_trutinh_tuyentapnhungbaihattrutinhhaynhat = path_trutinh + "Tuyển Tập Những Bài Hát Trữ Tình Hay (Vol. 1) _ V.A";

        private void pic_close_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
        private void pic_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void txt_searchbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_searchbar.Text == "Nhập tên bài hát")
                txt_searchbar.Text = "";
        }
        void load_img_ad()
        {
            this.TimeToSleep = 0;
            numberImagead++;
            if (numberImagead > MaxnumberImagead)
                numberImagead = 1;
            pic_ad.ImageLocation = string.Format(@"iconNimage\ad_song\{0}.jpg", numberImagead);
        }
        private void timer_ad_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("do2");
            load_img_ad();
        }
        private void pic_ad_Click(object sender, EventArgs e)
        {
            this.cat.check_isplayin();
            this.current_playlist = new PlayList(path_playlist_ad, numberImagead - 1);
            //this.current_playlist.play_song();
            //setup_when_play_song();
            cat.current_playlist = this.current_playlist;
            cat.play();
            //setup_showlistsong();

            //setText_for_btn_listsong(this.current_playlist.amount);
            //this.singleBar1.ProfilePath_playlist = path_playlist_ad;
            //this.singleBar1.ProfileIndex_playlist = numberImagead - 1;
            //this.singleBar1.playsong();
        }
        private Panel createPanel(Point point, Size size)
        {
            Panel a = new Panel();
            a.Location = point;
            a.Size = size;
            return a;
        }
        private void set_homepage()
        {

            this.pic_ad = new PictureBox();
            this.pic_ad.Location = new Point(36, 15);
            this.pic_ad.Size = new Size(824, 343);
            this.pic_ad.ImageLocation = "iconNimage\\ad_song\\1.jpg";
            this.pic_ad.Click += pic_ad_Click;
            this.panel_biggest.Controls.Add(pic_ad);
            //MessageBox.Show("do");
            timer_ad.Start();

            /// start co the ban se thich   ////// PART I
            List<string> playlist_maybeUlikethis = new List<string>()
            {
                path_nhactre_nhoAcoustic,
                path_nhactre_thuquadongsang,
                path_nhactre_VpopGirl,
                path_nhactrinh_nhactrinhhaynhat,
                path_nhactrinh_thientucat,
                path_nhactrinh_tuoinaochoem,
                path_trutinh_lkBolero,
                path_trutinh_nhactrutinhhaynhatveme,
                path_trutinh_tutinhquehuong,
                path_trutinh_tuyentapnhungbaihattrutinhhaynhat
            };
            Point point = new System.Drawing.Point(36, 375);    // POINT
            Size size = new Size(824, 270);
            Panel maybeUlikethis = createPanel(point, size);
            FormBoxCate boxCate = new FormBoxCate(playlist_maybeUlikethis, "Có thể bạn sẽ thích", this.cat);

            boxCate.TopLevel = false;
            maybeUlikethis.Controls.Add(boxCate);
            boxCate.Show();
            this.panel_biggest.Controls.Add(maybeUlikethis);
            /// end co the ban se thich

            /// start hom nay nghe gi         ////// PART II
            List<string> playlist_homnaynghegi = new List<string>()
            {
                path_nhactrinh_tuoinaochoem,
                path_trutinh_lkBolero,
                path_trutinh_nhactrutinhhaynhatveme,
                path_trutinh_tutinhquehuong,
                path_trutinh_tuyentapnhungbaihattrutinhhaynhat,
                path_nhactre_nhoAcoustic,
                path_nhactre_thuquadongsang,
                path_nhactre_VpopGirl,
                path_nhactrinh_nhactrinhhaynhat,
                path_nhactrinh_thientucat

            };
            Point point1 = new Point(36, 375 + 270 + 15);    // POINT
            Panel homnaynghegi = createPanel(point1, size);
            FormBoxCate boxCate1 = new FormBoxCate(playlist_homnaynghegi, "Hôm nay nghe gì?", this.cat);

            boxCate1.TopLevel = false;
            homnaynghegi.Controls.Add(boxCate1);
            boxCate1.Show();
            this.panel_biggest.Controls.Add(homnaynghegi);
            /// end hom nay nghe gi

            /// start di qua mua nang        ///// PART 3
            List<string> playlist_diquamuanang = new List<string>()
            {
                path_trutinh_tuyentapnhungbaihattrutinhhaynhat,
                path_nhactre_nhoAcoustic,
                path_nhactre_thuquadongsang,
                path_trutinh_lkBolero,
                path_nhactre_VpopGirl,
                path_nhactrinh_nhactrinhhaynhat,
                path_nhactrinh_tuoinaochoem,
                path_trutinh_nhactrutinhhaynhatveme,
                path_trutinh_tutinhquehuong,
                path_nhactrinh_thientucat

            };
            Point point2 = new Point(36, 375 + 270 * 2 + 15*2);     //POINT
            Panel diquamuanang = createPanel(point2, size);
            FormBoxCate boxCate2 = new FormBoxCate(playlist_diquamuanang, "Đi qua mùa nắng", this.cat);

            boxCate2.TopLevel = false;
            diquamuanang.Controls.Add(boxCate2);
            boxCate2.Show();
            this.panel_biggest.Controls.Add(diquamuanang);
            /// end di qua mua nang


            /// COPYRIGHT
            Label ThinhQuyen = new Label();
            ThinhQuyen.Location = new Point(320, 375 + 270 * 3 + 15 * 3);
            ThinhQuyen.Font = new Font("Arial", 9);
            ThinhQuyen.Size = new Size(300, 30);
            ThinhQuyen.ForeColor = Color.Teal;
            ThinhQuyen.Text = "Created by ThinhQuyen and XuanThang";

            this.panel_biggest.Controls.Add(ThinhQuyen);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.lbl_show_artistNsongname.Text = "";

            this.cat = new playSomething(this.pic_nextsong, this.pic_lastsong, this.pic_play_pause,
                        this.btn_listsong, this.lbl_show_artistNsongname, this.pic_shuffle, this.pic_repeat, this.panel_showplaylist);

            this.hidden_showlistsong = true;
            this.height_panel_showlistsong = this.panel_showplaylist.Height;
            this.panel_showplaylist.Height = 0;

            set_homepage();
        }
        private void timer_show_listsong_Tick(object sender, EventArgs e)
        {
            if (this.hidden_showlistsong)
            {
                this.panel_showplaylist.Height += 15;
                if (this.panel_showplaylist.Height >= this.height_panel_showlistsong)
                {
                    this.timer_show_listsong.Stop();
                    this.hidden_showlistsong = false;
                    this.Refresh();
                }
            }
            else
            {
                this.panel_showplaylist.Height -= 15;
                if (this.panel_showplaylist.Height <= 0)
                {
                    this.timer_show_listsong.Stop();
                    this.hidden_showlistsong = true;
                    this.Refresh();
                }
            }
        }
        private void btn_listsong_Click(object sender, EventArgs e)
        {
            timer_show_listsong.Start();
        }
        private void pic_search_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hello");
            if(this.txt_searchbar.Text!="" && this.txt_searchbar.Text != "Nhập tên bài hát")
            {
                this.panel_biggest.Controls.Clear();
                FormSearchSong formsearch = new FormSearchSong(this.txt_searchbar.Text, this.cat);
                formsearch.TopLevel = false;
                this.panel_biggest.Controls.Add(formsearch);
                formsearch.Show();
            }
        }
        private void lbl_trangchu_Click(object sender, EventArgs e)
        {
            this.panel_biggest.Controls.Clear();
            set_homepage();
        }
        private void pic_MyTimer_Click(object sender, EventArgs e)
        {
            MyTimer mytimer = new MyTimer();
            mytimer.ShowDialog();
            this.TimeToSleep = mytimer.theValue;

            //MessageBox.Show(this.TimeToSleep.ToString());
            if (this.TimeToSleep != 0)
            {
                Timer time2sleep = new Timer { Interval = this.TimeToSleep * 60000 };
                time2sleep.Enabled = true;
                time2sleep.Tick += Time2sleep_Tick;

                this.pic_MyTimer.BackColor = Color.WhiteSmoke;
            }

        }

        private void Time2sleep_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.cat.stopMusic();
            this.TimeToSleep = 0;
            this.pic_MyTimer.BackColor = Color.Teal;

        }

        private void lbl_playlist_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.Show();
        }
    }
}
