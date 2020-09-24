namespace ClassAttendenceManageSystem
{
    partial class TimingMessageBox
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(53, 101);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "取消(2)";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(51, 45);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(41, 12);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimingMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 160);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelMessage);
            this.Name = "TimingMessageBox";
            this.Text = "签到倒计时";
            this.Load += new System.EventHandler(this.TimingMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Timer timer1;
    }
}