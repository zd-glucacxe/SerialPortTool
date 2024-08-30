using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 串口助手 {
    // 使用策略模式构建一些类 (抽象基类)
    public abstract class DecodeData {
        // 抽象方法解析数据  （策略接口）
        public abstract byte[] DecodeDataFrame (Queue<byte> buffer);

    }
}
