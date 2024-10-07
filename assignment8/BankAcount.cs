
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    public class BankAcount
    {
        public int AccountNumber { get; set; }
        public decimal InitialBalance { get; private set; }

        public BankAcount(int accountNumber, decimal initialbalance)
        {
            this.AccountNumber = accountNumber;
            this.InitialBalance = initialbalance;
        }

        public void Deposit(decimal amount)
        {
            InitialBalance += amount;
            Console.WriteLine($"Deposited {amount} into your account.");
        }

        public void Withdraw(decimal amount)
        {
            if ( InitialBalance < amount )
            {
                Console.WriteLine("Insuficient funds to do the operation. ");
            }
            else
            {
                InitialBalance -= amount;
                Console.WriteLine($"Withdrawn {amount} from your account. Current balance: {InitialBalance}");
            }
        }
       
    }
}
