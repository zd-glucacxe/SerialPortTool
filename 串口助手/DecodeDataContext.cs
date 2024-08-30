using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 串口助手 {

    /// 上下文类
    /*DecodeDataContext 类的作用：
    它充当了策略模式和客户端之间的中介，允许客户端通过改变策略来改变行为，而不需要知道策略的具体实现细节。
    它管理着策略对象，并在运行时根据需要切换不同的解析策略。
    它提供了一个公共接口 GetDataFrames，允许客户端传入数据缓冲区（在这里是一个字节队列），并通过当前的解析策略来处理这些数据。
    总的来说，DecodeDataContext 允许系统的其他部分在不直接依赖于具体策略类的情况下使用不同的数据解析策略。这使得增加新的解析策略变得简单，只需创建一个新的 DecodeData 实现类，并将其传递给 DecodeDataContext 即可。*/
 
    public class DecodeDataContext {
        private DecodeData decodeData;  // 策略对象DecodeData 的引用

        public DecodeDataContext(DecodeData data)
        {
            this.decodeData = data;
        }

        // 调用策略对象的 DecodeDataFrame 方法来执行具体的解析策略
        public byte[] GetDataFrames(Queue<byte> buffer) {
            return decodeData.DecodeDataFrame(buffer);  
        }

    }
}
