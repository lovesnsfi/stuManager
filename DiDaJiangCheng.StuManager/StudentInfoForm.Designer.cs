namespace DiDaJiangCheng.StuManager
{
    partial class StudentInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cboxStuNation = new System.Windows.Forms.ComboBox();
            this.cboxStuSex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myDataGridView1 = new DiDaJiangCheng.StuManager.MyDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.StuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuNation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuFamilyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stupolitics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuPostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picMini
            // 
            this.picMini.Location = new System.Drawing.Point(752, 3);
            // 
            // picClose
            // 
            this.picClose.Location = new System.Drawing.Point(778, 3);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.cboxStuNation);
            this.panel1.Controls.Add(this.cboxStuSex);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStuName);
            this.panel1.Controls.Add(this.txtStuNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.myDataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 484);
            this.panel1.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(699, 16);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(92, 66);
            this.btnQuery.TabIndex = 33;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cboxStuNation
            // 
            this.cboxStuNation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cboxStuNation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStuNation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxStuNation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboxStuNation.FormattingEnabled = true;
            this.cboxStuNation.Items.AddRange(new object[] {
            "--请选择--",
            "汉族",
            "满族",
            "内蒙古",
            "回族",
            "藏族",
            "其它"});
            this.cboxStuNation.Location = new System.Drawing.Point(532, 55);
            this.cboxStuNation.Name = "cboxStuNation";
            this.cboxStuNation.Size = new System.Drawing.Size(160, 29);
            this.cboxStuNation.TabIndex = 32;
            // 
            // cboxStuSex
            // 
            this.cboxStuSex.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cboxStuSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStuSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxStuSex.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboxStuSex.FormattingEnabled = true;
            this.cboxStuSex.Items.AddRange(new object[] {
            "--请选择--",
            "男",
            "女"});
            this.cboxStuSex.Location = new System.Drawing.Point(259, 55);
            this.cboxStuSex.Name = "cboxStuSex";
            this.cboxStuSex.Size = new System.Drawing.Size(174, 29);
            this.cboxStuSex.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(441, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "民      族";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(168, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "性      别";
            // 
            // txtStuName
            // 
            this.txtStuName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStuName.Location = new System.Drawing.Point(532, 20);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(160, 29);
            this.txtStuName.TabIndex = 31;
            // 
            // txtStuNo
            // 
            this.txtStuNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStuNo.Location = new System.Drawing.Point(259, 20);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Size = new System.Drawing.Size(174, 29);
            this.txtStuNo.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(441, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "学生姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(165, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "学生学号";
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AllowUserToAddRows = false;
            this.myDataGridView1.AllowUserToDeleteRows = false;
            this.myDataGridView1.AllowUserToResizeRows = false;
            this.myDataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuId,
            this.StuNo,
            this.StuName,
            this.StuSex,
            this.StuNation,
            this.StuFamilyAddress,
            this.StuContact,
            this.Stupolitics,
            this.StuPostCode,
            this.ClassName,
            this.SpecialtyName});
            this.myDataGridView1.EnableHeadersVisualStyles = false;
            this.myDataGridView1.Location = new System.Drawing.Point(155, 94);
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.myDataGridView1.RowHeadersWidth = 30;
            this.myDataGridView1.RowTemplate.Height = 23;
            this.myDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.myDataGridView1.Size = new System.Drawing.Size(645, 387);
            this.myDataGridView1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::DiDaJiangCheng.StuManager.Properties.Resources.t03;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "  删除学生";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::DiDaJiangCheng.StuManager.Properties.Resources.t01;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(10, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 36);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "  新增学生";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::DiDaJiangCheng.StuManager.Properties.Resources.t02;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(10, 58);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 36);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "  修改学生";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DiDaJiangCheng.StuManager.Properties.Resources.LogoWhite;
            this.pictureBox1.Location = new System.Drawing.Point(28, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(111, 33);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(143, 33);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "学生管理";
            // 
            // StuId
            // 
            this.StuId.DataPropertyName = "StuId";
            this.StuId.HeaderText = "学生编号";
            this.StuId.Name = "StuId";
            this.StuId.ReadOnly = true;
            // 
            // StuNo
            // 
            this.StuNo.DataPropertyName = "StuNo";
            this.StuNo.HeaderText = "学生学号";
            this.StuNo.Name = "StuNo";
            this.StuNo.ReadOnly = true;
            // 
            // StuName
            // 
            this.StuName.DataPropertyName = "StuName";
            this.StuName.HeaderText = "学生姓名";
            this.StuName.Name = "StuName";
            this.StuName.ReadOnly = true;
            // 
            // StuSex
            // 
            this.StuSex.DataPropertyName = "StuSex";
            this.StuSex.HeaderText = "性别";
            this.StuSex.Name = "StuSex";
            this.StuSex.ReadOnly = true;
            this.StuSex.Width = 70;
            // 
            // StuNation
            // 
            this.StuNation.DataPropertyName = "StuNation";
            this.StuNation.HeaderText = "民族";
            this.StuNation.Name = "StuNation";
            this.StuNation.ReadOnly = true;
            // 
            // StuFamilyAddress
            // 
            this.StuFamilyAddress.DataPropertyName = "StuFamilyAddress";
            this.StuFamilyAddress.HeaderText = "家庭地址";
            this.StuFamilyAddress.Name = "StuFamilyAddress";
            this.StuFamilyAddress.ReadOnly = true;
            // 
            // StuContact
            // 
            this.StuContact.DataPropertyName = "StuContact";
            this.StuContact.HeaderText = "联系方式";
            this.StuContact.Name = "StuContact";
            this.StuContact.ReadOnly = true;
            // 
            // Stupolitics
            // 
            this.Stupolitics.DataPropertyName = "Stupolitics";
            this.Stupolitics.HeaderText = "政治面貌";
            this.Stupolitics.Name = "Stupolitics";
            this.Stupolitics.ReadOnly = true;
            // 
            // StuPostCode
            // 
            this.StuPostCode.DataPropertyName = "StuPostCode";
            this.StuPostCode.HeaderText = "邮政编码";
            this.StuPostCode.Name = "StuPostCode";
            this.StuPostCode.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "班级名称";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // SpecialtyName
            // 
            this.SpecialtyName.DataPropertyName = "SpecialtyName";
            this.SpecialtyName.HeaderText = "专业名称";
            this.SpecialtyName.Name = "SpecialtyName";
            this.SpecialtyName.ReadOnly = true;
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(98)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(803, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.Name = "StudentInfoForm";
            this.Text = "StudentInfoForm";
            this.Load += new System.EventHandler(this.StudentInfoForm_Load);
            this.Controls.SetChildIndex(this.picMini, 0);
            this.Controls.SetChildIndex(this.picClose, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.labelTitle, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private MyDataGridView myDataGridView1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cboxStuNation;
        private System.Windows.Forms.ComboBox cboxStuSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuNation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuFamilyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stupolitics;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuPostCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyName;
    }
}