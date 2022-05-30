using System;
using System.Windows.Forms;
using 小算盤02.Buttons;

namespace 小算盤02
{
    /// <summary>
    /// 小算盤
    /// </summary>
    public partial class MiniCalculator : Form
    {
        /// <summary>
        /// 初始化組件
        /// </summary>
        public MiniCalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 存取所有按鈕功能和要計算的數字陣列
        /// </summary>
        private readonly InputStorage Storage = new InputStorage();

        /// <summary>
        /// 所有按鈕輸入
        /// </summary>
        /// <param name="sender">輸入之當前物件</param>
        /// <param name="e">事件引數</param>
        private void ButtonClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Button ButtonThatWasPushed = (System.Windows.Forms.Button)sender;

            ButtonStrategy buttonStrategy = new ButtonStrategy(Storage);
            
            buttonStrategy.SetStrategy(ButtonThatWasPushed.Text, ButtonThatWasPushed.Tag.ToString());

            Showcase.Text = buttonStrategy.GetOutput();
            Expression.Text = buttonStrategy.GetExpression();
        }
    }
}
