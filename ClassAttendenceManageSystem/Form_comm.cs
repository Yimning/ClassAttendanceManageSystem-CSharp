using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAttendenceManageSystem
{
    public partial class Form_comm : Form
    {
        SerialPort serialPort = null;//声明串口类
        bool isOpen = false;//打开串口标志位
        bool isSetProperty = false;//属性设置标志位
        bool isHex = false;//十六进制显示标志位
        public Form_comm()
        {
            InitializeComponent();
        }


        private void Form_comm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;//禁止用最大化


            int i;
            for (i = 0; i < 8; i++)//最大支持到串口15，根据需求添加
            {
                comboBoxPort.Items.Add("COM" + (i + 1).ToString());
            }
            comboBoxPort.SelectedIndex = 0;

            //列出常用的波特率
            comboBoxBaud.Items.Add("1200");
            comboBoxBaud.Items.Add("2400");
            comboBoxBaud.Items.Add("4800");
            comboBoxBaud.Items.Add("9600");
            comboBoxBaud.Items.Add("19200");
            comboBoxBaud.Items.Add("38400");
            comboBoxBaud.Items.Add("43000");
            comboBoxBaud.Items.Add("56000");
            comboBoxBaud.Items.Add("57600");
            comboBoxBaud.Items.Add("115200");
            comboBoxBaud.SelectedIndex = 9;
            //列出停止位
            comboBoxSbits.Items.Add("0");
            comboBoxSbits.Items.Add("1");
            comboBoxSbits.Items.Add("1.5");
            comboBoxSbits.Items.Add("2");
            comboBoxSbits.SelectedIndex = 1;
            //列出奇偶校验位
            comboBoxParitv.Items.Add("无");
            comboBoxParitv.Items.Add("奇校验");
            comboBoxParitv.Items.Add("偶校验");
            comboBoxParitv.SelectedIndex = 0;
            //列出数据位
            comboBoxDatabits.Items.Add("8");
            comboBoxDatabits.Items.Add("7");
            comboBoxDatabits.Items.Add("6");
            comboBoxDatabits.Items.Add("5");
            comboBoxDatabits.SelectedIndex = 0;
            //默认显示char
            //rbnChar.Checked = true;
            comboBoxValue.Items.Add("20");
            comboBoxValue.Items.Add("25");
            comboBoxValue.Items.Add("35");
            comboBoxValue.Items.Add("40");
            comboBoxValue.Items.Add("45");
            comboBoxValue.SelectedIndex = 1;
        }



        private void buttonCheckcom_Click(object sender, EventArgs e)
        {
            bool comExistence = false;//有可用串口标志位
            comboBoxPort.Items.Clear();

            for (int i = 0; i < 8; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    comboBoxPort.Items.Add("COM" + (i + 1).ToString());
                    comExistence = true;

                }
                catch (Exception)
                {
                    continue;
                }

            }

            if (comExistence)
            {
                comboBoxPort.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("没有找到串口！", "错误提示");
            }

        }




        public static string str;
        /////////私有函数
        /*        检测串口是否设置        */
        private bool CheckPortSetting()
        {

            if (comboBoxPort.Text.Trim() == "") return false;
            if (comboBoxBaud.Text.Trim() == "") return false;
            if (comboBoxDatabits.Text.Trim() == "") return false;
            if (comboBoxParitv.Text.Trim() == "") return false;
            if (comboBoxSbits.Text.Trim() == "") return false;
            return true;
        }


        /////////私有函数
        /*        检测发送数据        */
        private bool CheckSendData()
        {
            if (comboBoxPort.Text.Trim() == "") return false;
            return true;
        }
        /////////私有函数
        /*       设置串口的属性        */
        private void SetPortProperty()
        {
            serialPort = new SerialPort();
            serialPort.PortName = comboBoxPort.Text.Trim();//串口名称
            serialPort.BaudRate = Convert.ToInt32(comboBoxBaud.Text.Trim());//波特率

            float f = Convert.ToSingle(comboBoxSbits.Text.Trim());//设置停止位
            if (f == 0)
            {
                serialPort.StopBits = StopBits.None;
            }
            else if (f == 1.5)
            {
                serialPort.StopBits = StopBits.OnePointFive;
            }
            else if (f == 1)
            {
                serialPort.StopBits = StopBits.One;
            }
            else if (f == 2)
            {
                serialPort.StopBits = StopBits.Two;
            }
            else
            {
                serialPort.StopBits = StopBits.One;
            }

            serialPort.DataBits = Convert.ToInt16(comboBoxDatabits.Text.Trim());//设置数据位
            string s = comboBoxParitv.Text.Trim();//设置奇偶位

            if (s == "无")
            {
                serialPort.Parity = Parity.None;
            }
            else if (s == "奇校验")
            {
                serialPort.Parity = Parity.Odd;
            }
            else if (s == "偶校验")
            {
                serialPort.Parity = Parity.Even;
            }
            else
            {
                serialPort.Parity = Parity.None;
            }

            serialPort.ReadTimeout = -1;//设置超时读取函数
            serialPort.RtsEnable = true;

            //定义 DataReceive 事件

            serialPort.ReceivedBytesThreshold = 1;

            serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);//该方法加载就运行，

            //if (rbnHex.Checked)
            //{

            //    isHex = true;
            //}
            //else
            //{
            //    isHex = false;
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);//延时100ms等待数据接收
            String PortData = serialPort.ReadLine();

            this.Invoke((EventHandler)(delegate
            {

                if (isHex == false)
                {
                    string temperature = PortData.Substring(0, 2);
                    string humidity = PortData.Substring(2, 2);
                    // textBox1.Text += sp.ReadLine();
                    //   textBox1.Text += "温度：" + temperature + "℃";
                    //  textBox2.Text += "湿度：" + humidity + "%";
                    // richTextBox1.Text += "温度：" + temperature + "℃";
                    //this.richTextBox1.SelectionStart = 4;//当前索引;
                    //this.richTextBox1.SelectionLength = 999999999;//行的长度;
                    //richTextBox1.SelectionColor = System.Drawing.Color.Blue;
                    //textBox1.ForeColor = Color.DarkGreen;
                    //textBox2.ForeColor = Color.DarkBlue;
                    //textBox1.AppendText(System.Environment.NewLine);
                    //textBox2.AppendText(System.Environment.NewLine);
                    //char warn_alarm;

                    if (int.Parse(temperature) >= int.Parse(comboBoxValue.Text))
                    {
                        //textBox1.ForeColor = Color.Red;
                        //serialPort.Write("1");
                        //TimingMessageBox messageBox = new TimingMessageBox("超标温度：" + temperature + "℃", 1);
                        //messageBox.ShowDialog();
                    }
                    else
                    {
                        serialPort.Write("0");
                    }
                }
                else
                {
                    Byte[] ReceivedData = new Byte[serialPort.BytesToRead];//创建接收的数组
                    serialPort.Read(ReceivedData, 0, ReceivedData.Length);
                    String RecvDataText = null;
                    for (int i = 0; i < ReceivedData.Length - 1; i++)
                    {
                        RecvDataText += ("0x" + ReceivedData[i].ToString("X2") + " ");
                    }

                }
                serialPort.DiscardInBuffer();
            }));
        }







        private void buttonOpenCom_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                if (!CheckPortSetting())
                {
                    MessageBox.Show("串口未设置！", "错误提示");
                    return;

                }
                if (!isSetProperty)
                {
                    SetPortProperty();
                    isSetProperty = true;
                }
                try
                {
                    serialPort.Open();
                    isOpen = true;
                    comboBoxPort.Enabled = false;
                    comboBoxBaud.Enabled = false;
                    comboBoxDatabits.Enabled = false;
                    comboBoxParitv.Enabled = false;
                    comboBoxSbits.Enabled = false;
                    buttonCheckcom.Enabled = false;
                    buttonOpenCom.Text = "关闭串口";
                    MessageBox.Show("串口已打开！", "提示");
                }
                catch (Exception)
                {
                    isSetProperty = false;
                    isOpen = false;
                    MessageBox.Show("串口无效或已被占用！", "错误提示");
                }
            }
            else
            {
                try
                {
                    serialPort.Close();
                    isOpen = false;
                    isSetProperty = false;
                    comboBoxPort.Enabled = true;
                    comboBoxBaud.Enabled = true;
                    comboBoxDatabits.Enabled = true;
                    comboBoxParitv.Enabled = true;
                    comboBoxSbits.Enabled = true;
                    buttonCheckcom.Enabled = true;
                    buttonOpenCom.Text = "打开串口";
                    // rbnChar.Enabled = true;
                    //rbnHex.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("关闭时发生错误！", "错误提示");

                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
