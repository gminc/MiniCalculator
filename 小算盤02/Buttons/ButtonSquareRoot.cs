using System;

namespace 小算盤02.Buttons
{
    /// <summary>
    /// 開根號
    /// </summary>
    public class ButtonSquareRoot : Button
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="storage">儲存數字和運算式的空間</param>
        public ButtonSquareRoot(InputStorage storage)
        {
            storage.Expression += string.Concat('√', new string(storage.Output.ToArray()));

            double.TryParse(new string(storage.Output.ToArray()), out double result);
            result = Math.Sqrt(result);

            storage.Numbers.AddLast((decimal)result);

            storage.Output.Clear();
            
            Output = new string(storage.Output.ToArray());
            Expression = storage.Expression;
        }
    }
}
