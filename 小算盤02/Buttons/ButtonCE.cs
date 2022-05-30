using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤02.Buttons
{
    /// <summary>
    /// 清除 Showcase
    /// </summary>
    public class ButtonCE : Button
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="storage">儲存要計算的數字空間</param>
        public ButtonCE(InputStorage storage)
        {
            storage.OutputReset();
            Output = new string(storage.Output.ToArray());
            Expression = storage.Expression;
        }
    }
}
