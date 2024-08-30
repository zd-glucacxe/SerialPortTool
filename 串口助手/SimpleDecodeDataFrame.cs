using System;
using System.Collections.Generic;

namespace 串口助手 {
    public class SimpleDecodeDataFrame : DecodeData {  // 是DecodeData 的具体实现

        // 标志位 是否有帧头数据
        private bool isHeadRecive = false;

        // 数据帧长度
        private int frameLength = 0;

        // 数据校验
        private bool frameCheckOk = false;

        public override byte[] DecodeDataFrame(Queue<byte> bufferQueue) {  
            // 实现算法解析数据，并返回帧或空

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
                isHeadRecive = false;


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
                            frameCheckOk = true;    
                        }
                        else
                        {
                            // 无效数据
                            Console.WriteLine("bad fram , drop it");

                            for (int i = 0; i < (1 + 1 + frameLength + 2); i++)
                            {
                                bufferQueue.Dequeue();  // 移出队列
                            }
                            
                        }
                        if (frameCheckOk)
                        {
                            frameCheckOk = false;
                            return frameBuffer;
                        }
                    }
                }

                // 继续接收数据

            }


            return null;
        }


        private bool crc_Check(byte[] frameBuffer) {
            /*
             大端模式：是指数据的高字节保存在内存的低地址中，而数据的低字节保存在内存的高地址中，这样的存模式有点儿类似于把数据当作字符串顺序处理：
            地址由小向大增加，而数据从高位往低位放；这和我们的阅读习惯一致。

            小端模式：是指数据的高字节保存在内存的高地址中而数据的低字节保存在内存的低地址中，这种存储模式将地址的高低和数据位权有效地结合起来，
            高地址部分权值高，低地址部分权值低。
             */

            bool ret = false;

            byte[] temp = new byte[frameBuffer.Length - 2];  // 去除CRC 之前的数据
            Array.Copy(frameBuffer, 0, temp, 0, temp.Length);  // copy to temp
            byte[] crcData = DataCheck.DataCrc16_Ccitt(temp, DataCheck.BigOrLittle.BigEndian);  // CRC
            if (crcData[0] == frameBuffer[frameBuffer.Length - 2] && crcData[1] == frameBuffer[frameBuffer.Length - 1])
            {
                // CRC 校验成功
                ret = true;
            }
            return ret;
        }
    }


}






