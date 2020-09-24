namespace ClassAttendenceManageSystem
{
    partial class Form_adminAddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusTimeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.lbComStat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comPort = new System.Windows.Forms.Label();
            this.gpPortSet = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSnr = new System.Windows.Forms.ComboBox();
            this.ReadSnrCmdButton = new System.Windows.Forms.Button();
            this.writeCmdButton = new System.Windows.Forms.Button();
            this.buttongetStuID = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.cmStopBit = new System.Windows.Forms.ComboBox();
            this.cmParity = new System.Windows.Forms.ComboBox();
            this.cmDataBit = new System.Windows.Forms.ComboBox();
            this.cmBaudRate = new System.Windows.Forms.ComboBox();
            this.cmPort = new System.Windows.Forms.ComboBox();
            this.gpRec = new System.Windows.Forms.GroupBox();
            this.cbAutoClr = new System.Windows.Forms.CheckBox();
            this.lbHexData = new System.Windows.Forms.Label();
            this.btClrRec = new System.Windows.Forms.Button();
            this.rtbRecStr = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gpSend = new System.Windows.Forms.GroupBox();
            this.tbTimeStr = new System.Windows.Forms.TextBox();
            this.cbTimeStr = new System.Windows.Forms.CheckBox();
            this.tbSendStr = new System.Windows.Forms.TextBox();
            this.btClrSend = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.statustimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeStr = new System.Windows.Forms.Timer(this.components);
            this.TimeHex = new System.Windows.Forms.Timer(this.components);
            this.sComm = new System.IO.Ports.SerialPort(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.recordState = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpPortSet.SuspendLayout();
            this.gpRec.SuspendLayout();
            this.gpSend.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.RB2);
            this.panel1.Controls.Add(this.RB1);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 442);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.Location = new System.Drawing.Point(104, 187);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(138, 26);
            this.textBox8.TabIndex = 169;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RB2.Location = new System.Drawing.Point(177, 80);
            this.RB2.Margin = new System.Windows.Forms.Padding(2);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(42, 20);
            this.RB2.TabIndex = 168;
            this.RB2.TabStop = true;
            this.RB2.Text = "女";
            this.RB2.UseVisualStyleBackColor = true;
            this.RB2.CheckedChanged += new System.EventHandler(this.RB2_CheckedChanged);
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Checked = true;
            this.RB1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RB1.Location = new System.Drawing.Point(113, 80);
            this.RB1.Margin = new System.Windows.Forms.Padding(2);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(42, 20);
            this.RB1.TabIndex = 167;
            this.RB1.TabStop = true;
            this.RB1.Text = "男";
            this.RB1.UseVisualStyleBackColor = true;
            this.RB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox11.Location = new System.Drawing.Point(104, 272);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(138, 26);
            this.textBox11.TabIndex = 148;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(18, 277);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 147;
            this.label12.Text = "学生密码：";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(105, 47);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 26);
            this.textBox2.TabIndex = 166;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(105, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 26);
            this.textBox1.TabIndex = 165;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(105, 144);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(138, 26);
            this.textBox6.TabIndex = 164;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(19, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 163;
            this.label5.Text = "所在班级：";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(105, 107);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 26);
            this.textBox4.TabIndex = 162;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 161;
            this.label4.Text = "所在班号：";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(104, 229);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(138, 26);
            this.textBox9.TabIndex = 157;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(19, 234);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 152;
            this.label9.Text = "课 程 号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(18, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 151;
            this.label8.Text = "卡    号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 144;
            this.label1.Text = "学生编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 145;
            this.label2.Text = "学生姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 146;
            this.label3.Text = "学生性别：";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.Location = new System.Drawing.Point(147, 323);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(96, 42);
            this.btn_close.TabIndex = 143;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(21, 323);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(96, 42);
            this.btn_add.TabIndex = 142;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusTimeLabel);
            this.groupBox1.Location = new System.Drawing.Point(289, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 65);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // statusTimeLabel
            // 
            this.statusTimeLabel.AutoSize = true;
            this.statusTimeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusTimeLabel.Location = new System.Drawing.Point(13, 16);
            this.statusTimeLabel.Name = "statusTimeLabel";
            this.statusTimeLabel.Size = new System.Drawing.Size(56, 16);
            this.statusTimeLabel.TabIndex = 16;
            this.statusTimeLabel.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "校验位:";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(138, 139);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(89, 40);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "关闭端口";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbComStat
            // 
            this.lbComStat.AutoSize = true;
            this.lbComStat.Location = new System.Drawing.Point(407, 14);
            this.lbComStat.Name = "lbComStat";
            this.lbComStat.Size = new System.Drawing.Size(224, 16);
            this.lbComStat.TabIndex = 1;
            this.lbComStat.Text = "                           ";
            this.lbComStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "停止位:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "数据位:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "波特率:";
            // 
            // comPort
            // 
            this.comPort.AutoSize = true;
            this.comPort.Location = new System.Drawing.Point(9, 23);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(64, 16);
            this.comPort.TabIndex = 1;
            this.comPort.Text = "端口号:";
            // 
            // gpPortSet
            // 
            this.gpPortSet.Controls.Add(this.label6);
            this.gpPortSet.Controls.Add(this.comboBoxSnr);
            this.gpPortSet.Controls.Add(this.ReadSnrCmdButton);
            this.gpPortSet.Controls.Add(this.writeCmdButton);
            this.gpPortSet.Controls.Add(this.buttongetStuID);
            this.gpPortSet.Controls.Add(this.btQuit);
            this.gpPortSet.Controls.Add(this.label7);
            this.gpPortSet.Controls.Add(this.btClose);
            this.gpPortSet.Controls.Add(this.btOpen);
            this.gpPortSet.Controls.Add(this.lbComStat);
            this.gpPortSet.Controls.Add(this.label11);
            this.gpPortSet.Controls.Add(this.label13);
            this.gpPortSet.Controls.Add(this.label14);
            this.gpPortSet.Controls.Add(this.comPort);
            this.gpPortSet.Controls.Add(this.cmStopBit);
            this.gpPortSet.Controls.Add(this.cmParity);
            this.gpPortSet.Controls.Add(this.cmDataBit);
            this.gpPortSet.Controls.Add(this.cmBaudRate);
            this.gpPortSet.Controls.Add(this.cmPort);
            this.gpPortSet.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpPortSet.Location = new System.Drawing.Point(289, 84);
            this.gpPortSet.Name = "gpPortSet";
            this.gpPortSet.Size = new System.Drawing.Size(247, 370);
            this.gpPortSet.TabIndex = 20;
            this.gpPortSet.TabStop = false;
            this.gpPortSet.Text = "端口设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "选择扇区号:";
            // 
            // comboBoxSnr
            // 
            this.comboBoxSnr.FormattingEnabled = true;
            this.comboBoxSnr.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBoxSnr.Location = new System.Drawing.Point(11, 322);
            this.comboBoxSnr.Name = "comboBoxSnr";
            this.comboBoxSnr.Size = new System.Drawing.Size(78, 24);
            this.comboBoxSnr.TabIndex = 13;
            this.comboBoxSnr.Text = "01";
            // 
            // ReadSnrCmdButton
            // 
            this.ReadSnrCmdButton.Location = new System.Drawing.Point(140, 314);
            this.ReadSnrCmdButton.Name = "ReadSnrCmdButton";
            this.ReadSnrCmdButton.Size = new System.Drawing.Size(87, 45);
            this.ReadSnrCmdButton.TabIndex = 12;
            this.ReadSnrCmdButton.Text = "读卡扇区";
            this.ReadSnrCmdButton.UseVisualStyleBackColor = true;
            this.ReadSnrCmdButton.Click += new System.EventHandler(this.ReadSnrCmdButton_Click);
            // 
            // writeCmdButton
            // 
            this.writeCmdButton.Location = new System.Drawing.Point(138, 255);
            this.writeCmdButton.Name = "writeCmdButton";
            this.writeCmdButton.Size = new System.Drawing.Size(87, 45);
            this.writeCmdButton.TabIndex = 11;
            this.writeCmdButton.Text = "写卡扇区";
            this.writeCmdButton.UseVisualStyleBackColor = true;
            this.writeCmdButton.Click += new System.EventHandler(this.writeCmdButton_Click);
            // 
            // buttongetStuID
            // 
            this.buttongetStuID.Location = new System.Drawing.Point(140, 20);
            this.buttongetStuID.Name = "buttongetStuID";
            this.buttongetStuID.Size = new System.Drawing.Size(87, 45);
            this.buttongetStuID.TabIndex = 10;
            this.buttongetStuID.Text = "获取学号";
            this.buttongetStuID.UseVisualStyleBackColor = true;
            this.buttongetStuID.Click += new System.EventHandler(this.button1_Click);
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("华文新魏", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQuit.ForeColor = System.Drawing.Color.MediumBlue;
            this.btQuit.Location = new System.Drawing.Point(138, 194);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(87, 49);
            this.btQuit.TabIndex = 9;
            this.btQuit.Text = "退出";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(140, 82);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(87, 45);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "打开端口";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // cmStopBit
            // 
            this.cmStopBit.FormattingEnabled = true;
            this.cmStopBit.Items.AddRange(new object[] {
            "One",
            "Two",
            "OnePointFive"});
            this.cmStopBit.Location = new System.Drawing.Point(11, 264);
            this.cmStopBit.Name = "cmStopBit";
            this.cmStopBit.Size = new System.Drawing.Size(78, 24);
            this.cmStopBit.TabIndex = 0;
            this.cmStopBit.Text = "One";
            // 
            // cmParity
            // 
            this.cmParity.FormattingEnabled = true;
            this.cmParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cmParity.Location = new System.Drawing.Point(11, 205);
            this.cmParity.Name = "cmParity";
            this.cmParity.Size = new System.Drawing.Size(78, 24);
            this.cmParity.TabIndex = 0;
            this.cmParity.Text = "None";
            // 
            // cmDataBit
            // 
            this.cmDataBit.FormattingEnabled = true;
            this.cmDataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cmDataBit.Location = new System.Drawing.Point(11, 151);
            this.cmDataBit.Name = "cmDataBit";
            this.cmDataBit.Size = new System.Drawing.Size(78, 24);
            this.cmDataBit.TabIndex = 0;
            this.cmDataBit.Text = "8";
            // 
            // cmBaudRate
            // 
            this.cmBaudRate.FormattingEnabled = true;
            this.cmBaudRate.Items.AddRange(new object[] {
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.cmBaudRate.Location = new System.Drawing.Point(11, 93);
            this.cmBaudRate.Name = "cmBaudRate";
            this.cmBaudRate.Size = new System.Drawing.Size(78, 24);
            this.cmBaudRate.TabIndex = 0;
            this.cmBaudRate.Text = "115200";
            // 
            // cmPort
            // 
            this.cmPort.FormattingEnabled = true;
            this.cmPort.Location = new System.Drawing.Point(12, 41);
            this.cmPort.Name = "cmPort";
            this.cmPort.Size = new System.Drawing.Size(77, 24);
            this.cmPort.TabIndex = 0;
            // 
            // gpRec
            // 
            this.gpRec.Controls.Add(this.cbAutoClr);
            this.gpRec.Controls.Add(this.lbHexData);
            this.gpRec.Controls.Add(this.btClrRec);
            this.gpRec.Controls.Add(this.rtbRecStr);
            this.gpRec.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpRec.Location = new System.Drawing.Point(14, 2);
            this.gpRec.Name = "gpRec";
            this.gpRec.Size = new System.Drawing.Size(506, 211);
            this.gpRec.TabIndex = 22;
            this.gpRec.TabStop = false;
            this.gpRec.Text = "接收窗口";
            // 
            // cbAutoClr
            // 
            this.cbAutoClr.AutoSize = true;
            this.cbAutoClr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAutoClr.Location = new System.Drawing.Point(212, 179);
            this.cbAutoClr.Name = "cbAutoClr";
            this.cbAutoClr.Size = new System.Drawing.Size(91, 20);
            this.cbAutoClr.TabIndex = 6;
            this.cbAutoClr.Text = "自动清除";
            this.cbAutoClr.UseVisualStyleBackColor = true;
            // 
            // lbHexData
            // 
            this.lbHexData.AutoSize = true;
            this.lbHexData.Location = new System.Drawing.Point(175, 202);
            this.lbHexData.Name = "lbHexData";
            this.lbHexData.Size = new System.Drawing.Size(104, 16);
            this.lbHexData.TabIndex = 5;
            this.lbHexData.Text = "            ";
            // 
            // btClrRec
            // 
            this.btClrRec.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClrRec.Location = new System.Drawing.Point(332, 177);
            this.btClrRec.Name = "btClrRec";
            this.btClrRec.Size = new System.Drawing.Size(75, 23);
            this.btClrRec.TabIndex = 4;
            this.btClrRec.Text = "清  除";
            this.btClrRec.UseVisualStyleBackColor = true;
            this.btClrRec.Click += new System.EventHandler(this.btClrRec_Click);
            // 
            // rtbRecStr
            // 
            this.rtbRecStr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbRecStr.Location = new System.Drawing.Point(13, 25);
            this.rtbRecStr.Name = "rtbRecStr";
            this.rtbRecStr.Size = new System.Drawing.Size(394, 148);
            this.rtbRecStr.TabIndex = 0;
            this.rtbRecStr.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(212, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "ms";
            // 
            // gpSend
            // 
            this.gpSend.Controls.Add(this.label15);
            this.gpSend.Controls.Add(this.tbTimeStr);
            this.gpSend.Controls.Add(this.cbTimeStr);
            this.gpSend.Controls.Add(this.tbSendStr);
            this.gpSend.Controls.Add(this.btClrSend);
            this.gpSend.Controls.Add(this.btSend);
            this.gpSend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpSend.Location = new System.Drawing.Point(14, 227);
            this.gpSend.Name = "gpSend";
            this.gpSend.Size = new System.Drawing.Size(506, 189);
            this.gpSend.TabIndex = 21;
            this.gpSend.TabStop = false;
            this.gpSend.Text = "发送窗口";
            // 
            // tbTimeStr
            // 
            this.tbTimeStr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTimeStr.Location = new System.Drawing.Point(164, 157);
            this.tbTimeStr.Name = "tbTimeStr";
            this.tbTimeStr.Size = new System.Drawing.Size(45, 26);
            this.tbTimeStr.TabIndex = 5;
            this.tbTimeStr.Text = "1000";
            // 
            // cbTimeStr
            // 
            this.cbTimeStr.AutoSize = true;
            this.cbTimeStr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTimeStr.Location = new System.Drawing.Point(109, 162);
            this.cbTimeStr.Name = "cbTimeStr";
            this.cbTimeStr.Size = new System.Drawing.Size(59, 20);
            this.cbTimeStr.TabIndex = 14;
            this.cbTimeStr.Text = "定时";
            this.cbTimeStr.UseVisualStyleBackColor = true;
            // 
            // tbSendStr
            // 
            this.tbSendStr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSendStr.Location = new System.Drawing.Point(15, 25);
            this.tbSendStr.Multiline = true;
            this.tbSendStr.Name = "tbSendStr";
            this.tbSendStr.Size = new System.Drawing.Size(392, 128);
            this.tbSendStr.TabIndex = 11;
            // 
            // btClrSend
            // 
            this.btClrSend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClrSend.Location = new System.Drawing.Point(238, 158);
            this.btClrSend.Name = "btClrSend";
            this.btClrSend.Size = new System.Drawing.Size(75, 23);
            this.btClrSend.TabIndex = 8;
            this.btClrSend.Text = "清除文本";
            this.btClrSend.UseVisualStyleBackColor = true;
            this.btClrSend.Click += new System.EventHandler(this.btClrSend_Click);
            // 
            // btSend
            // 
            this.btSend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSend.Location = new System.Drawing.Point(319, 158);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(87, 23);
            this.btSend.TabIndex = 1;
            this.btSend.Text = "发送文本";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // statustimer
            // 
            this.statustimer.Tick += new System.EventHandler(this.statustimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeStr
            // 
            this.TimeStr.Interval = 1000;
            this.TimeStr.Tick += new System.EventHandler(this.TimeStr_Tick);
            // 
            // TimeHex
            // 
            this.TimeHex.Interval = 1000;
            this.TimeHex.Tick += new System.EventHandler(this.TimeHex_Tick);
            // 
            // sComm
            // 
            this.sComm.BaudRate = 38400;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.recordState);
            this.panel2.Controls.Add(this.gpRec);
            this.panel2.Controls.Add(this.gpSend);
            this.panel2.Location = new System.Drawing.Point(554, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 432);
            this.panel2.TabIndex = 29;
            // 
            // recordState
            // 
            this.recordState.AutoSize = true;
            this.recordState.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recordState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.recordState.Location = new System.Drawing.Point(27, 206);
            this.recordState.Name = "recordState";
            this.recordState.Size = new System.Drawing.Size(56, 16);
            this.recordState.TabIndex = 7;
            this.recordState.Text = "record";
            // 
            // Form_adminAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpPortSet);
            this.Controls.Add(this.panel1);
            this.Name = "Form_adminAddStudent";
            this.Text = "Form_adminAddStudent";
            this.Load += new System.EventHandler(this.Form_adminAddStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpPortSet.ResumeLayout(false);
            this.gpPortSet.PerformLayout();
            this.gpRec.ResumeLayout(false);
            this.gpRec.PerformLayout();
            this.gpSend.ResumeLayout(false);
            this.gpSend.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gpRec;
        private System.Windows.Forms.CheckBox cbAutoClr;
        private System.Windows.Forms.Label lbHexData;
        private System.Windows.Forms.Button btClrRec;
        private System.Windows.Forms.RichTextBox rtbRecStr;
        private System.Windows.Forms.GroupBox gpSend;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTimeStr;
        private System.Windows.Forms.CheckBox cbTimeStr;
        private System.Windows.Forms.TextBox tbSendStr;
        private System.Windows.Forms.Button btClrSend;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label statusTimeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbComStat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label comPort;
        private System.Windows.Forms.GroupBox gpPortSet;
        private System.Windows.Forms.Button buttongetStuID;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.ComboBox cmStopBit;
        private System.Windows.Forms.ComboBox cmParity;
        private System.Windows.Forms.ComboBox cmDataBit;
        private System.Windows.Forms.ComboBox cmBaudRate;
        private System.Windows.Forms.ComboBox cmPort;
        private System.Windows.Forms.Timer statustimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer TimeStr;
        private System.Windows.Forms.Timer TimeHex;
        private System.IO.Ports.SerialPort sComm;
        private System.Windows.Forms.Button ReadSnrCmdButton;
        private System.Windows.Forms.Button writeCmdButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSnr;
        private System.Windows.Forms.Label recordState;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
    }
}