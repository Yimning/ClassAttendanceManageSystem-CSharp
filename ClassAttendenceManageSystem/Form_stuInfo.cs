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
    public partial class Form_stuInfo : Form
    {
        public Form_stuInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string id;
        public static string name;
        public static string sex;
        public static string cid;
        public static string cname;
        public static string cardid;
        public static string psw;
        private void Form_stuInfo_Load(object sender, EventArgs e)
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
                    MessageBox.Show("查询成功！", "提示");
                    panel1.Visible = true;
                    labels1.Text = myDataSet.Tables["studentInfo"].Rows[0][0].ToString();
                      id= labels1.Text;
                    labels2.Text = myDataSet.Tables["studentInfo"].Rows[0][1].ToString();
                      name = labels2.Text;
                    labels3.Text = myDataSet.Tables["studentInfo"].Rows[0][2].ToString();
                      sex = labels3.Text;
                    labels4.Text = myDataSet.Tables["studentInfo"].Rows[0][3].ToString();
                      cid  = labels4.Text;
                    labels5.Text = myDataSet.Tables["studentInfo"].Rows[0][4].ToString();
                       cname = labels5.Text;
                    labels6.Text = myDataSet.Tables["studentInfo"].Rows[0][5].ToString();
                       cardid= labels6.Text;
                      //labels7.Text = myDataSet.Tables["studentInfo"].Rows[0][6].ToString();
                    labels8.Text = myDataSet.Tables["studentInfo"].Rows[0][7].ToString();
                    psw = labels8.Text;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }
    }
}
