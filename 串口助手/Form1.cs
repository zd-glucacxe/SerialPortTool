using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 串口助手.Properties;


namespace 串口助手 {
    public partial class Form1 : Form {
    

        // 开关状态位
        private bool isOpen = false;

        // 是否将接收到的串口数据显示在用户界面上
        private bool isRxShow = true;

        // 接收数据缓冲区
        private List<byte> reciveBuffer = new List<byte>();

        // 接收计数
        private int reciveCount = 0;

        // 发送数据缓冲区
        private List<byte> sendBuffer = new List<byte>();

        // 发送计数
        private int sendCount = 0;

        // 声明队列进行数据解析
        private Queue<byte> bufferQueue = null;

        // 标志位 是否有帧头数据
        private bool isHeadRecive = false;

        // 数据帧长度
        private int frameLength = 0;

        // 声明委托，将串口接收的数据在子窗体显示
        public Transmitdata transmitdata;

        // 简约事件声明 使用事件将串口接收的数据在子窗体显示
        private event TransmitEventHandler transmitEvent;

        // 上下文对象 DecodeDataContext 的引用
        private DecodeDataContext dataContext;

        // 发送配置 发送的文件
        string strRead = null;



        public Form1() {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;  // 不检查跨线程的非法调用
        }


        /// <summary>
        /// 窗口加载时
        /// </summary>
        private void Form1_Load(object sender, EventArgs e) {
            // 在设计页面已经预先添加了COM1、COM2、COM3
            //this.port_cbb.Items.Add("COM4");
            //this.port_cbb.Items.Add("COM5");

            SerialPortLoad();
            

            bufferQueue = new Queue<byte>(); // 实例化队列

            Form2 fr2 = new Form2();
            //transmitdata = fr2.ReciveData;  // 父窗体的委托关联方法
            //fr2.useForm1Send = sendBytes;  // 子窗体的委托关联方法

            //transmitEvent += new TransmitEventHandler(fr2.ReciveData2);  // 订阅事件处理器
            transmitEvent += fr2.ReciveData2;

            //fr2.useForm1SendEvent += new TransmitEventHandler(sendBytes2); // 订阅事件处理器
            fr2.useForm1SendEvent += sendBytes2;

            fr2.Show();

            dataContext = new DecodeDataContext(new SimpleDecodeDataFrame());  // 为上下类实例化一个具体的数据解析类
            //dataContext = new DecodeDataContext(new ModbusDecodeDataFrame());  // 为上下类实例化一个具体的数据解析类
            //dataContext.GetDataFrames(bufferQueue);  // 具体实现的数据解析类，的策略接口的实现



            //给发送框添加预设文本
            //this.send_rtb.Text = "我是发送框";

            //给接收框添加预设文本
            //this.recive_rtb.Text = "我是接收框";
        }

        /// <summary>
        /// 将子窗体的数据通过父窗体发送到串口 事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendBytes2(object sender, TransmitEventArgs e) {
            // 将发送区数据写入串口
            serialPort1.Write(buffer: e.data, offset: 0, count: e.data.Length);
            sendCount += e.data.Length;  // 发送计数
            sendcount_tssl.Text = sendCount.ToString();  // 更新底部状态栏，发送计数
        }

        /// <summary>
        /// 将子窗体的数据通过父窗体发送到串口 委托
        /// </summary>
        /// <param name="data">textBox1.Text， Form2 子窗体的数据</param>
        private void sendBytes(byte[] data) {
            // 将发送区数据写入串口
            serialPort1.Write(buffer: data, offset: 0, count: data.Length);
            sendCount += data.Length;  // 发送计数
            sendcount_tssl.Text = sendCount.ToString();  // 更新底部状态栏，发送计数
        }

