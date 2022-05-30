using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤02.Tools.Operators
{
    /// <summary>
    /// 運算子的介面
    /// </summary>
    public interface IOperater
    {
        /// <summary>
        /// 運算時的先後順序
        /// </summary>
        public int Priority { get; }

        /// <summary>
        /// 所有計算子都要可以計算
        /// </summary>
        /// <param name="frontNum">第一個數字</param>
        /// <param name="laterNum">第二個數字</param>
        /// <returns>運算結果</returns>
        public decimal Calculate(decimal frontNum, decimal laterNum);
    }
}
