using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAttendenceManageSystem
{
    public partial class Form_checkIning : Form
    {
        //===================================================
        //申明全局变量。
        public int CmdIdx = 0;          //命令发送指针初始为0。
        bool IsReceving = false;        //接收数据标志。
        bool DoingStr = false;          //处理字符串标志。
        bool DoingHex = false;          //处理十六进制标志。
        //===================================================
        public Form_checkIning()
        {
            InitializeComponent();
            this.statusTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timercomboBox.Text = timercomboBox.Items[0].ToString();
        }
        private void IntToHex()
        {
            try
            {
                int Int = int.Parse(tbDec.Text);
                string TempStr = Convert.ToString(Int, 16);
                while (TempStr.Length < 8)
                    TempStr = '0' + TempStr;
                tbHex.Text = TempStr.ToUpper();
                tbDec.SelectAll();
            }
            catch (Exception Err)
            {
                tbDec.SelectAll();
                MessageBox.Show(Err.Message, "提示");
            }
        }

        private void HexToInt()
        {
            try
            {
                int Int = Convert.ToInt32(tbHex.Text, 16);
                tbDec.Text = Int.ToString();
                tbHex.SelectAll();
            }
            catch (Exception Err)
            {
                tbHex.SelectAll();
                MessageBox.Show(Err.Message, "提示");
            }
        }

        private void CmdClick(int idx)
        {   //发送命令。
            try
            {
                //自动打开端口。
                if (!sComm.IsOpen)
                    btOpen_Click(null, null);

                string TempStr = string.Empty;

                TempStr = DelSpace(TempStr);

                if (cbDefFrm.Checked)   //自动添加帧头帧尾和校验
                {
                    TempStr = DelSpace(tbStart.Text) + TempStr;     //加入头。

                    //转换为字节数组。
                    int Len = TempStr.Length;         //待校验的字符串长度。
                    byte[] VerBin = new byte[Len / 2];
                    int j = 0;
                    for (int i = 0; i < Len; i += 2, j++)
                    {
                        VerBin[j] = Convert.ToByte(TempStr.Substring(i, 2), 16);
                    }
                    //计算校验字节。
                    byte VerByte = 0;
                    if (rdXor.Checked)
                    {
                        for (int i = 0; i < VerBin.Length; i++)
                            VerByte ^= VerBin[i];     //异或校验。

                    }
                    else if (rdAdd.Checked)
                    {
                        for (int i = 0; i < VerBin.Length; i++)
                            VerByte += VerBin[i];     //和校验。
                    }
                    //校验字节转为HEX字符串。
                    string VerStr = Convert.ToString(VerByte, 16);
                    //合成一帧。
                    TempStr = TempStr + DelSpace(VerStr) + DelSpace(tbEnd.Text);
                }

                SendAsHex(TempStr);
            }
            catch (Exception err)
            {
                TimeHex.Stop();
                TimeHex.Enabled = false;
                MessageBox.Show(err.Message, "提示");
                cbTimeHex.Checked = false;
            }
        }


        private void SendAsHex(string str)
        {
            int Len = str.Length;
            //组包发送。
            byte[] send = new byte[Len / 2];
            int j = 0;
            for (int i = 0; i < Len; i = i + 2, j++)
                send[j] = Convert.ToByte(str.Substring(i, 2), 16);
            sComm.Write(send, 0, send.Length);
        }

        //清除空格。
        private string DelSpace(string str)
        {
            string TempStr = string.Empty;
            int Len = str.Length;
            for (int i = 0; i < Len; i++)
            {
                if (str[i] != ' ')
                    TempStr += str[i];
            }
            //Hex 位数检查。
            Len = TempStr.Length;
            if (Len % 2 != 0)
                TempStr = '0' + TempStr;
            return TempStr;
        }

        //重新打开端口。
        private void ReOpenPort()
        {
            try
            {
                btClose_Click(null, null);
                //重新打开通讯端口。
                if (!sComm.IsOpen)
                    btOpen_Click(null, null);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "提示");
            }
        }

        private void Form_checkIning_Load(object sender, EventArgs e)
        {
            this.statustimer.Enabled = true;
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Start();
            try
            {
                foreach (string com in System.IO.Ports.SerialPort.GetPortNames())  //自动获取串行口名称
                    this.cmPort.Items.Add(com);
                cmPort.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("找不到通讯端口！", "提示");
            }
        }

        private void OpenPort()
        {
            //***避免串口死锁***
            sComm.WriteTimeout = 1000;  //写超时，如果底层串口驱动效率问题，能有效的避免死锁。
            sComm.ReadTimeout = 1000;   //读超时，同上。
            sComm.NewLine = "\r\n";     //回车换行。
            sComm.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sComm_DataReceived);   //注册事件。
            //***避免串口死锁***

            sComm.PortName = cmPort.Text;
            sComm.BaudRate = int.Parse(cmBaudRate.Text);
            sComm.DataBits = int.Parse(cmDataBit.Text);
            sComm.Parity = (Parity)Enum.Parse(typeof(Parity), cmParity.Text);
            sComm.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmStopBit.Text);
            sComm.Open();

        }

        private void ClosePort()
        {
            //安全关闭当前串口。
            //***避免串口死锁***
            sComm.DataReceived -= this.sComm_DataReceived;   //注销串口中断接收事件，避免下次再执行进来，造成死锁。
            while (IsReceving)
                Application.DoEvents();     //处理串口接收事件及其它系统消息。
            sComm.Close();                  //现在没有死锁，可以关闭串口。
            //***避免串口死锁***
        }

        private void StopAutoSend()
        {
            //停止自动发送字符串。
            TimeStr.Stop();
            TimeStr.Enabled = false;
            tbTimeStr.Enabled = true;
            cbTimeStr.Checked = false;
            //停止自动发送命令。
            TimeHex.Stop();
            TimeHex.Enabled = false;
            tbTimeHex.Enabled = true;
            cbTimeHex.Checked = false;
        }
        //===================================================
        int timeUp;

        private int counter=0;
        private void btOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenPort();     //安全打开串口。
                if (sComm.IsOpen)
                {
                    btClose.Enabled = true;
                    btOpen.Enabled = false;
                    //lbComStat.Text = "已打开 " + Convert.ToString(sComm.PortName) + ' ' + Convert.ToString(sComm.BaudRate) + ' ' + Convert.ToString(sComm.DataBits) + ' ' + Convert.ToString(sComm.Parity) + ' ' + Convert.ToString(sComm.StopBits);
                  //  tbSendStr.Focus();
                   // sComm.WriteLine("s201");
                    MessageBox.Show("端口打开,请获取签到码或手动输入并发送！" , "提示");
                    timeUp = Convert.ToInt32(timercomboBox.Text.ToString().Trim());
                    TimingMessageBox messageBox = new TimingMessageBox("签到中...", timeUp * 60);
                   // messageBox.ShowDialog();
                }
            }
            catch (Exception er)
            {
                StopAutoSend(); //停止自动发送。
                ClosePort();    //安全关闭当前串口。
                MessageBox.Show("端口打开失败！" + er.Message, "提示");
                lbComStat.Text = "已关闭";
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            //自动打开端口。
            if (!sComm.IsOpen)
                btOpen_Click(null, null);
            //发送文本。
            try
            {
                string txt = tbSendStr.Text.Trim();
                //Byte[] EncodeByte = new byte[txt.Length * 2];
                //EncodeByte = Encoding.GetEncoding("GB2312").GetBytes(txt);
                //int Len = EncodeByte.Length;
                //sComm.Write(EncodeByte, 0, Len);
                sComm.WriteLine(txt);
                MessageBox.Show("发送成功，签到中...", "提示");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "提示");
            }
        }

        private void btClrSend_Click(object sender, EventArgs e)
        {
            tbSendStr.Text = string.Empty;
        }

        private void cmPort_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                cmPort.Items.Clear();
                foreach (string com in System.IO.Ports.SerialPort.GetPortNames())  //自动获取串行口名称
                    this.cmPort.Items.Add(com);
            }
            catch
            {
                MessageBox.Show("找不到通讯端口！", "提示");
            }
        }
        string Str;
        String SignedUpFlag;
        public static string CardIDstr; 
        private void sComm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            sComm.Encoding = System.Text.Encoding.GetEncoding("GB2312");//汉字编码字符集
            System.Threading.Thread.Sleep(100);//延时100ms等待数据接收
           // String PortData = sComm.ReadLine();
            try
            {
                IsReceving = true;  //***正在接收状态指示。
                //读入收到的数据。
                int Len = sComm.BytesToRead;
                if (Len < 1)
                {
                    IsReceving = false;  //***接收完成状态指示。
                    return;
                }

                byte[] data = new byte[Len];
                sComm.Read(data, 0, Len);
                 

        //字符串处理。
              Str = Encoding.GetEncoding("GB2312").GetString(data);
                CardIDstr = Str.Substring(0, 8);
                SignedUpFlag = Str.Substring(8,1);



                //数据转十六进制字符串。
                string Hex = string.Empty;
                for (int i = 0; i < data.Length; i++)
                {
                    string tempstr = Convert.ToString(data[i], 16);
                    if (tempstr.Length < 2)
                        tempstr = '0' + tempstr;
                    Hex += tempstr + ' ';
                }
                Hex = Hex.ToUpper();




                //使用委托跨线程读取数据。
                rtbRecStr.Invoke(new EventHandler(delegate
                {
                    DoingStr = true;    //***正在处理字符串。
                   // rtbRecStr.Text = "卡号：";
                    rtbRecStr.AppendText(Str);
                    WriteDownAttendenceInfo();
                    if (cbAutoClr.Checked && rtbRecStr.Text.Length > 10000)
                        rtbRecStr.Text = string.Empty;
                    rtbRecStr.ScrollToCaret();      //将控件的内容滚动到当前位置。

                    DoingStr = false;
                }
                ));





                rtbRecHex.Invoke(new EventHandler(delegate
                {
                    DoingHex = true;    //***正在处理十六进制数据。

                    rtbRecHex.AppendText(Hex);
                    if (cbAutoClr.Checked && rtbRecHex.Text.Length > 10000)
                        rtbRecHex.Text = string.Empty;
                    rtbRecHex.ScrollToCaret();      //将控件的内容滚动到当前位置。

                    DoingHex = false;
                }
                ));

                while (DoingStr || DoingHex)
                    Application.DoEvents();     //处理串口接收事件及其它系统消息。
                IsReceving = false;  //***接收完成状态指示。
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "提示");
            }
        }

        public void WriteDownAttendenceInfo()
        {
            string str;
          try
          {
             string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=ClassAttendanceManageSystem";
             SqlConnection connection = new SqlConnection(strCon);
             DataSet myDataSet = new DataSet();
             string strcom = "Select *from attendenceInfo";
            if(SignedUpFlag=="1")
            {
                str = "insert into attendenceInfo VALUES ('" + CardIDstr.Trim() + "','" + DateTime.Now + "','已签','"+Form_teacherMain.strcourseid+"')";
            }
          else
           {
              SignedUpFlag = "0";
              str = "insert into attendenceInfo VALUES ('" + CardIDstr.Trim() + "','" + DateTime.Now + "','已签','" + Form_teacherMain.strcourseid + "')";
          }
             

             connection.Open();
            SqlCommand xg;
             xg = new SqlCommand(str, connection);

            if (xg.ExecuteNonQuery() > 0)//判断插入数据是否成功        
            {                   //执行要操作的语句           
              SqlDataAdapter mycommand = new SqlDataAdapter(strcom, connection);
              myDataSet.Clear();
              mycommand.Fill(myDataSet, "attendenceInfo");
               //adminMain.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
            }
                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }




        private void btClrRec_Click(object sender, EventArgs e)
        {
            rtbRecStr.Text = string.Empty;
            rtbRecHex.Text = string.Empty;
          //  ClrEncode();
        }

        private void rtbRecHex_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int idx = rtbRecHex.SelectionStart / 3;
                idx *= 3;
                if (rtbRecHex.Text.Length >= idx + 4 * 3)
                {
                    rtbRecHex.Select(idx, 4 * 3);
                    string SubStr = rtbRecHex.Text.Substring(idx, 4 * 3);
                    lbHexData.Text = SubStr;
                    string[] TempStr = SubStr.Split(' ');
                    string[] Frm = new string[4];
                }
                else
                {
                   // ClrEncode();
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "提示");
            }
        }

        private void rdBig_CheckedChanged(object sender, EventArgs e)
        {
            rtbRecHex_MouseClick(null, null);   //重新刷新数据解码。
        }

        private void cbDefFrm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDefFrm.Checked)
            {
                gpDefFrm.Enabled = true;
            }
            else
            {
                gpDefFrm.Enabled = false;
            }
        }

        private void cbTimeHex_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTimeHex.Checked)
                {
                    //禁止Str自动发送。
                    cbTimeStr.Checked = false;

                    int t = int.Parse(tbTimeHex.Text);
                    if (t < 5)
                    {
                        t = 5;
                        tbTimeHex.Text = Convert.ToString(t, 10);
                    }
                    //起动Hex自动发送。
                    tbTimeHex.Enabled = false;
                    TimeHex.Enabled = true;
                    TimeHex.Interval = t;
                    TimeHex.Start();
                }
                else
                {
                    TimeHex.Stop();
                    TimeHex.Enabled = false;
                    tbTimeHex.Enabled = true;
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("定时值不正确！" + Err.Message, "提示");
            }
        }

        private void cbTimeStr_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTimeStr.Checked)
                {
                    //禁止Hex自动发送。
                    cbTimeHex.Checked = false;

                    int t = int.Parse(tbTimeStr.Text);
                    if (t < 5)
                    {
                        t = 5;
                        tbTimeStr.Text = Convert.ToString(t, 10);
                    }
                    //启动Str自动发送。
                    tbTimeStr.Enabled = false;
                    TimeStr.Enabled = true;
                    TimeStr.Interval = t;
                    TimeStr.Start();
                }
                else
                {
                    TimeStr.Stop();
                    TimeStr.Enabled = false;
                    tbTimeStr.Enabled = true;
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("定时值不正确！" + Err.Message, "提示");
            }
        }

        private void btCmd1_Click(object sender, EventArgs e)
        {
            CmdClick(1);
        }

        private void btCmd2_Click(object sender, EventArgs e)
        {
            CmdClick(2);
        }

        private void btCmd3_Click(object sender, EventArgs e)
        {
            CmdClick(3);
        }

        private void btCmd4_Click(object sender, EventArgs e)
        {
            CmdClick(4);
        }

        private void btCmd5_Click(object sender, EventArgs e)
        {
            CmdClick(5);
        }

        private void cmPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReOpenPort();
        }

        private void cmBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReOpenPort();
        }

        private void cmDataBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReOpenPort();
        }

        private void cmParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReOpenPort();
        }

        private void cmStopBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReOpenPort();
        }

        private void TimeHex_Tick(object sender, EventArgs e)
        {
            try
            {
              //  int[] Len = { tbCmd1.Text.Length, tbCmd2.Text.Length, tbCmd3.Text.Length, tbCmd4.Text.Length, tbCmd5.Text.Length };
                int j = 0;
                int OldIdx = CmdIdx;
                for (int i = OldIdx; i < OldIdx + 5; i++)
                {
                    CmdIdx %= 5;
                    j = i % 5;
                    if (CmdIdx == j)
                    {
                        //CmdIdx++;
                        //if (Len[j] > 0)
                        //{
                        //    CmdClick(CmdIdx);
                        //    return;
                        //}
                    }
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("定时发送错误！" + Err.Message, "提示");
                cbTimeHex.Checked = false;
            }
        }

        private void TimeStr_Tick(object sender, EventArgs e)
        {
            try
            {
                btSend_Click(null, null);
            }
            catch (Exception Err)
            {
                MessageBox.Show("定时发送错误！" + Err.Message, "提示");
                cbTimeStr.Checked = false;
            }

        }

        private void tbDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')  //回车键
                IntToHex();     //转换为Hex。
        }

        private void tbDec_Leave(object sender, EventArgs e)
        {
            IntToHex();
        }

        private void tbHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')  //回车键
            {
                while (tbHex.Text.Length < 8)
                    tbHex.Text = '0' + tbHex.Text;
                HexToInt();         //转换为Dec。
            }
        }

        private void tbHex_Leave(object sender, EventArgs e)
        {
            while (tbHex.Text.Length < 8)
                tbHex.Text = '0' + tbHex.Text;
            HexToInt();             //转换为Dec。
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            StopAutoSend(); //停止自动发送。
            ClosePort();    //安全关闭串口。
            if (!sComm.IsOpen)
            {
                btOpen.Enabled = true;
                btClose.Enabled = false;
                lbComStat.Text = "已关闭";
            }
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            btClose_Click(null, null);
            this.Close();
        }

        private void rtbRecStr_TextChanged(object sender, EventArgs e)
        {

        }

        private void statustimer_Tick(object sender, EventArgs e)
        {
            this.statusTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbSendStr.Text = Form_teacherMain.classRoom.Trim();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            this.counter++;
            if (this.timeUp - this.counter == 0)
            {
                btOpen.Enabled = true;
                btClose.Enabled = false;
                ClosePort();    //安全关闭串口。
                this.timer1.Enabled = false;
                this.timer1.Stop();
               // this.Close();
            }
        }
    }
}
