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
    public partial class Form_adminInfo : Form
    {
        public Form_adminInfo()
        {
            InitializeComponent();
        }


        private void Form_adminInfo_Load(object sender, EventArgs e)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                string strcom = "Select *from adminInfo where adminID ='" + Form_login.str.Trim() + "'";
                myconn.Open();
               SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                myDataSet.Clear();
                mycommand.Fill(myDataSet, "adminInfo");
                myconn.Close();

                if (myDataSet.Tables["adminInfo"].Rows.Count > 0)
                {
                    MessageBox.Show("查询成功！", "提示");
                    panel2.Visible = true;
                    label1.Text = myDataSet.Tables["adminInfo"].Rows[0][1].ToString();
                    label2.Text = myDataSet.Tables["adminInfo"].Rows[0][2].ToString();
                    label3.Text = myDataSet.Tables["adminInfo"].Rows[0][3].ToString();
                    label4.Text = myDataSet.Tables["adminInfo"].Rows[0][4].ToString();

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
