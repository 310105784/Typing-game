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
using System.Threading;

namespace Virus.gongNeng
{
    public partial class Frmxycj : Form
    {
        public Frmxycj()
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
        private void Frmxycj_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Frmxycj_MouseDown(object sender, MouseEventArgs e)
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

        private void Frmxycj_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        #endregion

        //**********程序退出**********
        #region 程序退出
        private void Frmxycj_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream fw = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\cjxx.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fw, Encoding.Default);
            sw.Write("{0};{1};{2};{3}", ydj, edj, sdj, cyj);  //存入用户抽奖信息
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

        string content;  //奖品

        string[] prize;  //奖品

        int jp = 0;  //奖品显示

        int ydj = 0;  //一等奖抽中次数

        int edj = 0;  //二等奖抽中次数

        int sdj = 0;  //三等奖抽中次数

        int cyj = 0;  //参与奖抽中次数

        //************************************************



        //**********窗口启动**********
        #region 窗口启动
        private void Frmxycj_Load(object sender, EventArgs e)
        {

            try  //读取文件出错预处理
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

                //******读取一、二、三等奖奖品*****
                FileStream fr = new FileStream(Application.StartupPath + "//res//Lucky Draw//Prize.txt", FileMode.Open);  //创建文件流
                StreamReader sr = new StreamReader(fr, Encoding.Default);  //创建读取器
                content = sr.ReadToEnd(); //读取内容
                prize = content.Split(' ');  //读取到的内容分割
                if (prize.Length >= 4)
                {
                    lstcjjp.Items.AddRange(new object[] { "一等奖:" + prize[0] + "\n", "二等奖:" + prize[1] + "\n", "三等奖:" + prize[2] + "\n", "参与奖:" + prize[3] });
                    for (int cyj = 4; cyj < prize.Length; cyj++)
                    {
                        string cyjhe = "\n" + prize[cyj];  //显示每个奖品的
                        lstcjjp.Items.AddRange(new object[] { cyjhe + "\n" });  //显示每个奖品
                    }
                    sr.Close();  //关闭读取器
                    fr.Close();  //关闭文件流
                }
                else
                {
                    Frmutw f = new Frmutw();
                    f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                    f.lblzi.Text = "奖品太少！";
                    f.ShowDialog();
                    Frmzhu f2 = new Frmzhu();
                    f2.Show();
                    Close();
                }
                //******读取一、二、三等奖奖品*****
            }
            catch (Exception)
            {
                Frmutw f = new Frmutw();
                f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                f.lblzi.Text = "读取本地文件出错了！";
                f.ShowDialog();
                Frmzhu f2 = new Frmzhu();
                f2.Show();
                Close();
            }

            try
            {
                FileStream fr2 = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\cjxx.txt", FileMode.Open);
                StreamReader sr2 = new StreamReader(fr2, Encoding.Default);
                string count2 = sr2.ReadToEnd();
                string[] fk2 = count2.Split(';');
                ydj = int.Parse(fk2[0]);  //显示一等奖
                edj = int.Parse(fk2[1]);  //显示二等奖
                sdj = int.Parse(fk2[2]);  //显示三等奖
                cyj = int.Parse(fk2[3]);  //显示参与奖
                sr2.Close();
                fr2.Close();
            }
            catch (Exception)
            {
            }
        }
        #endregion

        //******开始按钮点击*****
        #region 开始按钮点击
        private void btncj_Click(object sender, EventArgs e)
        {

            if (btncj.Text == "开始")
            {
                btncj.Text = "暂停";  //改变按钮名字
                timer1.Enabled = true;  //开启计时器
            }
            else
            {
                if (lbljp.Text == prize[0])
                {
                    ydj++;  //记录用户抽中的一等奖次数
                }
                else if (lbljp.Text == prize[1])
                {
                    edj++;  //记录用户抽中的二等奖次数
                }
                else if (lbljp.Text == prize[2])
                {
                    sdj++;  //记录用户抽中的三等奖次数
                }
                else
                {
                    cyj++;  //显示用户参与奖的次数
                }
                btncj.Text = "开始";  //改变按钮名字
                timer1.Enabled = false;  //暂停计时器
                lstwdjp.Items.AddRange(new object[] { lbljp.Text + "\n" }); //我的奖品新增记录
                lstwdjp.TopIndex = lstwdjp.Items.Count - (int)(lstwdjp.Height / lstwdjp.ItemHeight);  //可看到最后一条记录
            }
        }
        #endregion

        //*****显示抽奖*****
        #region 显示奖品
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbljp.Text = prize[jp];  //奖品显示
            if (jp >= prize.Length - 1)
            {
                jp = 0;
            }
            else
            {
                jp++;
            }
        }
        #endregion


    }
}
