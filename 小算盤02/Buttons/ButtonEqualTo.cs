using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using 小算盤02.Tools;

namespace 小算盤02.Buttons
{
    /// <summary>
    /// 等於的功能
    /// </summary>
    public class ButtonEqualTo : Button
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="storage">儲存數字和運算的空間</param>
        public ButtonEqualTo(InputStorage storage)
        {
            storage.Expression += string.Concat(new string(storage.Output.ToArray()), '=');
            storage.AddToNumbers();

            Calculator calculator = new Calculator(storage);
            try
            {
                calculator.Calculate();
            }
            catch (DivideByZeroException)
            {
                storage.Output.Clear();
                storage.Output.AddRange("無法除以零");
            }

            Output = new string(storage.Output.ToArray());
            Expression = storage.Expression;
            storage.Reset();
        }
    }
}
