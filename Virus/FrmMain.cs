using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            this.SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            this.Opacity = 0;
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                this.Opacity += 0.2;
                if (i == 6)
                {
                    timer5.Stop();
                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        int tz = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tz++;
            if (tz>=3)
            {
                timer1.Enabled = false;
                this.Hide();
                FrmLogin f = new FrmLogin();
                f.Show();
            }
        }
    }

    
}
