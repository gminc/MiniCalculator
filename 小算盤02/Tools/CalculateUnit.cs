using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 小算盤02.Tools.Operators;

namespace 小算盤02.Tools
{
    /// <summary>
    /// 重送單一計算行為資訊的物件
    /// </summary>
    public class CalculateUnit
    {
        /// <summary>
        /// 前一個數字
        /// </summary>
        public decimal FrontNumber { get; private set; }

        /// <summary>
        /// 後一個數字
        /// </summary>
        public decimal LaterNumber { get; private set; }

        /// <summary>
        /// 運算子
        /// </summary>
        public IOperater Operater { get; private set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="frontNum">前一個數字</param>
        /// <param name="laterNum">後一個數字</param>
        /// <param name="operater">運算子</param>
        public CalculateUnit(decimal frontNum, decimal laterNum, IOperater operater)
        {
            this.FrontNumber = frontNum;
            this.LaterNumber = laterNum;
            this.Operater = operater;
        }
    }
}
