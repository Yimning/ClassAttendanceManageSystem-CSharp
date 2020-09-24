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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\DiamondBlue.ssk";  //选择皮肤文件
            skinEngine1.DisableTag = 9999;      //设置不需要被渲染的控件Tag值为9999
                                                //this.BackgroundImage = Image.FromFile(@"C:\E盘(文件)\MyC\StudentInformationSystem\StudentInformationSystem\Resources\1.jpg");
                                                // BackgroundImage = this.imageList1.Images[0];
        }

        int flag;
        public static string str;//public类型的实例字段,static变量被所有对象所共有，也可以被所有对象所改变
        public static string str1;  //用户保存密码


        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private bool judge()

        {
            //用if来判断框的内容

            if (textBox1.Text == "")

                return false;

            if (textBox2.Text == "")

                return false;

            return true;

        }
        private void radioButton_stu_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void radioButton_teac_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void radioButton_admin_CheckedChanged(object sender, EventArgs e)
        {
            flag = 3;
        }


        private void button_login_Click(object sender, EventArgs e)
        {
            //这里写入刚刚的判断语句

            if (!judge())
            {

                MessageBox.Show("账号或密码为空,请正确输入信息","提示");

                return;

            }

            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                if (flag == 1) //radioButton1_stu  判断是否为学生用户
                {
                    string sql = "Select *from studentInfo where stuID ='" + textBox1.Text.Trim() +
                        "' and stuPassword='" + this.textBox2.Text.Trim() + "'";
                    connection.Open();
                    SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "studentInfo");
                    connection.Close();

                    if (myDataSet.Tables["studentInfo"].Rows.Count > 0)
                    {
                        MessageBox.Show("登录成功！", "提示");
                        this.Visible = false;
                        Form_studentMain stu = new Form_studentMain();
                        str = textBox1.Text;//注意，这句不能放在stu.Show();的后面，否则将传值不到其他窗体；会先执行textBox2.Text =stu.str;再执行str = textBox1.Text;
                        str1 = textBox2.Text;//保存密码
                        stu.Show();
                    }
                    else
                        MessageBox.Show("用户名或密码错误！", "提示");
                }

                else if (flag == 2)
                {
                    string sql = "Select *from teacherInfo where teacherID ='" + textBox1.Text.Trim() + "' and teacherPassword='" + this.textBox2.Text.Trim() + "'";
                    connection.Open();
                    SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "teacherInfo");
                    connection.Close();

                    if (myDataSet.Tables["teacherInfo"].Rows.Count > 0)
                    {
                        MessageBox.Show("登录成功！", "提示");
                        this.Visible = false;
                        Form_teacherMain a = new Form_teacherMain();
                        str = textBox1.Text;//注意，这句不能放在f2.ShowDialog();的后面，否则会先执行textBox2.Text = f1.str;再执行str = textBox1.Text;
                        str1 = textBox2.Text;//保存密码
                        a.ShowDialog();
                    }
                    else
                        MessageBox.Show("用户名或密码错误！", "提示");
                }
                else if (flag == 3)
                {
                    string sql = "Select *from adminInfo where adminID ='" + textBox1.Text.Trim() + "' and adminPassword='" + this.textBox2.Text.Trim() + "'";
                    connection.Open();
                    SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "adminInfo");
                    connection.Close();

                    if (myDataSet.Tables["adminInfo"].Rows.Count > 0)
                    {
                        MessageBox.Show("登录成功！","提示");
                        this.Visible = false;
                        Form_adminMain a = new Form_adminMain();
                        str = textBox1.Text;//注意，这句不能放在f2.ShowDialog();的后面，否则会先执行textBox2.Text = f1.str;再执行str = textBox1.Text;
                        str1 = textBox2.Text;//保存密码
                        a.ShowDialog();
                    }
                    else
                        MessageBox.Show("用户名或密码错误！", "提示");
                }
                else MessageBox.Show("请选择用户类型！", "提示");

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }


        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        /*
           // 等比例放大
                private float X;

                private float Y;

                private void setTag(Control cons)
                {
                    foreach (Control con in cons.Controls)
                    {
                        con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                        if (con.Controls.Count > 0)
                            setTag(con);
                    }
                }
                private void setControls(float newx, float newy, Control cons)
                {
                    foreach (Control con in cons.Controls)
                    {

                        string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                        float a = Convert.ToSingle(mytag[0]) * newx;
                        con.Width = (int)a;
                        a = Convert.ToSingle(mytag[1]) * newy;
                        con.Height = (int)(a);
                        a = Convert.ToSingle(mytag[2]) * newx;
                        con.Left = (int)(a);
                        a = Convert.ToSingle(mytag[3]) * newy;
                        con.Top = (int)(a);
                       // Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                       // con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                        if (con.Controls.Count > 0)
                        {
                            setControls(newx, newy, con);
                        }
                    }

                }

                void Form1_Resize(object sender, EventArgs e)
                {
                    float newx = (this.Width) / X;
                    float newy = this.Height / Y;
                    setControls(newx, newy, this);
                    this.Text = this.Width.ToString() + " " + this.Height.ToString();

                }

                private void Form_login_Load(object sender, EventArgs e)
                {
                    //在Form_Load里面添加:  

                    this.Resize += new EventHandler(Form1_Resize);

                    X = this.Width;
                    Y = this.Height;

                    setTag(this);
                    Form1_Resize(new object(), new EventArgs());//x,y可在实例化时赋值,最后这句是新加的，在MDI时有用
                }
            */

    }
}
