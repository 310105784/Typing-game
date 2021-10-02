using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Virus
{
    public partial class FrmLogin : Form
    {
        public static string name;  //全局变量用户名

        public FrmLogin()
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
        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
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
        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
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

        //**********拖动窗口**********
        #region 窗口启动
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtname.Focus();  //给文本框焦点
        }
        #endregion

        //**********登录**********
        #region 登录
        private void button1Click(object sender, EventArgs e)
        {
            name = txtname.Text;  //姓名
            Regex rx = new Regex("^[\u4E00-\u9FA5]+$");
            if (name == "")
            {
                Frmutw f = new Frmutw();
                f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                f.lblzi.Text = "姓名不能为空！";
                f.ShowDialog();
            }
            else if (name.Length < 2)
            {
                Frmutw f = new Frmutw();
                f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                f.lblzi.Text = "姓名长度不能小于2";
                f.ShowDialog();
                txtname.Focus();  //给文本框焦点
                txtname.SelectAll();  //选中文本框内容
            }
            else if (name.Length > 3)
            {
                Frmutw f = new Frmutw();
                f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                f.lblzi.Text = "姓名长度不能大于4";
                f.ShowDialog();
                txtname.Focus();  //给文本框焦点
                txtname.SelectAll();  //选中文本框内容
            }
            else if (!rx.IsMatch(name))
            {
                Frmutw f = new Frmutw();
                f.pictu.Image = global::Virus.Properties.Resources.utwjinggao;
                f.lblzi.Text = "只输入您的姓名";
                f.ShowDialog();
                txtname.Focus();  //给文本框焦点
                txtname.SelectAll();  //选中文本框内容
            }
            else
            {
                if (!Directory.Exists(Application.StartupPath + "\\res\\User\\" + name))
                {
                    //创建新用户
                    Directory.CreateDirectory(Application.StartupPath + "\\res\\User\\" + name);
                    FileStream fw = new FileStream(Application.StartupPath + "\\res\\User\\" + name + "\\bg.txt", FileMode.Create);
                    StreamWriter fww = new StreamWriter(fw);
                    fww.Write("bg1");
                    fww.Close();
                    fw.Close();
                    FileStream fw2 = new FileStream(Application.StartupPath + "\\res\\User\\" + FrmLogin.name + "\\sz.txt", FileMode.Create);
                    StreamWriter sw2 = new StreamWriter(fw2, Encoding.Default);
                    sw2.Write("1;开");
                    sw2.Close();
                    fw2.Close();
                }
                //跳转到主页面
                this.Hide();
                Frmzhu f = new Frmzhu();
                f.Show();
            }
        }

        #endregion
    }
}
