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
    public partial class Form_adminMain : Form
    {
        public Form_adminMain()
        {
            InitializeComponent();
        }
        DataSet myDataSet = new DataSet();
        private void Form_adminMain_Load(object sender, EventArgs e)
        {
            string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
            SqlConnection myconn = new SqlConnection(strCon);

            string strcom = "Select *from studentInfo";
            myconn.Open();
            SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
            mycommand.Fill(myDataSet, "studentInfo");
            myconn.Close();
            this.dataGridView1.DataSource = myDataSet.Tables["studentInfo"];
        }

        // labels10.Text = login.str;   //接收来自login窗体的账号值，若登录成功则作为查询条件
        // str = textBox1.Text;//注意，这句不能放在f2.ShowDialog();的后面，否则会先执行textBox2.Text = f1.str;再执行str = textBox1.Text;

        private void toolStrip_add_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_adminAddStudent adminAdd = new Form_adminAddStudent();
            // this.Visible = true ;
            adminAdd.Show();
            // this.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];


        }

        public static string studentnumber;

        private void toolStrip_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int selectrow = this.dataGridView1.CurrentRow.Index;  //所选行
                this.Close();
                Form_adminEditStu adminEdit = new Form_adminEditStu();
                // this.Visible = true ;
                studentnumber = this.dataGridView1.Rows[selectrow].Cells[0].Value.ToString(); //所选行的第0列值   
                adminEdit.Show();
                // this.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
            }
            else
            {
                MessageBox.Show("请选中一行后再点击编辑按钮", "提示");
            }
        }

        private void toolStrip_delete_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            //选中一个学生信息并删除
            if (dataGridView1.SelectedRows.Count == 1)
            {

                int selectrow = this.dataGridView1.CurrentRow.Index;  //所选行
                String studentnumber = this.dataGridView1.Rows[selectrow].Cells[0].Value.ToString(); //所选行的第0列值
                if (MessageBox.Show("确定删除", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    delete(studentnumber);
                }
                else this.Close();
            }
            else
            {
                this.Visible = true;
                MessageBox.Show("请选中一行后再点击删除按钮！", "提示");
            }
        }


        private void delete(String studentnumber)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();
                string strcom = "Select *from studentInfo";
                string str = "DELETE FROM studentInfo WHERE stuID ='" + studentnumber + "'";
                myconn.Open();
                SqlCommand xg;
                xg = new SqlCommand(str, myconn);

                if (xg.ExecuteNonQuery() > 0)//判断是否成功        
                {                   //执行要操作的语句           
                    SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "studentInfo");
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




        private void toolStrip_search_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_adminSearchStu adminSearch = new Form_adminSearchStu();
            // this.Visible = true ;
            adminSearch.Show();
            // this.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];


        }
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }



        private void query(String key)
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();
                string strcom = "Select *from systemStudent";
                string str = key;
                myconn.Open();
                SqlCommand xg;
                xg = new SqlCommand(str, myconn);

                if (xg.ExecuteNonQuery() > 0)//判断是否成功        
                {                   //执行要操作的语句           
                    SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "systemStudent");
                    dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
                }
                myconn.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }

        String str;

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "大数据与软件工程学院")
            {
                str = " Select* from systemStudent where studentDepart = '大数据与软件工程学院'";
                //query(str);
                try
                {
                    string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudentInformationSystem.accdb";
                    SqlConnection myconn = new SqlConnection(strCon);
                    DataSet myDataSet = new DataSet();
                    string strcom = "Select *from systemStudent";
                    // string str = key;
                    myconn.Open();
                    SqlCommand xg;
                    xg = new SqlCommand(str, myconn);

                    if (xg.ExecuteNonQuery() > 0)//判断是否成功        
                    {                   //执行要操作的语句           
                        SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                        myDataSet.Clear();
                        mycommand.Fill(myDataSet, "systemStudent");
                        dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
                    }
                    myconn.Close();

                }
                catch (Exception x)
                {
                    MessageBox.Show("error!" + x.ToString());
                }



















            }
            else if (treeView1.SelectedNode.Text == "商学院")
            {
                str = " Select* from systemStudent where studentDepart = '商学院'";
                query(str);
            }
            else if (treeView1.SelectedNode.Text == "17物联网工程班")
            {
                str = " Select* from systemStudent where studentClass = '17物联网工程'";
                query(str);
            }
            else if (treeView1.SelectedNode.Text == "男")
            {
                str = " Select* from systemStudent where studentSex = '男'";
                query(str);
            }
            else if (treeView1.SelectedNode.Text == "女")
            {
                str = " Select* from systemStudent where studentSex = '女'";
                query(str);
            }
            else this.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip_query_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Form_adminInfo a = new Form_adminInfo();
            a.ShowDialog();

        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_login login = new Form_login();
            login.Show();
        }

        private void teacherManagertoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_adminTeacherManager a = new Form_adminTeacherManager();
            a.Show();
        }
    }
}
