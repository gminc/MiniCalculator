using 小算盤02.Tools.Operators;

namespace 小算盤02.Buttons
{
    /// <summary>
    /// 乘法
    /// </summary>
    public class ButtonMultiplication : Button
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="storage">儲存空間</param>
        public ButtonMultiplication(InputStorage storage)
        {
            storage.Expression += string.Concat(new string(storage.Output.ToArray()), '×');

            storage.AddToNumbers();
            storage.Operators.AddLast(new Multiplication());

            Output = new string(storage.Output.ToArray());
            Expression = storage.Expression;
        }
    }
}
