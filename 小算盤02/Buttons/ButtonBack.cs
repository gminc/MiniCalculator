using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤02.Buttons
{
    /// <summary>
    /// 從 Showcase 最後一個開始刪除一個數字
    /// </summary>
    public class ButtonBack : Button
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="storage">儲存要計算的數字空間</param>
        public ButtonBack(InputStorage storage)
        {
            if (storage.Output.Count <= 1)
            {
                storage.OutputReset();
            }
            else
            {
                storage.Output.RemoveAt(storage.Output.Count - 1);
            }

            Output = new string(storage.Output.ToArray());
            Expression = storage.Expression;
        }
    }
}
