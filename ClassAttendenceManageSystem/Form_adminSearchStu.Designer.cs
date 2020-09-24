namespace ClassAttendenceManageSystem
{
    partial class Form_adminSearchStu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_adminSearchStu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cb_searchitem = new System.Windows.Forms.ToolStripComboBox();
            this.txt_searchtxt = new System.Windows.Forms.ToolStripTextBox();
            this.btn_close = new System.Windows.Forms.ToolStripButton();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(860, 406);
            this.dataGridView1.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cb_searchitem,
            this.txt_searchtxt,
            this.btn_close,
            this.btn_search});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(860, 42);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 39);
            this.toolStripLabel1.Text = "查找项目";
            // 
            // cb_searchitem
            // 
            this.cb_searchitem.Items.AddRange(new object[] {
            "学生学号",
            "学生姓名",
            "学生班级"});
            this.cb_searchitem.Name = "cb_searchitem";
            this.cb_searchitem.Size = new System.Drawing.Size(92, 42);
            // 
            // txt_searchtxt
            // 
            this.txt_searchtxt.AutoSize = false;
            this.txt_searchtxt.Name = "txt_searchtxt";
            this.txt_searchtxt.Size = new System.Drawing.Size(98, 23);
            // 
            // btn_close
            // 
            this.btn_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_close.AutoSize = false;
            this.btn_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(73, 50);
            this.btn_close.Text = "关闭";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_search
            // 
            this.btn_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_search.AutoSize = false;
            this.btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 50);
            this.btn_search.Text = "查找";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form_adminSearchStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_adminSearchStu";
            this.Text = "Form_adminSearchStu";
            this.Load += new System.EventHandler(this.Form_adminSearchStu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cb_searchitem;
        private System.Windows.Forms.ToolStripTextBox txt_searchtxt;
        private System.Windows.Forms.ToolStripButton btn_close;
        private System.Windows.Forms.ToolStripButton btn_search;
    }
}