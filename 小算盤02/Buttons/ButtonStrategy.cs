namespace 小算盤02.Buttons
{
    /// <summary>
    /// 按鈕策略模式
    /// </summary>
    public class ButtonStrategy
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="storage">儲存空間</param>
        public ButtonStrategy(InputStorage storage)
        {
            this.InputStorage = storage;
        }

        /// <summary>
        /// 帶入的儲存空間
        /// </summary>
        private InputStorage InputStorage;

        /// <summary>
        /// 特定的按鈕
        /// </summary>
        private Button Button;

        /// <summary>
        /// 取得 Output
        /// </summary>
        /// <returns>回傳 Output</returns>
        public string GetOutput()
        {
            return Button.GetOutput();
        }

        /// <summary>
        /// 取得算式
        /// </summary>
        /// <returns>回傳算式</returns>
        public string GetExpression()
        {
            return Button.GetExpression();
        }

        /// <summary>
        /// 簡單工廠模式
        /// </summary>
        /// <param name="buttonText">按鈕名稱</param>
        /// <param name="buttonName">按鈕類別</param>
        public void SetStrategy(string buttonText, string buttonName)
        {
            switch (buttonName)
            {
                case "ButtonAddition":
                    this.Button = new ButtonAddition(InputStorage);
                    break;
                case "ButtonSubtraction":
                    this.Button = new ButtonSubtraction(InputStorage);
                    break;
                case "ButtonMultiplication":
                    this.Button = new ButtonMultiplication(InputStorage);
                    break;
                case "ButtonDivision":
                    this.Button = new ButtonDivision(InputStorage);
                    break;
                case "ButtonSquareRoot":
                    this.Button = new ButtonSquareRoot(InputStorage);
                    break;
                case "ButtonEqualTo":
                    this.Button = new ButtonEqualTo(InputStorage);
                    break;
                case "ButtonNumbers":
                    this.Button = new ButtonNumbers(buttonText, InputStorage);
                    break;
                case "ButtonDot":
                    this.Button = new ButtonDot(InputStorage);
                    break;
                case "ButtonNegate":
                    this.Button = new ButtonNegate(InputStorage);
                    break;
                case "ButtonBack":
                    this.Button = new ButtonBack(InputStorage);
                    break;
                case "ButtonC":
                    this.Button = new ButtonC(InputStorage);
                    break;
                case "ButtonCE":
                    this.Button = new ButtonCE(InputStorage);
                    break;
            }
        }
    }
}
