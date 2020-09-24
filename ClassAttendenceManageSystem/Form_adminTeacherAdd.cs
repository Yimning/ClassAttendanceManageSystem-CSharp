using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAttendenceManageSystem
{
    public partial class Form_adminTeacherAdd : Form
    {
        public Form_adminTeacherAdd()
        {
            InitializeComponent();
        }

        String sex;
        Form_adminMain adminMain = new Form_adminMain();
        private bool judge()

        {
            //用if来判断框的内容

            if (textBox1.Text == "")

                return false;

            if (textBox2.Text == "")

                return false;


            if (textBox3.Text == "")

                return false;


            if (textBox4.Text == "")

                return false;
            return true;

        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            if (!judge())
            {
                MessageBox.Show("请正确输入信息", "提示");
                return;
            }

            try
            {
                if (RB1.Checked)
                {
                    sex = RB1.Text;   //取性别值
                }
                else sex = RB2.Text;

                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();
                string strcom = "Select *from teacherInfo";
                string str = "insert into teacherInfo VALUES ('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + sex.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "')";
                myconn.Open();
                SqlCommand xg;
                xg = new SqlCommand(str, myconn);

                if (xg.ExecuteNonQuery() > 0)//判断插入数据是否成功        
                {                   //执行要操作的语句           
                    SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "teacherInfo");
                    //adminMain.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
                    MessageBox.Show("添加成功", "提示");
                    Close();
                    Form_adminMain adminMain = new Form_adminMain();
                    adminMain.ShowDialog();
                }
                myconn.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_adminTeacherManager a = new Form_adminTeacherManager();
            a.Show();
        }
    }
}
