namespace ClassAttendenceManageSystem
{
    partial class Form_comm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOpenCom = new System.Windows.Forms.Button();
            this.buttonCheckcom = new System.Windows.Forms.Button();
            this.comboBoxDatabits = new System.Windows.Forms.ComboBox();
            this.comboBoxParitv = new System.Windows.Forms.ComboBox();
            this.comboBoxSbits = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxValue);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonOpenCom);
            this.panel1.Controls.Add(this.buttonCheckcom);
            this.panel1.Controls.Add(this.comboBoxDatabits);
            this.panel1.Controls.Add(this.comboBoxParitv);
            this.panel1.Controls.Add(this.comboBoxSbits);
            this.panel1.Controls.Add(this.comboBoxBaud);
            this.panel1.Controls.Add(this.comboBoxPort);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 170);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(345, 94);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(121, 20);
            this.comboBoxValue.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(261, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "温度阈值：";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.Location = new System.Drawing.Point(609, 16);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(88, 33);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonOpenCom
            // 
            this.buttonOpenCom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOpenCom.Location = new System.Drawing.Point(504, 76);
            this.buttonOpenCom.Name = "buttonOpenCom";
            this.buttonOpenCom.Size = new System.Drawing.Size(88, 33);
            this.buttonOpenCom.TabIndex = 11;
            this.buttonOpenCom.Text = "打开串口";
            this.buttonOpenCom.UseVisualStyleBackColor = true;
            this.buttonOpenCom.Click += new System.EventHandler(this.buttonOpenCom_Click);
            // 
            // buttonCheckcom
            // 
            this.buttonCheckcom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCheckcom.Location = new System.Drawing.Point(504, 18);
            this.buttonCheckcom.Name = "buttonCheckcom";
            this.buttonCheckcom.Size = new System.Drawing.Size(88, 33);
            this.buttonCheckcom.TabIndex = 1;
            this.buttonCheckcom.Text = "串口检测";
            this.buttonCheckcom.UseVisualStyleBackColor = true;
            // 
            // comboBoxDatabits
            // 
            this.comboBoxDatabits.FormattingEnabled = true;
            this.comboBoxDatabits.Location = new System.Drawing.Point(345, 61);
            this.comboBoxDatabits.Name = "comboBoxDatabits";
            this.comboBoxDatabits.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDatabits.TabIndex = 10;
            // 
            // comboBoxParitv
            // 
            this.comboBoxParitv.FormattingEnabled = true;
            this.comboBoxParitv.Location = new System.Drawing.Point(345, 26);
            this.comboBoxParitv.Name = "comboBoxParitv";
            this.comboBoxParitv.Size = new System.Drawing.Size(121, 20);
            this.comboBoxParitv.TabIndex = 9;
            // 
            // comboBoxSbits
            // 
            this.comboBoxSbits.FormattingEnabled = true;
            this.comboBoxSbits.Location = new System.Drawing.Point(78, 94);
            this.comboBoxSbits.Name = "comboBoxSbits";
            this.comboBoxSbits.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSbits.TabIndex = 8;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(78, 61);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBaud.TabIndex = 7;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(78, 25);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPort.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(261, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "数据位：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(261, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "奇偶校验：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "停止位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "波特率：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "串口号：";
            // 
            // Form_comm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 437);
            this.Controls.Add(this.panel1);
            this.Name = "Form_comm";
            this.Text = "Form_comm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOpenCom;
        private System.Windows.Forms.Button buttonCheckcom;
        private System.Windows.Forms.ComboBox comboBoxDatabits;
        private System.Windows.Forms.ComboBox comboBoxParitv;
        private System.Windows.Forms.ComboBox comboBoxSbits;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}