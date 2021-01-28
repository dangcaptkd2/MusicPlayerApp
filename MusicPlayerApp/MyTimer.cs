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
    public partial class MyTimer : Form
    {
        public int theValue;
        private int getValue(string txt)
        {
            return Int32.Parse(txt.Split()[0]);
        }
        public MyTimer()
        {
            InitializeComponent();
            this.theValue = 0;
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_oke_Click(object sender, EventArgs e)
        {
            this.theValue = getValue(this.TimeValue.SelectedItem.ToString());
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.theValue = 0;
            this.Close();
        }
    }
}
