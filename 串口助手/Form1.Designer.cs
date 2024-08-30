namespace 串口助手 {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.recive_rtb = new System.Windows.Forms.RichTextBox();
            this.port_cbb = new System.Windows.Forms.ComboBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.send_rtb = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.DTR_chb = new System.Windows.Forms.CheckBox();
            this.RTS_chb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stopbit_cbb = new System.Windows.Forms.ComboBox();
            this.databit_cbb = new System.Windows.Forms.ComboBox();
            this.check_cbb = new System.Windows.Forms.ComboBox();
            this.baud_cbb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.recivefile_txb = new System.Windows.Forms.TextBox();
            this.recivehex_chb = new System.Windows.Forms.CheckBox();
            this.autoclear_chb = new System.Windows.Forms.CheckBox();
            this.xzlj_btn = new System.Windows.Forms.Button();
            this.bcsj_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.autotimer_txb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sendfile_txb = new System.Windows.Forms.TextBox();
            this.sendhex_chb = new System.Windows.Forms.CheckBox();
            this.autosend_chb = new System.Windows.Forms.CheckBox();
            this.dkwj_btn = new System.Windows.Forms.Button();
            this.fswj_btn = new System.Windows.Forms.Button();
            this.sendclear_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.state_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendcount_tssl_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendcount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.recivecount_tssl_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.recivecount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.clearcount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.data_txb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.data4_txb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.data3_txb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.data2_txb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.data1_txb = new System.Windows.Forms.TextBox();
            this.startData_cbb = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // recive_rtb
            // 
            this.recive_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recive_rtb.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recive_rtb.Location = new System.Drawing.Point(3, 27);
            this.recive_rtb.Name = "recive_rtb";
            this.recive_rtb.Size = new System.Drawing.Size(493, 490);
            this.recive_rtb.TabIndex = 2;
            this.recive_rtb.Text = "";
            // 
            // port_cbb
            // 
            this.port_cbb.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.port_cbb.FormattingEnabled = true;
            this.port_cbb.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3"});
            this.port_cbb.Location = new System.Drawing.Point(122, 24);
            this.port_cbb.Name = "port_cbb";
            this.port_cbb.Size = new System.Drawing.Size(175, 32);
            this.port_cbb.TabIndex = 3;
            // 
            // send_btn
            // 
            this.send_btn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.send_btn.Location = new System.Drawing.Point(184, 30);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(121, 32);
            this.send_btn.TabIndex = 4;
            this.send_btn.Text = "手动发送";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // send_rtb
            // 
            this.send_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.send_rtb.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.send_rtb.Location = new System.Drawing.Point(3, 27);
            this.send_rtb.Name = "send_rtb";
            this.send_rtb.Size = new System.Drawing.Size(493, 226);
            this.send_rtb.TabIndex = 6;
            this.send_rtb.Text = "";
            this.send_rtb.TextChanged += new System.EventHandler(this.send_rtb_TextChanged);
            this.send_rtb.Leave += new System.EventHandler(this.send_rtb_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.open_btn);
            this.groupBox1.Controls.Add(this.DTR_chb);
            this.groupBox1.Controls.Add(this.RTS_chb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stopbit_cbb);
            this.groupBox1.Controls.Add(this.databit_cbb);
            this.groupBox1.Controls.Add(this.check_cbb);
            this.groupBox1.Controls.Add(this.baud_cbb);
            this.groupBox1.Controls.Add(this.port_cbb);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 304);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // open_btn
            // 
            this.open_btn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.open_btn.Location = new System.Drawing.Point(126, 229);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(159, 52);
            this.open_btn.TabIndex = 8;
            this.open_btn.Text = "打开串口";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // DTR_chb
            // 
            this.DTR_chb.AutoSize = true;
            this.DTR_chb.Location = new System.Drawing.Point(23, 269);
            this.DTR_chb.Name = "DTR_chb";
            this.DTR_chb.Size = new System.Drawing.Size(68, 28);
            this.DTR_chb.TabIndex = 13;
            this.DTR_chb.Text = "DTR";
            this.DTR_chb.UseVisualStyleBackColor = true;
            this.DTR_chb.CheckedChanged += new System.EventHandler(this.DTR_chb_CheckedChanged);
            // 
            // RTS_chb
            // 
            this.RTS_chb.AutoSize = true;
            this.RTS_chb.Location = new System.Drawing.Point(23, 235);
            this.RTS_chb.Name = "RTS_chb";
            this.RTS_chb.Size = new System.Drawing.Size(64, 28);
            this.RTS_chb.TabIndex = 11;
            this.RTS_chb.Text = "RTS";
            this.RTS_chb.UseVisualStyleBackColor = true;
            this.RTS_chb.CheckedChanged += new System.EventHandler(this.RTS_chb_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "端口号";
            // 
            // stopbit_cbb
            // 
            this.stopbit_cbb.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopbit_cbb.FormattingEnabled = true;
            this.stopbit_cbb.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbit_cbb.Location = new System.Drawing.Point(122, 184);
            this.stopbit_cbb.Name = "stopbit_cbb";
            this.stopbit_cbb.Size = new System.Drawing.Size(175, 32);
            this.stopbit_cbb.TabIndex = 7;
            // 
            // databit_cbb
            // 
            this.databit_cbb.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.databit_cbb.FormattingEnabled = true;
            this.databit_cbb.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databit_cbb.Location = new System.Drawing.Point(122, 144);
            this.databit_cbb.Name = "databit_cbb";
            this.databit_cbb.Size = new System.Drawing.Size(175, 32);
            this.databit_cbb.TabIndex = 6;
            // 
            // check_cbb
            // 
            this.check_cbb.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_cbb.FormattingEnabled = true;
            this.check_cbb.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.check_cbb.Location = new System.Drawing.Point(122, 104);
            this.check_cbb.Name = "check_cbb";
            this.check_cbb.Size = new System.Drawing.Size(175, 32);
            this.check_cbb.TabIndex = 5;
            // 
            // baud_cbb
            // 
            this.baud_cbb.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baud_cbb.FormattingEnabled = true;
            this.baud_cbb.Items.AddRange(new object[] {
            "115200",
            "9600",
            "4800"});
            this.baud_cbb.Location = new System.Drawing.Point(122, 64);
            this.baud_cbb.Name = "baud_cbb";
            this.baud_cbb.Size = new System.Drawing.Size(175, 32);
            this.baud_cbb.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.recivefile_txb);
            this.groupBox2.Controls.Add(this.recivehex_chb);
            this.groupBox2.Controls.Add(this.autoclear_chb);
            this.groupBox2.Controls.Add(this.xzlj_btn);
            this.groupBox2.Controls.Add(this.bcsj_btn);
            this.groupBox2.Controls.Add(this.stop_btn);
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 217);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // recivefile_txb
            // 
            this.recivefile_txb.Location = new System.Drawing.Point(23, 170);
            this.recivefile_txb.Name = "recivefile_txb";
            this.recivefile_txb.Size = new System.Drawing.Size(282, 31);
            this.recivefile_txb.TabIndex = 16;
            // 
            // recivehex_chb
            // 
            this.recivehex_chb.AutoSize = true;
            this.recivehex_chb.Location = new System.Drawing.Point(23, 73);
            this.recivehex_chb.Name = "recivehex_chb";
            this.recivehex_chb.Size = new System.Drawing.Size(104, 28);
            this.recivehex_chb.TabIndex = 15;
            this.recivehex_chb.Text = "十六进制";
            this.recivehex_chb.UseVisualStyleBackColor = true;
            this.recivehex_chb.CheckedChanged += new System.EventHandler(this.recivehex_chb_CheckedChanged);
            // 
            // autoclear_chb
            // 
            this.autoclear_chb.AutoSize = true;
            this.autoclear_chb.Location = new System.Drawing.Point(23, 34);
            this.autoclear_chb.Name = "autoclear_chb";
            this.autoclear_chb.Size = new System.Drawing.Size(104, 28);
            this.autoclear_chb.TabIndex = 14;
            this.autoclear_chb.Text = "自动清空";
            this.autoclear_chb.UseVisualStyleBackColor = true;
            this.autoclear_chb.CheckedChanged += new System.EventHandler(this.autoclear_chb_CheckedChanged);
            // 
            // xzlj_btn
            // 
            this.xzlj_btn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xzlj_btn.Location = new System.Drawing.Point(23, 121);
            this.xzlj_btn.Name = "xzlj_btn";
            this.xzlj_btn.Size = new System.Drawing.Size(121, 32);
            this.xzlj_btn.TabIndex = 11;
            this.xzlj_btn.Text = "选择路径";
            this.xzlj_btn.UseVisualStyleBackColor = true;
            this.xzlj_btn.Click += new System.EventHandler(this.xzlj_btn_Click);
            // 
            // bcsj_btn
            // 
            this.bcsj_btn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bcsj_btn.Location = new System.Drawing.Point(184, 122);
            this.bcsj_btn.Name = "bcsj_btn";
            this.bcsj_btn.Size = new System.Drawing.Size(121, 32);
            this.bcsj_btn.TabIndex = 10;
            this.bcsj_btn.Text = "保存数据";
            this.bcsj_btn.UseVisualStyleBackColor = true;
            this.bcsj_btn.Click += new System.EventHandler(this.bcsj_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stop_btn.Location = new System.Drawing.Point(184, 73);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(121, 32);
            this.stop_btn.TabIndex = 9;
            this.stop_btn.Text = "暂停";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear_btn.Location = new System.Drawing.Point(184, 30);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(121, 32);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Text = "手动清空";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.autotimer_txb);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.sendfile_txb);
            this.groupBox3.Controls.Add(this.sendhex_chb);
            this.groupBox3.Controls.Add(this.autosend_chb);
            this.groupBox3.Controls.Add(this.dkwj_btn);
            this.groupBox3.Controls.Add(this.fswj_btn);
            this.groupBox3.Controls.Add(this.sendclear_btn);
            this.groupBox3.Controls.Add(this.send_btn);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(12, 570);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 267);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // autotimer_txb
            // 
            this.autotimer_txb.Location = new System.Drawing.Point(205, 225);
            this.autotimer_txb.Name = "autotimer_txb";
            this.autotimer_txb.Size = new System.Drawing.Size(100, 31);
            this.autotimer_txb.TabIndex = 19;
            this.autotimer_txb.Text = "1000";
            this.autotimer_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "自动发送周期(ms):";
            // 
            // sendfile_txb
            // 
            this.sendfile_txb.Location = new System.Drawing.Point(23, 180);
            this.sendfile_txb.Name = "sendfile_txb";
            this.sendfile_txb.Size = new System.Drawing.Size(282, 31);
            this.sendfile_txb.TabIndex = 17;
            // 
            // sendhex_chb
            // 
            this.sendhex_chb.AutoSize = true;
            this.sendhex_chb.Location = new System.Drawing.Point(23, 72);
            this.sendhex_chb.Name = "sendhex_chb";
            this.sendhex_chb.Size = new System.Drawing.Size(104, 28);
            this.sendhex_chb.TabIndex = 18;
            this.sendhex_chb.Text = "十六进制";
            this.sendhex_chb.UseVisualStyleBackColor = true;
            this.sendhex_chb.CheckedChanged += new System.EventHandler(this.sendhex_chb_CheckedChanged);
            // 
            // autosend_chb
            // 
            this.autosend_chb.AutoSize = true;
            this.autosend_chb.Location = new System.Drawing.Point(23, 33);
            this.autosend_chb.Name = "autosend_chb";
            this.autosend_chb.Size = new System.Drawing.Size(104, 28);
            this.autosend_chb.TabIndex = 17;
            this.autosend_chb.Text = "自动发送";
            this.autosend_chb.UseVisualStyleBackColor = true;
            this.autosend_chb.CheckedChanged += new System.EventHandler(this.autosend_chb_CheckedChanged);
            // 
            // dkwj_btn
            // 
            this.dkwj_btn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dkwj_btn.Location = new System.Drawing.Point(23, 129);
            this.dkwj_btn.Name = "dkwj_btn";
            this.dkwj_btn.Size = new System.Drawing.Size(121, 32);
            this.dkwj_btn.TabIndex = 7;
            this.dkwj_btn.Text = "打开文件";
            this.dkwj_btn.UseVisualStyleBackColor = true;
            this.dkwj_btn.Click += new System.EventHandler(this.dkwj_btn_Click);
            // 
            // fswj_btn
            // 
            this.fswj_btn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fswj_btn.Location = new System.Drawing.Point(184, 128);
            this.fswj_btn.Name = "fswj_btn";
            this.fswj_btn.Size = new System.Drawing.Size(121, 32);
            this.fswj_btn.TabIndex = 6;
            this.fswj_btn.Text = "发送文件";
            this.fswj_btn.UseVisualStyleBackColor = true;
            this.fswj_btn.Click += new System.EventHandler(this.fswj_btn_Click);
            // 
            // sendclear_btn
            // 
            this.sendclear_btn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendclear_btn.Location = new System.Drawing.Point(184, 76);
            this.sendclear_btn.Name = "sendclear_btn";
            this.sendclear_btn.Size = new System.Drawing.Size(121, 32);
            this.sendclear_btn.TabIndex = 5;
            this.sendclear_btn.Text = "清空发送";
            this.sendclear_btn.UseVisualStyleBackColor = true;
            this.sendclear_btn.Click += new System.EventHandler(this.sendclear_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.recive_rtb);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(356, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 520);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.send_rtb);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(356, 570);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(499, 256);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.state_tssl,
            this.toolStripStatusLabel2,
            this.sendcount_tssl_name,
            this.sendcount_tssl,
            this.recivecount_tssl_name,
            this.recivecount_tssl,
            this.clearcount_tssl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 856);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1142, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // state_tssl
            // 
            this.state_tssl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_tssl.Name = "state_tssl";
            this.state_tssl.Size = new System.Drawing.Size(54, 20);
            this.state_tssl.Text = "状态：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(220, 20);
            this.toolStripStatusLabel2.Text = "初始化正常！";
            // 
            // sendcount_tssl_name
            // 
            this.sendcount_tssl_name.AutoSize = false;
            this.sendcount_tssl_name.Name = "sendcount_tssl_name";
            this.sendcount_tssl_name.Size = new System.Drawing.Size(120, 20);
            this.sendcount_tssl_name.Text = "发送计数：";
            // 
            // sendcount_tssl
            // 
            this.sendcount_tssl.AutoSize = false;
            this.sendcount_tssl.Name = "sendcount_tssl";
            this.sendcount_tssl.Size = new System.Drawing.Size(50, 20);
            this.sendcount_tssl.Text = "0";
            // 
            // recivecount_tssl_name
            // 
            this.recivecount_tssl_name.AutoSize = false;
            this.recivecount_tssl_name.Name = "recivecount_tssl_name";
            this.recivecount_tssl_name.Size = new System.Drawing.Size(120, 20);
            this.recivecount_tssl_name.Text = "接收计数：";
            // 
            // recivecount_tssl
            // 
            this.recivecount_tssl.AutoSize = false;
            this.recivecount_tssl.Name = "recivecount_tssl";
            this.recivecount_tssl.Size = new System.Drawing.Size(50, 20);
            this.recivecount_tssl.Text = "0";
            // 
            // clearcount_tssl
            // 
            this.clearcount_tssl.AutoSize = false;
            this.clearcount_tssl.Name = "clearcount_tssl";
            this.clearcount_tssl.Size = new System.Drawing.Size(80, 20);
            this.clearcount_tssl.Text = "清空计数";
            this.clearcount_tssl.Click += new System.EventHandler(this.clearcount_tssl_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.data_txb);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.data4_txb);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.data3_txb);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.data2_txb);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.data1_txb);
            this.groupBox6.Controls.Add(this.startData_cbb);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(873, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(258, 584);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "指令解析";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(10, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 114);
            this.label13.TabIndex = 25;
            this.label13.Text = "格式：\r\n      7F + 长度 + 数据 + CRC\r\n\r\n\r\n\r\n例：7f0431323334DE10";
            // 
            // data_txb
            // 
            this.data_txb.Location = new System.Drawing.Point(11, 269);
            this.data_txb.Multiline = true;
            this.data_txb.Name = "data_txb";
            this.data_txb.Size = new System.Drawing.Size(230, 96);
            this.data_txb.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "数据帧";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "数据4";
            // 
            // data4_txb
            // 
            this.data4_txb.Location = new System.Drawing.Point(77, 190);
            this.data4_txb.Name = "data4_txb";
            this.data4_txb.Size = new System.Drawing.Size(164, 31);
            this.data4_txb.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "数据3";
            // 
            // data3_txb
            // 
            this.data3_txb.Location = new System.Drawing.Point(77, 138);
            this.data3_txb.Name = "data3_txb";
            this.data3_txb.Size = new System.Drawing.Size(164, 31);
            this.data3_txb.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "数据2";
            // 
            // data2_txb
            // 
            this.data2_txb.Location = new System.Drawing.Point(77, 86);
            this.data2_txb.Name = "data2_txb";
            this.data2_txb.Size = new System.Drawing.Size(164, 31);
            this.data2_txb.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "数据1";
            // 
            // data1_txb
            // 
            this.data1_txb.Location = new System.Drawing.Point(77, 34);
            this.data1_txb.Name = "data1_txb";
            this.data1_txb.Size = new System.Drawing.Size(164, 31);
            this.data1_txb.TabIndex = 16;
            // 
            // startData_cbb
            // 
            this.startData_cbb.AutoSize = true;
            this.startData_cbb.Location = new System.Drawing.Point(11, 381);
            this.startData_cbb.Name = "startData_cbb";
            this.startData_cbb.Size = new System.Drawing.Size(158, 28);
            this.startData_cbb.TabIndex = 14;
            this.startData_cbb.Text = "启动数据帧接收";
            this.startData_cbb.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 882);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox recive_rtb;
        private System.Windows.Forms.ComboBox port_cbb;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.RichTextBox send_rtb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button fswj_btn;
        private System.Windows.Forms.Button sendclear_btn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stopbit_cbb;
        private System.Windows.Forms.ComboBox databit_cbb;
        private System.Windows.Forms.ComboBox check_cbb;
        private System.Windows.Forms.ComboBox baud_cbb;
        private System.Windows.Forms.Button dkwj_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox DTR_chb;
        private System.Windows.Forms.CheckBox RTS_chb;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button xzlj_btn;
        private System.Windows.Forms.Button bcsj_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.CheckBox recivehex_chb;
        private System.Windows.Forms.CheckBox autoclear_chb;
        private System.Windows.Forms.TextBox recivefile_txb;
        private System.Windows.Forms.CheckBox sendhex_chb;
        private System.Windows.Forms.CheckBox autosend_chb;
        private System.Windows.Forms.TextBox sendfile_txb;
        private System.Windows.Forms.TextBox autotimer_txb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel state_tssl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel sendcount_tssl_name;
        private System.Windows.Forms.ToolStripStatusLabel sendcount_tssl;
        private System.Windows.Forms.ToolStripStatusLabel recivecount_tssl_name;
        private System.Windows.Forms.ToolStripStatusLabel recivecount_tssl;
        private System.Windows.Forms.ToolStripStatusLabel clearcount_tssl;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox data1_txb;
        private System.Windows.Forms.CheckBox startData_cbb;
        private System.Windows.Forms.TextBox data_txb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox data4_txb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox data3_txb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox data2_txb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer2;
    }
}

