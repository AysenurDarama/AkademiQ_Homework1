using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public int Balance { get; set; }

        public BankAccount(string accountHolder, int balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public virtual void CalculateInterest(){}

        public void Info()
        {
            Console.WriteLine($"Account Holder: {AccountHolder},Balance {Balance}");
        }

    }
}
