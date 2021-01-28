namespace MusicPlayerApp
{
    partial class MyTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTimer));
            this.TimeValue = new System.Windows.Forms.ComboBox();
            this.btn_oke = new System.Windows.Forms.Button();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeValue
            // 
            this.TimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeValue.FormattingEnabled = true;
            this.TimeValue.Items.AddRange(new object[] {
            "0 Phút",
            "1 Phút",
            "2 Phút",
            "5 Phút",
            "10 Phút",
            "15 Phút",
            "30 Phút",
            "60 Phút"});
            this.TimeValue.Location = new System.Drawing.Point(107, 44);
            this.TimeValue.Name = "TimeValue";
            this.TimeValue.Size = new System.Drawing.Size(125, 32);
            this.TimeValue.TabIndex = 0;
            this.TimeValue.Text = "0 Phút";
            // 
            // btn_oke
            // 
            this.btn_oke.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_oke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oke.Location = new System.Drawing.Point(180, 95);
            this.btn_oke.Name = "btn_oke";
            this.btn_oke.Size = new System.Drawing.Size(87, 32);
            this.btn_oke.TabIndex = 1;
            this.btn_oke.Text = "Chọn";
            this.btn_oke.UseVisualStyleBackColor = false;
            this.btn_oke.Click += new System.EventHandler(this.btn_oke_Click);
            // 
            // pic_close
            // 
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(327, -1);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(25, 25);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 2;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Moccasin;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(69, 95);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(87, 32);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // MyTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 160);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_oke);
            this.Controls.Add(this.TimeValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyTimer";
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TimeValue;
        private System.Windows.Forms.Button btn_oke;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Button btn_cancel;
    }
}