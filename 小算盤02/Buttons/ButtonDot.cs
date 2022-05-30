using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤02.Buttons
{
    /// <summary>
    /// 增加小數點
    /// </summary>
    public class ButtonDot : Button
    {
        /// <summary>
        /// 點擊 . 後的動作
        /// </summary>
        /// <param name="storage">儲存空間</param>
        public ButtonDot(InputStorage storage)
        {
            if (!storage.Output.Contains('.'))
            {
                storage.Output.Add('.');
            }
            Output = new string(storage.Output.ToArray());
            Expression = storage.Expression;
        }
    }
}
