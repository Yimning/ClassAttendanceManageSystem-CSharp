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
    public partial class Form_teacherMain : Form
    {
        public Form_teacherMain()
        {
            InitializeComponent();
        }
        private int second;

        private int counter;
        public void TimingMessageBox(string message, int second)
        {
            InitializeComponent();
            this.second = second;
            this.counter = 0;
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }
        public static string strclassroom;  //用户保存密码
        public static string strcourseid;  //用户保存密码
        public void refresh_course()
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string sql = "Select courseInfo.id,courseInfo.courseID,couseName,courseTime,classRoom,courseNote,teacherID,teacherName from courseInfo,teacherInfo where teacherInfo.courseID=courseInfo.courseID and teacherID='"+Form_login.str+"'";
                connection.Open();
       
                SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "courseInfo");
                dataGridView1.DataSource = myDataSet.Tables["courseInfo"];
               // strclassroom = myDataSet.Tables["courseInfo"].Rows[0][0].ToString();
               // strcourseid = myDataSet.Tables["courseInfo"].Rows[0][4].ToString();
                connection.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }


        }

        private void Form_teacherMain_Load(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
            this.dataGridView1.Visible = true;
            this.dataGridView2.Visible = false;
            this.dataGridView3.Visible = false;
            refresh_course(); 
        }
        private void changepswMenuItem_Click(object sender, EventArgs e)
        {
            Form_changepsw comm = new Form_changepsw();
            comm.Show();
        }


        private void queryCourseMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            this.dataGridView2.Visible = false;
            this.dataGridView3.Visible = false;
            refresh_course();
        }



        private void AddCourseMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_addCourse addCourse = new Form_addCourse();
            addCourse.Show();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.counter <= this.second)
            {
                this.Refresh();
                this.counter++;
            }
            else
            {
                this.timer1.Enabled = false;
                this.timer1.Stop();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            this.timer2.Enabled = true;
            this.dataGridView1.Visible = true;
            this.dataGridView2.Visible = false;
            this.dataGridView3.Visible = false;
            refresh_course();
        }

        public void refresh_studentInfo()
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string sql = "Select stuID,stuName,stuSex,classID,className,cardID,studentInfo.courseID from studentInfo,teacherInfo where studentInfo.courseID = teacherInfo.courseID and teacherID='" + Form_login.str+"'";
                // string str = key;
                connection.Open();
                //SqlCommand xg;
                //xg = new SqlCommand(str, myconn);

                //if (xg.ExecuteNonQuery() > 0)//判断是否成功        
                //{                   //执行要操作的语句           
                SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "studentInfo");
                dataGridView2.DataSource = myDataSet.Tables["studentInfo"];
                // }
                connection.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }


        }


       void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            this.dataGridView2.Visible = true;
            refresh_studentInfo();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (dataGridView1.SelectedRows.Count == 1)
            {

                int selectrow = this.dataGridView1.CurrentRow.Index;  //所选行
                String courseID = this.dataGridView1.Rows[selectrow].Cells[1].Value.ToString(); //所选行的第0列值
                if (MessageBox.Show("删除课程?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

                {
                    delete(courseID);
                }else this.Visible = true;
            }
            else
            {
                this.Visible = true;
               MessageBox.Show("请选中一行后再点击删除按钮！","提示");
            }
        }


        private void delete(String courseID)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();
                string strcom = "Select *from courseInfo";
                string str = "DELETE FROM courseInfo WHERE courseID ='" + courseID + "'";
                myconn.Open();
                SqlCommand xg;
                xg = new SqlCommand(str, myconn);

                if (xg.ExecuteNonQuery() > 0)//判断是否成功        
                {                   //执行要操作的语句           
                    SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "courseInfo");
                    //adminMain.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
                    MessageBox.Show("删除成功");
                    Close();
                    Form_teacherMain teacher = new Form_teacherMain();
                    teacher.ShowDialog();
                }
                myconn.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }

        }
        public static string classRoom;//public类型的实例字段,static变量被所有对象所共有，也可以被所有对象所改变

        private void checkIningtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                int selectrow = this.dataGridView1.CurrentRow.Index;  //所选行
                 classRoom = this.dataGridView1.Rows[selectrow].Cells[4].Value.ToString(); //所选行的第0列值
                 strcourseid= this.dataGridView1.Rows[selectrow].Cells[1].Value.ToString();
                if (MessageBox.Show("进行课程签到?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Form_checkIning checkIn = new Form_checkIning();
                    checkIn.Show();
                }
                else this.Visible = true;
            }
            else
            {
                this.Visible = true;
                MessageBox.Show("请选中课程后再进行签到！", "提示");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("当前系统时间:yyyy年MM月dd日 HH时:mm分:ss秒");
        }

        private void teacherInfoMenuItem_Click(object sender, EventArgs e)
        {
            Form_teacherInfo a = new Form_teacherInfo();
            a.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_login a = new Form_login();
            a.Show();
        }

        private void isCheckInMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView3.Visible = true;
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string sql = "Select courseInfo.courseID,couseName,courseTime,classRoom,courseNote,teacherID,teacherName,studentInfo.stuID,studentInfo.stuName,studentInfo.cardID, attendenceInfo.time,attendenceInfo.flag from attendenceInfo,courseInfo,teacherInfo,studentInfo where classRoom ='" + Form_teacherMain.classRoom + "' and teacherInfo.courseID=courseInfo.courseID and attendenceInfo.flag like '%已签%'";
                connection.Open();

                SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "courseInfo");
                dataGridView3.DataSource = myDataSet.Tables["courseInfo"];
                connection.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }

        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView3.Visible = true ;
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string sql = "Select courseInfo.id,courseInfo.courseID,couseName,courseTime,classRoom,courseNote,teacherID,teacherName,studentInfo.stuID,studentInfo.stuName,studentInfo.cardID, attendenceInfo.time,attendenceInfo.flag from attendenceInfo,courseInfo,teacherInfo,studentInfo where classRoom ='" + Form_teacherMain.classRoom+ "' and teacherInfo.courseID='" + Form_teacherMain.strcourseid + "' and courseInfo.courseID='" + Form_teacherMain.strcourseid+"'";
                connection.Open();

                SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "courseInfo");
                dataGridView3.DataSource = myDataSet.Tables["courseInfo"];
                connection.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }

        private void noCheckInMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView3.Visible = true;
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string sql = "Select courseInfo.courseID,couseName,courseTime,classRoom,courseNote,teacherID,teacherName,studentInfo.stuID,studentInfo.stuName,studentInfo.cardID, attendenceInfo.time,attendenceInfo.flag from attendenceInfo,courseInfo,teacherInfo,studentInfo where classRoom ='" + Form_teacherMain.classRoom + "' and teacherInfo.courseID=courseInfo.courseID and attendenceInfo.flag like '%未签%'";
                connection.Open();

                SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "courseInfo");
                dataGridView3.DataSource = myDataSet.Tables["courseInfo"];
                connection.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }

        private void courseManageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
