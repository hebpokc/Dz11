using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tumakov_Lab13
{
    public enum BankAccountType
    {
        current,
        savings
    }
    class BankAccount
    {
        private int accountNumber;
        private double balance;
        private BankAccountType bat;
        private string holder;
        private static int magnifier = 1;
        private List<BankTransaction> transactions = new List<BankTransaction>();
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
        }
        public BankAccountType Bat
        {
            get
            {
                return bat;
            }
        }
        public string Holder
        {
            get
            {
                return holder;
            }
            set
            {
                holder = value;
            }
        }
        public List<BankTransaction> Transactions
        {
            get
            {
                return transactions;
            }
        }
        public BankTransaction this[int index]
        {
            get
            {
                if (index >= 0 && index < transactions.Count)
                    return transactions[index];
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public BankAccount()
        {
            accountNumber = magnifier;
            IncreaseNumber();
        }
        public BankAccount(double balance)
        {
            accountNumber = magnifier;
            IncreaseNumber();
            this.balance = balance;
            this.bat = BankAccountType.current;
        }
        public BankAccount(BankAccountType bat)
        {
            accountNumber = magnifier;
            IncreaseNumber();
            this.balance = 0;
            this.bat = bat;
        }
        public BankAccount(string holder, double balance, BankAccountType bat)
        {
            this.holder = holder;
            accountNumber = magnifier;
            IncreaseNumber();
            this.balance = balance;
            this.bat = bat;
        }
        private void IncreaseNumber()
        {
            magnifier++;
        }
        public void AddBalance(double money)
        {
            if (money > 0)
            {
                balance += money;
                BankTransaction transaction = new BankTransaction(money);
                transactions.Add(transaction);
            }
            else
            {
                Console.WriteLine("\nСумма должна быть положительной");
            }

        }
        public void RemoveBalance(double money)
        {

            if (balance < money)
            {
                Console.WriteLine("\nНедостаточно денег на счете");
            }
            else
            {
                balance -= money;
                BankTransaction transaction = new BankTransaction(-money);
                transactions.Add(transaction);
            }
        }
        public void Transfer(BankAccount ba, double money)
        {
            if (money < 0)
            {
                Console.WriteLine("\nСумма не может быть отрицательной");
            }
            else
            {
                if (ba.balance < money)
                {
                    Console.WriteLine("\nНедостаточно денег на счете");
                }
                else
                {
                    balance += money;
                    ba.balance -= money;
                    BankTransaction transaction = new BankTransaction(money);
                    transactions.Add(transaction);
                    Console.WriteLine($"\nПереведено {money} на счет");
                }
            }
        }
        public override string ToString()
        {
            return $"\nНомер счета: {accountNumber}\nБаланс: {balance}\nТип: {bat}";
        }
        public void Dispose()
        {
            foreach (var trans in transactions)
            {
                File.AppendAllText("transactions.txt", trans.ToString() + "\n");
            }
            GC.SuppressFinalize(this);
        }
        public override bool Equals(object obj)
        {
            BankAccount ba = obj as BankAccount;
            if (ba == null)
                return false;
            else
                return this.AccountNumber == ba.AccountNumber && this.Balance == ba.Balance && this.Bat == ba.Bat;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
