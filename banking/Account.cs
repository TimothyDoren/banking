using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    internal class Account
    {
        public string Id { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; } = string.Empty;

        public bool Deposit(decimal Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Amount cannot be negative or zero");
                return false;
            }
            Balance += Amount; // Balance = balance + amount
            return true;
        }
        public bool  Withdraw(decimal Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Invalid Transcation. The withdrawel cannot be negative.");
                return false;
            }
            if (Amount > Balance)
            {
                Console.WriteLine("Insufficient Funds. Amount withdrawn cannot be greater than Balance");
                return false;
            }
                Balance -= Amount;
            return true; 
        }
        public bool Transfer(decimal Amount, Account ToAccount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Invalid Transcation. The withdrawel cannot be negative.");
                return false;
            }
            if (Withdraw(Amount))
            {
                ToAccount.Deposit(Amount);
                return true;
            }
            return false;
        }

    }
}
