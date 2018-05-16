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
    public partial class SpecialtyForm : BaseForm
    {
        public SpecialtyForm()
        {
            InitializeComponent();
            //取消自动创建行
            this.myDataGridView1.AutoGenerateColumns = false;
        }

        private void SpecialtyForm_Load(object sender, EventArgs e)
        {
            DataSet ds = new BLL.tbSpecialtyInfo().GetAllList();
            if (ds!=null&&ds.Tables.Count>0)
            {
                this.myDataGridView1.DataSource = ds.Tables[0];
            }

        }

        //新增专业
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSpecialtyForm frm = new AddSpecialtyForm(FormStatus.Add,null);
            frm.Show();
        }

        //查询 
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataSet ds = new BLL.tbSpecialtyInfo().GetList(" SpecialtyName like '%"+this.txtSpecialty.Text.Trim()+"%' ");
            this.myDataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //确定是否绑定了数据源
            if (myDataGridView1.DataSource==null)
            {
                return;
            }
            if (myDataGridView1.SelectedRows.Count>0)
            {
                int id =int.Parse( this.myDataGridView1.CurrentRow.Cells[0].Value.ToString());
                AddSpecialtyForm frm = new AddSpecialtyForm(FormStatus.Update, id);
                frm.Show();
            }
        }

        //删除
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.myDataGridView1.DataSource==null)
            {
                return;
            }
            if (this.myDataGridView1.SelectedRows.Count==1)
            {
                int id = int.Parse(this.myDataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (new BLL.tbSpecialtyInfo().Delete(id))
                {
                    this.myDataGridView1.Rows.Remove(this.myDataGridView1.CurrentRow);
                    MessageBox.Show("删除成功");
                }
            }
        }
    }
}
