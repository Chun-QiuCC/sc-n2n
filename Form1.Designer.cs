namespace sc_n2n
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.serverIP_text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupID_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lan_ip_text = new System.Windows.Forms.TextBox();
            this.startedge_button = new System.Windows.Forms.Button();
            this.stopN2Nbutton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverIP_text
            // 
            this.serverIP_text.Location = new System.Drawing.Point(17, 35);
            this.serverIP_text.Name = "serverIP_text";
            this.serverIP_text.Size = new System.Drawing.Size(311, 25);
            this.serverIP_text.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serverIP_text);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器地址(带端口号)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupID_text);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lan_ip_text);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.groupBox2.Location = new System.Drawing.Point(8, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "网络选项";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox1.Location = new System.Drawing.Point(17, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "自动分配IP (需要服务器支持)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(186, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "小组名称：";
            // 
            // groupID_text
            // 
            this.groupID_text.Location = new System.Drawing.Point(189, 51);
            this.groupID_text.Name = "groupID_text";
            this.groupID_text.Size = new System.Drawing.Size(139, 25);
            this.groupID_text.TabIndex = 2;
            this.groupID_text.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "虚拟IP：";
            // 
            // lan_ip_text
            // 
            this.lan_ip_text.Location = new System.Drawing.Point(17, 51);
            this.lan_ip_text.Name = "lan_ip_text";
            this.lan_ip_text.Size = new System.Drawing.Size(139, 25);
            this.lan_ip_text.TabIndex = 0;
            // 
            // startedge_button
            // 
            this.startedge_button.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.startedge_button.Location = new System.Drawing.Point(16, 24);
            this.startedge_button.Name = "startedge_button";
            this.startedge_button.Size = new System.Drawing.Size(101, 43);
            this.startedge_button.TabIndex = 3;
            this.startedge_button.Text = "▶ 启动N2N";
            this.startedge_button.UseVisualStyleBackColor = true;
            this.startedge_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopN2Nbutton
            // 
            this.stopN2Nbutton.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.stopN2Nbutton.Location = new System.Drawing.Point(226, 24);
            this.stopN2Nbutton.Name = "stopN2Nbutton";
            this.stopN2Nbutton.Size = new System.Drawing.Size(101, 43);
            this.stopN2Nbutton.TabIndex = 4;
            this.stopN2Nbutton.Text = "⬛ 停止N2N";
            this.stopN2Nbutton.UseVisualStyleBackColor = true;
            this.stopN2Nbutton.Click += new System.EventHandler(this.stopN2Nbutton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(12, 304);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "查看日志";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stopN2Nbutton);
            this.groupBox3.Controls.Add(this.startedge_button);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.groupBox3.Location = new System.Drawing.Point(8, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 81);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "启动关闭";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(363, 335);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SunsetClubN2N Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverIP_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox groupID_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lan_ip_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button startedge_button;
        private System.Windows.Forms.Button stopN2Nbutton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

