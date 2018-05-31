using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace DiDaJiangCheng.Update
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        //窗体加载的时候
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            
            //开启多线程支持
            new Thread(new ThreadStart(() =>
            {
                try
                {
                    this.richTextBox1.Text += "正在下载更新文件...\n";
                    string url = "http://www.softeem.xin/stuManager/stuManager.zip";
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    MemoryStream ms = streamToMemoryStram(responseStream);
                    this.progressBar1.Maximum = (int)ms.Length;
                    //目标文件
                    string targetFile = Application.StartupPath + "\\stuManager.zip";
                    FileStream outFileStream = new FileStream(targetFile, FileMode.Create, FileAccess.Write);
                    int count = 0;
                    int totalCount = 0;
                    byte[] buff = new byte[100];
                    while ((count = ms.Read(buff, 0, buff.Length)) > 0)
                    {
                        totalCount += count;
                        outFileStream.Write(buff, 0, count);
                        this.progressBar1.Value = totalCount;
                    }
                    ms.Close();
                    outFileStream.Close();
                    this.richTextBox1.Text += "下载成功，正在解压文件\n";
                    if (ZipHelper.unZip(targetFile, Application.StartupPath, ""))
                    {
                        this.richTextBox1.Text += "文件解压成功\n";
                        if (MessageBox.Show("更新成功,是否启动程序","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk)==DialogResult.Yes)
                        {
                            Process.Start(Application.StartupPath + @"\StuManager.exe");
                        }
                        this.Close();
                        
                    }
                    else
                    {
                        this.richTextBox1.Text += "文件解压失败\n";
                        MessageBox.Show("更新失败");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            })).Start();
            
            
            

        }

        private MemoryStream streamToMemoryStram(Stream stream)
        {
            MemoryStream ms = new MemoryStream();
            byte[] buff = new byte[1024];
            if (stream==null)
            {
                return null;
            }
            else
            {
                int count = 0;
                while ((count=stream.Read(buff,0,buff.Length))>0)
                {
                    ms.Write(buff, 0, count);
                }
                ms.Position = 0;
                return ms;
            }

        }
    }
}
