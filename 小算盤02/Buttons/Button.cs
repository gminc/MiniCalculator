namespace 小算盤02.Buttons
{
    /// <summary>
    /// 所有按鈕要繼承的抽象類別
    /// </summary>
    public abstract class Button
    {
        /// <summary>
        /// 要顯示的結果
        /// </summary>
        public string Output { get; set; }

        /// <summary>
        /// 要顯示的算式
        /// </summary>
        protected string Expression { get; set; }

        /// <summary>
        /// 取得輸出資料
        /// </summary>
        /// <returns>輸出的數字</returns>
        public string GetOutput()
        {
            return Output;
        }

        /// <summary>
        /// 取得算式
        /// </summary>
        /// <returns>輸出算式</returns>
        public string GetExpression()
        {
            return Expression;
        }
    }
}
