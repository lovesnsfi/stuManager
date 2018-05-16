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
    public partial class AddClassForm : BaseForm
    {
        public AddClassForm()
        {
            InitializeComponent();
        }

        private FormStatus fs;
        private int ClassId;
        public FormStatus FS
        {
            get
            {
                return fs;
            }
            set
            {
                if (value == FormStatus.Add)
                {
                    this.labelTitle.Text = "◆新增班级";
                }
                else if (value == FormStatus.Update)
                {
                    this.labelTitle.Text = "◆修改班级";
                }
                fs = value;
            }
        }

        public AddClassForm(FormStatus _fs, int? _ClassId)
            : this()
        {
            this.FS = _fs;
            if (_ClassId.HasValue)
            {
                this.ClassId = _ClassId.Value;
            }
            else
            {
                this.ClassId = 0;
            }
        }

        //加载
        private void AddClass_Load(object sender, EventArgs e)
        {
            //绑定专业下拉框
            DataSet ds_Specialty = new BLL.tbSpecialtyInfo().GetAllList();
            this.cboxSpecialty.DataSource = ds_Specialty.Tables[0];
            this.cboxSpecialty.DisplayMember = "SpecialtyName";
            this.cboxSpecialty.ValueMember = "SpecialtyId";

            //加载数据 
            if (this.FS == FormStatus.Update)
            {
                Model.tbClassInfo model = new BLL.tbClassInfo().GetModel(this.ClassId);
                if (model != null)
                {
                    this.txtClassId.Text = model.ClassId.ToString();
                    this.txtClassName.Text = model.ClassName;
                    this.cboxSpecialty.SelectedValue = model.SpecialtyId.ToString();
                    this.txtClassroomId.Text = model.classroomId;
                    this.txteductionalSystem.Text = model.eductionalSystem;
                    this.TimePickerEnterTime.Value = model.enterTime;
                    this.txtMarks.Text = model.Marks;
                }
                else
                {
                    MessageBox.Show("未找到相关数据，请确认");
                }
            }
        }

        //保存
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool flag = Common.FormHelp.CheckTextBox(this.panel1.Controls, this.txtClassId, this.txtMarks);
            if (!flag)
            {
                MessageBox.Show("请将信息输入完整");
                return;
            }
            Model.tbClassInfo model = new Model.tbClassInfo();
            model.ClassName = this.txtClassName.Text.Trim();
            model.SpecialtyId = int.Parse(this.cboxSpecialty.SelectedValue.ToString());
            model.classroomId = this.txtClassroomId.Text.Trim();
            model.eductionalSystem = this.txteductionalSystem.Text.Trim();
            model.enterTime = this.TimePickerEnterTime.Value.Date;
            model.Marks = this.txtMarks.Text.Trim();
            bool SaveStatus = false;
            try
            {
                if (this.FS == FormStatus.Add)   //新增
                {
                    int id = new BLL.tbClassInfo().Add(model);
                    this.txtClassId.Text = id.ToString();
                    SaveStatus = true;
                }
                else if (this.FS == FormStatus.Update) //修改
                {
                    model.ClassId = int.Parse(this.txtClassId.Text.Trim());
                    SaveStatus = new BLL.tbClassInfo().Update(model);
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
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        //关闭
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
