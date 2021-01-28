using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class FormBoxCate : Form
    {
        public FormBoxCate()
        {
            InitializeComponent();
        }
        private List<SinglePlaylist> bar;
        private int panel_width;
        private bool isNext;
        private int temp;
        private int maximum_slide;
        private MusicPlayerApp.UserControls.SingleBar new_singlebar;

        private playSomething cat2;
        
        
        public FormBoxCate(List<string> paths, string title, playSomething dog)
        {
            InitializeComponent();

            this.cat2 = dog;

            this.isNext = true;
            this.temp = 0;
            this.lbl_title.Text = title;
            this.bar = new List<SinglePlaylist>();
            this.panel_width = 0;
            this.maximum_slide = 800;
            //this.new_singlebar = singlebar;
           
            ///    read path
       
            for (int i = 0; i < paths.Count; i++)
            {
                Point point = new Point(this.panel_width, 0);
                bar.Add(new SinglePlaylist(paths[i], point, this.cat2));
                this.panel_BoxCate.Controls.Add(this.bar[i].panel);

                this.panel_width += 182;

              
                
              
            }
            /// custom scrollbar
            this.panel_BoxCate.AutoScroll = false;
            this.panel_BoxCate.VerticalScroll.Enabled = false;
            this.panel_BoxCate.VerticalScroll.Visible = false;
            this.panel_BoxCate.VerticalScroll.Maximum = 0;
            this.panel_BoxCate.HorizontalScroll.Enabled = false;
            this.panel_BoxCate.HorizontalScroll.Visible = false;
            this.panel_BoxCate.HorizontalScroll.Maximum = this.panel_width;
            this.panel_BoxCate.AutoScroll = true;
            this.panel_BoxCate.SetAutoScrollMargin(1, 1);

        }

        private void FormBoxCate_Load(object sender, EventArgs e)
        {
            
        }

        private void pic_next_Click(object sender, EventArgs e)
        {
            this.temp = 0;
            this.isNext = true;
            this.timer_slide.Start();
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            this.temp = 0;
            this.isNext = false;
            this.timer_slide.Start();
        }

        private void timer_slide_Tick(object sender, EventArgs e)
        {
            if (isNext)
            {
                if (temp < this.maximum_slide || this.panel_BoxCate.HorizontalScroll.Value<this.Width-750)
                {
                    panel_BoxCate.HorizontalScroll.Value += 50;
                    temp += 50;
                }
                else
                {
                    timer_slide.Stop();
                    this.Refresh();
                }
            }
            else
            {
                if (this.panel_BoxCate.HorizontalScroll.Value >= 50)
                {
                    this.panel_BoxCate.HorizontalScroll.Value -= 50;
                    temp += 50;
                }
                if (temp >= this.maximum_slide || this.panel_BoxCate.HorizontalScroll.Value < 50)
                {
                    timer_slide.Stop();
                    this.Refresh();
                }
            }
        }
    }
}
