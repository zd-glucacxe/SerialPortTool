using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 串口助手 {
    public partial class Form2 : Form {

        // 声明委托，通过父窗体发送串口数据
        public Transmitdata useForm1Send;

        // 简约事件声明 使用事件通过父窗体发送串口数据
        public event TransmitEventHandler useForm1SendEvent;

        public Form2() {
            InitializeComponent();
        }


        // 委托
        // 子窗体 接收数据, 并将串口接收到的数据在子窗体显示
        public void ReciveData(byte[] tempData) {
            string str = Encoding.GetEncoding("gb2312").GetString(tempData);
            // 0x00 -> /0 结束， 不会显示 ，
            // 字符串 str 中所有的 null 字符都会被替换为两个字符序列 "\\0"。这样做的目的是为了让 null 字符在文本显示时变得可见
            str = str.Replace("\0", "\\0");
            richTextBox1.AppendText(str);
        }

        // 事件
        // 子窗体 接收数据, 并将串口接收到的数据在MessageBox显示 ReciveData2: 事件处理器
        internal void ReciveData2(object sender, TransmitEventArgs e) {
            string str = Encoding.GetEncoding("gb2312").GetString(e.data);
           
            str = str.Replace("\0", "\\0");
            richTextBox1.AppendText(str);
        }




        /// <summary>
        /// 发送数据 btn
        /// </summary>
        private void button1_Click(object sender, EventArgs e) {

            // 通过useForm1Send委托，将子窗体的数据通过父窗体发送出去
            useForm1Send?.Invoke(Encoding.GetEncoding("gb2312").GetBytes(textBox1.Text));

            // 通过useForm1SendEvent事件，将子窗体的数据通过父窗体发送出去
            byte[] dataTmp = Encoding.GetEncoding("gb2312").GetBytes(textBox1.Text);
            useForm1SendEvent?.Invoke(this, new TransmitEventArgs { data = dataTmp });

        }
    }
}
