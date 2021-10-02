namespace Virus.gongNeng
{
    partial class Frmdzcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdzcs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblfen = new System.Windows.Forms.Label();
            this.lblmiao = new System.Windows.Forms.Label();
            this.piczt = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.piccxks = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picJianPan = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblword = new System.Windows.Forms.Label();
            this.rictxtword = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piczt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccxks)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJianPan)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(860, 540);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picMin);
            this.panel2.Controls.Add(this.picExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 70);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frmdzcs_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frmdzcs_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frmdzcs_MouseUp);
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Transparent;
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::Virus.Properties.Resources.Mi;
            this.picMin.Location = new System.Drawing.Point(763, 11);
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
            this.picExit.Location = new System.Drawing.Point(827, 11);
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
            this.label1.Size = new System.Drawing.Size(839, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "  打字测试";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frmdzcs_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frmdzcs_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frmdzcs_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 429);
            this.panel3.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::Virus.Properties.Resources.Dazisjsd;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.lblfen);
            this.panel6.Controls.Add(this.lblmiao);
            this.panel6.Controls.Add(this.piczt);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.piccxks);
            this.panel6.Location = new System.Drawing.Point(295, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(257, 30);
            this.panel6.TabIndex = 5;
            // 
            // lblfen
            // 
            this.lblfen.Font = new System.Drawing.Font("宋体", 10F);
            this.lblfen.ForeColor = System.Drawing.Color.Tomato;
            this.lblfen.Location = new System.Drawing.Point(88, 9);
            this.lblfen.Name = "lblfen";
            this.lblfen.Size = new System.Drawing.Size(22, 15);
            this.lblfen.TabIndex = 1;
            this.lblfen.Text = "00";
            this.lblfen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblmiao
            // 
            this.lblmiao.Font = new System.Drawing.Font("宋体", 10F);
            this.lblmiao.ForeColor = System.Drawing.Color.Tomato;
            this.lblmiao.Location = new System.Drawing.Point(115, 9);
            this.lblmiao.Name = "lblmiao";
            this.lblmiao.Size = new System.Drawing.Size(22, 15);
            this.lblmiao.TabIndex = 1;
            this.lblmiao.Text = "00";
            this.lblmiao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // piczt
            // 
            this.piczt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piczt.Image = global::Virus.Properties.Resources.Dazizanting;
            this.piczt.Location = new System.Drawing.Point(192, 2);
            this.piczt.Name = "piczt";
            this.piczt.Size = new System.Drawing.Size(25, 25);
            this.piczt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piczt.TabIndex = 3;
            this.piczt.TabStop = false;
            this.piczt.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "时间";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(108, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(8, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = ":";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Virus.Properties.Resources.Dazishijian;
            this.pictureBox4.Location = new System.Drawing.Point(39, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // piccxks
            // 
            this.piccxks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piccxks.Image = global::Virus.Properties.Resources.Dazichongxinkais;
            this.piccxks.Location = new System.Drawing.Point(153, 2);
            this.piccxks.Name = "piccxks";
            this.piccxks.Size = new System.Drawing.Size(25, 25);
            this.piccxks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccxks.TabIndex = 3;
            this.piccxks.TabStop = false;
            this.piccxks.Click += new System.EventHandler(this.piccxks_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.picJianPan);
            this.panel5.Location = new System.Drawing.Point(36, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(790, 265);
            this.panel5.TabIndex = 2;
            // 
            // picJianPan
            // 
            this.picJianPan.Image = global::Virus.Properties.Resources.jianpan;
            this.picJianPan.Location = new System.Drawing.Point(7, 9);
            this.picJianPan.Name = "picJianPan";
            this.picJianPan.Size = new System.Drawing.Size(775, 248);
            this.picJianPan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJianPan.TabIndex = 0;
            this.picJianPan.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Virus.Properties.Resources.daZiCeShiwbk;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lblword);
            this.panel4.Controls.Add(this.rictxtword);
            this.panel4.Location = new System.Drawing.Point(36, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(790, 78);
            this.panel4.TabIndex = 1;
            // 
            // lblword
            // 
            this.lblword.BackColor = System.Drawing.Color.White;
            this.lblword.Font = new System.Drawing.Font("宋体", 18F);
            this.lblword.ForeColor = System.Drawing.Color.Black;
            this.lblword.Location = new System.Drawing.Point(2, 3);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(786, 35);
            this.lblword.TabIndex = 1;
            this.lblword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rictxtword
            // 
            this.rictxtword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rictxtword.Font = new System.Drawing.Font("宋体", 18F);
            new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            rictxtword.LanguageOption = System.Windows.Forms.RichTextBoxLanguageOptions.UIFonts;
            this.rictxtword.ForeColor = System.Drawing.Color.Gray;
            this.rictxtword.Location = new System.Drawing.Point(6, 40);
            this.rictxtword.MaxLength = 60;
            this.rictxtword.Multiline = false;
            this.rictxtword.Name = "rictxtword";
            this.rictxtword.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rictxtword.Size = new System.Drawing.Size(782, 35);
            this.rictxtword.TabIndex = 0;
            this.rictxtword.Text = "";
            this.rictxtword.WordWrap = false;
            this.rictxtword.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            this.rictxtword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rictxtword_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Virus.Properties.Resources.JianBian;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(859, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Frmdzcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Virus.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmdzcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmdzcs";
            this.Load += new System.EventHandler(this.Frmdzcs_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piczt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccxks)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picJianPan)).EndInit();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rictxtword;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox picJianPan;
        private System.Windows.Forms.PictureBox piccxks;
        private System.Windows.Forms.PictureBox piczt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfen;
        private System.Windows.Forms.Label lblmiao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer5;
    }
}