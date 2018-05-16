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
    public partial class ClassForm : BaseForm
    {
        public ClassForm()
        {
            InitializeComponent();
            this.myDataGridView1.AutoGenerateColumns = false;
        }

        //加载
        private void ClassForm_Load(object sender, EventArgs e)
        {
            //绑定专业 下拉框
            DataSet ds_Specialty = new BLL.tbSpecialtyInfo().GetAllList();
            DataRow dr = ds_Specialty.Tables[0].NewRow();
            dr["SpecialtyId"] = 0;
            dr["SpecialtyName"] = "--请选择--";
            ds_Specialty.Tables[0].Rows.InsertAt(dr, 0);
            this.cboxSpeicalty.DataSource = ds_Specialty.Tables[0];
            this.cboxSpeicalty.ValueMember = "SpecialtyId";
            this.cboxSpeicalty.DisplayMember = "SpecialtyName";
            
            DataSet ds = new BLL.tbClassInfo().GetListByClassInfoView("");
            this.myDataGridView1.DataSource = ds.Tables[0];
            
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strWhere = " 1=1 ";
            if (!string.IsNullOrEmpty(this.txtClassName.Text.Trim()))
            {
                strWhere += " and ClassName like '%"+this.txtClassName.Text.Trim()+"%'";
            }
            if (this.cboxSpeicalty.SelectedValue.ToString()!="0")
            {
                strWhere += " and SpecialtyId ='" + this.cboxSpeicalty.SelectedValue.ToString() + "'";
            }
            DataSet ds = new BLL.tbClassInfo().GetListByClassInfoView(strWhere);
            this.myDataGridView1.DataSource = ds.Tables[0];
        }

        //新增班级
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClassForm frm = new AddClassForm(FormStatus.Add,null);
            frm.Show();
        }

        //修改改级
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (myDataGridView1.DataSource==null)
            {
                return;
            }
            if (myDataGridView1.SelectedRows.Count==1)
            {
                AddClassForm frm = new AddClassForm(FormStatus.Update, int.Parse(this.myDataGridView1.CurrentRow.Cells[0].Value.ToString()));
                frm.Show();
            }
        }
    }
}
