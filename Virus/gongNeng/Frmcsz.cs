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
    public partial class Frmcsz : Form
    {
        public Frmcsz()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            this.SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            this.Opacity = 0;
            timer5.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
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
        private void Frmcsz_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Frmcsz_MouseDown(object sender, MouseEventArgs e)
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

        private void Frmcsz_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        #endregion

        //**********程序退出**********
        #region 程序退出
        private void Frmcsz_FormClosed(object sender, FormClosedEventArgs e)
        {
            //保存用户玩的信息
            FileStream fr7 = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\cszxx.txt", FileMode.Create);
            StreamWriter sr7 = new StreamWriter(fr7, Encoding.Default);
            sr7.Write(gong + ";" + ying + ";" + shu);
            sr7.Close();
            fr7.Close();
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

        





        //*******************公共变量********************

        int x;  //全局变量随机数

        int guan = 1;  //关卡

        int cishu = 24;  //需在这个次数内通关   主

        int cishu2;  //计算在这个次数内通关的关数   副

        int gong;  //总共玩了多少关

        int ying;  //总共赢了多少关

        int shu;  //总共输了多少关

        //***********************************************




        //**********窗口启动**********
        #region
        private void Frmcsz_Load(object sender, EventArgs e)
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
        #endregion

        //**********启动游戏**********
        #region  启动游戏
        //开始游戏
        private void btnks_Click(object sender, EventArgs e)
        {
            Random sui = new Random();
            x = sui.Next(100);  //生成随机数
            btnks.Enabled = false;  //开始按钮禁用
            btntj.Enabled = true;  //提交按钮启用
            btncxks.Enabled = true;  //重新开始按钮启用
            txtshu.Enabled = true;  //文本框启用
            txtshu.Focus();  //焦点给文本框
            cishu2 = cishu;  //主通关次数赋值给副通关次数
        }

        //重新开始游戏
        private void btncxks_Click(object sender, EventArgs e)
        {
            cishu = 24;  //次数等于默认通关次数
            cishu2 = cishu;  //主通关次数赋值给副通关次数
            guan = 1;  //关数等于1
            lbljihui.Text = cishu.ToString();
            lblcishu.Text = "你有" + cishu + "次机会";
            lblguan.Text = "第" + guan.ToString() + "关";
            lblts.Text = "提示";
            btntj.Enabled = true;
            txtshu.Enabled = true;
            txtshu.Text = null;
            txtshu.Focus();
        }
        #endregion

        //**********提交**********
        #region 提交
        private void btntj_Click(object sender, EventArgs e)
        {
            if (btntj.Text == "确定")
            {
                try
                {
                    if (txtshu.Text == "")
                    {
                        lblts.Text = "不能为空！";
                    }
                    else if (int.Parse(txtshu.Text) < 0 || int.Parse(txtshu.Text) > 100)
                    {
                        lblts.Text = "请输入0-100之间的整数！";
                        txtshu.Text = null;  //清空文本框
                        txtshu.Focus();  //给文本框焦点
                    }
                    else if (x == int.Parse(txtshu.Text))  //猜对了
                    {
                        Random sui = new Random();
                        x = sui.Next(100);
                        txtshu.Text = null;
                        txtshu.Enabled = false;
                        if (guan == 8)
                        {
                            //通关弹窗
                            btntj.Enabled = false;
                            Frmutw f = new Frmutw();
                            f.pictu.Image = global::Virus.Properties.Resources.utwyes;
                            f.lblzi.Text = "你好棒！通关了！";
                            f.ShowDialog();
                        }
                        else
                        {
                            ying++;
                            gong++;
                            btntj.Text = "下一关";
                            lblts.Text = "恭喜你猜对了！";
                        }

                    }
                    else if (x < int.Parse(txtshu.Text))  //猜错了
                    {
                        cishu--;  //次数减一
                        if (cishu <= 0)
                        {
                            lblcishu.Text = "你有0次机会";
                            lblts.Text = "提示";
                            txtshu.Enabled = false;
                            btntj.Enabled = false;
                            Frmutw f = new Frmutw();
                            f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                            f.lblzi.Text = "很遗憾，你输了！";
                            f.ShowDialog();
                        }
                        else
                        {
                            shu++;
                            gong++;
                            lblcishu.Text = "你还有" + cishu + "次机会";
                            lblts.Text = "大了呦！";
                            txtshu.Focus();
                            txtshu.SelectAll();
                        }
                    }
                    else if (x > int.Parse(txtshu.Text))  //猜错了
                    {
                        cishu--;
                        if (cishu <= 0)
                        {
                            lblcishu.Text = "你有0次机会";
                            lblts.Text = "提示";
                            txtshu.Enabled = false;
                            btntj.Enabled = false;
                            Frmutw f = new Frmutw();
                            f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                            f.lblzi.Text = "很遗憾，你输了！";
                            f.ShowDialog();
                        }
                        else
                        {
                            shu++;
                            gong++;
                            lblcishu.Text = "你还有" + cishu + "次机会";
                            lblts.Text = "小了呦！";
                            txtshu.Focus();
                            txtshu.SelectAll();
                        }
                    }
                }
                catch (Exception)
                {
                    lblts.Text = "请输入正确的数字！";
                    txtshu.Text = null;
                    txtshu.Focus();
                }
            }
            else if (btntj.Text == "下一关")
            {
                lblts.Text = "提示";
                btntj.Text = "确定";
                txtshu.Enabled = true;
                cishu = cishu2 - 3;  //每次通关次数减三
                cishu2 = cishu;
                guan++;
                lblguan.Text = "第" + guan + "关";
                lblcishu.Text = "你有" + cishu + "次机会";
                lbljihui.Text = cishu.ToString(); ;
                txtshu.Text = null;
                txtshu.Focus();
            }
        }
        #endregion


    }
}
