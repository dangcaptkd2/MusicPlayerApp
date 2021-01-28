namespace MusicPlayerApp
{
    partial class UserControl2
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.pic_avatar = new System.Windows.Forms.PictureBox();
            this.lbl_author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(51, 5);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(40, 18);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "artist";
            // 
            // pic_avatar
            // 
            this.pic_avatar.Location = new System.Drawing.Point(5, 5);
            this.pic_avatar.Name = "pic_avatar";
            this.pic_avatar.Size = new System.Drawing.Size(40, 40);
            this.pic_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avatar.TabIndex = 0;
            this.pic_avatar.TabStop = false;
            this.pic_avatar.Click += new System.EventHandler(this.pic_avatar_Click);
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(51, 27);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(37, 13);
            this.lbl_author.TabIndex = 2;
            this.lbl_author.Text = "author";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pic_avatar);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(255, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_avatar;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_author;
    }
}
