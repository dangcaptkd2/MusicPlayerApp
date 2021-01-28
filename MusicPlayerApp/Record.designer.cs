namespace MusicPlayerApp
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_record = new System.Windows.Forms.PictureBox();
            this.cB_listsong = new System.Windows.Forms.ComboBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_trangchu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic_playrecord = new System.Windows.Forms.PictureBox();
            this.pic_saverecord = new System.Windows.Forms.PictureBox();
            this.pic_stoprecord = new System.Windows.Forms.PictureBox();
            this.lb_rec = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playrecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_saverecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_stoprecord)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pic_record);
            this.panel1.Controls.Add(this.cB_listsong);
            this.panel1.Controls.Add(this.pic_close);
            this.panel1.Controls.Add(this.pic_minimize);
            this.panel1.Controls.Add(this.lbl_logo);
            this.panel1.Controls.Add(this.lbl_trangchu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 112);
            this.panel1.TabIndex = 0;
            // 
            // pic_record
            // 
            this.pic_record.Image = ((System.Drawing.Image)(resources.GetObject("pic_record.Image")));
            this.pic_record.Location = new System.Drawing.Point(555, 68);
            this.pic_record.Name = "pic_record";
            this.pic_record.Size = new System.Drawing.Size(32, 32);
            this.pic_record.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_record.TabIndex = 16;
            this.pic_record.TabStop = false;
            this.pic_record.Click += new System.EventHandler(this.pic_record_Click);
            // 
            // cB_listsong
            // 
            this.cB_listsong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_listsong.FormattingEnabled = true;
            this.cB_listsong.Items.AddRange(new object[] {
            "Bước Qua Mùa Cô Đơn -Vũ",
            "Anh nhà Ở Đâu Thế -Amee",
            "Sóng Gió -Jack",
            "Nàng Thơ -Hoàng Dũng",
            "Hết Thương Cạn Nhớ-Đức Phúc",
            "Buồn Của Anh- Đạt_G",
            "Tháng Tư Là Lời Nói Dối Của Em -Hà Anh Tuấn"});
            this.cB_listsong.Location = new System.Drawing.Point(239, 72);
            this.cB_listsong.Name = "cB_listsong";
            this.cB_listsong.Size = new System.Drawing.Size(310, 28);
            this.cB_listsong.TabIndex = 13;
            this.cB_listsong.Text = "Danh sách bài hát ";
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(870, -1);
            this.pic_close.Margin = new System.Windows.Forms.Padding(0);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(30, 30);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 11;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_minimize
            // 
            this.pic_minimize.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pic_minimize.Image")));
            this.pic_minimize.Location = new System.Drawing.Point(840, -1);
            this.pic_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(30, 30);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_minimize.TabIndex = 12;
            this.pic_minimize.TabStop = false;
            this.pic_minimize.Click += new System.EventHandler(this.pic_minimize_Click);
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_logo.Location = new System.Drawing.Point(19, 15);
            this.lbl_logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(143, 29);
            this.lbl_logo.TabIndex = 5;
            this.lbl_logo.Text = "MusicPlayer";
            // 
            // lbl_trangchu
            // 
            this.lbl_trangchu.AutoSize = true;
            this.lbl_trangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trangchu.Location = new System.Drawing.Point(21, 81);
            this.lbl_trangchu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trangchu.Name = "lbl_trangchu";
            this.lbl_trangchu.Size = new System.Drawing.Size(88, 16);
            this.lbl_trangchu.TabIndex = 10;
            this.lbl_trangchu.Text = "TRANG CHỦ";
            this.lbl_trangchu.Click += new System.EventHandler(this.lbl_trangchu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 428);
            this.panel2.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(39, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(822, 384);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(39, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(822, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.pic_playrecord);
            this.panel3.Controls.Add(this.pic_saverecord);
            this.panel3.Controls.Add(this.pic_stoprecord);
            this.panel3.Controls.Add(this.lb_rec);
            this.panel3.Controls.Add(this.lb_time);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 537);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 63);
            this.panel3.TabIndex = 2;
            // 
            // pic_playrecord
            // 
            this.pic_playrecord.Image = ((System.Drawing.Image)(resources.GetObject("pic_playrecord.Image")));
            this.pic_playrecord.Location = new System.Drawing.Point(130, 13);
            this.pic_playrecord.Name = "pic_playrecord";
            this.pic_playrecord.Size = new System.Drawing.Size(32, 32);
            this.pic_playrecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_playrecord.TabIndex = 7;
            this.pic_playrecord.TabStop = false;
            this.pic_playrecord.Click += new System.EventHandler(this.pic_playrecord_Click);
            // 
            // pic_saverecord
            // 
            this.pic_saverecord.Image = ((System.Drawing.Image)(resources.GetObject("pic_saverecord.Image")));
            this.pic_saverecord.Location = new System.Drawing.Point(77, 13);
            this.pic_saverecord.Name = "pic_saverecord";
            this.pic_saverecord.Size = new System.Drawing.Size(32, 32);
            this.pic_saverecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_saverecord.TabIndex = 6;
            this.pic_saverecord.TabStop = false;
            this.pic_saverecord.Click += new System.EventHandler(this.pic_saverecord_Click);
            // 
            // pic_stoprecord
            // 
            this.pic_stoprecord.Image = ((System.Drawing.Image)(resources.GetObject("pic_stoprecord.Image")));
            this.pic_stoprecord.Location = new System.Drawing.Point(24, 12);
            this.pic_stoprecord.Name = "pic_stoprecord";
            this.pic_stoprecord.Size = new System.Drawing.Size(32, 32);
            this.pic_stoprecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_stoprecord.TabIndex = 5;
            this.pic_stoprecord.TabStop = false;
            this.pic_stoprecord.Click += new System.EventHandler(this.pic_stoprecord_Click);
            // 
            // lb_rec
            // 
            this.lb_rec.AutoSize = true;
            this.lb_rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rec.Location = new System.Drawing.Point(192, 12);
            this.lb_rec.Name = "lb_rec";
            this.lb_rec.Size = new System.Drawing.Size(54, 20);
            this.lb_rec.TabIndex = 2;
            this.lb_rec.Text = "record";
            // 
            // lb_time
            // 
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(261, 12);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(97, 31);
            this.lb_time.TabIndex = 1;
            this.lb_time.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Record_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playrecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_saverecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_stoprecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Label lbl_trangchu;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_rec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cB_listsong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pic_record;
        private System.Windows.Forms.PictureBox pic_stoprecord;
        private System.Windows.Forms.PictureBox pic_saverecord;
        private System.Windows.Forms.PictureBox pic_playrecord;
    }
}