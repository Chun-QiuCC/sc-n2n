using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;

namespace sc_n2n
{
    public partial class main : Form
    {
        // 声明n2n文件夹路径
        public static string n2nfullPath;
        // 检查操作系统位数
        public static string osBit = Environment.Is64BitOperatingSystem ? "x64" : "x86";
        // edge进程UID
        public static int global_edgeuid;
        public main()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory(); // 获取当前程序运行目录
            string iniPath = currentDirectory + "\\" + "config.ini";
            IniFile iniFile = new IniFile(iniPath);
            // 写入配置
            iniFile.Write("Settings", "iniIP", serverIP_text.Text);
            iniFile.Write("Settings", "iniTeam", groupID_text.Text);
            iniFile.Write("Settings", "iniLAN", lan_ip_text.Text);
        }

        static bool checkN2N(string folderName)
        {
            string currentDirectory = Directory.GetCurrentDirectory(); // 获取当前程序运行目录
            string fullFolderPath = Path.Combine(currentDirectory, folderName); // 组合完整路径
            n2nfullPath = fullFolderPath;
            return Directory.Exists(fullFolderPath);

        }


        // 获取n2n edge程序路径
        string fulln2nEdgepath()
        {
            string fullPath = n2nfullPath + "\\" + osBit + "\\" + "edge_v3_sc_n2n.exe";
            return fullPath;
        }

        // ini操作
        public class IniFile
        {
            private string path;

            public IniFile(string iniPath)
            {
                path = iniPath;
            }

            [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
            private static extern bool WritePrivateProfileString(string section, string key, string value, string filePath);

            public string Read(string section, string key, string defaultValue)
            {
                StringBuilder result = new StringBuilder(255);
                GetPrivateProfileString(section, key, defaultValue, result, 255, path);
                return result.ToString();
            }

            public void Write(string section, string key, string value)
            {
                WritePrivateProfileString(section, key, value, path);
            }
        }
        
        // 当窗口1加载时
        private void Form1_Load(object sender, EventArgs e)
        {

            string currentDirectory = Directory.GetCurrentDirectory(); // 获取当前程序运行目录
            string iniPath = currentDirectory + "\\" + "config.ini";
            IniFile iniFile = new IniFile(iniPath);

            // 读取配置
            string iniIP = iniFile.Read("Settings", "iniIP", "");
            string iniGroup = iniFile.Read("Settings", "iniTeam", "");
            string iniLan = iniFile.Read("Settings", "iniLAN", "");

            serverIP_text.Text = iniIP;
            groupID_text.Text = iniGroup;
            lan_ip_text.Text = iniLan;

            // 提前打开Form2 预加载log
            form2.Show();
            form2.Visible = false;


            // 检查N2N本体是否存在
            if (checkN2N("n2n_client") == false)
            {
                MessageBox.Show("未在程序运行目录找到n2n本体，程序不完整，请重新下载");
                Process[] processes = Process.GetProcessesByName("sc-n2n");
                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }

            // 启动时隐藏结束按钮
            stopN2Nbutton.Visible = false;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                lan_ip_text.Enabled = false;
            }
            else {
                lan_ip_text.Enabled = true;
            }
        }
        // 声明Form2
        Form2 form2 = new Form2();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
            { 
                // 如果Form2进程存在则展示Form2
                form2.Visible = true;
            } 
            else
            {
                // 不存在则重新吊起Form2
                form2.Show();
            }
                    
            
            // 声明Form2
            // Form2 form2 = new Form2();
            // form2.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(form2 == null || form2.IsDisposed)
            {
                // 如果Form2进程存在则直接启动
                string Edgepath = fulln2nEdgepath();
                string lanIP = lan_ip_text.Text;
                string serverIP = serverIP_text.Text;
                string groupID = groupID_text.Text;
                Random random = new Random();
                int randomUID = random.Next(27000, 28000);
                global_edgeuid = randomUID;

                if (serverIP == "")
                {
                    MessageBox.Show("服务器IP不能为空");
                }
                else if (groupID == "")
                {
                    MessageBox.Show("小组名称不能为空");
                }
                else
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = Edgepath, // 指定 EXE 文件路径
                        Arguments = $"-c {groupID} -l {serverIP} -a {lanIP}", // 指定启动参数
                        RedirectStandardOutput = true, // 重定向标准输出
                        RedirectStandardError = true, // 重定向错误输出
                        UseShellExecute = false, // 必须设置为 false
                        CreateNoWindow = true
                    };
                    Process process = new Process { StartInfo = startInfo };



                    process.OutputDataReceived += (outputSender, outputArgs) => form2.AppendLog(outputArgs.Data);
                    process.ErrorDataReceived += (errorSender, errorArgs) => form2.AppendLog(errorArgs.Data);

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();


                    startedge_button.Enabled = false;
                    stopN2Nbutton.Visible = true;
                }

            }
            else
            {
                // 不存在则重新吊起Form2并隐藏Form2再启动
                form2.Show();
                form2.Visible=false;

                string Edgepath = fulln2nEdgepath();
                string lanIP = lan_ip_text.Text;
                string serverIP = serverIP_text.Text;
                string groupID = groupID_text.Text;
                Random random = new Random();
                int randomUID = random.Next(27000, 28000);
                global_edgeuid = randomUID;

                if (serverIP == "")
                {
                    MessageBox.Show("服务器IP不能为空");
                }
                else if (groupID == "")
                {
                    MessageBox.Show("小组名称不能为空");
                }
                else
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = Edgepath, // 指定 EXE 文件路径
                        Arguments = $"-c {groupID} -l {serverIP} -a {lanIP}", // 指定启动参数
                        RedirectStandardOutput = true, // 重定向标准输出
                        RedirectStandardError = true, // 重定向错误输出
                        UseShellExecute = false, // 必须设置为 false
                        CreateNoWindow = true
                    };
                    Process process = new Process { StartInfo = startInfo };



                    process.OutputDataReceived += (outputSender, outputArgs) => form2.AppendLog(outputArgs.Data);
                    process.ErrorDataReceived += (errorSender, errorArgs) => form2.AppendLog(errorArgs.Data);

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();


                    startedge_button.Enabled = false;
                    stopN2Nbutton.Visible = true;
                }
            }

            


            


            // 显示结束按钮

        }
        // 结束N2N edge
        void KillProcess(string processName)
        {
            Process.Start("taskkill", $"/IM {processName}.exe /F");
        }

        private void stopN2Nbutton_Click(object sender, EventArgs e)
        {
            startedge_button.Enabled = true;
            stopN2Nbutton.Visible = false;
            
            KillProcess("edge_v3_sc_n2n");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
