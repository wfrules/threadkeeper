using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threadkeeper
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            utils.Config config = new utils.Config();
            nudInterVal.Value = Convert.ToInt32(config.Read("CONFIG", "interval", Convert.ToString(30*1000)));
            tbProc.Text = config.Read("CONFIG", "proc", "");
            tbCmd.Text = config.Read("CONFIG", "cmd", "");
            int iStart = Convert.ToInt32(config.Read("CONFIG", "start", "0"));
            if (iStart > 0)
            {
                toggle();
            }
        }

        private void addLog(string content)
        {
            tbLog.Text = tbLog.Text + $"\r\n{DateTime.Now.ToString()}===>" + content;
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            tbLog.Text = "";
            System.Diagnostics.Process[] processList = System.Diagnostics.Process.GetProcesses();
            bool bExists = false;
            foreach (System.Diagnostics.Process process in processList)
            {
                if (process.ProcessName.ToUpper() == tbProc.Text.Trim().ToUpper())
                {
                    bExists = true;
                    break;
                }
            }
            if (!bExists)
            {
                addLog(Execute(tbCmd.Text, 60 * 1000));
            }
        }

        public static string Execute(string command, int seconds)
        {
            string output = ""; //输出字符串 
            if (command != null && !command.Equals(""))
            {
                Process process = new Process();//创建进程对象 
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";//设定需要执行的命令 
                startInfo.Arguments = "/C " + command;//“/C”表示执行完命令后马上退出 
                startInfo.UseShellExecute = false;//不使用系统外壳程序启动 
                startInfo.RedirectStandardInput = false;//不重定向输入 
                startInfo.RedirectStandardOutput = true; //重定向输出 
                startInfo.CreateNoWindow = true;//不创建窗口 
                process.StartInfo = startInfo;
                try
                {
                    if (process.Start())//开始进程 
                    {
                        if (seconds == 0)
                        {
                            process.WaitForExit();//这里无限等待进程结束 
                        }
                        else
                        {
                            process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒 
                        }
                        output = process.StandardOutput.ReadToEnd();//读取进程的输出 
                    }
                }
                catch
                {
                }
                finally
                {
                    if (process != null)
                        process.Close();
                }
            }
            return output;
        }

        private void toggle()
        {
            if (tmrCheck.Enabled)
            {
                btnToggle.Text = "启动";
                tmrCheck.Enabled = false;
                nudInterVal.Enabled = true;
                addLog("结束进程监控");
            }
            {
                btnToggle.Text = "停止";
                tmrCheck.Interval = Convert.ToInt32(nudInterVal.Value);
                tmrCheck.Enabled = true;
                nudInterVal.Enabled = false;
                addLog("开始进程监控");
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            toggle();
        }
    }
}
