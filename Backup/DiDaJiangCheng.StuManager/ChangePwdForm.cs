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
    public partial class ChangePwdForm : BaseForm
    {
        public ChangePwdForm()
        {
            InitializeComponent();

            base.picClose.Location = new Point(this.Width - base.picClose.Width, 0);
            base.picMini.Location = new Point(this.Width - base.picClose.Width - base.picMini.Width, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePwdForm_Load(object sender, EventArgs e)
        {
            this.txtUserName.Text = MainForm.UserName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //检查信息是否输入完整
            foreach (Control ctr in this.panel1.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox tbox = ctr as TextBox;
                    if (string.IsNullOrEmpty(tbox.Text.Trim()))
                    {
                        MessageBox.Show("请将信息输入完整 ");
                        return;
                    }
                }
            }
            Model.tbUserInfo model = new BLL.tbUserInfo().GetModel(MainForm.UserName);
            if (this.txtNewPassWord.Text.Trim()!=this.txtSecondPassWord.Text.Trim())
            {
                MessageBox.Show("两次密码不正确 ，请确认");
                return;
            }
            if (model.UserPassword!=this.txtPassword.Text.Trim())
            {
                MessageBox.Show("旧密码不正确，请确认");
            }
            else
            {
                model.UserPassword = this.txtNewPassWord.Text.Trim();
                if (new BLL.tbUserInfo().Update(model))
                {
                    MessageBox.Show("密码修改成功");
                    this.txtPassword.Clear();
                    this.txtNewPassWord.Clear();
                    this.txtSecondPassWord.Clear();
                }
                else
                {
                    MessageBox.Show("密码修改失败");
                }
            }
        }
    }
}
