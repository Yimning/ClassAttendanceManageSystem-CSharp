namespace ClassAttendenceManageSystem
{
    partial class Form_studentMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changepswMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stuInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stuInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryCourseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isCheckInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noCheckInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem,
            this.stuInfoToolStripMenuItem,
            this.courseManageToolStripMenuItem,
            this.AddCourseToolStripMenuItem,
            this.CheckInToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changepswMenuItem});
            this.SettingToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.SettingToolStripMenuItem.Text = "基本设置";
            // 
            // changepswMenuItem
            // 
            this.changepswMenuItem.Name = "changepswMenuItem";
            this.changepswMenuItem.Size = new System.Drawing.Size(140, 22);
            this.changepswMenuItem.Text = "密码修改";
            this.changepswMenuItem.Click += new System.EventHandler(this.changepswMenuItem_Click);
            // 
            // stuInfoToolStripMenuItem
            // 
            this.stuInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stuInfoMenuItem});
            this.stuInfoToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stuInfoToolStripMenuItem.Name = "stuInfoToolStripMenuItem";
            this.stuInfoToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.stuInfoToolStripMenuItem.Text = "学生信息";
            // 
            // stuInfoMenuItem
            // 
            this.stuInfoMenuItem.Name = "stuInfoMenuItem";
            this.stuInfoMenuItem.Size = new System.Drawing.Size(140, 22);
            this.stuInfoMenuItem.Text = "学生信息";
            this.stuInfoMenuItem.Click += new System.EventHandler(this.stuInfoMenuItem_Click);
            // 
            // courseManageToolStripMenuItem
            // 
            this.courseManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryCourseMenuItem,
            this.HCToolStripMenuItem});
            this.courseManageToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.courseManageToolStripMenuItem.Name = "courseManageToolStripMenuItem";
            this.courseManageToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.courseManageToolStripMenuItem.Text = "课程管理";
            // 
            // queryCourseMenuItem
            // 
            this.queryCourseMenuItem.Name = "queryCourseMenuItem";
            this.queryCourseMenuItem.Size = new System.Drawing.Size(140, 22);
            this.queryCourseMenuItem.Text = "查看课程";
            this.queryCourseMenuItem.Click += new System.EventHandler(this.queryCourseMenuItem_Click);
            // 
            // HCToolStripMenuItem
            // 
            this.HCToolStripMenuItem.Name = "HCToolStripMenuItem";
            this.HCToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.HCToolStripMenuItem.Text = "已选课程";
            this.HCToolStripMenuItem.Click += new System.EventHandler(this.HCToolStripMenuItem_Click);
            // 
            // AddCourseToolStripMenuItem
            // 
            this.AddCourseToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddCourseToolStripMenuItem.Name = "AddCourseToolStripMenuItem";
            this.AddCourseToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.AddCourseToolStripMenuItem.Text = "选择加入课程";
            this.AddCourseToolStripMenuItem.Click += new System.EventHandler(this.AddCourseToolStripMenuItem_Click);
            // 
            // CheckInToolStripMenuItem
            // 
            this.CheckInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordToolStripMenuItem,
            this.isCheckInMenuItem,
            this.noCheckInMenuItem});
            this.CheckInToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckInToolStripMenuItem.Name = "CheckInToolStripMenuItem";
            this.CheckInToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.CheckInToolStripMenuItem.Text = "签到情况";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.recordToolStripMenuItem.Text = "签到记录";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // isCheckInMenuItem
            // 
            this.isCheckInMenuItem.Name = "isCheckInMenuItem";
            this.isCheckInMenuItem.Size = new System.Drawing.Size(140, 22);
            this.isCheckInMenuItem.Text = "已签";
            this.isCheckInMenuItem.Click += new System.EventHandler(this.isCheckInMenuItem_Click);
            // 
            // noCheckInMenuItem
            // 
            this.noCheckInMenuItem.Name = "noCheckInMenuItem";
            this.noCheckInMenuItem.Size = new System.Drawing.Size(140, 22);
            this.noCheckInMenuItem.Text = "未签";
            this.noCheckInMenuItem.Click += new System.EventHandler(this.noCheckInMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.refreshToolStripMenuItem.Text = "刷新页面";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.exitToolStripMenuItem.Text = "退出登录";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(831, 367);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridView3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.Location = new System.Drawing.Point(12, 35);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(831, 392);
            this.dataGridView3.TabIndex = 10;
            // 
            // Form_studentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 430);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_studentMain";
            this.Text = "学生端";
            this.Load += new System.EventHandler(this.Form_studentMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changepswMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stuInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stuInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryCourseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isCheckInMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noCheckInMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HCToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStripMenuItem AddCourseToolStripMenuItem;
    }
}