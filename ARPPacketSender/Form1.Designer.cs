namespace ARPPacketSender
{
    partial class form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoReq = new System.Windows.Forms.RadioButton();
            this.rdoResp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEhSourMac = new System.Windows.Forms.TextBox();
            this.txtEhDestMac = new System.Windows.Forms.TextBox();
            this.txtARPSourMac = new System.Windows.Forms.TextBox();
            this.txtARPSourIP = new System.Windows.Forms.TextBox();
            this.txtARPDestMac = new System.Windows.Forms.TextBox();
            this.txtARPDestIP = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comDeviceList = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "以太网帧头源MAC地址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "以太网帧头目的MAC地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ARP报文源MAC地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "ARP报文源IP地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "ARP报文目的MAC地址：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "ARP报文目的IP地址：";
            // 
            // rdoReq
            // 
            this.rdoReq.AutoSize = true;
            this.rdoReq.Location = new System.Drawing.Point(6, 15);
            this.rdoReq.Name = "rdoReq";
            this.rdoReq.Size = new System.Drawing.Size(89, 16);
            this.rdoReq.TabIndex = 7;
            this.rdoReq.TabStop = true;
            this.rdoReq.Text = "ARP请求报文";
            this.rdoReq.UseVisualStyleBackColor = true;
            // 
            // rdoResp
            // 
            this.rdoResp.AutoSize = true;
            this.rdoResp.Location = new System.Drawing.Point(101, 15);
            this.rdoResp.Name = "rdoResp";
            this.rdoResp.Size = new System.Drawing.Size(89, 16);
            this.rdoResp.TabIndex = 8;
            this.rdoResp.TabStop = true;
            this.rdoResp.Text = "ARP应答报文";
            this.rdoResp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoReq);
            this.groupBox1.Controls.Add(this.rdoResp);
            this.groupBox1.Location = new System.Drawing.Point(14, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 40);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作方式";
            // 
            // txtEhSourMac
            // 
            this.txtEhSourMac.Location = new System.Drawing.Point(161, 52);
            this.txtEhSourMac.Name = "txtEhSourMac";
            this.txtEhSourMac.Size = new System.Drawing.Size(219, 21);
            this.txtEhSourMac.TabIndex = 10;
            // 
            // txtEhDestMac
            // 
            this.txtEhDestMac.Location = new System.Drawing.Point(161, 94);
            this.txtEhDestMac.Name = "txtEhDestMac";
            this.txtEhDestMac.Size = new System.Drawing.Size(219, 21);
            this.txtEhDestMac.TabIndex = 11;
            // 
            // txtARPSourMac
            // 
            this.txtARPSourMac.Location = new System.Drawing.Point(143, 135);
            this.txtARPSourMac.Name = "txtARPSourMac";
            this.txtARPSourMac.Size = new System.Drawing.Size(237, 21);
            this.txtARPSourMac.TabIndex = 12;
            // 
            // txtARPSourIP
            // 
            this.txtARPSourIP.Location = new System.Drawing.Point(143, 174);
            this.txtARPSourIP.Name = "txtARPSourIP";
            this.txtARPSourIP.Size = new System.Drawing.Size(237, 21);
            this.txtARPSourIP.TabIndex = 13;
            // 
            // txtARPDestMac
            // 
            this.txtARPDestMac.Location = new System.Drawing.Point(143, 216);
            this.txtARPDestMac.Name = "txtARPDestMac";
            this.txtARPDestMac.Size = new System.Drawing.Size(237, 21);
            this.txtARPDestMac.TabIndex = 14;
            // 
            // txtARPDestIP
            // 
            this.txtARPDestIP.Location = new System.Drawing.Point(143, 256);
            this.txtARPDestIP.Name = "txtARPDestIP";
            this.txtARPDestIP.Size = new System.Drawing.Size(237, 21);
            this.txtARPDestIP.TabIndex = 15;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSend.Location = new System.Drawing.Point(236, 347);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 28);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "报文发送间隔：";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(102, 299);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(41, 21);
            this.txtInterval.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "ms";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStop.Location = new System.Drawing.Point(320, 347);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(66, 28);
            this.btnStop.TabIndex = 20;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "选择网卡：";
            // 
            // comDeviceList
            // 
            this.comDeviceList.FormattingEnabled = true;
            this.comDeviceList.Location = new System.Drawing.Point(77, 15);
            this.comDeviceList.Name = "comDeviceList";
            this.comDeviceList.Size = new System.Drawing.Size(303, 20);
            this.comDeviceList.TabIndex = 22;
            this.comDeviceList.SelectedIndexChanged += new System.EventHandler(this.comDeviceList_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "已发送:";
            // 
            // txtCount
            // 
            this.txtCount.AutoSize = true;
            this.txtCount.Location = new System.Drawing.Point(265, 302);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(0, 12);
            this.txtCount.TabIndex = 24;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(394, 389);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comDeviceList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtARPDestIP);
            this.Controls.Add(this.txtARPDestMac);
            this.Controls.Add(this.txtARPSourIP);
            this.Controls.Add(this.txtARPSourMac);
            this.Controls.Add(this.txtEhDestMac);
            this.Controls.Add(this.txtEhSourMac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "form1";
            this.Text = "发包测试工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoReq;
        private System.Windows.Forms.RadioButton rdoResp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEhSourMac;
        private System.Windows.Forms.TextBox txtEhDestMac;
        private System.Windows.Forms.TextBox txtARPSourMac;
        private System.Windows.Forms.TextBox txtARPSourIP;
        private System.Windows.Forms.TextBox txtARPDestMac;
        private System.Windows.Forms.TextBox txtARPDestIP;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comDeviceList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtCount;
    }
}

