using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiDaJiangCheng.StuManager
{
    public partial class AddStudentInfoForm : BaseForm
    {
        public AddStudentInfoForm()
        {
            InitializeComponent();
        }
        private FormStatus fs;
        private FormStatus FS
        {
            get
            {
                return fs;
            }
            set
            {
                if (value==FormStatus.Add)
                {
                    this.labelTitle.Text = "◆新增学生";
                }
                else if (value==FormStatus.Update)
                {
                    this.labelTitle.Text = "◆修改学生";
                }
                fs = value;
            }
        }
        private string StuNo;
        public AddStudentInfoForm(FormStatus _fs,string _StuNo):this()
        {
            this.FS = _fs;
            this.StuNo = _StuNo;
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        private void AddStudentInfoForm_Load(object sender, EventArgs e)
        {
            //绑定班级下拉框
            DataSet ds_Class = new BLL.tbClassInfo().GetAllList();
            this.cboxClassId.DataSource = ds_Class.Tables[0];
            this.cboxClassId.DisplayMember = "ClassName";
            this.cboxClassId.ValueMember = "ClassId";
            if (this.FS== FormStatus.Update)
            {

                Model.tbStudentInfo model = new BLL.tbStudentInfo().GetModel(this.StuNo);
                if (model!=null)
                {
                    this.txtStuId.Text = model.StuId.ToString();
                    this.txtStuNo.Text = model.StuNo;
                    this.txtStuName.Text = model.StuName;
                    this.cboxStuSex.Text = model.StuSex;
                    this.cboxStuNation.Text = model.StuNation;
                    this.txtStupolitics.Text = model.Stupolitics;
                    this.txtStuContact.Text = model.StuContact;
                    this.txtStuPostCode.Text = model.StuPostCode;
                    this.txtStuFamilyAddress.Text = model.StuFamilyAddress;
                    this.cboxClassId.SelectedValue = model.ClassId;
                    if (model.StuPhoto!=null&&model.StuPhoto.Length>0)
                    {
                        this.picBoxStuPhoto.Image = Image.FromStream(new System.IO.MemoryStream(model.StuPhoto));
                    }

                }
                else
                {
                    MessageBox.Show("未找到相关数据，请确认");
                    this.Close();
                }
            }
        }

        //关闭
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 选择图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = false;
            op.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff";
            if (op.ShowDialog()==DialogResult.OK)
            {
                this.picBoxStuPhoto.Image = Image.FromFile(op.FileName);
            }
        }

        private void 请除图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要清除图片吗？","请确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk)==DialogResult.OK)
            {
                this.picBoxStuPhoto.Image = null;
            }
        }

        
        
        //保存事事件
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool flag = Common.FormHelp.CheckTextBox(this.panel1.Controls, this.txtStuId);
            if (!flag)
            {
                MessageBox.Show("请将信息输入完整 ");
                return;
            }
            bool SaveStatus = false;

            Model.tbStudentInfo model = new Model.tbStudentInfo();
            model.StuNo = this.txtStuNo.Text.Trim();
            model.StuName = this.txtStuName.Text.Trim();
            model.StuSex = this.cboxStuSex.Text;
            model.StuNation = this.cboxStuNation.Text;
            model.Stupolitics = this.txtStupolitics.Text.Trim();
            model.StuContact = this.txtStuContact.Text.Trim();
            model.StuPostCode = this.txtStuPostCode.Text.Trim();
            model.StuFamilyAddress = this.txtStuFamilyAddress.Text.Trim();
            model.ClassId = int.Parse(this.cboxClassId.SelectedValue.ToString());
            if (this.picBoxStuPhoto.Image!=null)
            {
                Image img = this.picBoxStuPhoto.Image;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                model.StuPhoto = ms.ToArray();
            }
            if (this.FS==FormStatus.Add)
            {
                int id = new BLL.tbStudentInfo().Add(model);
                this.txtStuId.Text = id.ToString();
                SaveStatus = true;
            }
            else if (this.FS==FormStatus.Update)
            {
                model.StuId = int.Parse(this.txtStuId.Text.Trim());
                SaveStatus = new BLL.tbStudentInfo().Update(model);
            }
            if (SaveStatus)
            {
                MessageBox.Show("保存成功");
                this.FS = FormStatus.Update;
            }
            else
            {
                MessageBox.Show("保存失败，请重试或联系管理员");
            }
        }

        private void picBoxStuPhoto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                
            }
        }

    }
}
