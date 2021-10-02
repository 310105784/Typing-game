using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Virus.gongNeng
{
    public partial class Frmrjcq : Form
    {
        public Frmrjcq()
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
        private void Frmrjcq_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Frmrjcq_MouseDown(object sender, MouseEventArgs e)
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

        private void Frmrjcq_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        #endregion

        //**********程序退出**********
        #region 程序退出
        private void Frmrjcq_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream fw = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\cqxx.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fw, Encoding.Default);
            sw.Write("{0};{1};{2};{3}", ju, ying, shu, ping);
            sw.Close();
            fw.Close();
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            Frmzhu f = new Frmzhu();
            f.Show();
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


        //********************公共变量********************
        int wanjia;  //玩家出的拳

        int diannao;  //电脑出的拳

        int wanjiasm = 3;  //玩家生命

        int diannaosm = 3;  //电脑生命

        int ju = 0;  //共玩了多少局

        int ying = 0;  //赢了多少局

        int shu = 0;  //输了多少局

        int ping = 0;  //平局多少局
        //************************************************



        //**********窗口启动**********
        #region 窗口启动
        private void Frmrjcq_Load(object sender, EventArgs e)
        {
            label2.Text = "昵称:" + FrmLogin.name;
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
            try
            {
                FileStream fr3 = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\cqxx.txt", FileMode.Open);
                StreamReader sr3 = new StreamReader(fr3, Encoding.Default);
                string count3 = sr3.ReadToEnd();
                string[] fk3 = count3.Split(';');
                ju = int.Parse(fk3[0]);
                ying = int.Parse(fk3[1]);
                shu = int.Parse(fk3[2]);
                ping = int.Parse(fk3[3]);
                sr3.Close();
                fr3.Close();
            }
            catch (Exception)
            {
            }

        }
        #endregion

        //picdiannao和picwanjia图片轮番
        #region picdiannao和picwanjia图片轮番
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random f = new Random();
            diannao = f.Next(0, 3);
            picdiannao.Image = lstdiannao.Images[diannao];
            Random ff = new Random();
            int wanjia = ff.Next(0, 3);
            picwanjia.Image = lstwanjia.Images[wanjia];
        }
        #endregion

        //开始游戏and下一局and重新开始
        #region 开始游戏and下一局and重新开始
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "开始游戏")
            {
                timer1.Enabled = true;  //启动计时器
                button1.Visible = false;  //隐藏按钮
                picwjshi.Visible = true;  //显示石头
                picwjjian.Visible = true;  //显示剪刀
                picwjbu.Visible = true;  //显示布
            }
            else if (button1.Text == "下一局")
            {
                timer1.Enabled = true;  //启动计时器
                button1.Visible = false;  //隐藏按钮
                picwjshi.Visible = true;  //显示石头
                picwjjian.Visible = true;  //显示剪刀
                picwjbu.Visible = true;  //显示布
            }
            else if (button1.Text == "重新开始")
            {
                wanjiasm = 3;  //玩家生命
                diannaosm = 3;  //电脑生命
                picxinwanjia1.Image = global::Virus.Properties.Resources.caiQuanXue;
                picxinwanjia2.Image = global::Virus.Properties.Resources.caiQuanXue;
                picxinwanjia3.Image = global::Virus.Properties.Resources.caiQuanXue;
                picxindiannao1.Image = global::Virus.Properties.Resources.caiQuanXue;
                picxindiannao2.Image = global::Virus.Properties.Resources.caiQuanXue;
                picxindiannao3.Image = global::Virus.Properties.Resources.caiQuanXue;
                timer1.Enabled = true;  //启动计时器
                button1.Visible = false;  //隐藏按钮
                picwjshi.Visible = true;  //显示石头
                picwjjian.Visible = true;  //显示剪刀
                picwjbu.Visible = true;  //显示布
            }
        }
        #endregion

        //玩家点击石头
        #region 玩家点击石头
        private void picwjshi_Click(object sender, EventArgs e)
        {
            ju++;
            wanjia = 0;  //玩家出拳头
            picwanjia.Image = global::Virus.Properties.Resources.caiQuanShiwj;
            timer1.Enabled = false;  //暂停计时器
            if (wanjia == 0 && diannao == 0)
            {
                button1.Visible = true;  //显示按钮
                picwjshi.Visible = false;  //隐藏石头
                picwjjian.Visible = false;  //隐藏剪刀
                picwjbu.Visible = false;  //隐藏布
                button1.Text = "下一局";
                lbljieguo.Text = "平局";
                ping++;
            }
            else if (wanjia == 0 && diannao == 1)
            {
                diannaosm--;  //电脑生命减一
                button1.Text = "下一局";
                lbljieguo.Text = "赢了";
                ying++;
                if (diannaosm <= 0)
                {
                    picxindiannao3.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    button1.Text = "重新开始";
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                    Frmutw f = new Frmutw();
                    f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                    f.lblzi.Text = "恭喜你赢了！";
                    f.ShowDialog();
                }
                else if (diannaosm == 1)
                {
                    picxindiannao2.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
                else if (diannaosm == 2)
                {
                    picxindiannao1.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
            }
            else if (wanjia == 0 && diannao == 2)
            {
                wanjiasm--;  //玩家生命减一
                button1.Text = "下一局";
                lbljieguo.Text = "输了";
                shu++;
                if (wanjiasm <= 0)
                {
                    picxinwanjia3.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    button1.Text = "重新开始";
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                    Frmutw f = new Frmutw();
                    f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                    f.lblzi.Text = "很遗憾你输了！";
                    f.ShowDialog();
                }
                else if (wanjiasm == 1)
                {
                    picxinwanjia2.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
                else if (wanjiasm == 2)
                {
                    picxinwanjia1.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
            }
        }
        #endregion

        //玩家点击剪刀
        #region 玩家点击剪刀
        private void picwjjian_Click(object sender, EventArgs e)
        {
            ju++;
            wanjia = 1;  //玩家出剪刀
            picwanjia.Image = global::Virus.Properties.Resources.caiQuanJianwj;
            timer1.Enabled = false;  //暂停计时器
            if (wanjia == 1 && diannao == 0)
            {
                wanjiasm--;  //玩家生命减一
                button1.Text = "下一局";
                lbljieguo.Text = "输了";
                shu++;
                if (wanjiasm <= 0)
                {
                    picxinwanjia3.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    button1.Text = "重新开始";
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                    Frmutw f = new Frmutw();
                    f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                    f.lblzi.Text = "很遗憾你输了！";
                    f.ShowDialog();
                }
                else if (wanjiasm == 1)
                {
                    picxinwanjia2.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
                else if (wanjiasm == 2)
                {
                    picxinwanjia1.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
            }
            else if (wanjia == 1 && diannao == 1)
            {
                button1.Visible = true;  //显示按钮
                picwjshi.Visible = false;  //隐藏石头
                picwjjian.Visible = false;  //隐藏剪刀
                picwjbu.Visible = false;  //隐藏布
                button1.Text = "下一局";
                lbljieguo.Text = "平局";
                ping++;
            }
            else if (wanjia == 1 && diannao == 2)
            {
                diannaosm--;  //电脑生命减一
                button1.Text = "下一局";
                lbljieguo.Text = "赢了";
                ying++;
                if (diannaosm <= 0)
                {
                    picxindiannao3.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    button1.Text = "重新开始";
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                    Frmutw f = new Frmutw();
                    f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                    f.lblzi.Text = "恭喜你赢了！";
                    f.ShowDialog();
                }
                else if (diannaosm == 1)
                {
                    picxindiannao2.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
                else if (diannaosm == 2)
                {
                    picxindiannao1.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
            }
        }
        #endregion

        //玩家点击布
        #region 玩家点击布
        private void picwjbu_Click(object sender, EventArgs e)
        {
            ju++;
            wanjia = 2;  //玩家出布
            picwanjia.Image = global::Virus.Properties.Resources.caiQuanBuwj;
            timer1.Enabled = false;  //暂停计时器
            if (wanjia == 2 && diannao == 0)
            {
                diannaosm--;  //电脑生命减一
                button1.Text = "下一局";
                lbljieguo.Text = "赢了";
                ying++;
                if (diannaosm <= 0)
                {
                    picxindiannao3.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    button1.Text = "重新开始";
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                    Frmutw f = new Frmutw();
                    f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                    f.lblzi.Text = "恭喜你赢了！";
                    f.ShowDialog();
                }
                else if (diannaosm == 1)
                {
                    picxindiannao2.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
                else if (diannaosm == 2)
                {
                    picxindiannao1.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
            }
            else if (wanjia == 2 && diannao == 1)
            {
                wanjiasm--;  //电脑生命减一
                button1.Text = "下一局";
                lbljieguo.Text = "输了";
                shu++;
                if (wanjiasm <= 0)
                {
                    picxinwanjia3.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    button1.Text = "重新开始";
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                    Frmutw f = new Frmutw();
                    f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                    f.lblzi.Text = "很遗憾你输了！";
                    f.ShowDialog();
                }
                else if (wanjiasm == 1)
                {
                    picxinwanjia2.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
                else if (wanjiasm == 2)
                {
                    picxinwanjia1.Image = global::Virus.Properties.Resources.caiQuanXue2;
                    button1.Visible = true;  //显示按钮
                    picwjshi.Visible = false;  //隐藏石头
                    picwjjian.Visible = false;  //隐藏剪刀
                    picwjbu.Visible = false;  //隐藏布
                }
            }
            else if (wanjia == 2 && diannao == 2)
            {
                button1.Visible = true;  //显示按钮
                picwjshi.Visible = false;  //隐藏石头
                picwjjian.Visible = false;  //隐藏剪刀
                picwjbu.Visible = false;  //隐藏布
                button1.Text = "下一局";
                lbljieguo.Text = "平局";
                ping++;
            }
        }





        #endregion


    }
}
