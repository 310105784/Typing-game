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

namespace Virus
{
    public partial class Frmzhu : Form
    {
        public Frmzhu()
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
        private void Frmzhu_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        private void Frmzhu_MouseDown(object sender, MouseEventArgs e)
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
        private void Frmzhu_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        #endregion

        //**********程序退出**********
        #region 程序退出
        private void Frmzhu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        //**********程序最小化**********
        #region 程序最小化
        private void picMin_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void picMin_MouseMove(object sender, MouseEventArgs e)
        {
            picMin.Image = global::Virus.Properties.Resources.Mi2;
        }

        private void picMin_MouseLeave(object sender, EventArgs e)
        {
            picMin.Image = global::Virus.Properties.Resources.Mi;
        }
        #endregion

        //**********窗体启动***********
        #region 窗体启动
        private void Frmzhu_Load(object sender, EventArgs e)
        {
            lblhuanying.Text = "欢迎您" + FrmLogin.name;
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
        #endregion

        //**********功能**********
        #region 功能

        //*****打字测试******
        private void picgongn1_Click(object sender, EventArgs e)
        {
            gongNeng.Frmdzcs f = new gongNeng.Frmdzcs();
            f.Show();  //跳转打字测试页面
            this.Hide();
        }

        private void picgongn1_MouseMove(object sender, MouseEventArgs e)
        {
            picgongn1.Image = global::Virus.Properties.Resources.gongneng2;
        }

        private void picgongn1_MouseLeave(object sender, EventArgs e)
        {
            picgongn1.Image = global::Virus.Properties.Resources.gongneng;
        }


        //*****随机点名******
        private void picgongn2_Click(object sender, EventArgs e)
        {
            gongNeng.Frmsjdm f = new gongNeng.Frmsjdm();
            f.Show();  //跳转随机点名页面
            this.Hide();
        }

        private void picgongn2_MouseMove(object sender, MouseEventArgs e)
        {
            picgongn2.Image = global::Virus.Properties.Resources.gongneng2;
        }

        private void picgongn2_MouseLeave(object sender, EventArgs e)
        {
            picgongn2.Image = global::Virus.Properties.Resources.gongneng;
        }


        //*****幸运抽奖******
        private void picgongn3_Click(object sender, EventArgs e)
        {
            gongNeng.Frmxycj f = new gongNeng.Frmxycj();
            f.Show();  //跳转幸运抽奖页面
            this.Hide();
        }

        private void picgongn3_MouseMove(object sender, MouseEventArgs e)
        {
            picgongn3.Image = global::Virus.Properties.Resources.gongneng2;
        }

        private void picgongn3_MouseLeave(object sender, EventArgs e)
        {
            picgongn3.Image = global::Virus.Properties.Resources.gongneng;
        }


        //*****猜数字******
        private void picgongn4_Click(object sender, EventArgs e)
        {
            gongNeng.Frmcsz f = new gongNeng.Frmcsz();
            f.Show();  //跳转猜数字页面
            this.Hide();
        }

        private void picgongn4_MouseMove(object sender, MouseEventArgs e)
        {
            picgongn4.Image = global::Virus.Properties.Resources.gongneng2;
        }

        private void picgongn4_MouseLeave(object sender, EventArgs e)
        {
            picgongn4.Image = global::Virus.Properties.Resources.gongneng;
        }


        //*****人机猜拳******
        private void picgongn5_Click(object sender, EventArgs e)
        {
            gongNeng.Frmrjcq f = new gongNeng.Frmrjcq();
            f.Show();  //跳转人机猜拳页面
            this.Hide();
        }

        private void picgongn5_MouseMove(object sender, MouseEventArgs e)
        {
            picgongn5.Image = global::Virus.Properties.Resources.gongneng2;
        }

        private void picgongn5_MouseLeave(object sender, EventArgs e)
        {
            picgongn5.Image = global::Virus.Properties.Resources.gongneng;
        }
        #endregion

        //**********底部功能**********
        #region 底部功能
        //*****换肤******
        private void picDianniu1_Click(object sender, EventArgs e)
        {
            diBuGongNeng.Frmpf f = new diBuGongNeng.Frmpf();
            f.Owner = this;  //跳转换肤页面
            f.ShowDialog();
        }

        private void picDianniu1_MouseMove(object sender, MouseEventArgs e)
        {
            picDianniu1.Image = global::Virus.Properties.Resources.zhuAnNiu2;
        }

        private void picDianniu1_MouseLeave(object sender, EventArgs e)
        {
            picDianniu1.Image = global::Virus.Properties.Resources.zhuAnNiu;
        }


        //*****设置******
        private void picDianniu2_Click(object sender, EventArgs e)
        {
            diBuGongNeng.Frmsz f = new diBuGongNeng.Frmsz();
            f.ShowDialog();  //跳转设置页面
        }

        private void picDianniu2_MouseMove(object sender, MouseEventArgs e)
        {
            picDianniu2.Image = global::Virus.Properties.Resources.zhuAnNiu2;
        }

        private void picDianniu2_MouseLeave(object sender, EventArgs e)
        {
            picDianniu2.Image = global::Virus.Properties.Resources.zhuAnNiu;
        }


        //*****关于******
        private void picDianniu3_Click(object sender, EventArgs e)
        {
            diBuGongNeng.Frmgy f = new diBuGongNeng.Frmgy();
            f.ShowDialog();  //跳转关于页面
        }

        private void picDianniu3_MouseMove(object sender, MouseEventArgs e)
        {
            picDianniu3.Image = global::Virus.Properties.Resources.zhuAnNiu2;
        }

        private void picDianniu3_MouseLeave(object sender, EventArgs e)
        {
            picDianniu3.Image = global::Virus.Properties.Resources.zhuAnNiu;
        }
        #endregion


    }
}
