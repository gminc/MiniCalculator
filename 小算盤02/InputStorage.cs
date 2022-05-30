using System.Collections.Generic;
using System.Linq;
using 小算盤02.Tools.Operators;

namespace 小算盤02
{
    /// <summary>
    /// 算式和數字的儲存空間
    /// </summary>
    public class InputStorage
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public InputStorage()
        {
            Output = new List<char>() { '0' };
            Expression = string.Empty;
            Numbers = new LinkedList<decimal>();
            Operators = new LinkedList<IOperater>();
        }

        /// <summary>
        /// 輸出的數字欄位
        /// </summary>
        public List<char> Output { get; set; }

        /// <summary>
        /// 輸出的算式欄位
        /// </summary>
        public string Expression { get; set; }

        /// <summary>
        /// 儲存算式數字部分
        /// </summary>
        public LinkedList<decimal> Numbers { get; set; }

        /// <summary>
        /// 儲存算式運算子部分
        /// </summary>
        public LinkedList<IOperater> Operators { get; set; }

        /// <summary>
        /// 重設計算空間
        /// </summary>
        public void Reset()
        {
            OutputReset();
            Expression = string.Empty;
            Numbers.Clear();
            Operators.Clear();
        }

        /// <summary>
        /// 重設輸出欄位
        /// </summary>
        public void OutputReset()
        {
            Output.Clear();
            Output.Add('0');
        }

        /// <summary>
        /// 將數字存入 Output 裡
        /// </summary>
        /// <param name="number">數字</param>
        public void SaveToOutput(char number)
        {
            if (Output.Count.Equals(0))
            {
                Reset();
                Output.Clear();
            }
            else if (Output.First().Equals('0') && Output.Count.Equals(1))
            {
                Output.Clear();
            }
            Output.Add(number);
        }

        /// <summary>
        /// 把數字加進數字 linkedlist 中
        /// </summary>
        public void AddToNumbers()
        {
            if (!Output.Count.Equals(0))
            {
                decimal.TryParse(new string(Output.ToArray()), out decimal result);
                Numbers.AddLast(result);                
            }
            OutputReset();
        }
    }
}
