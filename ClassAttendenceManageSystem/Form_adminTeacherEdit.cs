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
    public partial class Form_adminTeacherEdit : Form
    {
        public Form_adminTeacherEdit()
        {
            InitializeComponent();
        }
        public static string id;
        public static string name;
        public static string sex;
        public static string cid;
        public static string cname;
        public static string cardid;
        public static string courseid;
        public static string psw;
        private void Form_adminTeacherEdit_Load(object sender, EventArgs e)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();
                string strcom = "Select *from teacherInfo where teacherID ='" + Form_adminTeacherManager.teacherID + "'";
                myconn.Open();
                SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "teacherInfo");
                myconn.Close();

                if (myDataSet.Tables["teacherInfo"].Rows.Count > 0)
                {
                    //MessageBox.Show("查询成功！", "提示");
                    panel1.Visible = true;
                    textBox1.Text = myDataSet.Tables["teacherInfo"].Rows[0][0].ToString();
                    id = textBox1.Text;
                    textBox2.Text = myDataSet.Tables["teacherInfo"].Rows[0][1].ToString();
                    name = textBox2.Text;
                    //string str = myDataSet.Tables["studentInfo"].Rows[0][2].ToString();
                    if (myDataSet.Tables["teacherInfo"].Rows[0][2].ToString().Trim() == "男".Trim())
                    {
                        RB1.Checked = true;
                    }
                    else RB2.Checked = true;
                    //labels3.Text = myDataSet.Tables["studentInfo"].Rows[0][2].ToString();
                    //sex = str;
                    textBox3.Text = myDataSet.Tables["teacherInfo"].Rows[0][3].ToString();
                    cid = textBox3.Text;

                    textBox4.Text = myDataSet.Tables["teacherInfo"].Rows[0][4].ToString();
                    cname = textBox4.Text;

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
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
                string str = "UPDATE teacherInfo SET teacherName='" + textBox2.Text.Trim() + "',teacherSex='" + sex.Trim() + "',courseID='" + textBox3.Text.Trim() + "',teacherPassword='" + textBox4.Text.Trim() + "'where teacherID='"+Form_adminTeacherManager.teacherID+"'";
                myconn.Open();
                SqlCommand xg;
                xg = new SqlCommand(str, myconn);

                if (xg.ExecuteNonQuery() > 0)//判断插入数据是否成功        
                {                   //执行要操作的语句           
                    SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "teacherInfo");
                    //adminMain.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
                    MessageBox.Show("修改成功", "提示");
                    Close();
                    Form_adminTeacherManager a = new Form_adminTeacherManager();
                    a.ShowDialog();
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
