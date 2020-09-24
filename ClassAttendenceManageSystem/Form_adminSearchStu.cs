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
    public partial class Form_adminSearchStu : Form
    {
        public Form_adminSearchStu()
        {
            InitializeComponent();
        }
        private void number_find(String numberfind)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string strcom = "Select *from studentInfo where stuID ='" + numberfind + "'";
                myconn.Open();
                SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "studentInfo");
                myconn.Close();

                if (myDataSet.Tables["studentInfo"].Rows.Count > 0)
                {
                    MessageBox.Show("查询成功！", "提示");
                    dataGridView1.DataSource = myDataSet.Tables["studentInfo"];
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }

        }


        private void name_find(String namefind)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string strcom = "Select *from studentInfo where stuName like '%" + namefind + "%'";
                myconn.Open();
                SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "studentInfo");
                myconn.Close();

                if (myDataSet.Tables["studentInfo"].Rows.Count > 0)
                {
                    MessageBox.Show("查询成功！", "提示");
                    dataGridView1.DataSource = myDataSet.Tables["studentInfo"];
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }

        }

        private void classnumber_find(String classnumber)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string strcom = "Select *from studentInfo where classID ='" + classnumber + "'";
                myconn.Open();
                SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "studentInfo");
                myconn.Close();

                if (myDataSet.Tables["studentInfo"].Rows.Count > 0)
                {
                    MessageBox.Show("查询成功！", "提示");
                    dataGridView1.DataSource = myDataSet.Tables["studentInfo"];
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }

        private void Form_adminSearchStu_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //依据选择的查询和输入查询值进行查询，如果两者都为空，则查询所有信息
            if (cb_searchitem.Text == string.Empty)
            {
                MessageBox.Show("请选择查询条件并输入值");
            }
            else if (cb_searchitem.Text != string.Empty)
            {
                //StudentInfo studentsearch = new StudentInfo();
                switch (cb_searchitem.SelectedIndex)
                {
                    case 0:
                        number_find(txt_searchtxt.Text); break;
                    case 1:
                        name_find(txt_searchtxt.Text); break;
                    case 2:
                        classnumber_find(txt_searchtxt.Text); break;
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
            Form_adminMain adminMain = new Form_adminMain();
            adminMain.ShowDialog();
        }
    }
}
