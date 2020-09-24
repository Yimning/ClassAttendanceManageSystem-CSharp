namespace ClassAttendenceManageSystem
{
    partial class Form_adminMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("计算机科学与技术");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("信息安全");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("电子信息科学与技术");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("专业", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("性别", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_adminMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip_query = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_search = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.teacherManagertoolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 72);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(916, 388);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点3";
            treeNode1.Text = "计算机科学与技术";
            treeNode2.Name = "节点5";
            treeNode2.Text = "信息安全";
            treeNode3.Name = "节点6";
            treeNode3.Text = "电子信息科学与技术";
            treeNode4.Name = "Profession";
            treeNode4.Text = "专业";
            treeNode5.Name = "节点8";
            treeNode5.Text = "男";
            treeNode6.Name = "节点9";
            treeNode6.Text = "女";
            treeNode7.Name = "节点7";
            treeNode7.Text = "性别";
            treeNode8.Name = "节点1";
            treeNode8.Text = "全部";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(123, 388);
            this.treeView1.TabIndex = 0;
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
            this.dataGridView1.Location = new System.Drawing.Point(-5, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(792, 385);
            this.dataGridView1.TabIndex = 7;
            // 
            // toolStrip_query
            // 
            this.toolStrip_query.AutoSize = false;
            this.toolStrip_query.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_query.Image")));
            this.toolStrip_query.ImageTransparentColor = System.Drawing.Color.MediumAquamarine;
            this.toolStrip_query.Name = "toolStrip_query";
            this.toolStrip_query.Size = new System.Drawing.Size(80, 80);
            this.toolStrip_query.Text = "管理员信息";
            this.toolStrip_query.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_query.Click += new System.EventHandler(this.toolStrip_query_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStrip_add
            // 
            this.toolStrip_add.AutoSize = false;
            this.toolStrip_add.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_add.Image")));
            this.toolStrip_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_add.Name = "toolStrip_add";
            this.toolStrip_add.Size = new System.Drawing.Size(80, 80);
            this.toolStrip_add.Text = "添加学生信息";
            this.toolStrip_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_add.Click += new System.EventHandler(this.toolStrip_add_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStrip_edit
            // 
            this.toolStrip_edit.AutoSize = false;
            this.toolStrip_edit.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_edit.Image")));
            this.toolStrip_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_edit.Name = "toolStrip_edit";
            this.toolStrip_edit.Size = new System.Drawing.Size(80, 80);
            this.toolStrip_edit.Text = "编辑学生信息";
            this.toolStrip_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_edit.Click += new System.EventHandler(this.toolStrip_edit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStrip_search
            // 
            this.toolStrip_search.AutoSize = false;
            this.toolStrip_search.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_search.Image")));
            this.toolStrip_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_search.Name = "toolStrip_search";
            this.toolStrip_search.Size = new System.Drawing.Size(80, 80);
            this.toolStrip_search.Text = "查找学生信息";
            this.toolStrip_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_search.Click += new System.EventHandler(this.toolStrip_search_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStrip_delete
            // 
            this.toolStrip_delete.AutoSize = false;
            this.toolStrip_delete.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_delete.Image")));
            this.toolStrip_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_delete.Name = "toolStrip_delete";
            this.toolStrip_delete.Size = new System.Drawing.Size(80, 80);
            this.toolStrip_delete.Text = "删除";
            this.toolStrip_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_delete.ToolTipText = "管理员信息";
            this.toolStrip_delete.Click += new System.EventHandler(this.toolStrip_delete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripExit
            // 
            this.toolStripExit.AutoSize = false;
            this.toolStripExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExit.Image")));
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(80, 80);
            this.toolStripExit.Text = "退出登录";
            this.toolStripExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripExit.ToolTipText = "管理员信息";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_query,
            this.toolStripSeparator3,
            this.toolStrip_add,
            this.toolStripSeparator4,
            this.toolStrip_edit,
            this.toolStripSeparator2,
            this.toolStrip_search,
            this.toolStripSeparator5,
            this.toolStrip_delete,
            this.toolStripSeparator1,
            this.teacherManagertoolStripButton,
            this.toolStripExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(916, 72);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // teacherManagertoolStripButton
            // 
            this.teacherManagertoolStripButton.AutoSize = false;
            this.teacherManagertoolStripButton.Image = global::ClassAttendenceManageSystem.Properties.Resources.copy;
            this.teacherManagertoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.teacherManagertoolStripButton.Name = "teacherManagertoolStripButton";
            this.teacherManagertoolStripButton.Size = new System.Drawing.Size(80, 80);
            this.teacherManagertoolStripButton.Text = "教师管理";
            this.teacherManagertoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.teacherManagertoolStripButton.ToolTipText = "管理员信息";
            this.teacherManagertoolStripButton.Click += new System.EventHandler(this.teacherManagertoolStripButton_Click);
            // 
            // Form_adminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 460);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_adminMain";
            this.Text = "Form_adminMain";
            this.Load += new System.EventHandler(this.Form_adminMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripButton toolStrip_query;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStrip_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStrip_edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStrip_search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStrip_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton teacherManagertoolStripButton;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}