        /// <summary>
        /// 从注册表加载串口
        /// </summary>
        private void SerialPortLoad() {

            //打开注册表中HKEY_LOCAL_MACHINE根键下的Hardware\DeviceMap\SerialComm子键，这样程序就可以读取与串行通信端口相关的配置信息
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");
            string[] sSubKeys = keyCom.GetValueNames();  // 也就是注册表项名称
            port_cbb.Items.Clear(); // 先清空一下
            foreach (var key in sSubKeys)
            {
                string portName = keyCom.GetValue(key).ToString();  //通过名称获取数据
                port_cbb.Items.Add(portName);  // 添加到port_cbb
            }


            // 串口配置的默认预设选择
            this.port_cbb.SelectedIndex = 2; // COM3
            this.baud_cbb.SelectedIndex = 1; // 9600
            this.check_cbb.SelectedIndex = 0; // None
            this.databit_cbb.SelectedIndex = 3; // 8
            this.stopbit_cbb.SelectedIndex = 0; // 1
        }

        /// <summary>
        /// 串口配置 RTS信号由发送设备 用来告诉接收设备，发送设备有数据要发送，请求允许发送。
        /// </summary>
        private void RTS_chb_CheckedChanged(object sender, EventArgs e) {
            if (RTS_chb.CheckState == CheckState.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        /// <summary>
        /// 串口配置 DTR信号表示通知其他设备，已经准备好进行通信
        /// </summary>
        private void DTR_chb_CheckedChanged(object sender, EventArgs e) {
            if (DTR_chb.CheckState == CheckState.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }



        /// <summary>
        ///  串口配置 "打开" / "关闭" 串口按钮
        /// </summary>
        private void open_btn_Click(object sender, EventArgs e) {
            try
            {

                if (serialPort1.IsOpen == false)
                {
                    // 初始化串口
                    serialPort1.PortName = port_cbb.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baud_cbb.Text);
                    switch (check_cbb.SelectedIndex)
                    {
                        case 0:
                            serialPort1.Parity = Parity.None;
                            break;
                        case 1:
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case 2:
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            serialPort1.Parity = Parity.None;
                            break;
                    }
                    serialPort1.DataBits = Convert.ToInt32(databit_cbb.Text);
                    switch (stopbit_cbb.SelectedIndex)
                    {
                        case 0:
                            serialPort1.StopBits = StopBits.One;
                            break;
                        case 1:
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case 2:
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            serialPort1.StopBits = StopBits.One;
                            break;
                    }

                    //打开串口
                    serialPort1.Open();
                    isOpen = true;
                    open_btn.Text = "关闭串口";
                    state_tssl.Text = $"打开串口{serialPort1.PortName}成功！";

                    if (serialPort1.IsOpen)
                    {
                        MessageBox.Show($"串口{serialPort1.PortName} 打开成功！");
                    }
                }
                else
                {
                    serialPort1.Close();
                    isOpen = false;
                    open_btn.Text = "打开串口";
                    state_tssl.Text = $"关闭串口{serialPort1.PortName}成功！";

                    if (serialPort1.IsOpen == false)
                    {
                        MessageBox.Show($"串口{serialPort1.PortName} 关闭成功！");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"串口{serialPort1.PortName} 操作失败！ {ex.Message}");
            }

        }

        /// <summary>
        /// 接收区 接收数据 serialPort1的DataReceived事件
        /// serialPort1 每次监听到有数据过来，就读取数据，然后添加到接收区的文本框里
        /// </summary>
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            if (isRxShow == false) return;  // 暂停按钮被按下

            byte[] dataTemp = new byte[serialPort1.BytesToRead]; // BytesToRead 当前可从串口缓冲区读取的字节数
            serialPort1.Read(buffer: dataTemp, 0, dataTemp.Length);  // 读取输入缓冲区, 将读到的数据临时存入dataTemp
            reciveBuffer.AddRange(dataTemp);  // 将数据存入接收缓冲区
            reciveCount += dataTemp.Length;  // 计数

            // 在接收数据的过程中，将数据发送到fr2.ReciveData(),也就是通过委托，让串口接收的数据在子窗体显示
            transmitdata?.Invoke(dataTemp);

            // 在接收数据的过程中，将数据发送到fr2.ReciveData(),也就是通过事件，让串口接收的数据在子窗体显示
            transmitEvent.Invoke(this, new TransmitEventArgs {data = dataTemp });



            // 使用辅助线程接收数据，把数据显示到接收区
            this.Invoke(new EventHandler(delegate
            {
                recivecount_tssl.Text = reciveCount.ToString();   // 更新底部状态栏，接收计数

                if (startData_cbb.Checked == false) // 没有勾选 启动数据帧接收
                {

                    // 没有勾选 16进制接收
                    if (!recivehex_chb.Checked)
                    {
                        string str = Encoding.GetEncoding("gb2312").GetString(dataTemp);
                        // 0x00 -> /0 结束， 不会显示 ，
                        // 字符串 str 中所有的 null 字符都会被替换为两个字符序列 "\\0"。这样做的目的是为了让 null 字符在文本显示时变得可见
                        str = str.Replace("\0", "\\0");
                        recive_rtb.AppendText(str);
                    }
                    else
                    {
                        // 十六进制，选中的情况下，以十六进制接收
                        this.recive_rtb.AppendText(Transform.ToHexString(dataTemp, " "));

                    }
                }
                else  // 启动数据帧接收 （指令解析）
                {
                    foreach (var data in dataTemp)
                    {
                        bufferQueue.Enqueue(data);  // 添加到队列末尾
                    }

                    // 
                    byte[] frameData = dataContext.GetDataFrames(bufferQueue);
                    if (frameData != null)
                    {
                        Console.WriteLine($"show the data in frameData{Transform.ToHexString(frameData)}");

                        data_txb.Text = Transform.ToHexString(frameData);  // 显示到数据帧TextBox
                        Console.WriteLine($"show the HeadRecive {string.Format("{0:X2}", frameData[0])} in frameBuffer");
                        Console.WriteLine($"show the DataRecive1 {string.Format("{0:X2}", frameData[1])} in frameBuffer");
                        Console.WriteLine($"show the DataRecive2 {string.Format("{0:X2}", frameData[2])} in frameBuffer");

                        /*
                         * 四位有效数据， 由于frameBuffer[0]是帧头，frameBuffer[1]是长度，因此从frameBuffer[2] 开始解析
                         */
                        data1_txb.Text = string.Format("{0:X2}", frameData[2]);
                        data2_txb.Text = string.Format("{0:X2}", frameData[3]);
                        data3_txb.Text = string.Format("{0:X2}", frameData[4]);
                        data4_txb.Text = string.Format("{0:X2}", frameData[5]);

                        for (int i = 0; i < frameData.Length; i++)
                        {
                            bufferQueue.Dequeue();  // 移出队列
                        }


                    }
                }

#if old
                    // 解析获取帧头 0X7F
                    if (isHeadRecive == false)
                    {
                        foreach (byte item in bufferQueue.ToArray())
                        {
                            if (item != 0x7f)
                            {
                                bufferQueue.Dequeue();  // 当前元素出队
                                Console.WriteLine("not 0x7f, bufferQueue！");
                            }
                            else
                            {
                                isHeadRecive = true;  // 获取到了帧头
                                Console.WriteLine("0x7f is recived!");
                                break;
                            }
                        }
                    }
                    if (isHeadRecive == true)
                    {
                        // 解析数据帧
                        if (bufferQueue.Count >= 2) // 帧头 + 数据帧
                        {
                            Console.WriteLine(DateTime.Now.ToString());
                            Console.WriteLine($"show the data in bufferQueue{Transform.ToHexString(bufferQueue.ToArray())}");
                            // 转换成十六进制形式 输出的十六进制数至少有两位，如果不足两位，前面用 0 补齐
                            Console.WriteLine($"frame length = {string.Format("{0:X2}", bufferQueue.ToArray()[1])}");
                            frameLength = bufferQueue.ToArray()[1];


                            // 完整的数据长度
                            if (bufferQueue.Count >= 1 + 1 + frameLength + 2)  // 帧头 + 数据 + 数据长度 + 2位的CRC
                            {
                                byte[] frameBuffer = new byte[1 + 1 + frameLength + 2];
                                Array.Copy(bufferQueue.ToArray(), 0, frameBuffer, 0, frameBuffer.Length);  // 有效的数据 copy 到 frameBuffer
                                if (crc_Check(frameBuffer))
                                {
                                    Console.WriteLine("frame is check ok ,pick it");
                                    Console.WriteLine($"show the data in frameBuffer{Transform.ToHexString(frameBuffer)}");

                                    data_txb.Text = Transform.ToHexString(frameBuffer);  // 显示到数据帧TextBox
                                    Console.WriteLine($"show the HeadRecive {string.Format("{0:X2}", frameBuffer[0])} in frameBuffer");
                                    Console.WriteLine($"show the DataRecive1 {string.Format("{0:X2}", frameBuffer[1])} in frameBuffer");
                                    Console.WriteLine($"show the DataRecive2 {string.Format("{0:X2}", frameBuffer[2])} in frameBuffer");

                                    /*
                                     * 四位有效数据， 由于frameBuffer[0]是帧头，frameBuffer[1]是长度，因此从frameBuffer[2] 开始解析
                                     */
                                    data1_txb.Text = string.Format("{0:X2}", frameBuffer[2]);
                                    data2_txb.Text = string.Format("{0:X2}", frameBuffer[3]);
                                    data3_txb.Text = string.Format("{0:X2}", frameBuffer[4]);
                                    data4_txb.Text = string.Format("{0:X2}", frameBuffer[5]);
                                }
                                else
                                {
                                    // 无效数据
                                    Console.WriteLine("bad fram , drop it");
                                }

                                for (int i = 0; i < (1 + 1 + frameLength + 2); i++)
                                {
                                    bufferQueue.Dequeue();  // 移出队列
                                }

                                isHeadRecive = false;

                            }



                        }
                        // 接续接收数据

                    }


#endif
            }));
        }

# if old

        private bool crc_Check(byte[] frameBuffer) {
            /*
             大端模式：是指数据的高字节保存在内存的低地址中，而数据的低字节保存在内存的高地址中，这样的存模式有点儿类似于把数据当作字符串顺序处理：
            地址由小向大增加，而数据从高位往低位放；这和我们的阅读习惯一致。

            小端模式：是指数据的高字节保存在内存的高地址中而数据的低字节保存在内存的低地址中，这种存储模式将地址的高低和数据位权有效地结合起来，
            高地址部分权值高，低地址部分权值低。
             */

            bool ret = false;

            byte[] temp = new byte[frameBuffer.Length - 2];  // 去除CRC 之前的数据
            Array.Copy(frameBuffer, 0 , temp, 0, temp.Length);  // copy to temp
            byte[] crcData = DataCheck.DataCrc16_Ccitt(temp, DataCheck.BigOrLittle.BigEndian);  // CRC
            if (crcData[0] == frameBuffer[frameBuffer.Length - 2] && crcData[1] == frameBuffer[frameBuffer.Length - 1])
            {
                // CRC 校验成功
                ret = true;
            }
            return ret;
        }

# endif

        /// <summary>
        /// 接收配置的 “暂停” 按钮
        /// </summary>
        private void stop_btn_Click(object sender, EventArgs e) {
            if (isRxShow == true)  // 表明当前正在显示接收到的数据
            {
                isRxShow = false;
                stop_btn.Text = "取消暂停";  // 暂停显示数据的状态
            }
            else   // 表明当前不在显示接收到的数据
            {
                isRxShow = true;
                stop_btn.Text = "暂停";  // 重新开始显示接收到的数据。
            }
        }

        /// <summary>
        /// 接收配置， 16进制选中 ，也就是让接收区文本以16进制显示
        /// </summary>
        private void recivehex_chb_CheckedChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(recive_rtb.Text)) return;  //接收区为空

            if (recivehex_chb.Checked)  // 16进制选中
            {
                recive_rtb.Text = Transform.ToHexString(reciveBuffer.ToArray(), " ");  // reciveBuffer 接收数据缓冲区
            }
            else
            {
                recive_rtb.Text = Encoding.GetEncoding("gb2312").GetString(reciveBuffer.ToArray()).Replace("\0", "\\0");
            }

        }


