using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAttendenceManageSystem
{
    public partial class TimingMessageBox : Form
    {
        public TimingMessageBox()
        {
            InitializeComponent();
        }
        private int second;

        private int counter;
        public TimingMessageBox(string message, int second)
        {
            InitializeComponent();
            this.labelMessage.Text = message;
            this.second = second;
            this.counter = 0;
            this.buttonOK.Text = string.Format("确定({0})", this.second - this.counter);

            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.counter <= this.second)
            {
                this.buttonOK.Text = string.Format("确定({0})", this.second - this.counter);
                this.Refresh();
                this.counter++;
            }
            else
            {
                this.timer1.Enabled = false;
                this.timer1.Stop();
                this.Close();
            }
            if (this.second - this.counter == 0)
            {
                // Application.Exit();
                if (MessageBox.Show("签到结束！！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Form_checkIning a = new Form_checkIning();
                    a.Visible = false;
                }else this.Close();
            }
        }

        private void TimingMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
