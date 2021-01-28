namespace MusicPlayerApp.UserControls
{
    partial class SingleBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleBar));
            this.btn_listsong = new System.Windows.Forms.Button();
            this.lbl_show_artistNsongname = new System.Windows.Forms.Label();
            this.pic_lastsong = new System.Windows.Forms.PictureBox();
            this.pic_repeat = new System.Windows.Forms.PictureBox();
            this.pic_shuffle = new System.Windows.Forms.PictureBox();
            this.pic_nextsong = new System.Windows.Forms.PictureBox();
            this.pic_play_pause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lastsong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_repeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextsong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play_pause)).BeginInit();
            this.SuspendLayout();
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
            this.btn_listsong.TabIndex = 10;
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
            this.lbl_show_artistNsongname.TabIndex = 9;
            this.lbl_show_artistNsongname.Text = "lbl_show_artistNsongname";
            // 
            // pic_lastsong
            // 
            this.pic_lastsong.Image = ((System.Drawing.Image)(resources.GetObject("pic_lastsong.Image")));
            this.pic_lastsong.Location = new System.Drawing.Point(74, 16);
            this.pic_lastsong.Name = "pic_lastsong";
            this.pic_lastsong.Size = new System.Drawing.Size(25, 25);
            this.pic_lastsong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_lastsong.TabIndex = 4;
            this.pic_lastsong.TabStop = false;
            this.pic_lastsong.Click += new System.EventHandler(this.pic_lastsong_Click);
            // 
            // pic_repeat
            // 
            this.pic_repeat.Image = ((System.Drawing.Image)(resources.GetObject("pic_repeat.Image")));
            this.pic_repeat.Location = new System.Drawing.Point(230, 21);
            this.pic_repeat.Name = "pic_repeat";
            this.pic_repeat.Size = new System.Drawing.Size(20, 20);
            this.pic_repeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_repeat.TabIndex = 5;
            this.pic_repeat.TabStop = false;
            this.pic_repeat.Click += new System.EventHandler(this.pic_repeat_Click);
            // 
            // pic_shuffle
            // 
            this.pic_shuffle.Image = ((System.Drawing.Image)(resources.GetObject("pic_shuffle.Image")));
            this.pic_shuffle.Location = new System.Drawing.Point(192, 21);
            this.pic_shuffle.Name = "pic_shuffle";
            this.pic_shuffle.Size = new System.Drawing.Size(20, 20);
            this.pic_shuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_shuffle.TabIndex = 6;
            this.pic_shuffle.TabStop = false;
            this.pic_shuffle.Click += new System.EventHandler(this.pic_shuffle_Click);
            // 
            // pic_nextsong
            // 
            this.pic_nextsong.Image = ((System.Drawing.Image)(resources.GetObject("pic_nextsong.Image")));
            this.pic_nextsong.Location = new System.Drawing.Point(142, 16);
            this.pic_nextsong.Name = "pic_nextsong";
            this.pic_nextsong.Size = new System.Drawing.Size(25, 25);
            this.pic_nextsong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_nextsong.TabIndex = 7;
            this.pic_nextsong.TabStop = false;
            this.pic_nextsong.Click += new System.EventHandler(this.pic_nextsong_Click);
            // 
            // pic_play_pause
            // 
            this.pic_play_pause.Image = ((System.Drawing.Image)(resources.GetObject("pic_play_pause.Image")));
            this.pic_play_pause.Location = new System.Drawing.Point(103, 12);
            this.pic_play_pause.Name = "pic_play_pause";
            this.pic_play_pause.Size = new System.Drawing.Size(35, 35);
            this.pic_play_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_play_pause.TabIndex = 8;
            this.pic_play_pause.TabStop = false;
            this.pic_play_pause.Click += new System.EventHandler(this.pic_play_pause_Click);
            // 
            // SingleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btn_listsong);
            this.Controls.Add(this.lbl_show_artistNsongname);
            this.Controls.Add(this.pic_lastsong);
            this.Controls.Add(this.pic_repeat);
            this.Controls.Add(this.pic_shuffle);
            this.Controls.Add(this.pic_nextsong);
            this.Controls.Add(this.pic_play_pause);
            this.Name = "SingleBar";
            this.Size = new System.Drawing.Size(900, 55);
            this.Load += new System.EventHandler(this.SingleBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_lastsong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_repeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextsong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play_pause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_listsong;
        public System.Windows.Forms.Label lbl_show_artistNsongname;
        private System.Windows.Forms.PictureBox pic_lastsong;
        private System.Windows.Forms.PictureBox pic_repeat;
        private System.Windows.Forms.PictureBox pic_shuffle;
        private System.Windows.Forms.PictureBox pic_nextsong;
        private System.Windows.Forms.PictureBox pic_play_pause;
    }
}
