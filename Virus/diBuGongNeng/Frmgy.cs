using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Virus.diBuGongNeng
{
    public partial class Frmgy : Form
    {
        public Frmgy()
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



        //**********拖动窗口**********
        #region 拖动窗口
        private Point mouseOffset;
        private bool isMouseDown = false;
        private void Frmgy_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        private void Frmgy_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }
        private void Frmgy_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        #endregion

        //**********程序退出**********
        #region 程序退出
        private void button1Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picExit_MouseMove(object sender, MouseEventArgs e)
        {
            picExit.Image = global::Virus.Properties.Resources.exit2;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = global::Virus.Properties.Resources.exit;
        }



        #endregion

        //**********窗口启动**********
        private void Frmgy_Load(object sender, EventArgs e)
        {
            #region 读取历史换肤记录
            try
            {
                FileStream fr2 = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\bg.txt", FileMode.Open);
                StreamReader sr2 = new StreamReader(fr2, Encoding.Default);
                string huanfu = sr2.ReadToEnd();
                sr2.Close();
                fr2.Close();
                if (huanfu == "bg1")
                {
                    BackgroundImage = global::Virus.Properties.Resources.bg1;
                }
                else if (huanfu == "bg2")
                {
                    BackgroundImage = global::Virus.Properties.Resources.bg2;
                }
                else if (huanfu == "bg3")
                {
                    BackgroundImage = global::Virus.Properties.Resources.bg3;
                }
                else if (huanfu == "bg4")
                {
                    BackgroundImage = global::Virus.Properties.Resources.bg4;
                }
                else if (huanfu == "bg5")
                {
                    BackgroundImage = global::Virus.Properties.Resources.bg5;
                }
                else if (huanfu == "bg6")
                {
                    BackgroundImage = global::Virus.Properties.Resources.bg6;
                }
                else if (huanfu == "bg7")
                {
                    BackgroundImage = global::Virus.Properties.Resources.bg7;
                }
                else
                {
                    BackgroundImage = Image.FromFile(huanfu);
                }
            }
            catch (Exception)
            {
                BackgroundImage = global::Virus.Properties.Resources.bg1;
            }
            #endregion


        }
    }
}