        /// <summary>
        /// 接收配置 手动清空按钮
        /// </summary>
        private void clear_btn_Click(object sender, EventArgs e) {
            // 首先清空缓冲区的数据
            reciveBuffer.Clear();
            reciveCount = 0;
            recive_rtb.Text = "";
            recivecount_tssl.Text = "0";  // 清空底部接收计数
            recive_rtb.Text = "";
        }

        /// <summary>
        /// 接收配置 自动清空 选中
        /// </summary>
        private void autoclear_chb_CheckedChanged(object sender, EventArgs e) {
            if (autoclear_chb.Checked)
            {
                timer1.Start(); //启动定时器
            }
            else
            {
                timer1.Stop(); //停止定时器
            }
        }

        /// <summary>
        /// 定时器timer1 事件
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e) {
            if (recive_rtb.Text.Length >= 4096)  // 接收区文本长度大于4kb
            {
                reciveBuffer.Clear();
                recive_rtb.Text = "";
                recivecount_tssl.Text = "0";  // 清空底部接收计数
            }
        }

        /// <summary>
        /// 接收配置 选择路径
        /// </summary>
        private void xzlj_btn_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                recivefile_txb.Text = fbDialog.SelectedPath;  // 获取用户选择的路径
            }

        }

        /// <summary>
        /// 接收配置 保存数据
        /// </summary>
        private void bcsj_btn_Click(object sender, EventArgs e) {
            if (recivefile_txb.Text == "")
            {
                return;
            }
            string fileName = recivefile_txb.Text + "\\" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";

            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(recive_rtb.Text);
            sw.Flush();
            sw.Close();
            MessageBox.Show("保存成功！");
        }

        /// <summary>
        /// 发送配置 焦点离开控件(send_rtb 发送区)时发生 ，处理发送缓冲区的数据
        /// </summary>
        private void send_rtb_Leave(object sender, EventArgs e) {
            if (sendhex_chb.Checked)  // 发送配置 16进制已选中
            {
                if (DataEncoding.IsHexString(send_rtb.Text.Replace(" ", "")))  // 发送区文本是否为16进制
                {
                    sendBuffer.Clear();
                    sendBuffer.AddRange(Transform.ToBytes(send_rtb.Text.Replace(" ", "")));  // 添加到发送缓冲区
                }
                else
                {
                    MessageBox.Show("请输入正确的16进制数据！");
                    send_rtb.Select();  // 关闭窗口后，光标回到send_rtb
                }

            }
            else
            {
                sendBuffer.Clear();
                sendBuffer.AddRange(Encoding.GetEncoding("gb2312").GetBytes(send_rtb.Text));
            }
        }

        /// <summary>
        /// 发送配置 发送区文本改变的事件
        /// </summary>
        private void send_rtb_TextChanged(object sender, EventArgs e) {
            // todo: 16进制转换 0x00


        }

        /// <summary>
        /// 发送配置 16进制选中
        /// </summary>
        private void sendhex_chb_CheckedChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(send_rtb.Text)) return;

            if (sendhex_chb.Checked)  //选中
            {
                send_rtb.Text = Transform.ToHexString(sendBuffer.ToArray(), " ");  //转为 16进制
            }
            else
            {
                send_rtb.Text = Encoding.GetEncoding("gb2312").GetString(sendBuffer.ToArray()).Replace("\0", "\\0");
            }

        }

        /// <summary>
        /// 发送配置 手动发送 按钮
        /// </summary>
        private void send_btn_Click(object sender, EventArgs e) {

            // 发送区字符串 非空 且 串口处于打开状态
            if (!string.IsNullOrEmpty(send_rtb.Text) && serialPort1.IsOpen)
            {
                Console.WriteLine(Transform.ToHexString(sendBuffer.ToArray()));
                SendData();
            }
            else
            {
                MessageBox.Show("请检查发送数据或串口状态！");
            }
        }

        private void SendData() {
            // 将发送区数据写入串口
            serialPort1.Write(buffer: sendBuffer.ToArray(), offset: 0, count: sendBuffer.Count);
            sendCount += sendBuffer.Count;  // 发送计数
            sendcount_tssl.Text = sendCount.ToString();  // 更新底部状态栏，发送计数
        }

        /// <summary>
        /// 发送配置 清空发送 按钮
        /// </summary>
        private void sendclear_btn_Click(object sender, EventArgs e) {
            sendBuffer.Clear();
            send_rtb.Text = "";
            sendCount = 0;
            sendcount_tssl.Text = "0";
        }

        /// <summary>
        /// 发送配置 自动发送 按钮
        /// </summary>
        private void autosend_chb_CheckedChanged(object sender, EventArgs e) {

            // 串口未打开
            if (serialPort1.IsOpen == false && autosend_chb.CheckState == CheckState.Checked) {

                autosend_chb.CheckState = CheckState.Unchecked;

                if (timer2 != null) 
                {
                    timer2.Enabled = false; 
                    timer2.Stop();
                    timer2 = null;  
                }
                MessageBox.Show("发送失败，串口未打开！");
                return;
            }

            // 串口打开
            if (serialPort1.IsOpen == true && autosend_chb.CheckState == CheckState.Checked)
            {
                autotimer_txb.Enabled = false;
                send_btn.Enabled = false;
                int i = Convert.ToInt32(autotimer_txb.Text);
                if (i < 10 || i > 60 * 1000)
                {
                    i = 1000;
                    autotimer_txb.Text = "1000";
                    MessageBox.Show("自动发送数据的周期范围是“10 - 60000 毫秒", "警告");
                }
                timer2.Interval = i;
                timer2.Start();

            }
            else
            {
                send_btn.Enabled = true;
                autotimer_txb.Enabled = true;
                if (timer2 != null)
                {
                    timer2.Stop();
                    timer2 = null;  
                }
            }
        }

        /// <summary>
        /// 定时器timer2 事件
        /// </summary>
        private void timer2_Tick(object sender, EventArgs e) {
            // 发送区字符串 非空 且 串口处于打开状态
            if (!string.IsNullOrEmpty(send_rtb.Text) && serialPort1.IsOpen)
            {
                Console.WriteLine(Transform.ToHexString(sendBuffer.ToArray()));
                SendData();
            }
            else
            {
                state_tssl.Text = "请先输入发送数据！";
                MessageBox.Show("请检查发送数据或串口状态！");
            }
        }

        /// <summary>
        /// 发送配置 打开文件 ,读取 并写入发送区
        /// </summary>
        private void dkwj_btn_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择文件";
            ofd.Filter = "文本文件(*.txt)|*.txt";  //过滤文件
            ofd.RestoreDirectory = true;     // 记住路径
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                sendfile_txb.Text = fileName;
                StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding("gb2312"));
                strRead = sr.ReadToEnd();  // 读文件
                send_rtb.Text = strRead;
                sr.Close();
            }
        }

        /// <summary>
        /// 发送配置 发送文件
        /// </summary>
        private void fswj_btn_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(strRead))
            {
                MessageBox.Show("请先选择文件！");
                return;
            }

            try
            {
                byte[] data = Encoding.GetEncoding("gb2312").GetBytes(strRead);
                sendCount += data.Length;
                sendcount_tssl.Text = sendCount.ToString();
                int pageum = data.Length / 4096;  //计算了数据需要分成多少页来发送，每页大小为4096字节。
                int remaind = data.Length % 4096;  // pageum是完整页的数量，remaind是最后一页剩余的字节数。
                for (int i = 0; i < pageum; i++)
                {
                    serialPort1.Write(data, i * 4096, 4096);  // 字节数组data中的数据写入串口。i * 4096是每页数据的起始索引，4096是每页的字节大小。每次发送后，线程会暂停10毫秒
                    Thread.Sleep(10);
                }
                if (remaind > 0)
                {
                    serialPort1.Write(data, pageum * 4096, remaind);  // 如果有剩余的数据（即最后一页的数据），这段代码会发送这部分数据。起始索引是pageum * 4096，发送的字节长度是remaind
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送数据失败！" + ex.Message.ToString(), "错误");
            }
        }

        /// <summary>
        ///  状态栏 清空计数
        /// </summary>
        private void clearcount_tssl_Click(object sender, EventArgs e) {
            sendBuffer.Clear();
            sendCount = 0;
            sendcount_tssl.Text = "0";

            reciveBuffer.Clear();
            reciveCount = 0;
            recivecount_tssl.Text = "0";
        }

        
    }
}
