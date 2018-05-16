namespace DiDaJiangCheng.StuManager
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUserName = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelDrawdownList = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReLogin = new System.Windows.Forms.Button();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.btnStuManager = new System.Windows.Forms.Button();
            this.btnClassManager = new System.Windows.Forms.Button();
            this.btnSpecialtyManager = new System.Windows.Forms.Button();
            this.btnCourseManager = new System.Windows.Forms.Button();
            this.btnSourceManager = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelUserName.SuspendLayout();
            this.panelDrawdownList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picMini
            // 
            this.picMini.Location = new System.Drawing.Point(869, 1);
            // 
            // picClose
            // 
            this.picClose.Location = new System.Drawing.Point(895, 1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "学生学籍管理系统";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(84)))), ((int)(((byte)(79)))), ((int)(((byte)(84)))));
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Location = new System.Drawing.Point(2, 554);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(919, 40);
            this.panelBottom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(268, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "版权信息：武汉·杨标版权所有";
            // 
            // panelUserName
            // 
            this.panelUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelUserName.Controls.Add(this.labelUserName);
            this.panelUserName.Location = new System.Drawing.Point(766, 36);
            this.panelUserName.Name = "panelUserName";
            this.panelUserName.Size = new System.Drawing.Size(135, 37);
            this.panelUserName.TabIndex = 8;
            this.panelUserName.Click += new System.EventHandler(this.panelUserName_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(12, 6);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(140, 32);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "系统管理员";
            this.labelUserName.Click += new System.EventHandler(this.panelUserName_Click);
            // 
            // panelDrawdownList
            // 
            this.panelDrawdownList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDrawdownList.Controls.Add(this.btnExit);
            this.panelDrawdownList.Controls.Add(this.btnReLogin);
            this.panelDrawdownList.Controls.Add(this.btnChangePwd);
            this.panelDrawdownList.Location = new System.Drawing.Point(766, 76);
            this.panelDrawdownList.Name = "panelDrawdownList";
            this.panelDrawdownList.Size = new System.Drawing.Size(135, 130);
            this.panelDrawdownList.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(7, 87);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 37);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "退出系统";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReLogin
            // 
            this.btnReLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnReLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReLogin.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnReLogin.ForeColor = System.Drawing.Color.White;
            this.btnReLogin.Location = new System.Drawing.Point(7, 47);
            this.btnReLogin.Name = "btnReLogin";
            this.btnReLogin.Size = new System.Drawing.Size(119, 37);
            this.btnReLogin.TabIndex = 0;
            this.btnReLogin.Text = "重新登陆";
            this.btnReLogin.UseVisualStyleBackColor = false;
            this.btnReLogin.Click += new System.EventHandler(this.btnReLogin_Click);
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePwd.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnChangePwd.ForeColor = System.Drawing.Color.White;
            this.btnChangePwd.Location = new System.Drawing.Point(7, 7);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(119, 37);
            this.btnChangePwd.TabIndex = 0;
            this.btnChangePwd.Text = "修改密码";
            this.btnChangePwd.UseVisualStyleBackColor = false;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // btnStuManager
            // 
            this.btnStuManager.BackgroundImage = global::DiDaJiangCheng.StuManager.Properties.Resources.Student;
            this.btnStuManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStuManager.Location = new System.Drawing.Point(574, 149);
            this.btnStuManager.Name = "btnStuManager";
            this.btnStuManager.Size = new System.Drawing.Size(207, 103);
            this.btnStuManager.TabIndex = 9;
            this.btnStuManager.UseVisualStyleBackColor = true;
            this.btnStuManager.Click += new System.EventHandler(this.btnStuManager_Click);
            // 
            // btnClassManager
            // 
            this.btnClassManager.BackgroundImage = global::DiDaJiangCheng.StuManager.Properties.Resources.ClassManager;
            this.btnClassManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClassManager.Location = new System.Drawing.Point(355, 149);
            this.btnClassManager.Name = "btnClassManager";
            this.btnClassManager.Size = new System.Drawing.Size(207, 103);
            this.btnClassManager.TabIndex = 9;
            this.btnClassManager.UseVisualStyleBackColor = true;
            this.btnClassManager.Click += new System.EventHandler(this.btnClassManager_Click);
            // 
            // btnSpecialtyManager
            // 
            this.btnSpecialtyManager.BackgroundImage = global::DiDaJiangCheng.StuManager.Properties.Resources.ProManager;
            this.btnSpecialtyManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpecialtyManager.Location = new System.Drawing.Point(136, 149);
            this.btnSpecialtyManager.Name = "btnSpecialtyManager";
            this.btnSpecialtyManager.Size = new System.Drawing.Size(207, 103);
            this.btnSpecialtyManager.TabIndex = 9;
            this.btnSpecialtyManager.UseVisualStyleBackColor = true;
            this.btnSpecialtyManager.Click += new System.EventHandler(this.btnSpecialtyManager_Click);
            // 
            // btnCourseManager
            // 
            this.btnCourseManager.BackgroundImage = global::DiDaJiangCheng.StuManager.Properties.Resources.课程管理;
            this.btnCourseManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCourseManager.Location = new System.Drawing.Point(136, 269);
            this.btnCourseManager.Name = "btnCourseManager";
            this.btnCourseManager.Size = new System.Drawing.Size(207, 103);
            this.btnCourseManager.TabIndex = 9;
            this.btnCourseManager.UseVisualStyleBackColor = true;
            this.btnCourseManager.Click += new System.EventHandler(this.btnCourseManager_Click);
            // 
            // btnSourceManager
            // 
            this.btnSourceManager.BackgroundImage = global::DiDaJiangCheng.StuManager.Properties.Resources.成绩管理;
            this.btnSourceManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSourceManager.Location = new System.Drawing.Point(355, 269);
            this.btnSourceManager.Name = "btnSourceManager";
            this.btnSourceManager.Size = new System.Drawing.Size(207, 103);
            this.btnSourceManager.TabIndex = 9;
            this.btnSourceManager.UseVisualStyleBackColor = true;
            this.btnSourceManager.Click += new System.EventHandler(this.btnSourceManager_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DiDaJiangCheng.StuManager.Properties.Resources.LogoWhite;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiDaJiangCheng.StuManager.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(919, 594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCourseManager);
            this.Controls.Add(this.btnSpecialtyManager);
            this.Controls.Add(this.btnSourceManager);
            this.Controls.Add(this.btnClassManager);
            this.Controls.Add(this.btnStuManager);
            this.Controls.Add(this.panelDrawdownList);
            this.Controls.Add(this.panelUserName);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.label2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.panelBottom, 0);
            this.Controls.SetChildIndex(this.panelUserName, 0);
            this.Controls.SetChildIndex(this.panelDrawdownList, 0);
            this.Controls.SetChildIndex(this.picMini, 0);
            this.Controls.SetChildIndex(this.picClose, 0);
            this.Controls.SetChildIndex(this.btnStuManager, 0);
            this.Controls.SetChildIndex(this.btnClassManager, 0);
            this.Controls.SetChildIndex(this.btnSourceManager, 0);
            this.Controls.SetChildIndex(this.btnSpecialtyManager, 0);
            this.Controls.SetChildIndex(this.btnCourseManager, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelUserName.ResumeLayout(false);
            this.panelUserName.PerformLayout();
            this.panelDrawdownList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Panel panelDrawdownList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReLogin;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.Button btnStuManager;
        private System.Windows.Forms.Button btnClassManager;
        private System.Windows.Forms.Button btnSpecialtyManager;
        private System.Windows.Forms.Button btnCourseManager;
        private System.Windows.Forms.Button btnSourceManager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}