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
    public partial class Form_changepsw : Form
    {
        public Form_changepsw()
        {
            InitializeComponent();
        }

        private bool judge()

        {
            //用if来判断框的内容

            if (textBox1.Text == "")

                return false;

            if (textBox2.Text == "")

                return false;

            if (textBox3.Text == "")

                return false;

            return true;

        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (!judge())
            {
                MessageBox.Show("请正确输入密码");
            }
            else if (textBox2.Text.Equals(textBox3.Text))
            {
                if (textBox1.Text.Trim().Equals(Form_login.str1))
                {
                    try
                    {
                        string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                        SqlConnection myconn = new SqlConnection(strCon);
                        DataSet myDataSet = new DataSet();
                        string strcom = "Select *from teacherInfo";
                        string str = "UPDATE teacherInfo SET teacherPassword ='" + textBox3.Text.Trim() + "'where teacherID = '" + Form_login.str.Trim() + "'";
                        myconn.Open();
                        SqlCommand xg;
                        xg = new SqlCommand(str, myconn);

                        if (xg.ExecuteNonQuery() > 0)//判断插入数据是否成功        
                        {                   //执行要操作的语句           
                            SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                            myDataSet.Clear();
                            mycommand.Fill(myDataSet, "teacherInfo");
                            //adminMain.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
                            MessageBox.Show("修改成功");
                            Close();
                            myconn.Close();
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("error!" + x.ToString());

                    }
                }
                else MessageBox.Show("原密码不正确");

            }
            else MessageBox.Show("两次密码输入不同");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
