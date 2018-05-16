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
    public partial class CourseInfoForm : BaseForm
    {
        public CourseInfoForm()
        {
            InitializeComponent();
            this.myDataGridView1.AutoGenerateColumns = false;
            this.cboxSpecialtyId.SelectedIndex = 0;
            this.cboxStuNation.SelectedIndex = 0;
        }

        private void CourseInfoForm_Load(object sender, EventArgs e)
        {
            //绑定下拉框
            DataSet ds_Specialty = new BLL.tbSpecialtyInfo().GetAllList();
            DataRow dr = ds_Specialty.Tables[0].NewRow();
            dr["SpecialtyId"] = 0;
            dr["SpecialtyName"] = "--请选择--";
            ds_Specialty.Tables[0].Rows.InsertAt(dr, 0);
            this.cboxSpecialtyId.DataSource = ds_Specialty.Tables[0];
            this.cboxSpecialtyId.DisplayMember = "SpecialtyName";
            this.cboxSpecialtyId.ValueMember = "SpecialtyId";
            DataSet ds = new BLL.tbCourseInfo().GetListByCourseInfoView("");
            this.myDataGridView1.DataSource = ds.Tables[0];
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strWhere = " 1=1 ";
            if (!string.IsNullOrEmpty(this.txtCourseName.Text.Trim()))
            {
                strWhere += " and CourseName like '%"+this.txtCourseName.Text.Trim()+"%'";
            }
            if (!string.IsNullOrEmpty(this.txtClassName.Text.Trim()))
            {
                strWhere += " and ClassName like '%"+this.txtClassName.Text.Trim()+"%'";
            }
            if (this.cboxSpecialtyId.SelectedValue.ToString()!="0")
            {
                strWhere += " and SpecialtyId ='"+this.cboxSpecialtyId.SelectedValue.ToString()+"'";
            }
            if (this.cboxStuNation.Text != "--请选择--")
            {
                strWhere += " and Semester = '"+this.cboxStuNation.Text+"'";
            }
            this.myDataGridView1.DataSource = new BLL.tbCourseInfo().GetListByCourseInfoView(strWhere).Tables[0];
        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCourseInfoForm frm = new AddCourseInfoForm(FormStatus.Add, null);
            frm.Show();
        }

        //修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.myDataGridView1.DataSource==null)
            {
                return;
            }
            if (this.myDataGridView1.SelectedRows.Count>=1)
            {
                AddCourseInfoForm frm = new AddCourseInfoForm(FormStatus.Update, int.Parse(this.myDataGridView1.CurrentRow.Cells[0].Value.ToString()));
                frm.Show();
            }
        }

        //删除课程
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.myDataGridView1.DataSource==null)
            {
                return;
            }
            if (this.myDataGridView1.SelectedRows.Count>=1)
            {
                if (MessageBox.Show("你确定要删除该条信息吗？","请确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk)==DialogResult.OK)
                {
                    if (new BLL.tbCourseInfo().Delete(int.Parse(this.myDataGridView1.CurrentRow.Cells[0].Value.ToString())))
                    {
                        this.myDataGridView1.Rows.Remove(this.myDataGridView1.CurrentRow);
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
        }
    }
}
