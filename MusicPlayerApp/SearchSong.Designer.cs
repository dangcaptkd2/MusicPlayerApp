namespace MusicPlayerApp
{
    partial class FormSearchSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchSong));
            this.lbl_kqtimkiem = new System.Windows.Forms.Label();
            this.lbl_baihat = new System.Windows.Forms.Label();
            this.lbl_lienquan = new System.Windows.Forms.Label();
            this.uc_lq3 = new MusicPlayerApp.UserControl2();
            this.uc_lq2 = new MusicPlayerApp.UserControl2();
            this.uc_lq1 = new MusicPlayerApp.UserControl2();
            this.uc_result_search = new MusicPlayerApp.UserControl2();
            this.SuspendLayout();
            // 
            // lbl_kqtimkiem
            // 
            this.lbl_kqtimkiem.AutoSize = true;
            this.lbl_kqtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kqtimkiem.Location = new System.Drawing.Point(12, 9);
            this.lbl_kqtimkiem.Name = "lbl_kqtimkiem";
            this.lbl_kqtimkiem.Size = new System.Drawing.Size(293, 42);
            this.lbl_kqtimkiem.TabIndex = 0;
            this.lbl_kqtimkiem.Text = "Kết quả tìm kiếm";
            // 
            // lbl_baihat
            // 
            this.lbl_baihat.AutoSize = true;
            this.lbl_baihat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baihat.Location = new System.Drawing.Point(14, 81);
            this.lbl_baihat.Name = "lbl_baihat";
            this.lbl_baihat.Size = new System.Drawing.Size(79, 25);
            this.lbl_baihat.TabIndex = 2;
            this.lbl_baihat.Text = "Bài hát";
            // 
            // lbl_lienquan
            // 
            this.lbl_lienquan.AutoSize = true;
            this.lbl_lienquan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lienquan.Location = new System.Drawing.Point(14, 176);
            this.lbl_lienquan.Name = "lbl_lienquan";
            this.lbl_lienquan.Size = new System.Drawing.Size(240, 25);
            this.lbl_lienquan.TabIndex = 2;
            this.lbl_lienquan.Text = "Những bài hát liên quan";
            // 
            // uc_lq3
            // 
            this.uc_lq3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uc_lq3.Location = new System.Drawing.Point(12, 316);
            this.uc_lq3.Name = "uc_lq3";
            this.uc_lq3.Profile_artist = "artist";
            this.uc_lq3.Profile_author = "author";
            this.uc_lq3.Profile_avatar = ((System.Drawing.Image)(resources.GetObject("uc_lq3.Profile_avatar")));
            this.uc_lq3.Profile_index = 0;
            this.uc_lq3.Size = new System.Drawing.Size(785, 50);
            this.uc_lq3.TabIndex = 1;
            // 
            // uc_lq2
            // 
            this.uc_lq2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uc_lq2.Location = new System.Drawing.Point(12, 260);
            this.uc_lq2.Name = "uc_lq2";
            this.uc_lq2.Profile_artist = "artist";
            this.uc_lq2.Profile_author = "author";
            this.uc_lq2.Profile_avatar = ((System.Drawing.Image)(resources.GetObject("uc_lq2.Profile_avatar")));
            this.uc_lq2.Profile_index = 0;
            this.uc_lq2.Size = new System.Drawing.Size(785, 50);
            this.uc_lq2.TabIndex = 1;
            // 
            // uc_lq1
            // 
            this.uc_lq1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uc_lq1.Location = new System.Drawing.Point(12, 204);
            this.uc_lq1.Name = "uc_lq1";
            this.uc_lq1.Profile_artist = "artist";
            this.uc_lq1.Profile_author = "author";
            this.uc_lq1.Profile_avatar = ((System.Drawing.Image)(resources.GetObject("uc_lq1.Profile_avatar")));
            this.uc_lq1.Profile_index = 0;
            this.uc_lq1.Size = new System.Drawing.Size(785, 50);
            this.uc_lq1.TabIndex = 1;
            // 
            // uc_result_search
            // 
            this.uc_result_search.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uc_result_search.Location = new System.Drawing.Point(19, 109);
            this.uc_result_search.Name = "uc_result_search";
            this.uc_result_search.Profile_artist = "artist";
            this.uc_result_search.Profile_author = "author";
            this.uc_result_search.Profile_avatar = ((System.Drawing.Image)(resources.GetObject("uc_result_search.Profile_avatar")));
            this.uc_result_search.Profile_index = 0;
            this.uc_result_search.Size = new System.Drawing.Size(785, 50);
            this.uc_result_search.TabIndex = 1;
            // 
            // FormSearchSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 439);
            this.Controls.Add(this.lbl_lienquan);
            this.Controls.Add(this.lbl_baihat);
            this.Controls.Add(this.uc_lq3);
            this.Controls.Add(this.uc_lq2);
            this.Controls.Add(this.uc_lq1);
            this.Controls.Add(this.uc_result_search);
            this.Controls.Add(this.lbl_kqtimkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSearchSong";
            this.Text = "SearchSong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kqtimkiem;
        private UserControl2 uc_result_search;
        private System.Windows.Forms.Label lbl_baihat;
        private System.Windows.Forms.Label lbl_lienquan;
        private UserControl2 uc_lq1;
        private UserControl2 uc_lq2;
        private UserControl2 uc_lq3;
    }
}