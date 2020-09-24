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
    public partial class Form_adminTeacherManager : Form
    {
        public Form_adminTeacherManager()
        {
            InitializeComponent();
        }
      
        private void TInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryTeachers();
        }

        private void queryTeachers()
        {
            string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
            SqlConnection myconn = new SqlConnection(strCon);
            DataSet myDataSet = new DataSet();
            string strcom = "Select *from teacherInfo";
            myconn.Open();
            SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
            mycommand.Fill(myDataSet, "teacherInfo");
            myconn.Close();
            this.dataGridView1.DataSource = myDataSet.Tables["teacherInfo"];
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            this.dataGridView1.Visible = true;
            queryTeachers();
        }

        private void AddTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_adminTeacherAdd a = new Form_adminTeacherAdd();
            a.Show();
        }


        public static string teacherID;

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int selectrow = this.dataGridView1.CurrentRow.Index;  //所选行
                teacherID = this.dataGridView1.Rows[selectrow].Cells[0].Value.ToString(); //所选行的第0列值   
                this.Close();
                Form_adminTeacherEdit a = new Form_adminTeacherEdit();
                // this.Visible = true ;
                Console.WriteLine("{0}",selectrow);
                Console.ReadLine();
                a.Show();
                // this.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
            }
            else
            {
                MessageBox.Show("请选中一行后再点击编辑按钮","提示");
            }
        }

        private void deltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //选中一个学生信息并删除
            if (dataGridView1.SelectedRows.Count == 1)
            {

                int selectrow = this.dataGridView1.CurrentRow.Index;  //所选行
                String teacherid = this.dataGridView1.Rows[selectrow].Cells[0].Value.ToString(); //所选行的第0列值
                if (MessageBox.Show("确定删除", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    delete(teacherid);
                }
                else this.Close();
            }
            else
            {
                this.Visible = true;
                MessageBox.Show("请选中一行后再点击删除按钮！", "提示");
            }
        }

        private void delete(String teacherid)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();
                string strcom = "Select *from teacherInfo";
                string str = "DELETE FROM teacherInfo WHERE teacherID ='" + teacherid + "'";
                myconn.Open();
                SqlCommand xg;
                xg = new SqlCommand(str, myconn);

                if (xg.ExecuteNonQuery() > 0)//判断是否成功        
                {                   //执行要操作的语句           
                    SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "teacherInfo");
                    //adminMain.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
                    MessageBox.Show("删除成功", "提示");
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




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_adminMain a = new Form_adminMain();
            a.Show();
        }

        private void Form_adminTeacherManager_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            queryTeachers();
        }
    }
}
