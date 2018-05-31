using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Threading;

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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(() =>
            {
                DiDaJiangCheng.Common.WebClient wc = new Common.WebClient();
                string html = wc.GetHtml("http://www.softeem.xin/stuManager/updateInfo.json");
                dynamic jo = JObject.Parse(html);
                //获取当前程序版本信息
                int currentVersionNumber = int.Parse(Application.ProductVersion.Replace(".", ""));
                //获取远程服务器版本信息
                int serverVersionNumber = int.Parse(((string)jo.version).Replace(".", ""));
                MessageBox.Show(currentVersionNumber+"---"+serverVersionNumber);
                if (serverVersionNumber > currentVersionNumber)
                {
                    //如果服务器版本号大于当前程序版本号
                    if (MessageBox.Show("当前程序有新版本，是否更新至最新版", "更新提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Process.Start(Application.StartupPath + @"\DiDaJiangCheng.Update.exe");
                        this.Close();
                    }

                }
            })).Start();
            
        }

 
    }
}
