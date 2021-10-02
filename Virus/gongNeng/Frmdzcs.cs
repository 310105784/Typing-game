using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Virus.gongNeng
{
    public partial class Frmdzcs : Form
    {
        public Frmdzcs()
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
        private void Frmdzcs_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Frmdzcs_MouseDown(object sender, MouseEventArgs e)
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

        private void Frmdzcs_MouseUp(object sender, MouseEventArgs e)
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





        //********************公共变量********************

        string conent;  //全部单词

        string[] dc;  //单个单词

        Random sui = new Random();  //随机数生成
        int shu;  //随机数生成

        int wordlength;  //单词长度

        int count;  //单词长度

        //********************公共变量********************





        //**********窗口启动**********
        #region 窗口启动
        private void Frmdzcs_Load(object sender, EventArgs e)
        {

            try
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


                FileStream fr = new FileStream(Application.StartupPath + "\\res\\Typing test\\Word.txt", FileMode.Open);  //创建文件流
                StreamReader sr = new StreamReader(fr, Encoding.Default);  //创建读取器
                conent = sr.ReadToEnd();  //获取内容
                dc = conent.Split(' ');  //分割
                while (wordlength < 64)  //文本框单词是否小于64个字符
                {
                    if (wordlength < 64)  //文本框单词是否小于64个字符
                    {
                        shu = sui.Next(0, dc.Length - 1);  //生成随机数
                        lblword.Text = lblword.Text + dc[shu] + " ";  //单词赋值给文本
                        wordlength += dc[shu].Length;  //文本的单词长度
                        wordlength += 1;  //文本的单词长度
                    }
                }
                if (wordlength > 64)  //单词是否大于64个字符
                {
                    //单词长度大于64的时候截取文本框的64个字符赋值给文本
                    lblword.Text = lblword.Text.Substring(0, lblword.Text.Length - (lblword.Text.Length - 63));
                }
                sr.Close();  //关闭读取器
                fr.Close();  //关闭文件流

                FileStream f2r = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\sz.txt", FileMode.Open);
                StreamReader s2r = new StreamReader(f2r, Encoding.Default);
                sj = s2r.ReadToEnd();
                szsj = sj.Split(';');
                fen = int.Parse(szsj[0]);
                if (int.Parse(szsj[0]) <= 9)
                {
                    lblfen.Text = "0" + szsj[0];
                }
                else
                {
                    lblfen.Text = szsj[0].ToString();
                }
                if (miao <= 9)
                {
                    lblmiao.Text = "0" + miao;  //如果小于10那么就在后面加个零使文本变两位数
                }
                else
                {
                    lblmiao.Text = miao.ToString();
                }
                if (szsj[1] == "开")
                {
                    #region 键盘字母显示判断
                    keyboard(lblword.Text.Substring(0, 1));
                    #endregion
                }
            }
            catch (Exception)
            {
                Frmutw f = new Frmutw();
                f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                f.lblzi.Text = "配置文件出错！";
                f.ShowDialog();
                Frmzhu f2 = new Frmzhu();
                f2.Show();
                Close();
            }

        }
        #endregion

        //**********打字**********
        #region 打字
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            piczt.Image = global::Virus.Properties.Resources.Dazizanting2;  //图片切换开始
            timer1.Enabled = true;  //启动计时器
            piczt.TabIndex = 4;
            int t; //文本框字符长度
            rictxtword.MaxLength = lblword.Text.Length;  //文本框的字符的长度为文本的长度
            t = rictxtword.Text.Length;  //文本框的字符长度

            //**********单词相等**********
            #region 单词相等
            if (rictxtword.Text == lblword.Text)
            {
                rictxtword.Text = null;  //文本框单词清空
                lblword.Text = null;  //文本单词清空
                wordlength = 0;  //单词长度清零
                while (wordlength < 64)  //文本框单词是否小于64个字符
                {
                    if (wordlength < 64)  //文本框单词是否小于64个字符
                    {
                        shu = sui.Next(0, dc.Length - 1);  //生成随机数
                        lblword.Text = lblword.Text + dc[shu] + " ";  //单词出现
                        wordlength += dc[shu].Length;  //文本的单词长度
                        wordlength += 1;  //文本的单词长度
                    }
                }
                if (wordlength > 64)  //文本框单词是否大于64个字符
                {
                    //文本框单词长度大于64的时候截取64个字符赋值给文本
                    lblword.Text = lblword.Text.Substring(0, lblword.Text.Length - (lblword.Text.Length - 63));
                }
            }

            else if (t != 0)  //文本框单词长度是否不等于0
            {

                if (rictxtword.Text[t - 1] != lblword.Text[t - 1])  //文本框单词是否不等于文本长度
                {
                    rictxtword.Select(t - 1, 1);  //选中文本框最后一位字符
                    rictxtword.SelectionColor = Color.Red;  //选中的文本变为红色
                    rictxtword.Select(t, 0);  //光标给文本框最后一位
                    //lblword.ForeColor = System.Drawing.Color.Red;  //文本字体颜色为红色
                }
                else
                {
                    rictxtword.Select(t - 1, 1);  //选中文本框最后一位字符
                    rictxtword.SelectionColor = Color.Gray;  //选中的文本黑色红色
                    rictxtword.Select(t, 0);  //光标给文本框最后一位
                    //lblword.ForeColor = System.Drawing.Color.Black;  //文本字体颜色为黑色
                }
            }
            //else  //文本框单词长度等于0
            //{
            //    lblword.ForeColor = System.Drawing.Color.Black;  //文本字体颜色为黑色
            //}
            #endregion

            //**********键盘预判断**********
            #region 键盘预判断
            string jianpandc;  //文本框需输入的下一个单词
            if (rictxtword.Text == "")
            {
                jianpandc = lblword.Text.Substring(0, 1);
            }
            else
            {
                if (rictxtword.Text.Length == lblword.Text.Length)  //文本框的字符长度是否等于文本长度
                {
                    jianpandc = lblword.Text.Substring(rictxtword.Text.Length - 1, 0);//文本框需输入的下一个单词
                }
                else
                {
                    jianpandc = lblword.Text.Substring(rictxtword.Text.Length - 1, 2).Substring(1, 1);//文本框需输入的下一个单词
                }

            }
            #endregion

            //**********键盘字母显示判断**********
            if (szsj[1] == "开")
            {
                #region 键盘字母显示判断
                keyboard(jianpandc);
                #endregion
            }


        }
        #endregion

        //**********文本框键盘按下**********
        #region 文本框键盘按下
        private void rictxtword_KeyDown(object sender, KeyEventArgs e)
        {

            int t = rictxtword.Text.Length;  //获取文本框字符长度
            rictxtword.Select(t, 0);  //光标给文本框最后一位
            if (rictxtword.Text != "")
            {
                if (rictxtword.Text.Substring(rictxtword.Text.Length - 1, 1) == " " && e.KeyCode == Keys.Space)
                {
                    rictxtword.Text = rictxtword.Text.Substring(0, rictxtword.Text.Length - 1);  //文本框的内容为文本框内容的字符减一
                }
                else if (rictxtword.Text[t - 1] == lblword.Text[t - 1])
                {
                    count++;  //单词长度加一
                }
            }
            else
            {
                rictxtword.Text = "";  //文本框清空
            }
        }
        #endregion

        //**********打字时间**********
        #region 打字时间
        string sj;  //获取设置
        string[] szsj;
        int fen;  //分
        int miao = 0; //秒
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (fen <= 0 && miao <= 1)
            {
                miao = 0; //秒
                lblmiao.Text = "00";  //秒归0
                fen = int.Parse(szsj[0]);
                if (int.Parse(szsj[0]) <= 9)
                {
                    lblfen.Text = "0" + szsj[0];
                }
                else
                {
                    lblfen.Text = szsj[0].ToString();
                }
                if (miao <= 9)
                {
                    lblmiao.Text = "0" + miao;  //如果小于10那么就在后面加个零使文本变两位数
                }
                else
                {
                    lblmiao.Text = miao.ToString();
                }
                rictxtword.Text = null;  //文本框单词清空
                lblword.Text = null;  //文本单词清空
                wordlength = 0;  //单词长度清零
                timer1.Enabled = false;  //暂停计时器
                while (wordlength < 64)  //文本框单词是否小于64个字符
                {
                    if (wordlength < 64)  //文本框单词是否小于64个字符
                    {
                        shu = sui.Next(0, dc.Length - 1);  //生成随机数
                        lblword.Text = lblword.Text + dc[shu] + " ";  //单词出现
                        wordlength += dc[shu].Length;  //文本的单词长度
                        wordlength += 1;  //文本的单词长度
                    }
                }
                if (wordlength > 64)  //文本框单词是否大于64个字符
                {
                    //文本框单词长度大于64的时候截取64个字符赋值给文本
                    lblword.Text = lblword.Text.Substring(0, lblword.Text.Length - (lblword.Text.Length - 63));
                }

                //保存用户打字速度
                FileStream fw = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\dazisudu.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fw, Encoding.Default);
                sw.Write("打字速度：" + count / int.Parse(szsj[0]) + "字/分钟");
                sw.Close();
                fw.Close();

                //弹出用户打字速度
                Frmutw f = new Frmutw();
                f.pictu.Image = global::Virus.Properties.Resources.utwyes;
                f.lblzi.Text = "打字时间到！你的打字速度为   " + count / int.Parse(szsj[0]) + "字/分钟";
                f.ShowDialog();
                count = 0;  //单词长度归0
                piczt.Image = global::Virus.Properties.Resources.Dazizanting;  //图片切换暂停
                piczt.TabIndex = 3;
            }
            else if (miao <= 0)
            {
                miao = 59;  //给秒赋值59
                lblmiao.Text = miao.ToString();
                fen--;
                if (int.Parse(lblfen.Text) <= 9 || int.Parse(lblmiao.Text) < 10)
                {
                    lblfen.Text = "0" + fen;  //分和秒小于一位数的时候给前面加个0
                }
                else
                {
                    lblfen.Text = fen.ToString();
                    lblmiao.Text = miao.ToString();
                }
            }
            else
            {
                miao--;
                if (miao == 9)
                {
                    lblmiao.Text = "0" + miao;  //秒小于一位数的时候给秒前面加个0
                }
                if (int.Parse(lblmiao.Text) < 10)
                {
                    lblmiao.Text = "0" + miao;  //如果小于10那么就在后面加个零使文本变两位数
                }
                else
                {
                    lblmiao.Text = miao.ToString();
                }

            }
        }
        #endregion

        //**********开始和暂停*********
        #region 开始和暂停
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (piczt.TabIndex == 3)
            {
                piczt.Image = global::Virus.Properties.Resources.Dazizanting2;  //图片切换开始
                timer1.Enabled = true;  //启动计时器
                piczt.TabIndex = 4;
            }
            else if (piczt.TabIndex == 4)
            {
                piczt.Image = global::Virus.Properties.Resources.Dazizanting;  //图片切换暂停
                timer1.Enabled = false;  //暂停计时器
                piczt.TabIndex = 3;
            }

        }
        #endregion

        //**********重新开始**********
        #region 重新开始
        private void piccxks_Click(object sender, EventArgs e)
        {

            miao = 0; //秒
            lblmiao.Text = "00";  //秒归0
            fen = int.Parse(szsj[0]);  //分等于设置中的时间
            if (int.Parse(szsj[0]) <= 9)
            {
                lblfen.Text = "0" + szsj[0];
            }
            else
            {
                lblfen.Text = szsj[0].ToString();
            }
            if (miao <= 9)
            {
                lblmiao.Text = "0" + miao;  //如果小于10那么就在后面加个零使文本变两位数
            }
            else
            {
                lblmiao.Text = miao.ToString();
            }
            count = 0;  //单词长度归0
            rictxtword.Text = null;  //文本框单词清空
            lblword.Text = null;  //文本单词清空
            wordlength = 0;  //单词长度清零
            timer1.Enabled = false;  //暂停计时器

            while (wordlength < 64)  //文本框单词是否小于64个字符
            {
                if (wordlength < 64)  //文本框单词是否小于64个字符
                {
                    shu = sui.Next(0, dc.Length - 1);  //生成随机数
                    lblword.Text = lblword.Text + dc[shu] + " ";  //单词出现
                    wordlength += dc[shu].Length;  //文本的单词长度
                    wordlength += 1;  //文本的单词长度
                }
            }
            if (wordlength > 64)  //文本框单词是否大于64个字符
            {
                //文本框单词长度大于64的时候截取64个字符赋值给文本
                lblword.Text = lblword.Text.Substring(0, lblword.Text.Length - (lblword.Text.Length - 63));
            }
            piczt.Image = global::Virus.Properties.Resources.Dazizanting;  //图片切换暂停
            piczt.TabIndex = 3;

            if (szsj[1] == "开")
            {
                #region 键盘字母显示判断
                keyboard(lblword.Text.Substring(0, 1));
                #endregion
            }
        }
        #endregion




        private void keyboard(string jianpandc)
        {
            if (jianpandc == "a" || jianpandc == "A")
            {
                picJianPan.Image = global::Virus.Properties.Resources.A;
            }
            else if (jianpandc == "b" || jianpandc == "B")
            {
                picJianPan.Image = global::Virus.Properties.Resources.B;
            }
            else if (jianpandc == "c" || jianpandc == "C")
            {
                picJianPan.Image = global::Virus.Properties.Resources.C;
            }
            else if (jianpandc == "d" || jianpandc == "D")
            {
                picJianPan.Image = global::Virus.Properties.Resources.D;
            }
            else if (jianpandc == "e" || jianpandc == "E")
            {
                picJianPan.Image = global::Virus.Properties.Resources.E;
            }
            else if (jianpandc == "f" || jianpandc == "F")
            {
                picJianPan.Image = global::Virus.Properties.Resources.F;
            }
            else if (jianpandc == "g" || jianpandc == "G")
            {
                picJianPan.Image = global::Virus.Properties.Resources.G;
            }
            else if (jianpandc == "h" || jianpandc == "H")
            {
                picJianPan.Image = global::Virus.Properties.Resources.H;
            }
            else if (jianpandc == "i" || jianpandc == "I")
            {
                picJianPan.Image = global::Virus.Properties.Resources.I;
            }
            else if (jianpandc == "j" || jianpandc == "J")
            {
                picJianPan.Image = global::Virus.Properties.Resources.J;
            }
            else if (jianpandc == "k" || jianpandc == "K")
            {
                picJianPan.Image = global::Virus.Properties.Resources.K;
            }
            else if (jianpandc == "l" || jianpandc == "L")
            {
                picJianPan.Image = global::Virus.Properties.Resources.L;
            }
            else if (jianpandc == "m" || jianpandc == "M")
            {
                picJianPan.Image = global::Virus.Properties.Resources.M;
            }
            else if (jianpandc == "n" || jianpandc == "N")
            {
                picJianPan.Image = global::Virus.Properties.Resources.N;
            }
            else if (jianpandc == "o" || jianpandc == "O")
            {
                picJianPan.Image = global::Virus.Properties.Resources.O;
            }
            else if (jianpandc == "p" || jianpandc == "P")
            {
                picJianPan.Image = global::Virus.Properties.Resources.P;
            }
            else if (jianpandc == "q" || jianpandc == "Q")
            {
                picJianPan.Image = global::Virus.Properties.Resources.Q;
            }
            else if (jianpandc == "r" || jianpandc == "R")
            {
                picJianPan.Image = global::Virus.Properties.Resources.R;
            }
            else if (jianpandc == "s" || jianpandc == "S")
            {
                picJianPan.Image = global::Virus.Properties.Resources.S;
            }
            else if (jianpandc == "t" || jianpandc == "T")
            {
                picJianPan.Image = global::Virus.Properties.Resources.Y;
            }
            else if (jianpandc == "u" || jianpandc == "U")
            {
                picJianPan.Image = global::Virus.Properties.Resources.U;
            }
            else if (jianpandc == "v" || jianpandc == "V")
            {
                picJianPan.Image = global::Virus.Properties.Resources.V;
            }
            else if (jianpandc == "w" || jianpandc == "W")
            {
                picJianPan.Image = global::Virus.Properties.Resources.W;
            }
            else if (jianpandc == "x" || jianpandc == "X")
            {
                picJianPan.Image = global::Virus.Properties.Resources.X;
            }
            else if (jianpandc == "y" || jianpandc == "Y")
            {
                picJianPan.Image = global::Virus.Properties.Resources.Y;
            }
            else if (jianpandc == "z" || jianpandc == "Z")
            {
                picJianPan.Image = global::Virus.Properties.Resources.Z;
            }
            else if (jianpandc == " ")
            {
                picJianPan.Image = global::Virus.Properties.Resources.kongge;
            }
        }
    }
}

