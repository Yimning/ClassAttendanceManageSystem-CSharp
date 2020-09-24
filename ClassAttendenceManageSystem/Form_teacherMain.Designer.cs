namespace ClassAttendenceManageSystem
{
    partial class Form_teacherMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.attendenceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isCheckInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noCheckInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryCourseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCourseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changepswMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkIningtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.classAttendanceManageSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceManageSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // attendenceMenuItem
            // 
            this.attendenceMenuItem.Name = "attendenceMenuItem";
            this.attendenceMenuItem.Size = new System.Drawing.Size(152, 22);
            this.attendenceMenuItem.Text = "出勤率";
            // 
            // isCheckInMenuItem
            // 
            this.isCheckInMenuItem.Name = "isCheckInMenuItem";
            this.isCheckInMenuItem.Size = new System.Drawing.Size(152, 22);
            this.isCheckInMenuItem.Text = "已签";
            this.isCheckInMenuItem.Click += new System.EventHandler(this.isCheckInMenuItem_Click);
            // 
            // CheckInToolStripMenuItem
            // 
            this.CheckInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordToolStripMenuItem,
            this.isCheckInMenuItem,
            this.noCheckInMenuItem,
            this.attendenceMenuItem});
            this.CheckInToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckInToolStripMenuItem.Name = "CheckInToolStripMenuItem";
            this.CheckInToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.CheckInToolStripMenuItem.Text = "签到情况";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recordToolStripMenuItem.Text = "签到记录";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // noCheckInMenuItem
            // 
            this.noCheckInMenuItem.Name = "noCheckInMenuItem";
            this.noCheckInMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noCheckInMenuItem.Text = "未签";
            this.noCheckInMenuItem.Click += new System.EventHandler(this.noCheckInMenuItem_Click);
            // 
            // queryCourseMenuItem
            // 
            this.queryCourseMenuItem.Name = "queryCourseMenuItem";
            this.queryCourseMenuItem.Size = new System.Drawing.Size(152, 22);
            this.queryCourseMenuItem.Text = "查看课程";
            this.queryCourseMenuItem.Click += new System.EventHandler(this.queryCourseMenuItem_Click);
            // 
            // courseManageToolStripMenuItem
            // 
            this.courseManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryCourseMenuItem,
            this.AddCourseMenuItem,
            this.delToolStripMenuItem});
            this.courseManageToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.courseManageToolStripMenuItem.Name = "courseManageToolStripMenuItem";
            this.courseManageToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.courseManageToolStripMenuItem.Text = "课程管理";
            this.courseManageToolStripMenuItem.Click += new System.EventHandler(this.courseManageToolStripMenuItem_Click);
            // 
            // AddCourseMenuItem
            // 
            this.AddCourseMenuItem.Name = "AddCourseMenuItem";
            this.AddCourseMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddCourseMenuItem.Text = "添加课程";
            this.AddCourseMenuItem.Click += new System.EventHandler(this.AddCourseMenuItem_Click);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.delToolStripMenuItem.Text = "删除课程";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // changepswMenuItem
            // 
            this.changepswMenuItem.Name = "changepswMenuItem";
            this.changepswMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changepswMenuItem.Text = "密码修改";
            this.changepswMenuItem.Click += new System.EventHandler(this.changepswMenuItem_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem,
            this.teacherInfoToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.courseManageToolStripMenuItem,
            this.checkIningtoolStripMenuItem,
            this.CheckInToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teacherInfoToolStripMenuItem
            // 
            this.teacherInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherInfoMenuItem});
            this.teacherInfoToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teacherInfoToolStripMenuItem.Name = "teacherInfoToolStripMenuItem";
            this.teacherInfoToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.teacherInfoToolStripMenuItem.Text = "教师信息";
            // 
            // teacherInfoMenuItem
            // 
            this.teacherInfoMenuItem.Name = "teacherInfoMenuItem";
            this.teacherInfoMenuItem.Size = new System.Drawing.Size(140, 22);
            this.teacherInfoMenuItem.Text = "教师信息";
            this.teacherInfoMenuItem.Click += new System.EventHandler(this.teacherInfoMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.studentToolStripMenuItem.Text = "学生表";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // checkIningtoolStripMenuItem
            // 
            this.checkIningtoolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkIningtoolStripMenuItem.Name = "checkIningtoolStripMenuItem";
            this.checkIningtoolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.checkIningtoolStripMenuItem.Text = "进行课堂签到";
            this.checkIningtoolStripMenuItem.Click += new System.EventHandler(this.checkIningtoolStripMenuItem_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(11, 44);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(831, 367);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(831, 367);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "1";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // dataGridView3
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView3.Location = new System.Drawing.Point(12, 43);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(831, 367);
            this.dataGridView3.TabIndex = 8;
            // 
            // Form_teacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 446);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_teacherMain";
            this.Text = "教师端";
            this.Load += new System.EventHandler(this.Form_teacherMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceManageSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem attendenceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isCheckInMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noCheckInMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryCourseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changepswMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teacherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.BindingSource classAttendanceManageSystemDataSetBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem checkIningtoolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem AddCourseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView3;
    }
}

