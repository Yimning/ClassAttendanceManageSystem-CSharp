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
    public partial class Form_addCourse : Form
    {
        public Form_addCourse()
        {
            InitializeComponent();
        }
        private bool judge()

        {
            //用if来判断框的内容

            if (CourseNumber.Text == "")

                return false;

            if (courseName.Text == "")

                return false;


            if (CourseTime.Text == "")

                return false;

            if (ClassRoom.Text == "")

                return false;

            if (CourseNote.Text == "")

                return false;
            return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!judge())
            {
                MessageBox.Show("请正确输入信息");
            }
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string sql = "Select *from courseInfo";
                string str = "insert into courseInfo VALUES ('" + CourseNumber.Text.Trim() + "','" + courseName.Text.Trim() + "','" + CourseTime.Text.Trim() + "','" + ClassRoom.Text.Trim() + "','" + CourseNote.Text.Trim() + "')";
                connection.Open();
                SqlCommand xg;
                xg = new SqlCommand(str, connection);

                if (xg.ExecuteNonQuery() > 0)//判断是否成功        
                {                   //执行要操作的语句           
                    SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "courseInfo");
                    MessageBox.Show("添加成功!请刷新!");
                    this.Close();
                    Form_teacherMain teacherMain = new Form_teacherMain();
                    teacherMain.ShowDialog();
                    // Form_teacherMain.dataGridView1.DataSource = myDataSet.Tables["courseInfo"];
                }
                connection.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_teacherMain teacherMain = new Form_teacherMain();
            teacherMain.ShowDialog();
        }

    }
}
