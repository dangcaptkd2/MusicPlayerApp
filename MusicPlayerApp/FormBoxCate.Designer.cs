namespace MusicPlayerApp
{
    partial class FormBoxCate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoxCate));
            this.lbl_title = new System.Windows.Forms.Label();
            this.pic_next = new System.Windows.Forms.PictureBox();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.panel_BoxCate = new System.Windows.Forms.Panel();
            this.timer_slide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(96, 24);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "This is title";
            // 
            // pic_next
            // 
            this.pic_next.Image = ((System.Drawing.Image)(resources.GetObject("pic_next.Image")));
            this.pic_next.Location = new System.Drawing.Point(779, 0);
            this.pic_next.Name = "pic_next";
            this.pic_next.Size = new System.Drawing.Size(24, 24);
            this.pic_next.TabIndex = 2;
            this.pic_next.TabStop = false;
            this.pic_next.Click += new System.EventHandler(this.pic_next_Click);
            // 
            // pic_back
            // 
            this.pic_back.Image = ((System.Drawing.Image)(resources.GetObject("pic_back.Image")));
            this.pic_back.Location = new System.Drawing.Point(749, 0);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(24, 24);
            this.pic_back.TabIndex = 2;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // panel_BoxCate
            // 
            this.panel_BoxCate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_BoxCate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_BoxCate.Location = new System.Drawing.Point(0, 30);
            this.panel_BoxCate.Name = "panel_BoxCate";
            this.panel_BoxCate.Size = new System.Drawing.Size(824, 240);
            this.panel_BoxCate.TabIndex = 3;
            // 
            // timer_slide
            // 
            this.timer_slide.Interval = 30;
            this.timer_slide.Tick += new System.EventHandler(this.timer_slide_Tick);
            // 
            // FormBoxCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(824, 270);
            this.Controls.Add(this.panel_BoxCate);
            this.Controls.Add(this.pic_back);
            this.Controls.Add(this.pic_next);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBoxCate";
            this.Text = "FormBoxCate";
            this.Load += new System.EventHandler(this.FormBoxCate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pic_next;
        private System.Windows.Forms.PictureBox pic_back;
        private System.Windows.Forms.Panel panel_BoxCate;
        private System.Windows.Forms.Timer timer_slide;
    }
}