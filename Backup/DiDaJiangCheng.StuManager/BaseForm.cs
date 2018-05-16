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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            //防止屏幕闪烁
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);

        }

        /// <summary>
        /// 最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void picMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected int X, Y;
        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.X = e.X;
            this.Y = e.Y;
        }

        private void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                int lengx = e.X - X;
                int lengy = e.Y - Y;
                this.Left += lengx;
                this.Top += lengy;
            }
        }
    }
}
