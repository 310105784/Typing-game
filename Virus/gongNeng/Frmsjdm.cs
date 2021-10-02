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
    public partial class Frmsjdm : Form
    {
        public Frmsjdm()
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
        private void Frmsjdm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Frmsjdm_MouseDown(object sender, MouseEventArgs e)
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

        private void Frmsjdm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        #endregion

        //**********程序退出**********
        #region 程序退出
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

        //**********窗口启动**********
        #region 窗口启动
        private void Frmsjdm_Load(object sender, EventArgs e)
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


        //********************公共变量********************

        int tp;  //图片

        //************************************************

        //**********选择目录**********
        #region 选择目录
        private void button1_Click(object sender, EventArgs e)
        {
            fbdopen.ShowDialog();//模式化打开文件夹浏览窗口
        }
        #endregion

        //**********开始**********
        #region 开始
        private void btnKaishi_Click(object sender, EventArgs e)
        {
            //没有选择目录
            if (fbdopen.SelectedPath == "")
            {
                Frmutw f = new Frmutw();
                f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                f.lblzi.Text = "请选择图片文件夹";
                f.ShowDialog();
            }
            else if (btnKaishi.Text == "开始")
            {
                btnKaishi.Text = "暂停";
                timer1.Enabled = true;//启动计时器                
            }
            else
            {
                btnKaishi.Text = "开始";
                timer1.Enabled = false;//停止计时器
            }
        }
        #endregion

        //**********计时器**********
        #region 计时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string path = fbdopen.SelectedPath;  //获取用户选择的文件夹路径
                DirectoryInfo dir = new DirectoryInfo(path);
                FileInfo[] files = dir.GetFiles();
                if (!(files.Length <= 1))  //文件夹内小于2张图片判断
                {
                    if (tp < files.Length)
                    {
                        PicTupian.Image = Image.FromFile(path + "\\" + files[tp].Name);
                        int index = files[tp].Name.IndexOf('.');//找到.的位置
                        lblMingzi.Text = files[tp].Name.Substring(0, index);//截取
                        tp++;
                    }
                    else
                    {
                        tp = 0;//归0 循环显示
                    }
                }
                else
                {
                    timer1.Enabled = false;  //停止计时器
                    btnKaishi.Text = "开始";
                    Frmutw f = new Frmutw();
                    f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                    f.lblzi.Text = "文件夹中小于两张图片";
                    f.ShowDialog();
                }
            }
            catch (Exception)
            {
                timer1.Enabled = false;//停止计时器
                tp = 0;  //图片归零
                btnKaishi.Text = "开始";
                Frmutw f = new Frmutw();
                f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                f.lblzi.Text = "文件有误,请重新选择一个图片文件夹";
                f.ShowDialog();
            }
        }
        #endregion





    }
}
