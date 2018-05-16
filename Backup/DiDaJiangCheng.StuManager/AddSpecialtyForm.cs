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
    public partial class AddSpecialtyForm : BaseForm
    {
        public AddSpecialtyForm()
        {
            InitializeComponent();
        }
        private int SpecialtyId;
        /// <summary>
        /// 自定义构造方法
        /// </summary>
        public AddSpecialtyForm(FormStatus fs,int? speicaltyid):this()
        {
            this.Fs = fs;
            if (speicaltyid.HasValue)
            {
                this.SpecialtyId = speicaltyid.Value;
            }
            else
            {
                this.SpecialtyId = 0;
            }
        }
        private FormStatus _fs;

        public FormStatus Fs
        {
            get { return _fs; }
            set
            {
                if (value==FormStatus.Add)
                {
                    this.labelTitle.Text = "◆新增专业";
                }
                else if (value==FormStatus.Update)
                {
                    this.labelTitle.Text = "◆修改专业";
                }
                _fs = value;
            }
        }
        //加载
        private void AddSpecialtyForm_Load(object sender, EventArgs e)
        {
            if (Fs==FormStatus.Update)
            {
                Model.tbSpecialtyInfo model = new BLL.tbSpecialtyInfo().GetModel(SpecialtyId);
                if (model!=null)
                {
                    this.txtSpecialtyId.Text = model.SpecialtyId.ToString();
                    this.txtSpecialtyName.Text = model.SpecialtyName;
                    this.txtSpecialtyDescription.Text = model.SpecialtyDescription;
                }
                else
                {
                    MessageBox.Show("查不当前数据，请确定或重试");
                    this.Close();
                }
            }
        }

        //关闭
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //保存
        private void btnOK_Click(object sender, EventArgs e)
        {
            Model.tbSpecialtyInfo model = new Model.tbSpecialtyInfo();
            model.SpecialtyName = this.txtSpecialtyName.Text.Trim();
            model.SpecialtyDescription = this.txtSpecialtyDescription.Text.Trim();
            bool flag = false;
            try
            {
                if (Fs == FormStatus.Add)
                {
                    int id = new BLL.tbSpecialtyInfo().Add(model);
                    this.txtSpecialtyId.Text = id.ToString();
                    flag = true;

                }
                else if (Fs == FormStatus.Update)
                {
                    model.SpecialtyId = int.Parse(this.txtSpecialtyId.Text.Trim());
                   flag= new BLL.tbSpecialtyInfo().Update(model);

                }
                if (flag)
                {
                    MessageBox.Show("保存成功");
                    //如果保存成功，将当前窗体的状态改为修改状态
                    this.Fs = FormStatus.Update;
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
    }
}
