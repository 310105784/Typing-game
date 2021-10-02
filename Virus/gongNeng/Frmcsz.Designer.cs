namespace Virus.gongNeng
{
    partial class Frmcsz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcsz));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbljihui = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblcishu = new System.Windows.Forms.Label();
            this.lblguan = new System.Windows.Forms.Label();
            this.txtshu = new System.Windows.Forms.TextBox();
            this.lblts = new System.Windows.Forms.Label();
            this.lblbt = new System.Windows.Forms.Label();
            this.btntj = new System.Windows.Forms.Button();
            this.btncxks = new System.Windows.Forms.Button();
            this.btnks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 360);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picMin);
            this.panel2.Controls.Add(this.picExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 70);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frmcsz_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frmcsz_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frmcsz_MouseUp);
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Transparent;
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::Virus.Properties.Resources.Mi;
            this.picMin.Location = new System.Drawing.Point(522, 11);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(20, 20);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMin.TabIndex = 8;
            this.picMin.TabStop = false;
            this.picMin.Visible = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            this.picMin.MouseLeave += new System.EventHandler(this.picMin_MouseLeave);
            this.picMin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMin_MouseMove);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::Virus.Properties.Resources.exit;
            this.picExit.Location = new System.Drawing.Point(568, 11);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(20, 20);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            this.picExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picExit_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "  猜数字";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frmcsz_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frmcsz_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frmcsz_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lbljihui);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblcishu);
            this.panel3.Controls.Add(this.lblguan);
            this.panel3.Controls.Add(this.txtshu);
            this.panel3.Controls.Add(this.lblts);
            this.panel3.Controls.Add(this.lblbt);
            this.panel3.Controls.Add(this.btntj);
            this.panel3.Controls.Add(this.btncxks);
            this.panel3.Controls.Add(this.btnks);
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 250);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(460, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 10F);
            this.label11.Location = new System.Drawing.Point(87, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 14);
            this.label11.TabIndex = 11;
            this.label11.Text = "次机会";
            // 
            // lbljihui
            // 
            this.lbljihui.AutoSize = true;
            this.lbljihui.BackColor = System.Drawing.Color.Transparent;
            this.lbljihui.Font = new System.Drawing.Font("宋体", 10F);
            this.lbljihui.Location = new System.Drawing.Point(70, 106);
            this.lbljihui.Name = "lbljihui";
            this.lbljihui.Size = new System.Drawing.Size(21, 14);
            this.lbljihui.TabIndex = 11;
            this.lbljihui.Text = "24";
            this.lbljihui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 10F);
            this.label9.Location = new System.Drawing.Point(37, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "共有";
            // 
            // lblcishu
            // 
            this.lblcishu.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.lblcishu.ForeColor = System.Drawing.Color.Red;
            this.lblcishu.Location = new System.Drawing.Point(203, 4);
            this.lblcishu.Name = "lblcishu";
            this.lblcishu.Size = new System.Drawing.Size(198, 23);
            this.lblcishu.TabIndex = 9;
            this.lblcishu.Text = "你有24次机会";
            this.lblcishu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblguan
            // 
            this.lblguan.AutoSize = true;
            this.lblguan.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.lblguan.ForeColor = System.Drawing.Color.Black;
            this.lblguan.Location = new System.Drawing.Point(46, 70);
            this.lblguan.Name = "lblguan";
            this.lblguan.Size = new System.Drawing.Size(68, 22);
            this.lblguan.TabIndex = 7;
            this.lblguan.Text = "第1关";
            // 
            // txtshu
            // 
            this.txtshu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtshu.Enabled = false;
            this.txtshu.Font = new System.Drawing.Font("宋体", 17F, System.Drawing.FontStyle.Bold);
            this.txtshu.Location = new System.Drawing.Point(203, 169);
            this.txtshu.MaxLength = 3;
            this.txtshu.Multiline = true;
            this.txtshu.Name = "txtshu";
            this.txtshu.Size = new System.Drawing.Size(198, 30);
            this.txtshu.TabIndex = 4;
            this.txtshu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblts
            // 
            this.lblts.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lblts.ForeColor = System.Drawing.Color.Red;
            this.lblts.Location = new System.Drawing.Point(203, 70);
            this.lblts.Name = "lblts";
            this.lblts.Size = new System.Drawing.Size(198, 49);
            this.lblts.TabIndex = 6;
            this.lblts.Text = "提示";
            this.lblts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbt
            // 
            this.lblbt.AutoSize = true;
            this.lblbt.Font = new System.Drawing.Font("宋体", 10F);
            this.lblbt.Location = new System.Drawing.Point(211, 152);
            this.lblbt.Name = "lblbt";
            this.lblbt.Size = new System.Drawing.Size(182, 14);
            this.lblbt.TabIndex = 6;
            this.lblbt.Text = "请输入一个0-100之间的整数";
            // 
            // btntj
            // 
            this.btntj.BackColor = System.Drawing.Color.Transparent;
            this.btntj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntj.Enabled = false;
            this.btntj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btntj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btntj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btntj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntj.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btntj.ForeColor = System.Drawing.Color.Black;
            this.btntj.Location = new System.Drawing.Point(253, 208);
            this.btntj.Name = "btntj";
            this.btntj.Size = new System.Drawing.Size(100, 30);
            this.btntj.TabIndex = 3;
            this.btntj.TabStop = false;
            this.btntj.Text = "确定";
            this.btntj.UseVisualStyleBackColor = false;
            this.btntj.Click += new System.EventHandler(this.btntj_Click);
            // 
            // btncxks
            // 
            this.btncxks.BackColor = System.Drawing.Color.Transparent;
            this.btncxks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncxks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncxks.Enabled = false;
            this.btncxks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncxks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncxks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncxks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncxks.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btncxks.ForeColor = System.Drawing.Color.Black;
            this.btncxks.Location = new System.Drawing.Point(34, 208);
            this.btncxks.Name = "btncxks";
            this.btncxks.Size = new System.Drawing.Size(100, 30);
            this.btncxks.TabIndex = 3;
            this.btncxks.TabStop = false;
            this.btncxks.Text = "重新开始";
            this.btncxks.UseVisualStyleBackColor = false;
            this.btncxks.Click += new System.EventHandler(this.btncxks_Click);
            // 
            // btnks
            // 
            this.btnks.BackColor = System.Drawing.Color.Transparent;
            this.btnks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnks.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btnks.ForeColor = System.Drawing.Color.Black;
            this.btnks.Location = new System.Drawing.Point(460, 208);
            this.btnks.Name = "btnks";
            this.btnks.Size = new System.Drawing.Size(100, 30);
            this.btnks.TabIndex = 3;
            this.btnks.Text = "开始";
            this.btnks.UseVisualStyleBackColor = false;
            this.btnks.Click += new System.EventHandler(this.btnks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Virus.Properties.Resources.JianBian;
            this.pictureBox1.Location = new System.Drawing.Point(0, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timer5
            // 
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Frmcsz
            // 
            this.AcceptButton = this.btntj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Virus.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmcsz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmcsz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmcsz_FormClosed);
            this.Load += new System.EventHandler(this.Frmcsz_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnks;
        private System.Windows.Forms.TextBox txtshu;
        private System.Windows.Forms.Label lblbt;
        private System.Windows.Forms.Label lblts;
        private System.Windows.Forms.Button btntj;
        private System.Windows.Forms.Button btncxks;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label lblguan;
        private System.Windows.Forms.Label lblcishu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbljihui;
        private System.Windows.Forms.Label label9;
    }
}