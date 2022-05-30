using 小算盤02.Tools.Operators;

namespace 小算盤02.Buttons
{
    /// <summary>
    /// 加法
    /// </summary>
    public class ButtonAddition : Button
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="storage">儲存空間</param>
        public ButtonAddition(InputStorage storage)
        {
            storage.Expression += string.Concat(new string(storage.Output.ToArray()), '＋');

            storage.AddToNumbers();
            storage.Operators.AddLast(new Addition());

            Output = new string(storage.Output.ToArray());
            Expression = storage.Expression;
        }
    }
}
