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
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        

        //登陆事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空");
            }
            else if (string.IsNullOrEmpty(this.txtPassWord.Text.Trim()))
            {
                MessageBox.Show("密码不能为空");
            }
            else
            {
                DataTable dt = new BLL.tbUserInfo().CheckLogin(this.txtUserName.Text.Trim(), this.txtPassWord.Text.Trim());
                if (dt!=null&&dt.Rows.Count==1)
                {
                    MessageBox.Show("登陆成功");
                    MainForm.UserName = this.txtUserName.Text.Trim();
                    MainForm mf = new MainForm();
                    this.Hide();
                    mf.Show();

                }
                else
                {
                    MessageBox.Show("用户名或密码不正确 ，请重试");
                    this.txtPassWord.Clear();
                }
            }
        }

        /// <summary>
        /// 取消登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
    }
}
