namespace MusicPlayerApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_top = new System.Windows.Forms.Panel();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.txt_searchbar = new RoundTextBoxExample.CeLearningTextbox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_playlist = new System.Windows.Forms.Label();
            this.lbl_trangchu = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.panel_biggest = new System.Windows.Forms.Panel();
            this.timer_ad = new System.Windows.Forms.Timer(this.components);
            this.timer_show_listsong = new System.Windows.Forms.Timer(this.components);
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.pic_MyTimer = new System.Windows.Forms.PictureBox();
            this.btn_listsong = new System.Windows.Forms.Button();
            this.lbl_show_artistNsongname = new System.Windows.Forms.Label();
            this.pic_lastsong = new System.Windows.Forms.PictureBox();
            this.pic_repeat = new System.Windows.Forms.PictureBox();
            this.pic_shuffle = new System.Windows.Forms.PictureBox();
            this.pic_nextsong = new System.Windows.Forms.PictureBox();
            this.pic_play_pause = new System.Windows.Forms.PictureBox();
            this.panel_showplaylist = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MyTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lastsong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_repeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextsong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play_pause)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_top.Controls.Add(this.pic_search);
            this.panel_top.Controls.Add(this.txt_searchbar);
            this.panel_top.Controls.Add(this.pic_minimize);
            this.panel_top.Controls.Add(this.lbl_logo);
            this.panel_top.Controls.Add(this.lbl_playlist);
            this.panel_top.Controls.Add(this.lbl_trangchu);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(900, 112);
            this.panel_top.TabIndex = 0;
            // 
            // pic_search
            // 
            this.pic_search.BackColor = System.Drawing.Color.White;
            this.pic_search.Image = ((System.Drawing.Image)(resources.GetObject("pic_search.Image")));
            this.pic_search.Location = new System.Drawing.Point(572, 35);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(28, 28);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_search.TabIndex = 5;
            this.pic_search.TabStop = false;
            this.pic_search.Click += new System.EventHandler(this.pic_search_Click);
            // 
            // txt_searchbar
            // 
            this.txt_searchbar.BackColor = System.Drawing.Color.Transparent;
            this.txt_searchbar.BorderColor = System.Drawing.Color.Gray;
            this.txt_searchbar.BorderSize = 1;
            this.txt_searchbar.Br = System.Drawing.Color.White;
            this.txt_searchbar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_searchbar.ForeColor = System.Drawing.Color.Gray;
            this.txt_searchbar.Location = new System.Drawing.Point(196, 33);
            this.txt_searchbar.Name = "txt_searchbar";
            this.txt_searchbar.PasswordChar = '\0';
            this.txt_searchbar.Size = new System.Drawing.Size(415, 33);
            this.txt_searchbar.TabIndex = 1;
            this.txt_searchbar.Text = "Nhập tên bài hát";
            this.txt_searchbar.textboxRadius = 15;
            this.txt_searchbar.UseSystemPasswordChar = false;
            //this.txt_searchbar.Click += new System.EventHandler(this.txt_searchbar_Click);
            this.txt_searchbar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_searchbar_KeyPress);
            // 
            // pic_minimize
            // 
            this.pic_minimize.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pic_minimize.Image")));
            this.pic_minimize.Location = new System.Drawing.Point(839, 0);
            this.pic_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(30, 30);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_minimize.TabIndex = 0;
            this.pic_minimize.TabStop = false;
            this.pic_minimize.Click += new System.EventHandler(this.pic_minimize_Click);
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_logo.Location = new System.Drawing.Point(31, 37);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(143, 29);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "MusicPlayer";
            // 
            // lbl_playlist
            // 
            this.lbl_playlist.AutoSize = true;
            this.lbl_playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playlist.Location = new System.Drawing.Point(142, 82);
            this.lbl_playlist.Name = "lbl_playlist";
            this.lbl_playlist.Size = new System.Drawing.Size(71, 16);
            this.lbl_playlist.TabIndex = 3;
            this.lbl_playlist.Text = "KARAOKE";
            this.lbl_playlist.Click += new System.EventHandler(this.lbl_playlist_Click);
            // 
            // lbl_trangchu
            // 
            this.lbl_trangchu.AutoSize = true;
            this.lbl_trangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trangchu.Location = new System.Drawing.Point(33, 82);
            this.lbl_trangchu.Name = "lbl_trangchu";
            this.lbl_trangchu.Size = new System.Drawing.Size(88, 16);
            this.lbl_trangchu.TabIndex = 3;
            this.lbl_trangchu.Text = "TRANG CHỦ";
            this.lbl_trangchu.Click += new System.EventHandler(this.lbl_trangchu_Click);
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(870, 0);
            this.pic_close.Margin = new System.Windows.Forms.Padding(0);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(30, 30);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 0;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // panel_biggest
            // 
            this.panel_biggest.AutoScroll = true;
            this.panel_biggest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_biggest.Location = new System.Drawing.Point(0, 112);
            this.panel_biggest.Name = "panel_biggest";
            this.panel_biggest.Size = new System.Drawing.Size(900, 439);
            this.panel_biggest.TabIndex = 1;
            // 
            // timer_ad
            // 
            this.timer_ad.Enabled = true;
            this.timer_ad.Interval = 2500;
            this.timer_ad.Tick += new System.EventHandler(this.timer_ad_Tick);
            // 
            // timer_show_listsong
            // 
            this.timer_show_listsong.Interval = 2;
            this.timer_show_listsong.Tick += new System.EventHandler(this.timer_show_listsong_Tick);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.Teal;
            this.panel_bottom.Controls.Add(this.pic_MyTimer);
            this.panel_bottom.Controls.Add(this.btn_listsong);
            this.panel_bottom.Controls.Add(this.lbl_show_artistNsongname);
            this.panel_bottom.Controls.Add(this.pic_lastsong);
            this.panel_bottom.Controls.Add(this.pic_repeat);
            this.panel_bottom.Controls.Add(this.pic_shuffle);
            this.panel_bottom.Controls.Add(this.pic_nextsong);
            this.panel_bottom.Controls.Add(this.pic_play_pause);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 547);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(900, 53);
            this.panel_bottom.TabIndex = 2;
            // 
            // pic_MyTimer
            // 
            this.pic_MyTimer.BackColor = System.Drawing.Color.Teal;
            this.pic_MyTimer.Image = ((System.Drawing.Image)(resources.GetObject("pic_MyTimer.Image")));
            this.pic_MyTimer.Location = new System.Drawing.Point(33, 12);
            this.pic_MyTimer.Name = "pic_MyTimer";
            this.pic_MyTimer.Size = new System.Drawing.Size(35, 35);
            this.pic_MyTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MyTimer.TabIndex = 18;
            this.pic_MyTimer.TabStop = false;
            this.pic_MyTimer.Click += new System.EventHandler(this.pic_MyTimer_Click);
            // 
            // btn_listsong
            // 
            this.btn_listsong.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_listsong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_listsong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listsong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listsong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_listsong.Location = new System.Drawing.Point(672, 12);
            this.btn_listsong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_listsong.Name = "btn_listsong";
            this.btn_listsong.Size = new System.Drawing.Size(154, 33);
            this.btn_listsong.TabIndex = 17;
            this.btn_listsong.Text = "Danh sách phát(0)";
            this.btn_listsong.UseVisualStyleBackColor = false;
            this.btn_listsong.Click += new System.EventHandler(this.btn_listsong_Click);
            // 
            // lbl_show_artistNsongname
            // 
            this.lbl_show_artistNsongname.AutoSize = true;
            this.lbl_show_artistNsongname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show_artistNsongname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_show_artistNsongname.Location = new System.Drawing.Point(277, 7);
            this.lbl_show_artistNsongname.Name = "lbl_show_artistNsongname";
            this.lbl_show_artistNsongname.Size = new System.Drawing.Size(169, 16);
            this.lbl_show_artistNsongname.TabIndex = 16;
            this.lbl_show_artistNsongname.Text = "lbl_show_artistNsongname";
            // 
            // pic_lastsong
            // 
            this.pic_lastsong.Image = ((System.Drawing.Image)(resources.GetObject("pic_lastsong.Image")));
            this.pic_lastsong.Location = new System.Drawing.Point(74, 16);
            this.pic_lastsong.Name = "pic_lastsong";
            this.pic_lastsong.Size = new System.Drawing.Size(25, 25);
            this.pic_lastsong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_lastsong.TabIndex = 11;
            this.pic_lastsong.TabStop = false;
            // 
            // pic_repeat
            // 
            this.pic_repeat.Image = ((System.Drawing.Image)(resources.GetObject("pic_repeat.Image")));
            this.pic_repeat.Location = new System.Drawing.Point(230, 21);
            this.pic_repeat.Name = "pic_repeat";
            this.pic_repeat.Size = new System.Drawing.Size(20, 20);
            this.pic_repeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_repeat.TabIndex = 12;
            this.pic_repeat.TabStop = false;
            // 
            // pic_shuffle
            // 
            this.pic_shuffle.Image = ((System.Drawing.Image)(resources.GetObject("pic_shuffle.Image")));
            this.pic_shuffle.Location = new System.Drawing.Point(192, 21);
            this.pic_shuffle.Name = "pic_shuffle";
            this.pic_shuffle.Size = new System.Drawing.Size(20, 20);
            this.pic_shuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_shuffle.TabIndex = 13;
            this.pic_shuffle.TabStop = false;
            // 
            // pic_nextsong
            // 
            this.pic_nextsong.Image = ((System.Drawing.Image)(resources.GetObject("pic_nextsong.Image")));
            this.pic_nextsong.Location = new System.Drawing.Point(142, 16);
            this.pic_nextsong.Name = "pic_nextsong";
            this.pic_nextsong.Size = new System.Drawing.Size(25, 25);
            this.pic_nextsong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_nextsong.TabIndex = 14;
            this.pic_nextsong.TabStop = false;
            // 
            // pic_play_pause
            // 
            this.pic_play_pause.Image = ((System.Drawing.Image)(resources.GetObject("pic_play_pause.Image")));
            this.pic_play_pause.Location = new System.Drawing.Point(103, 12);
            this.pic_play_pause.Name = "pic_play_pause";
            this.pic_play_pause.Size = new System.Drawing.Size(35, 35);
            this.pic_play_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_play_pause.TabIndex = 15;
            this.pic_play_pause.TabStop = false;
            // 
            // panel_showplaylist
            // 
            this.panel_showplaylist.BackColor = System.Drawing.Color.Honeydew;
            this.panel_showplaylist.Location = new System.Drawing.Point(635, 112);
            this.panel_showplaylist.Name = "panel_showplaylist";
            this.panel_showplaylist.Size = new System.Drawing.Size(265, 429);
            this.panel_showplaylist.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel_showplaylist);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_biggest);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MyTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lastsong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_repeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextsong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play_pause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Panel panel_biggest;
        private System.Windows.Forms.Label lbl_logo;
        private RoundTextBoxExample.CeLearningTextbox txt_searchbar;
        private System.Windows.Forms.Label lbl_playlist;
        private System.Windows.Forms.Label lbl_trangchu;
        private System.Windows.Forms.Timer timer_ad;
        private System.Windows.Forms.Timer timer_show_listsong;
        private System.Windows.Forms.Panel panel_bottom;
        public System.Windows.Forms.Button btn_listsong;
        public System.Windows.Forms.Label lbl_show_artistNsongname;
        private System.Windows.Forms.PictureBox pic_lastsong;
        private System.Windows.Forms.PictureBox pic_repeat;
        private System.Windows.Forms.PictureBox pic_shuffle;
        private System.Windows.Forms.PictureBox pic_nextsong;
        private System.Windows.Forms.PictureBox pic_play_pause;
        private System.Windows.Forms.Panel panel_showplaylist;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.PictureBox pic_MyTimer;
    }
}

