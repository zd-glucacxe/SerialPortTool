using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 串口助手 {
    /// <summary>
    /// Make sure the Endian mode of the data
    /// </summary>
    public enum BigOrLittle {
        /// <summary>
        /// BigEndian
        /// </summary>
        BigEndian = 0,
        /// <summary>
        /// LittleEndian
        /// </summary>
        LittleEndian = 1
    }
}
