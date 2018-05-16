using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiDaJiangCheng.Common
{
    public class FormHelp
    {
        /// <summary>
        /// 检查TextBox信息是否输入完整
        /// </summary>
        /// <param name="ctrs"></param>
        /// <returns></returns>
        public static bool CheckTextBox(System.Windows.Forms.Control.ControlCollection ctrs)
        {
            bool flag = true;
            foreach (System.Windows.Forms.Control ctr in ctrs)
            {
                if (ctr.Controls.Count>0)
                {
                    CheckTextBox(ctr.Controls);
                }
                else
                {
                    if (ctr is System.Windows.Forms.TextBox)
                    {
                        System.Windows.Forms.TextBox tbox = ctr as System.Windows.Forms.TextBox;
                        if (string.IsNullOrEmpty(tbox.Text.Trim()))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
            }
            return flag;
        }
        /// <summary>
        /// 检查TextBox信息是否输入完整,并排除某些无素
        /// </summary>
        /// <param name="ctrs">遍历的控件</param>
        /// <param name="tboxs">要排除的TextBox</param>
        /// <returns>返回True则检测通过，返回False则检测不通过</returns>

        public static bool CheckTextBox(System.Windows.Forms.Control.ControlCollection ctrs,params System.Windows.Forms.TextBox[] tboxs)
        {
            bool flag = true;
            foreach (System.Windows.Forms.Control ctr in ctrs)
            {
                if (ctr.Controls.Count > 0)
                {
                    CheckTextBox(ctr.Controls);
                }
                else
                {
                    if (ctr is System.Windows.Forms.TextBox)
                    {
                        System.Windows.Forms.TextBox tbox = ctr as System.Windows.Forms.TextBox;

                        if (!tboxs.Contains(tbox))
                        {
                            if (string.IsNullOrEmpty(tbox.Text.Trim()))
                            {
                                flag = false;
                                return flag;
                            }
                        }
                        
                    }
                }
            }
            return flag;
        }
        /// <summary>
        /// 清空TextBox里面的内容
        /// </summary>
        /// <param name="ctrs"></param>
        public static void ClearTextBox(System.Windows.Forms.Control.ControlCollection ctrs)
        {
            foreach (System.Windows.Forms.Control ctr in ctrs)
            {
                if (ctr.Controls.Count>0)
                {
                    ClearTextBox(ctr.Controls);
                }
                else
                {
                    if (ctr is System.Windows.Forms.TextBox)
                    {
                        System.Windows.Forms.TextBox tbox = ctr as System.Windows.Forms.TextBox;
                        tbox.Clear();
                    }
                }
            }
        }
    }
}
