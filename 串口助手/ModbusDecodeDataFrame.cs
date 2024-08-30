using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 串口助手 {
    public class ModbusDecodeDataFrame : DecodeData {  // 是DecodeData 的具体实现
        public override byte[] DecodeDataFrame(Queue<byte> buffer) {
            // Modbus 的实现
            

            return null;
        }
    }
}
