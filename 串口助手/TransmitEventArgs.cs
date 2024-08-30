using System;

namespace 串口助手 {

    // 自定义委托
    public delegate void Transmitdata(byte[] data);



    // 自定义委托，用来声明事件
    public delegate void TransmitEventHandler(object sender, TransmitEventArgs e);
    // 事件参数
    public class TransmitEventArgs : EventArgs {
       public byte[] data { get; set; }
    }
}
