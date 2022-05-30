using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤02.Buttons
{
    /// <summary>
    /// 正負號
    /// </summary>
    public class ButtonNegate : Button
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="storage">儲存要計算的數字空間</param>
        public ButtonNegate(InputStorage storage)
        {
            decimal originalNum = decimal.Parse(new string(storage.Output.ToArray()));
            decimal negateNum = originalNum * (-1);
            storage.Output.Clear();
            storage.Output.AddRange(negateNum.ToString().ToArray());
            Output = new string(storage.Output.ToArray());
            Expression = storage.Expression;
        }
    }
}
