namespace ClassAttendenceManageSystem
{
    partial class Form_adminTeacherManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TInfoToolStripMenuItem,
            this.AddTeacherToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deltoolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TInfoToolStripMenuItem
            // 
            this.TInfoToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TInfoToolStripMenuItem.Name = "TInfoToolStripMenuItem";
            this.TInfoToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.TInfoToolStripMenuItem.Text = "全体教师";
            this.TInfoToolStripMenuItem.Click += new System.EventHandler(this.TInfoToolStripMenuItem_Click);
            // 
            // AddTeacherToolStripMenuItem
            // 
            this.AddTeacherToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddTeacherToolStripMenuItem.Name = "AddTeacherToolStripMenuItem";
            this.AddTeacherToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AddTeacherToolStripMenuItem.Text = "添加";
            this.AddTeacherToolStripMenuItem.Click += new System.EventHandler(this.AddTeacherToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.editToolStripMenuItem.Text = "编辑";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deltoolStripMenuItem
            // 
            this.deltoolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deltoolStripMenuItem.Name = "deltoolStripMenuItem";
            this.deltoolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deltoolStripMenuItem.Text = "删除";
            this.deltoolStripMenuItem.Click += new System.EventHandler(this.deltoolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Text = "返回首页";
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 39);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(835, 379);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form_adminTeacherManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_adminTeacherManager";
            this.Text = "教师管理";
            this.Load += new System.EventHandler(this.Form_adminTeacherManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deltoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}