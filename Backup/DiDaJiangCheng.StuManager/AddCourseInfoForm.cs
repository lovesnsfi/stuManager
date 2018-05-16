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
    public partial class AddCourseInfoForm : BaseForm
    {
        public AddCourseInfoForm()
        {
            InitializeComponent();
            this.cboxSemester.SelectedIndex = 0;
        }

        private FormStatus fs;
        public FormStatus FS
        {
            get
            {
                return fs;
            }
            set
            {
                if (value==FormStatus.Add)
                {
                    this.labelTitle.Text = "◆新增课程";
                }
                else if (value==FormStatus.Update)
                {
                    this.labelTitle.Text = "◆修改课程";
                }
                fs = value;
            }
        }
        private int CourseId;
        public AddCourseInfoForm(FormStatus _fs,int? courseId):this()
        {
            this.FS = _fs;
            if (courseId.HasValue)
            {
                this.CourseId = courseId.Value;
            }
            else
            {
                this.CourseId = 0;
            }
        }

        private void AddCourseInfoForm_Load(object sender, EventArgs e)
        {
            //绑定班级
            DataSet ds_Class = new BLL.tbClassInfo().GetAllList();
            this.cboxClassId.DataSource = ds_Class.Tables[0];
            this.cboxClassId.DisplayMember = "ClassName";
            this.cboxClassId.ValueMember = "ClassId";

            //如果是修改，则绑定数据
            if (this.FS==FormStatus.Update)
            {
                Model.tbCourseInfo model = new BLL.tbCourseInfo().GetModel(this.CourseId);
                if (model!=null)
                {
                    this.txtCourseId.Text = model.CourseId.ToString();
                    this.txtCourseName.Text = model.CourseName;
                    this.cboxClassId.SelectedValue = model.ClassId;
                    this.cboxSemester.Text = model.Semester;
                }
                else
                {
                    MessageBox.Show("该条记录不存在，请确认");
                    this.Close();
                }
            }
        }

        //保存
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool flag = Common.FormHelp.CheckTextBox(this.panel1.Controls, this.txtCourseId);
            if (!flag)
            {
                MessageBox.Show("请将信息输入完整");
                return;
            }
            Model.tbCourseInfo model = new Model.tbCourseInfo();
            model.CourseName = this.txtCourseName.Text.Trim();
            model.ClassId = int.Parse(this.cboxClassId.SelectedValue.ToString());
            model.Semester = this.cboxSemester.Text;

            bool SaveStatus = false;
            try
            {
                if (this.FS==FormStatus.Add)
                {
                    int rows = new BLL.tbCourseInfo().Add(model);
                    this.txtCourseId.Text = rows.ToString();
                    SaveStatus = true;
                }
                else if (this.FS==FormStatus.Update)
                {
                    model.CourseId = int.Parse(this.txtCourseId.Text.Trim());
                    SaveStatus = new BLL.tbCourseInfo().Update(model);

                }
                if (SaveStatus)
                {
                    MessageBox.Show("保存成功");
                    //将状态改为修改状态
                    this.FS = FormStatus.Update;
                }
                else
                {
                    MessageBox.Show("保存失败");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
