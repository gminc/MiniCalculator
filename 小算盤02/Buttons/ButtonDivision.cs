using 小算盤02.Tools.Operators;

namespace 小算盤02.Buttons
{
    /// <summary>
    /// 除法
    /// </summary>
    public class ButtonDivision : Button
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="storage">儲存空間</param>
        public ButtonDivision(InputStorage storage)
        {
            storage.Expression += string.Concat(new string(storage.Output.ToArray()), '÷');

            storage.AddToNumbers();
            storage.Operators.AddLast(new Division());

            Output = new string(storage.Output.ToArray());
            Expression = storage.Expression;
        }
    }
}
