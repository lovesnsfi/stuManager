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
    public partial class StudentInfoForm : BaseForm
    {
        public StudentInfoForm()
        {
            InitializeComponent();
            this.myDataGridView1.AutoGenerateColumns = false;
            this.cboxStuNation.SelectedIndex = 0;
            this.cboxStuSex.SelectedIndex = 0;
        }

        //加载信息
        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            DataSet ds = new BLL.tbStudentInfo().GetListByStudentInfoView("");
            this.myDataGridView1.DataSource = ds.Tables[0];
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strWhere = " 1=1 ";
            if (!string.IsNullOrEmpty(this.txtStuNo.Text.Trim()))
            {
                strWhere += " and StuNo like '%"+this.txtStuNo.Text.Trim()+"%'";
            }
            if (!string.IsNullOrEmpty(this.txtStuName.Text.Trim()))
            {
                strWhere += " and StuName like '%"+this.txtStuName.Text.Trim()+"%'";
            }
            if (this.cboxStuSex.SelectedIndex!=0)
            {
                strWhere += " and StuSex ='"+this.cboxStuSex.Text.ToString()+"'";
            }
            if (this.cboxStuNation.SelectedIndex!=0)
            {
                strWhere += " and StuNation='"+this.cboxStuNation.Text.ToString()+"'";
            }
            DataSet ds = new BLL.tbStudentInfo().GetListByStudentInfoView(strWhere);
            this.myDataGridView1.DataSource = ds.Tables[0];
        }

        //新增学生
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentInfoForm frm = new AddStudentInfoForm(FormStatus.Add,null);
            frm.Show();
        }

        //修改学生
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (myDataGridView1.DataSource==null)
            {
                return;
            }
            if (myDataGridView1.SelectedRows.Count>=1)
            {
                AddStudentInfoForm frm = new AddStudentInfoForm(FormStatus.Update, this.myDataGridView1.CurrentRow.Cells["StuNo"].Value.ToString());
                frm.Show();
            }
        }

        //删除学生
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
