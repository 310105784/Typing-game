namespace Virus.gongNeng
{
    partial class Frmxycj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmxycj));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstcjjp = new System.Windows.Forms.ListBox();
            this.lstwdjp = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncj = new System.Windows.Forms.Button();
            this.lbljp = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(700, 400);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picMin);
            this.panel2.Controls.Add(this.picExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 70);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frmxycj_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frmxycj_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frmxycj_MouseUp);
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Transparent;
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::Virus.Properties.Resources.Mi;
            this.picMin.Location = new System.Drawing.Point(634, 11);
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
            this.picExit.Location = new System.Drawing.Point(667, 11);
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
            this.label1.Size = new System.Drawing.Size(698, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "  幸运抽奖";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frmxycj_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frmxycj_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frmxycj_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.lstcjjp);
            this.panel3.Controls.Add(this.lstwdjp);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btncj);
            this.panel3.Controls.Add(this.lbljp);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 290);
            this.panel3.TabIndex = 6;
            // 
            // lstcjjp
            // 
            this.lstcjjp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstcjjp.Font = new System.Drawing.Font("宋体", 11F);
            this.lstcjjp.ForeColor = System.Drawing.Color.Black;
            this.lstcjjp.HorizontalScrollbar = true;
            this.lstcjjp.IntegralHeight = false;
            this.lstcjjp.ItemHeight = 15;
            this.lstcjjp.Items.AddRange(new object[] {
            " "});
            this.lstcjjp.Location = new System.Drawing.Point(39, 62);
            this.lstcjjp.Name = "lstcjjp";
            this.lstcjjp.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstcjjp.Size = new System.Drawing.Size(120, 126);
            this.lstcjjp.TabIndex = 7;
            // 
            // lstwdjp
            // 
            this.lstwdjp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstwdjp.Font = new System.Drawing.Font("宋体", 12F);
            this.lstwdjp.ForeColor = System.Drawing.Color.Black;
            this.lstwdjp.HorizontalScrollbar = true;
            this.lstwdjp.IntegralHeight = false;
            this.lstwdjp.ItemHeight = 16;
            this.lstwdjp.Items.AddRange(new object[] {
            " "});
            this.lstwdjp.Location = new System.Drawing.Point(541, 62);
            this.lstwdjp.Name = "lstwdjp";
            this.lstwdjp.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstwdjp.Size = new System.Drawing.Size(120, 120);
            this.lstwdjp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(535, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "我的奖品";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(32, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "抽奖奖品";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncj
            // 
            this.btncj.BackColor = System.Drawing.Color.Transparent;
            this.btncj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncj.BackgroundImage")));
            this.btncj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncj.FlatAppearance.BorderSize = 0;
            this.btncj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncj.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.btncj.ForeColor = System.Drawing.Color.White;
            this.btncj.Location = new System.Drawing.Point(292, 226);
            this.btncj.Name = "btncj";
            this.btncj.Size = new System.Drawing.Size(112, 34);
            this.btncj.TabIndex = 3;
            this.btncj.Text = "开始";
            this.btncj.UseVisualStyleBackColor = false;
            this.btncj.Click += new System.EventHandler(this.btncj_Click);
            // 
            // lbljp
            // 
            this.lbljp.BackColor = System.Drawing.Color.Transparent;
            this.lbljp.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold);
            this.lbljp.Location = new System.Drawing.Point(257, 112);
            this.lbljp.Name = "lbljp";
            this.lbljp.Size = new System.Drawing.Size(181, 38);
            this.lbljp.TabIndex = 2;
            this.lbljp.Text = "笔记本";
            this.lbljp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Virus.Properties.Resources.choJiangBianKuang;
            this.pictureBox6.Location = new System.Drawing.Point(189, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pictureBox6.Size = new System.Drawing.Size(320, 200);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(508, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(179, 228);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Virus.Properties.Resources.JianBian;
            this.pictureBox1.Location = new System.Drawing.Point(0, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Frmxycj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Virus.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmxycj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmxycj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmxycj_FormClosed);
            this.Load += new System.EventHandler(this.Frmxycj_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbljp;
        private System.Windows.Forms.Button btncj;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox lstwdjp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstcjjp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer5;
    }
}