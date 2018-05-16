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
    public partial class AddScoreInfoForm : BaseForm
    {
        public AddScoreInfoForm()
        {
            InitializeComponent();
        }
        private FormStatus fs;

        public FormStatus FS
        {
            get { return fs; }
            set
            {
                if (value==FormStatus.Add)
                {
                    this.labelTitle.Text = "◆新增学生成绩";
                }
                else if (value==FormStatus.Update)
                {
                    this.labelTitle.Text = "◆修改学生成绩";
                }
                fs = value;
            }
        }
        private int ScroeId;
        public AddScoreInfoForm(FormStatus _fs,int? scroeid):this()
        {
            this.FS = _fs;
            if (scroeid.HasValue)
            {
                this.ScroeId = scroeid.Value;
            }
            else
            {
                this.ScroeId = 0;
            }
        }
        
        Dictionary<string, string> dic = new Dictionary<string, string>();
        private void AddScoreInfoForm_Load(object sender, EventArgs e)
        {
            //学号的自动提示功能
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            
            DataSet ds = new BLL.tbStudentInfo().GetAllList();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ac.Add(ds.Tables[0].Rows[i]["StuNo"].ToString());
                dic.Add(ds.Tables[0].Rows[i]["StuNo"].ToString(), ds.Tables[0].Rows[i]["StuName"].ToString());
            }
            this.txtfiledStuNo.AutoCompleteCustomSource = ac;
            this.txtfiledStuNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtfiledStuNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            if (this.FS==FormStatus.Update)
            {
                Model.tbScoreInfo model = new BLL.tbScoreInfo().GetModel(this.ScroeId);
                if (model!=null)
                {
                    //绑定下拉框 
                    DataSet ds_Course = new BLL.tbStudentInfo().GetStuCourseInfo(model.filedStuNo);
                    this.cboxfiledCourseId.DataSource = ds_Course.Tables[0];
                    this.cboxfiledCourseId.DisplayMember = "CourseName";
                    this.cboxfiledCourseId.ValueMember = "CourseId";


                    this.txtfiledaScoreId.Text = model.filedaScoreId.ToString();
                    this.txtfiledStuNo.Text = model.filedStuNo;
                    this.txtStuName.Text = dic[model.filedStuNo].ToString();
                    this.cboxfiledCourseId.SelectedValue = model.filedCourseId;
                    this.txtfiledScore.Text = model.filedScore.ToString();
                }
                else
                {
                    MessageBox.Show("找不到相关数据，请重试");
                    this.Close();
                }
            }
        }

        //验证学生学号及自动对应学生姓名
        private void txtfiledStuNo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtfiledStuNo.Text.Trim()))
            {
                if (dic.Keys.Contains(this.txtfiledStuNo.Text.Trim()))
                {
                    this.txtStuName.Text = dic[this.txtfiledStuNo.Text.Trim()].ToString();
                    //绑定课程名称下拉框
                    DataSet ds_Course = new BLL.tbStudentInfo().GetStuCourseInfo(this.txtfiledStuNo.Text.Trim());
                    this.cboxfiledCourseId.DataSource = ds_Course.Tables[0];
                    this.cboxfiledCourseId.DisplayMember = "CourseName";
                    this.cboxfiledCourseId.ValueMember = "CourseId";
                    if (this.FS==FormStatus.Update)
                    {
                        Model.tbScoreInfo model = new BLL.tbScoreInfo().GetModel(this.ScroeId);
                        this.cboxfiledCourseId.SelectedValue = model.filedCourseId;
                    }
                }
                else
                {
                    MessageBox.Show("找不到该学生的信息，请确定");
                    this.txtfiledStuNo.Clear();
                    this.txtStuName.Clear();
                    this.txtfiledStuNo.Focus();
                }
            }
        }

        //保存
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool flag = Common.FormHelp.CheckTextBox(this.panel1.Controls, this.txtfiledaScoreId);
            if (!flag)
            {
                MessageBox.Show("请将信息输入完整");
                return;
            }
            bool SaveStatus = false;

            Model.tbScoreInfo model = new Model.tbScoreInfo();
            model.filedStuNo = this.txtfiledStuNo.Text.Trim();
            model.filedCourseId = int.Parse(this.cboxfiledCourseId.SelectedValue.ToString());
            model.filedScore = decimal.Parse(this.txtfiledScore.Text.Trim());
            try
            {
                if (this.FS==FormStatus.Add)
                {
                    int rows = new BLL.tbScoreInfo().Add(model);
                    this.txtfiledaScoreId.Text = rows.ToString();
                    SaveStatus = true;
                }
                else if (this.FS==FormStatus.Update)
                {
                    model.filedaScoreId=int.Parse(this.txtfiledaScoreId.Text.Trim());
                    SaveStatus = new BLL.tbScoreInfo().Update(model);
                }
                if (SaveStatus)
                {
                    MessageBox.Show("保存成功");
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

        //关闭
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
