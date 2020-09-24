namespace ClassAttendenceManageSystem
{
    partial class Form_checkIning
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
            this.btClrSend = new System.Windows.Forms.Button();
            this.cbAutoClr = new System.Windows.Forms.CheckBox();
            this.lbHexData = new System.Windows.Forms.Label();
            this.btClrRec = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rdAdd = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.tbDec = new System.Windows.Forms.TextBox();
            this.rdXor = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTimeStr = new System.Windows.Forms.CheckBox();
            this.tbTimeHex = new System.Windows.Forms.TextBox();
            this.cbTimeHex = new System.Windows.Forms.CheckBox();
            this.gpDefFrm = new System.Windows.Forms.GroupBox();
            this.cbDefFrm = new System.Windows.Forms.CheckBox();
            this.tbSendStr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbRecStr = new System.Windows.Forms.RichTextBox();
            this.TimeStr = new System.Windows.Forms.Timer(this.components);
            this.TimeHex = new System.Windows.Forms.Timer(this.components);
            this.sComm = new System.IO.Ports.SerialPort(this.components);
            this.btQuit = new System.Windows.Forms.Button();
            this.tbTimeStr = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.rtbRecHex = new System.Windows.Forms.RichTextBox();
            this.lbComStat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comPort = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpPortSet = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.cmStopBit = new System.Windows.Forms.ComboBox();
            this.cmParity = new System.Windows.Forms.ComboBox();
            this.cmDataBit = new System.Windows.Forms.ComboBox();
            this.cmBaudRate = new System.Windows.Forms.ComboBox();
            this.cmPort = new System.Windows.Forms.ComboBox();
            this.gpRec = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gpSend = new System.Windows.Forms.GroupBox();
            this.statustimer = new System.Windows.Forms.Timer(this.components);
            this.statusTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timercomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpDefFrm.SuspendLayout();
            this.gpPortSet.SuspendLayout();
            this.gpRec.SuspendLayout();
            this.gpSend.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClrSend
            // 
            this.btClrSend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClrSend.Location = new System.Drawing.Point(332, 156);
            this.btClrSend.Name = "btClrSend";
            this.btClrSend.Size = new System.Drawing.Size(75, 23);
            this.btClrSend.TabIndex = 8;
            this.btClrSend.Text = "清除文本";
            this.btClrSend.UseVisualStyleBackColor = true;
            this.btClrSend.Click += new System.EventHandler(this.btClrSend_Click);
            // 
            // cbAutoClr
            // 
            this.cbAutoClr.AutoSize = true;
            this.cbAutoClr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAutoClr.Location = new System.Drawing.Point(316, 360);
            this.cbAutoClr.Name = "cbAutoClr";
            this.cbAutoClr.Size = new System.Drawing.Size(91, 20);
            this.cbAutoClr.TabIndex = 6;
            this.cbAutoClr.Text = "自动清除";
            this.cbAutoClr.UseVisualStyleBackColor = true;
            // 
            // lbHexData
            // 
            this.lbHexData.AutoSize = true;
            this.lbHexData.Location = new System.Drawing.Point(163, 387);
            this.lbHexData.Name = "lbHexData";
            this.lbHexData.Size = new System.Drawing.Size(104, 16);
            this.lbHexData.TabIndex = 5;
            this.lbHexData.Text = "            ";
            // 
            // btClrRec
            // 
            this.btClrRec.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClrRec.Location = new System.Drawing.Point(413, 358);
            this.btClrRec.Name = "btClrRec";
            this.btClrRec.Size = new System.Drawing.Size(75, 23);
            this.btClrRec.TabIndex = 4;
            this.btClrRec.Text = "清  除";
            this.btClrRec.UseVisualStyleBackColor = true;
            this.btClrRec.Click += new System.EventHandler(this.btClrRec_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(757, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "十六进制";
            // 
            // rdAdd
            // 
            this.rdAdd.AutoSize = true;
            this.rdAdd.Location = new System.Drawing.Point(158, 91);
            this.rdAdd.Name = "rdAdd";
            this.rdAdd.Size = new System.Drawing.Size(74, 20);
            this.rdAdd.TabIndex = 6;
            this.rdAdd.Text = "和校验";
            this.rdAdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "帧头";
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(63, 85);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(67, 26);
            this.tbStart.TabIndex = 5;
            this.tbStart.Text = "55";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "帧尾";
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(63, 113);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(67, 26);
            this.tbEnd.TabIndex = 5;
            this.tbEnd.Text = "AA";
            // 
            // tbHex
            // 
            this.tbHex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHex.Location = new System.Drawing.Point(743, 411);
            this.tbHex.Name = "tbHex";
            this.tbHex.Size = new System.Drawing.Size(120, 26);
            this.tbHex.TabIndex = 10;
            // 
            // tbDec
            // 
            this.tbDec.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDec.Location = new System.Drawing.Point(589, 411);
            this.tbDec.Name = "tbDec";
            this.tbDec.Size = new System.Drawing.Size(120, 26);
            this.tbDec.TabIndex = 10;
            this.tbDec.Text = "1000";
            // 
            // rdXor
            // 
            this.rdXor.AutoSize = true;
            this.rdXor.Checked = true;
            this.rdXor.Location = new System.Drawing.Point(158, 114);
            this.rdXor.Name = "rdXor";
            this.rdXor.Size = new System.Drawing.Size(90, 20);
            this.rdXor.TabIndex = 7;
            this.rdXor.TabStop = true;
            this.rdXor.Text = "异或校验";
            this.rdXor.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(121, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "ms";
            // 
            // cbTimeStr
            // 
            this.cbTimeStr.AutoSize = true;
            this.cbTimeStr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTimeStr.Location = new System.Drawing.Point(203, 160);
            this.cbTimeStr.Name = "cbTimeStr";
            this.cbTimeStr.Size = new System.Drawing.Size(59, 20);
            this.cbTimeStr.TabIndex = 14;
            this.cbTimeStr.Text = "定时";
            this.cbTimeStr.UseVisualStyleBackColor = true;
            // 
            // tbTimeHex
            // 
            this.tbTimeHex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTimeHex.Location = new System.Drawing.Point(71, 47);
            this.tbTimeHex.Name = "tbTimeHex";
            this.tbTimeHex.Size = new System.Drawing.Size(49, 26);
            this.tbTimeHex.TabIndex = 5;
            this.tbTimeHex.Text = "1000";
            // 
            // cbTimeHex
            // 
            this.cbTimeHex.AutoSize = true;
            this.cbTimeHex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTimeHex.Location = new System.Drawing.Point(15, 50);
            this.cbTimeHex.Name = "cbTimeHex";
            this.cbTimeHex.Size = new System.Drawing.Size(59, 20);
            this.cbTimeHex.TabIndex = 14;
            this.cbTimeHex.Text = "定时";
            this.cbTimeHex.UseVisualStyleBackColor = true;
            // 
            // gpDefFrm
            // 
            this.gpDefFrm.Controls.Add(this.rdAdd);
            this.gpDefFrm.Controls.Add(this.label7);
            this.gpDefFrm.Controls.Add(this.label12);
            this.gpDefFrm.Controls.Add(this.tbStart);
            this.gpDefFrm.Controls.Add(this.label8);
            this.gpDefFrm.Controls.Add(this.tbEnd);
            this.gpDefFrm.Controls.Add(this.rdXor);
            this.gpDefFrm.Controls.Add(this.tbTimeHex);
            this.gpDefFrm.Controls.Add(this.cbDefFrm);
            this.gpDefFrm.Controls.Add(this.cbTimeHex);
            this.gpDefFrm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpDefFrm.Location = new System.Drawing.Point(589, 449);
            this.gpDefFrm.Name = "gpDefFrm";
            this.gpDefFrm.Size = new System.Drawing.Size(274, 146);
            this.gpDefFrm.TabIndex = 13;
            this.gpDefFrm.TabStop = false;
            this.gpDefFrm.Text = "自定义帧";
            // 
            // cbDefFrm
            // 
            this.cbDefFrm.AutoSize = true;
            this.cbDefFrm.Checked = true;
            this.cbDefFrm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefFrm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDefFrm.Location = new System.Drawing.Point(15, 25);
            this.cbDefFrm.Name = "cbDefFrm";
            this.cbDefFrm.Size = new System.Drawing.Size(123, 20);
            this.cbDefFrm.TabIndex = 12;
            this.cbDefFrm.Text = "使用自定义帧";
            this.cbDefFrm.UseVisualStyleBackColor = true;
            // 
            // tbSendStr
            // 
            this.tbSendStr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSendStr.Location = new System.Drawing.Point(6, 20);
            this.tbSendStr.Multiline = true;
            this.tbSendStr.Name = "tbSendStr";
            this.tbSendStr.Size = new System.Drawing.Size(491, 128);
            this.tbSendStr.TabIndex = 11;
            this.tbSendStr.Text = "在此输入要发送的内容";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(615, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "十进制";
            // 
            // rtbRecStr
            // 
            this.rtbRecStr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbRecStr.Location = new System.Drawing.Point(6, 20);
            this.rtbRecStr.Name = "rtbRecStr";
            this.rtbRecStr.Size = new System.Drawing.Size(491, 209);
            this.rtbRecStr.TabIndex = 0;
            this.rtbRecStr.Text = "";
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
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("华文新魏", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQuit.ForeColor = System.Drawing.Color.MediumBlue;
            this.btQuit.Location = new System.Drawing.Point(140, 231);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(87, 49);
            this.btQuit.TabIndex = 9;
            this.btQuit.Text = "退出";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // tbTimeStr
            // 
            this.tbTimeStr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTimeStr.Location = new System.Drawing.Point(258, 155);
            this.tbTimeStr.Name = "tbTimeStr";
            this.tbTimeStr.Size = new System.Drawing.Size(45, 26);
            this.tbTimeStr.TabIndex = 5;
            this.tbTimeStr.Text = "1000";
            // 
            // btSend
            // 
            this.btSend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSend.Location = new System.Drawing.Point(413, 156);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(87, 23);
            this.btSend.TabIndex = 1;
            this.btSend.Text = "发送文本";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // rtbRecHex
            // 
            this.rtbRecHex.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbRecHex.Location = new System.Drawing.Point(6, 240);
            this.rtbRecHex.Name = "rtbRecHex";
            this.rtbRecHex.Size = new System.Drawing.Size(491, 110);
            this.rtbRecHex.TabIndex = 0;
            this.rtbRecHex.Text = "";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "停止位:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据位:";
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
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(138, 163);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(89, 40);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "关闭端口";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "校验位:";
            // 
            // gpPortSet
            // 
            this.gpPortSet.Controls.Add(this.button1);
            this.gpPortSet.Controls.Add(this.btQuit);
            this.gpPortSet.Controls.Add(this.label5);
            this.gpPortSet.Controls.Add(this.btClose);
            this.gpPortSet.Controls.Add(this.btOpen);
            this.gpPortSet.Controls.Add(this.lbComStat);
            this.gpPortSet.Controls.Add(this.label4);
            this.gpPortSet.Controls.Add(this.label3);
            this.gpPortSet.Controls.Add(this.label2);
            this.gpPortSet.Controls.Add(this.comPort);
            this.gpPortSet.Controls.Add(this.cmStopBit);
            this.gpPortSet.Controls.Add(this.cmParity);
            this.gpPortSet.Controls.Add(this.cmDataBit);
            this.gpPortSet.Controls.Add(this.cmBaudRate);
            this.gpPortSet.Controls.Add(this.cmPort);
            this.gpPortSet.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpPortSet.Location = new System.Drawing.Point(600, 94);
            this.gpPortSet.Name = "gpPortSet";
            this.gpPortSet.Size = new System.Drawing.Size(247, 294);
            this.gpPortSet.TabIndex = 6;
            this.gpPortSet.TabStop = false;
            this.gpPortSet.Text = "端口设置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "签到码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(140, 84);
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
            this.gpRec.Controls.Add(this.rtbRecHex);
            this.gpRec.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpRec.Location = new System.Drawing.Point(46, 6);
            this.gpRec.Name = "gpRec";
            this.gpRec.Size = new System.Drawing.Size(506, 382);
            this.gpRec.TabIndex = 8;
            this.gpRec.TabStop = false;
            this.gpRec.Text = "接收窗口";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(306, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "ms";
            // 
            // gpSend
            // 
            this.gpSend.Controls.Add(this.label13);
            this.gpSend.Controls.Add(this.tbTimeStr);
            this.gpSend.Controls.Add(this.cbTimeStr);
            this.gpSend.Controls.Add(this.tbSendStr);
            this.gpSend.Controls.Add(this.btClrSend);
            this.gpSend.Controls.Add(this.btSend);
            this.gpSend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpSend.Location = new System.Drawing.Point(46, 394);
            this.gpSend.Name = "gpSend";
            this.gpSend.Size = new System.Drawing.Size(506, 189);
            this.gpSend.TabIndex = 7;
            this.gpSend.TabStop = false;
            this.gpSend.Text = "发送窗口";
            // 
            // statustimer
            // 
            this.statustimer.Tick += new System.EventHandler(this.statustimer_Tick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "签到时长(分钟)：";
            // 
            // timercomboBox
            // 
            this.timercomboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timercomboBox.FormattingEnabled = true;
            this.timercomboBox.Items.AddRange(new object[] {
            "1",
            "15",
            "20",
            "30"});
            this.timercomboBox.Location = new System.Drawing.Point(150, 43);
            this.timercomboBox.Name = "timercomboBox";
            this.timercomboBox.Size = new System.Drawing.Size(78, 24);
            this.timercomboBox.TabIndex = 17;
            this.timercomboBox.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.statusTimeLabel);
            this.groupBox1.Controls.Add(this.timercomboBox);
            this.groupBox1.Location = new System.Drawing.Point(588, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 78);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_checkIning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpPortSet);
            this.Controls.Add(this.gpRec);
            this.Controls.Add(this.gpSend);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDec);
            this.Controls.Add(this.gpDefFrm);
            this.Controls.Add(this.tbHex);
            this.Name = "Form_checkIning";
            this.Text = "签到";
            this.Load += new System.EventHandler(this.Form_checkIning_Load);
            this.gpDefFrm.ResumeLayout(false);
            this.gpDefFrm.PerformLayout();
            this.gpPortSet.ResumeLayout(false);
            this.gpPortSet.PerformLayout();
            this.gpRec.ResumeLayout(false);
            this.gpRec.PerformLayout();
            this.gpSend.ResumeLayout(false);
            this.gpSend.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClrSend;
        private System.Windows.Forms.CheckBox cbAutoClr;
        private System.Windows.Forms.Label lbHexData;
        private System.Windows.Forms.Button btClrRec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.TextBox tbDec;
        private System.Windows.Forms.RadioButton rdXor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbTimeStr;
        private System.Windows.Forms.TextBox tbTimeHex;
        private System.Windows.Forms.CheckBox cbTimeHex;
        private System.Windows.Forms.GroupBox gpDefFrm;
        private System.Windows.Forms.CheckBox cbDefFrm;
        private System.Windows.Forms.TextBox tbSendStr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtbRecStr;
        private System.Windows.Forms.Timer TimeStr;
        private System.Windows.Forms.Timer TimeHex;
        private System.IO.Ports.SerialPort sComm;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.TextBox tbTimeStr;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.RichTextBox rtbRecHex;
        private System.Windows.Forms.Label lbComStat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label comPort;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpPortSet;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.ComboBox cmStopBit;
        private System.Windows.Forms.ComboBox cmParity;
        private System.Windows.Forms.ComboBox cmDataBit;
        private System.Windows.Forms.ComboBox cmBaudRate;
        private System.Windows.Forms.ComboBox cmPort;
        private System.Windows.Forms.GroupBox gpRec;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gpSend;
        private System.Windows.Forms.Timer statustimer;
        private System.Windows.Forms.Label statusTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timercomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}