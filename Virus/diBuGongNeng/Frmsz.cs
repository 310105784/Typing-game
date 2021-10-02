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
    public partial class Frmsz : Form
    {
        public Frmsz()
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
        private void FrmSheZhi_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        private void FrmSheZhi_MouseDown(object sender, MouseEventArgs e)
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
        private void FrmSheZhi_MouseUp(object sender, MouseEventArgs e)
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
        #region 窗口启动
        private void FrmSheZhi_Load(object sender, EventArgs e)
        {
            lblnicheng.Text = "昵称：" + FrmLogin.name;
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

            //读取打字测试设置
            try
            {
                FileStream f2r = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\sz.txt", FileMode.Open);
                StreamReader s2r = new StreamReader(f2r, Encoding.Default);
                string sj = s2r.ReadToEnd();
                string[] szsj = sj.Split(';');
                s2r.Close();
                f2r.Close();
                if (szsj[1] == "开")
                {
                    cbxdzts.Checked = true;
                    numdzsj.Value = int.Parse(szsj[0]);
                }
                else
                {
                    cbxdzts.Checked = false;
                    numdzsj.Value = int.Parse(szsj[0]);
                }
            }
            catch (Exception)
            {
                FileStream fw = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\sz.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fw, Encoding.Default);
                sw.Write("1;开");
            }

            //打字测试用户信息
            try
            {
                FileStream fr3 = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\dazisudu.txt", FileMode.Open);
                StreamReader sr3 = new StreamReader(fr3, Encoding.Default);
                string count3 = sr3.ReadToEnd();
                lblnicheng.Text = "昵称：" + FrmLogin.name;
                lbldazisudu.Text = count3;
                sr3.Close();
                fr3.Close();
            }
            catch (Exception)
            {
            }

            //幸运抽奖用户信息
            try
            {
                FileStream fr2 = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\cjxx.txt", FileMode.Open);
                StreamReader sr2 = new StreamReader(fr2, Encoding.Default);
                string count2 = sr2.ReadToEnd();
                string[] fk2 = count2.Split(';');
                lblydj.Text = "一等奖抽中次数：" + fk2[0] + "次";
                lbledj.Text = "二等奖抽中次数：" + fk2[1] + "次";
                lblsdj.Text = "三等奖抽中次数：" + fk2[2] + "次";
                lblcyj.Text = "参与奖抽中次数：" + fk2[3] + "次";
                sr2.Close();
                fr2.Close();
            }
            catch (Exception)
            {
            }

            //人机猜拳用户信息
            try
            {
                FileStream fr4 = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\cqxx.txt", FileMode.Open);
                StreamReader sr4 = new StreamReader(fr4, Encoding.Default);
                string count4 = sr4.ReadToEnd();
                string[] fk4 = count4.Split(';');
                lblju.Text = "共玩了：" + fk4[0] + "局";
                lblying.Text = "赢：" + fk4[1] + "局";
                lblshu.Text = "输：" + fk4[2] + "局";
                lblping.Text = "平：" + fk4[3] + "局";
                sr4.Close();
                fr4.Close();
            }
            catch (Exception)
            {
            }

            //猜数字用户信息
            try
            {
                FileStream fr5 = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\cszxx.txt", FileMode.Open);
                StreamReader sr5 = new StreamReader(fr5, Encoding.Default);
                string count5 = sr5.ReadToEnd();
                string[] fk5 = count5.Split(';');
                lblgong.Text = "总共猜了：" + fk5[0] + "次";
                lblcaishuziy.Text = "猜中次数：" + fk5[1] + "次";
                lblcaishuzis.Text = "猜错次数：" + fk5[2] + "次";
                sr5.Close();
                fr5.Close();
            }
            catch (Exception)
            {
            }
        }
        #endregion

        //**********打字测试设置保存**********
        #region 打字测试设置保存
        string jwts = "开";
        private void button1_Click(object sender, EventArgs e)
        {

            if (numdzsj.Value < 1)
            {
                Frmutw f = new Frmutw();
                f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                f.lblzi.Text = "打字时间最低1分钟！";
                f.ShowDialog();
            }
            else if (numdzsj.Value > 60)
            {
                Frmutw f = new Frmutw();
                f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                f.lblzi.Text = "打字时间最高60分钟！";
                f.ShowDialog();
            }
            else
            {
                try
                {
                    FileStream fw = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\sz.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fw, Encoding.Default);
                    sw.Write(numdzsj.Value + ";" + jwts);
                    Frmutw f = new Frmutw();
                    f.pictu.Image = global::Virus.Properties.Resources.utwyes;
                    f.lblzi.Text = "保存成功！";
                    f.ShowDialog();
                    sw.Close();
                    fw.Close();
                }
                catch (Exception)
                {
                    Frmutw f = new Frmutw();
                    f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                    f.lblzi.Text = "保存失败！";
                    f.ShowDialog();
                }
            }
        }
        #endregion

        //**********打字键位提示是否开启**********
        #region 打字键位提示是否开启
        private void cbxdzts_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxdzts.Checked)
            {
                jwts = "开";
            }
            else
            {
                jwts = "关";
            }
        }
        #endregion



    }
}
