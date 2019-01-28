namespace Final_Project
{
    partial class TimeUp
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
            this.lblIdInfo = new System.Windows.Forms.Label();
            this.lblPointInfo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdInfo
            // 
            this.lblIdInfo.AutoSize = true;
            this.lblIdInfo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIdInfo.Location = new System.Drawing.Point(88, 113);
            this.lblIdInfo.Name = "lblIdInfo";
            this.lblIdInfo.Size = new System.Drawing.Size(88, 20);
            this.lblIdInfo.TabIndex = 0;
            this.lblIdInfo.Text = "아이디 :";
            // 
            // lblPointInfo
            // 
            this.lblPointInfo.AutoSize = true;
            this.lblPointInfo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPointInfo.Location = new System.Drawing.Point(109, 158);
            this.lblPointInfo.Name = "lblPointInfo";
            this.lblPointInfo.Size = new System.Drawing.Size(67, 20);
            this.lblPointInfo.TabIndex = 0;
            this.lblPointInfo.Text = "점수 :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblId.Location = new System.Drawing.Point(182, 113);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 1;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPoint.Location = new System.Drawing.Point(182, 158);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(0, 20);
            this.lblPoint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(51, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "시간이 초과되었습니다";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(122, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimeUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPointInfo);
            this.Controls.Add(this.lblIdInfo);
            this.Name = "TimeUp";
            this.Text = "시간 초과";
            this.Load += new System.EventHandler(this.TimeUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdInfo;
        private System.Windows.Forms.Label lblPointInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}