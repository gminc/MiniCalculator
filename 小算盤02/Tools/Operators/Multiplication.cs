namespace 小算盤02.Tools.Operators
{
    /// <summary>
    /// 乘法
    /// </summary>
    public class Multiplication : IOperater
    {
        /// <summary>
        /// 運算順序
        /// </summary>
        private readonly int CalculatePriority = 2;

        /// <summary>
        /// 取得運算順序
        /// </summary>
        public int Priority
        {
            get
            {
                return CalculatePriority;
            }
        }

        /// <summary>
        /// 計算
        /// </summary>
        /// <param name="frontNum">前面的數字</param>
        /// <param name="laterNum">後面的數字</param>
        /// <returns>計算結果</returns>
        public decimal Calculate(decimal frontNum, decimal laterNum)
        {
            return frontNum * laterNum;
        }
    }
}
