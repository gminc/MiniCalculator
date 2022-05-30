using System;

namespace 小算盤02.Buttons
{
    /// <summary>
    /// 數字按鈕
    /// </summary>
    public class ButtonNumbers : Button
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="number">輸入數字</param>
        /// <param name="storage">儲存輸入的空間</param>
        public ButtonNumbers(string number, InputStorage storage)
        {
            storage.SaveToOutput(Convert.ToChar(number));
            Output = new string(storage.Output.ToArray());
            Expression = storage.Expression;
        }
    }
}