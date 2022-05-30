using System.Collections.Generic;
using 小算盤02.Tools.Operators;

namespace 小算盤02.Tools
{
    /// <summary>
    /// 計算功能
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// index 資訊
        /// </summary>
        public enum Priority
        {
            MaxPriority = 2
        }

        /// <summary>
        /// 儲存空間
        /// </summary>
        private InputStorage Storage;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="storage">儲存空間</param>
        public Calculator(InputStorage storage)
        {
            this.Storage = storage;
        }

        /// <summary>
        /// 運算
        /// </summary>
        public void Calculate()
        {
            LinkedList<decimal> dealingNumbers;
            LinkedList<IOperater> dealingOperator;
            for (int i = (int)Priority.MaxPriority; i > 0; i--)
            {
                dealingNumbers = new LinkedList<decimal>();
                dealingOperator = new LinkedList<IOperater>();
                int count = Storage.Operators.Count;
                while (count != 0)
                {
                    CalculateUnit calculateUnit = GetCalculateUnit();

                    if (calculateUnit.Operater.Priority.Equals(i))
                    {
                        decimal result = calculateUnit.Operater.Calculate(calculateUnit.FrontNumber, calculateUnit.LaterNumber);
                        Storage.Numbers.AddFirst(result);
                    }
                    else
                    {
                        dealingNumbers.AddLast(calculateUnit.FrontNumber);
                        dealingOperator.AddLast(calculateUnit.Operater);
                        Storage.Numbers.AddFirst(calculateUnit.LaterNumber);
                    }
                    count--;
                }
                dealingNumbers.AddLast(Storage.Numbers.First.Value);
                Storage.Numbers = new LinkedList<decimal>(dealingNumbers);
                Storage.Operators = new LinkedList<IOperater>(dealingOperator);
            }
            Storage.Output.Clear();
            Storage.Output.AddRange(new string(Storage.Numbers.First.Value.ToString().ToCharArray()));
        }

        /// <summary>
        /// 取得運算單位
        /// </summary>
        /// <returns>回傳運算單位</returns>
        public CalculateUnit GetCalculateUnit()
        {
            decimal frontNumber = Storage.Numbers.First.Value;
            Storage.Numbers.RemoveFirst();
            decimal laterNumber = Storage.Numbers.First.Value;
            Storage.Numbers.RemoveFirst();
            IOperater currentOperator = Storage.Operators.First.Value;
            Storage.Operators.RemoveFirst();
            CalculateUnit calculateUnit = new CalculateUnit(frontNumber, laterNumber, currentOperator);
            return calculateUnit;
        }
    }
}
