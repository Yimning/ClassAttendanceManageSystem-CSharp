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
    public partial class Form_studentMain : Form
    {
        public Form_studentMain()
        {
            InitializeComponent();
        }

        private void Form_studentMain_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            //this.dataGridView2.Visible = false;
            this.dataGridView3.Visible = false;
            refresh_course();
        }

        private void stuInfoMenuItem_Click(object sender, EventArgs e)
        {
            Form_stuInfo a = new Form_stuInfo();
            a.Show();
        }

        public void refresh_course()
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string sql = "Select courseInfo.id,courseInfo.courseID,couseName,courseTime,classRoom,courseNote,teacherID,teacherName from courseInfo,teacherInfo where teacherInfo.courseID=courseInfo.courseID ";
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

        private void changepswMenuItem_Click(object sender, EventArgs e)
        {
            Form_stuChangepsw a = new Form_stuChangepsw();
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
                //and studentInfo.cardID= attendenceInfo.cardID           studentInfo.cardID= attendenceInfo.cardID
                string sql = "Select courseInfo.courseID,couseName,courseTime,classRoom,teacherName,studentInfo.stuID,studentInfo.stuName,studentInfo.cardID, attendenceInfo.time,attendenceInfo.flag from attendenceInfo,courseInfo,teacherInfo,studentInfo where courseInfo.courseID = attendenceInfo.courseID AND courseInfo.courseID = studentInfo.courseID and teacherInfo.courseID = courseInfo.courseID and studentInfo.stuID='" + Form_login.str + "'and attendenceInfo.flag like '%已签%'";
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
            this.dataGridView3.Visible = true;
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();
                //and studentInfo.cardID= attendenceInfo.cardID           studentInfo.cardID= attendenceInfo.cardID
                string sql = "Select courseInfo.id,courseInfo.courseID,couseName,courseTime,classRoom,courseNote,teacherID,teacherName,studentInfo.stuID,studentInfo.stuName,studentInfo.cardID, attendenceInfo.time,attendenceInfo.flag from attendenceInfo,courseInfo,teacherInfo,studentInfo where courseInfo.courseID = attendenceInfo.courseID AND courseInfo.courseID = studentInfo.courseID and teacherInfo.courseID = courseInfo.courseID and studentInfo.stuID='" + Form_login.str+"'";
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
                //and studentInfo.cardID= attendenceInfo.cardID           studentInfo.cardID= attendenceInfo.cardID
                string sql = "Select courseInfo.courseID,couseName,courseTime,classRoom,teacherName,studentInfo.stuID,studentInfo.stuName,studentInfo.cardID, attendenceInfo.time,attendenceInfo.flag from attendenceInfo,courseInfo,teacherInfo,studentInfo where courseInfo.courseID = attendenceInfo.courseID AND courseInfo.courseID = studentInfo.courseID and teacherInfo.courseID = courseInfo.courseID and studentInfo.stuID='" + Form_login.str + "'and attendenceInfo.flag like '%未签%'";
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            this.dataGridView1.Visible = true;
           // this.dataGridView2.Visible = false;
            this.dataGridView3.Visible = false;
            refresh_course();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_login a = new Form_login();
            a.Show();
        }

        public static string strcourseid;
        private void AddCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

               int selectrow = this.dataGridView1.CurrentRow.Index;  //所选行
              // classRoom = this.dataGridView1.Rows[selectrow].Cells[4].Value.ToString(); //所选行的第0列值
               strcourseid = this.dataGridView1.Rows[selectrow].Cells[1].Value.ToString();
              if (MessageBox.Show("选择该课程", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
              {
                    queryCourseStu();
                    try
                    {
                        string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                        SqlConnection myconn = new SqlConnection(strCon);
                        DataSet myDataSet = new DataSet();
                        string strcom = "Select *from studentInfo where stuID ='" + Form_login.str.Trim() + "'and courseID = '" + strcourseid + "'";
                        myconn.Open();
                        SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                        myDataSet.Clear();
                        mycommand.Fill(myDataSet, "studentInfo");
                        myconn.Close();
                       if (myDataSet.Tables["studentInfo"].Rows.Count <= 0)
                        {
                          addCourseStu();
                        }
                        else MessageBox.Show("已选有该课程!","提示");
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("error!" + x.ToString());
                    }
              
               }
               else this.Close();
            }
            else
            {
                this.Visible = true;
                MessageBox.Show("请选中课程后再进行添加课程！", "提示");
            }
        }


        public static string id;
        public static string name;
        public static string sex;
        public static string cid;
        public static string cname;
        public static string cardid;
        public static string courseid;
        public static string psw;

        public void queryCourseStu()
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();
                string strcom = "Select *from studentInfo where stuID ='" + Form_login.str.Trim() + "'";
                myconn.Open();
                SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "studentInfo");
                myconn.Close();

                if (myDataSet.Tables["studentInfo"].Rows.Count > 0)
                {
                    // MessageBox.Show("查询成功！", "提示");
                    // panel1.Visible = true;
                    id = myDataSet.Tables["studentInfo"].Rows[0][0].ToString();

                    name= myDataSet.Tables["studentInfo"].Rows[0][1].ToString();

                    sex= myDataSet.Tables["studentInfo"].Rows[0][2].ToString();

                    cid= myDataSet.Tables["studentInfo"].Rows[0][3].ToString();

                    cname= myDataSet.Tables["studentInfo"].Rows[0][4].ToString();

                    cardid = myDataSet.Tables["studentInfo"].Rows[0][5].ToString();

                    courseid = myDataSet.Tables["studentInfo"].Rows[0][6].ToString();

                    psw = myDataSet.Tables["studentInfo"].Rows[0][7].ToString();
                   
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }

        }

        public void addCourseStu ()
        { 
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string sql = "Select *from studentInfo";
                string str = "insert into studentInfo VALUES ('" + id + "','" + name + "','" + sex+ "','" + cid + "','" + cname + "','" +  cardid+ "','" + strcourseid + "','" + psw + "')";
                connection.Open();
                SqlCommand xg;
                xg = new SqlCommand(str, connection);

                if (xg.ExecuteNonQuery() > 0)//判断是否成功        
                {                   //执行要操作的语句           
                    SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "studentInfo");
                    MessageBox.Show("选课成功!请刷新!");
                    this.Close();
                    Form_studentMain a = new Form_studentMain();
                    a.ShowDialog();
                    // Form_teacherMain.dataGridView1.DataSource = myDataSet.Tables["courseInfo"];
                }
                connection.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
         }

        private void HCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string sql = "Select courseInfo.id,courseInfo.courseID,couseName,courseTime,classRoom,courseNote,teacherID,teacherName,stuID,stuName from courseInfo,teacherInfo,studentInfo where teacherInfo.courseID=courseInfo.courseID and courseInfo.courseID = studentInfo.courseID and studentInfo.stuID='"+Form_login.str+"'";
                connection.Open();

                SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "courseInfo");
                dataGridView1.DataSource = myDataSet.Tables["courseInfo"];
                connection.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }

        private void queryCourseMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
         //   this.dataGridView2.Visible = false;
            this.dataGridView3.Visible = false;
            refresh_course();
        }

    }
}
