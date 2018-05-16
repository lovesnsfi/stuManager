using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiDaJiangCheng.StuManager
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            initialForm();
        }
        public static string UserName=string.Empty;   //全局静态变量用于存放当前登陆的用户名

        /// <summary>
        /// 初始化屏幕组件
        /// </summary>
        private void initialForm()
        {
            //底部的panel设置为背景透明   直接在前台更改了
            //this.panelBottom.BackColor = Color.FromArgb(80, 84, 79, 84);
            //用户Panel的背景色
            // this.panelUserName.BackColor = Color.FromArgb(80, 0,0,0);
            this.panelUserName.Cursor = Cursors.Hand;
            //用户的姓名居中
            this.labelUserName.Text = MainForm.UserName;
            this.labelUserName.Location = new Point((this.panelUserName.Width - this.labelUserName.Width) / 2, 
                (this.panelUserName.Height-this.labelUserName.Height)/2);
            
            //下拉框的显示
            // this.panelDrawdownList.BackColor = Color.FromArgb(80, 0, 0, 0);
            this.panelDrawdownList.Visible = false; //默认不显示
        }


        //重写退出的方法
        public override void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //单击用户名面板以后的事件
        private void panelUserName_Click(object sender, EventArgs e)
        {
            if (this.panelDrawdownList.Visible==false)
            {
                this.panelDrawdownList.Visible = true;
            }
            else
            {
                this.panelDrawdownList.Visible = false;
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //重新登陆
        private void btnReLogin_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //修改密码
        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            ChangePwdForm frm = new ChangePwdForm();
            frm.Show();
        }


        //专业管理
        private void btnSpecialtyManager_Click(object sender, EventArgs e)
        {
            SpecialtyForm frm = new SpecialtyForm();
            frm.Show();
        }

        //班级管理
        private void btnClassManager_Click(object sender, EventArgs e)
        {
            ClassForm frm = new ClassForm();
            frm.Show();
        }

        //学生管理 
        private void btnStuManager_Click(object sender, EventArgs e)
        {
            StudentInfoForm frm = new StudentInfoForm();
            frm.Show();
        }

        //课程管理
        private void btnCourseManager_Click(object sender, EventArgs e)
        {
            CourseInfoForm frm = new CourseInfoForm();
            frm.Show();
            
        }

        //成绩管理
        private void btnSourceManager_Click(object sender, EventArgs e)
        {
            ScoreInfoForm frm = new ScoreInfoForm();
            frm.Show();
        }
    }
}
