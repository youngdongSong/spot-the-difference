namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJoin = new System.Windows.Forms.LinkLabel();
            this.lblMail = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.정보IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비밀번호찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원가입ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.피드백ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPwdFind = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.회원가입ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.메일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(162, 294);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(159, 25);
            this.txtId.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(346, 294);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 70);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(90, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(71, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "패스워드";
            // 
            // lblJoin
            // 
            this.lblJoin.AutoSize = true;
            this.lblJoin.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblJoin.Location = new System.Drawing.Point(265, 387);
            this.lblJoin.Name = "lblJoin";
            this.lblJoin.Size = new System.Drawing.Size(89, 20);
            this.lblJoin.TabIndex = 4;
            this.lblJoin.TabStop = true;
            this.lblJoin.Text = "회원가입";
            this.lblJoin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMail.Location = new System.Drawing.Point(148, 259);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(186, 19);
            this.lblMail.TabIndex = 5;
            this.lblMail.TabStop = true;
            this.lblMail.Text = "sos9493@naver.com";
            this.lblMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보IToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 정보IToolStripMenuItem
            // 
            this.정보IToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.비밀번호찾기ToolStripMenuItem,
            this.회원가입ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.피드백ToolStripMenuItem,
            this.닫기ToolStripMenuItem});
            this.정보IToolStripMenuItem.Name = "정보IToolStripMenuItem";
            this.정보IToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.정보IToolStripMenuItem.Text = "정보(&I)";
            // 
            // 비밀번호찾기ToolStripMenuItem
            // 
            this.비밀번호찾기ToolStripMenuItem.Name = "비밀번호찾기ToolStripMenuItem";
            this.비밀번호찾기ToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.비밀번호찾기ToolStripMenuItem.Text = "비밀번호 찾기(&F)";
            this.비밀번호찾기ToolStripMenuItem.Click += new System.EventHandler(this.비밀번호찾기ToolStripMenuItem_Click);
            // 
            // 회원가입ToolStripMenuItem
            // 
            this.회원가입ToolStripMenuItem.Name = "회원가입ToolStripMenuItem";
            this.회원가입ToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.회원가입ToolStripMenuItem.Text = "회원가입(&J)";
            this.회원가입ToolStripMenuItem.Click += new System.EventHandler(this.회원가입ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // 피드백ToolStripMenuItem
            // 
            this.피드백ToolStripMenuItem.Name = "피드백ToolStripMenuItem";
            this.피드백ToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.피드백ToolStripMenuItem.Text = "메일(&M)";
            this.피드백ToolStripMenuItem.Click += new System.EventHandler(this.피드백ToolStripMenuItem_Click);
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.닫기ToolStripMenuItem.Text = "닫기(&C)";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보ToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            this.도움말HToolStripMenuItem.Click += new System.EventHandler(this.도움말HToolStripMenuItem_Click);
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.정보ToolStripMenuItem.Text = "도움말";
            this.정보ToolStripMenuItem.Click += new System.EventHandler(this.정보ToolStripMenuItem_Click);
            // 
            // lblPwdFind
            // 
            this.lblPwdFind.AutoSize = true;
            this.lblPwdFind.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPwdFind.Location = new System.Drawing.Point(109, 387);
            this.lblPwdFind.Name = "lblPwdFind";
            this.lblPwdFind.Size = new System.Drawing.Size(136, 20);
            this.lblPwdFind.TabIndex = 7;
            this.lblPwdFind.TabStop = true;
            this.lblPwdFind.Text = "비밀번호 찾기";
            this.lblPwdFind.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(162, 339);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(159, 25);
            this.txtPwd.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원가입ToolStripMenuItem1,
            this.메일ToolStripMenuItem,
            this.닫기ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 76);
            // 
            // 회원가입ToolStripMenuItem1
            // 
            this.회원가입ToolStripMenuItem1.Name = "회원가입ToolStripMenuItem1";
            this.회원가입ToolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.회원가입ToolStripMenuItem1.Text = "회원가입";
            this.회원가입ToolStripMenuItem1.Click += new System.EventHandler(this.회원가입ToolStripMenuItem_Click);
            // 
            // 메일ToolStripMenuItem
            // 
            this.메일ToolStripMenuItem.Name = "메일ToolStripMenuItem";
            this.메일ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.메일ToolStripMenuItem.Text = "메일";
            this.메일ToolStripMenuItem.Click += new System.EventHandler(this.피드백ToolStripMenuItem_Click);
            // 
            // 닫기ToolStripMenuItem1
            // 
            this.닫기ToolStripMenuItem1.Name = "닫기ToolStripMenuItem1";
            this.닫기ToolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.닫기ToolStripMenuItem1.Text = "닫기";
            this.닫기ToolStripMenuItem1.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 440);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPwdFind);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblJoin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblJoin;
        private System.Windows.Forms.LinkLabel lblMail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 정보IToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lblPwdFind;
        private System.Windows.Forms.ToolStripMenuItem 비밀번호찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원가입ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 피드백ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 회원가입ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 메일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem1;
    }
}

