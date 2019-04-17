using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiDaJiangCheng.StuManager
{
    /// <summary>
    /// 自定义DataGridView控件
    /// </summary>
    public class MyDataGridView:DataGridView
    {
        public MyDataGridView()
        {
            base.EnableHeadersVisualStyles = false;
            base.AllowUserToResizeRows = false;
            base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            base.BackgroundColor = Color.AliceBlue;
        }

        /// <summary>
        /// 在每行前加一个自动生成的序列
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            base.OnRowPostPaint(e);
            if (e.RowIndex%2==0)
            {
                //偶数
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                //奇数
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            //取当前颜色作为画笔
            SolidBrush b = new SolidBrush(base.RowHeadersDefaultCellStyle.ForeColor);
            Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.RowHeadersWidth, this.Rows[e.RowIndex].Height);
            StringFormat sf=new StringFormat();
            sf.Alignment=StringAlignment.Center;
            sf.LineAlignment=StringAlignment.Center;

            e.Graphics.DrawString((e.RowIndex + 1).ToString(), new Font("微软雅黑", 12), b, rect, sf);
            
            base.OnRowPostPaint(e);
        }

        /// <summary>
        /// 奇偶行换色
        /// </summary>
        /// <param name="e"></param>
//         protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e)
//         {
//             base.OnDataBindingComplete(e);
//             for (int i = 0; i < base.Rows.Count; i++)
//             {
//                 if (i%2==0)
//                 {
//                     base.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
//                 }
//             }

//         }
    }
}
