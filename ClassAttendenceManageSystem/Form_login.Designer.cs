namespace ClassAttendenceManageSystem
{
    partial class Form_login
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
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton1_stu = new System.Windows.Forms.RadioButton();
            this.radioButton_teac = new System.Windows.Forms.RadioButton();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.button_login = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(190, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "基于RFID的课堂考勤管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(215, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "账  号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(215, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "密  码:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(285, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(285, 255);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '.';
            this.textBox2.Size = new System.Drawing.Size(140, 23);
            this.textBox2.TabIndex = 40;
            // 
            // radioButton1_stu
            // 
            this.radioButton1_stu.AutoSize = true;
            this.radioButton1_stu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1_stu.Location = new System.Drawing.Point(218, 298);
            this.radioButton1_stu.Name = "radioButton1_stu";
            this.radioButton1_stu.Size = new System.Drawing.Size(58, 20);
            this.radioButton1_stu.TabIndex = 41;
            this.radioButton1_stu.Text = "学生";
            this.radioButton1_stu.UseVisualStyleBackColor = true;
            this.radioButton1_stu.CheckedChanged += new System.EventHandler(this.radioButton_stu_CheckedChanged);
            // 
            // radioButton_teac
            // 
            this.radioButton_teac.AutoSize = true;
            this.radioButton_teac.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_teac.Location = new System.Drawing.Point(295, 298);
            this.radioButton_teac.Name = "radioButton_teac";
            this.radioButton_teac.Size = new System.Drawing.Size(58, 20);
            this.radioButton_teac.TabIndex = 42;
            this.radioButton_teac.Text = "教师";
            this.radioButton_teac.UseVisualStyleBackColor = true;
            this.radioButton_teac.CheckedChanged += new System.EventHandler(this.radioButton_teac_CheckedChanged);
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_admin.Location = new System.Drawing.Point(370, 298);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(74, 20);
            this.radioButton_admin.TabIndex = 43;
            this.radioButton_admin.Text = "管理员";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            this.radioButton_admin.CheckedChanged += new System.EventHandler(this.radioButton_admin_CheckedChanged);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_login.Location = new System.Drawing.Point(218, 343);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 36);
            this.button_login.TabIndex = 44;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_cancel.Location = new System.Drawing.Point(365, 343);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 36);
            this.button_cancel.TabIndex = 45;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button4
            // 
            this.button4.Image = global::ClassAttendenceManageSystem.Properties.Resources.wzlogo;
            this.button4.Location = new System.Drawing.Point(276, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 134);
            this.button4.TabIndex = 38;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 395);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.radioButton_admin);
            this.Controls.Add(this.radioButton_teac);
            this.Controls.Add(this.radioButton1_stu);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form_login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton1_stu;
        private System.Windows.Forms.RadioButton radioButton_teac;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_cancel;
    }
}