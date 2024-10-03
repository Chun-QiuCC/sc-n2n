using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sc_n2n
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;
        }
        public void AppendLog(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                // 在 UI 线程中更新 TextBox
                if (textBoxLog.InvokeRequired)
                {
                    textBoxLog.Invoke(new Action<string>(AppendLog), message);
                }
                else
                {
                    textBoxLog.AppendText(message + Environment.NewLine);
                    textBoxLog.ScrollToCaret(); // 滚动到文本框的最后一行
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 取消关闭事件
            this.Hide();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
