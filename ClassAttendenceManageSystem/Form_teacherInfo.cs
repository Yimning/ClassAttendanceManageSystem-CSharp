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
    public partial class Form_teacherInfo : Form
    {
        public Form_teacherInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_teacherInfo_Load(object sender, EventArgs e)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();
                string strcom = "Select *from teacherInfo where teacherID ='" + Form_login.str.Trim() + "'";
                myconn.Open();
                SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "teacherInfo");
                myconn.Close();

                if (myDataSet.Tables["teacherInfo"].Rows.Count > 0)
                {
                    MessageBox.Show("查询成功！", "提示");
                    panel1.Visible = true;
                    labels1.Text = myDataSet.Tables["teacherInfo"].Rows[0][0].ToString();
                    labels2.Text = myDataSet.Tables["teacherInfo"].Rows[0][1].ToString();
                    labels3.Text = myDataSet.Tables["teacherInfo"].Rows[0][2].ToString();
                    labels4.Text = myDataSet.Tables["teacherInfo"].Rows[0][3].ToString();
                    //labels5.Text = myDataSet.Tables["systemStudent"].Rows[0][5].ToString();
                    //labels6.Text = myDataSet.Tables["systemStudent"].Rows[0][6].ToString();
                    //labels7.Text = myDataSet.Tables["systemStudent"].Rows[0][7].ToString();
                    //labels8.Text = myDataSet.Tables["systemStudent"].Rows[0][8].ToString();
                    //labels9.Text = myDataSet.Tables["systemStudent"].Rows[0][9].ToString();
                    //labels10.Text = myDataSet.Tables["systemStudent"].Rows[0][10].ToString();
                    //labels11.Text = myDataSet.Tables["systemStudent"].Rows[0][11].ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }
    }
}
