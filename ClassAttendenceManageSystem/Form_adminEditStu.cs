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
    public partial class Form_adminEditStu : Form
    {
        public Form_adminEditStu()
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
        private void Form_adminEditStu_Load(object sender, EventArgs e)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();
                string strcom = "Select *from studentInfo where stuID ='" + Form_adminMain.studentnumber + "'";
                myconn.Open();
                SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "studentInfo");
                myconn.Close();

                if (myDataSet.Tables["studentInfo"].Rows.Count > 0)
                {
                    //MessageBox.Show("查询成功！", "提示");
                    panel1.Visible = true;
                    textBox1.Text = myDataSet.Tables["studentInfo"].Rows[0][0].ToString();
                    id = textBox1.Text;
                    textBox2.Text = myDataSet.Tables["studentInfo"].Rows[0][1].ToString();
                    name = textBox2.Text;
                    //string str = myDataSet.Tables["studentInfo"].Rows[0][2].ToString();
                    if (myDataSet.Tables["studentInfo"].Rows[0][2].ToString().Trim() == "男".Trim())
                    {
                        RB1.Checked = true;
                    }
                    else RB2.Checked = true;
                    //labels3.Text = myDataSet.Tables["studentInfo"].Rows[0][2].ToString();
                    //sex = str;
                    textBox4.Text = myDataSet.Tables["studentInfo"].Rows[0][3].ToString();
                    cid = textBox4.Text;
                    textBox6.Text = myDataSet.Tables["studentInfo"].Rows[0][4].ToString();
                    cname = textBox6.Text;
                    textBox8.Text = myDataSet.Tables["studentInfo"].Rows[0][5].ToString();
                    cardid = textBox8.Text;
                    textBox9.Text = myDataSet.Tables["studentInfo"].Rows[0][6].ToString();
                    courseid = textBox9.Text;
                    textBox11.Text = myDataSet.Tables["studentInfo"].Rows[0][7].ToString();
                    psw = textBox11.Text;
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
                string strcom = "Select *from studentInfo";
                string str = "UPDATE studentInfo SET stuID='" + textBox1.Text.Trim() + "',stuName='" + textBox2.Text.Trim() + "',stuSex='" + sex.Trim() + "',classID='" + textBox4.Text.Trim() + "',className='" + textBox6.Text.Trim() + "',cardID='" + textBox8.Text.Trim() + "',courseID='" + textBox9.Text.Trim() + "',stuPassword='" + textBox11.Text.Trim() + "' where stuID='"+textBox1.Text+"'";
                myconn.Open();
                SqlCommand xg;
                xg = new SqlCommand(str, myconn);

                if (xg.ExecuteNonQuery() > 0)//判断插入数据是否成功        
                {                   //执行要操作的语句           
                    SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "studentInfo");
                    //adminMain.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
                    MessageBox.Show("修改成功","提示");
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

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
           // int flag = 1; 
        }

        private void RB2_CheckedChanged(object sender, EventArgs e)
        {
            //int flag = 2;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_adminMain a = new Form_adminMain();
            a.Show();
        }
    }
}
