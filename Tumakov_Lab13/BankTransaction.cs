using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab13
{
    class BankTransaction
    {
        private DateTime transactionTime;
        private double money;
        public DateTime TransactionTime
        {
            get
            {
                return transactionTime;
            }
        }
        public double Money
        {
            get
            {
                return money;
            }
        }
        public BankTransaction(double money)
        {
            transactionTime = DateTime.Now;
            this.money = money;
        }
        public override string ToString()
        {
            if (money < 0)
            {
                return $"{transactionTime} - снятие {Math.Abs(money)}";
            }
            else
            {
                return $"{transactionTime} - пополнение {money}";
            }
        }
    }
}
