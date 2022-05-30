using 小算盤02.Tools.Operators;

namespace 小算盤02.Buttons
{
    /// <summary>
    /// 減法
    /// </summary>
    public class ButtonSubtraction : Button
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="storage">儲存空間</param>
        public ButtonSubtraction(InputStorage storage)
        {
            storage.Expression += string.Concat(new string(storage.Output.ToArray()), '－');

            storage.AddToNumbers();
            storage.Operators.AddLast(new Subtraction());

            Output = new string(storage.Output.ToArray());
            Expression = storage.Expression;
        }
    }
}
