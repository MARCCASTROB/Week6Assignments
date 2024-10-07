using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace assignment6
{
    public class Account
    {
       
        private string _accountHolder;
        private double _amount;

        public Account(string accountHolder)
        {
            _accountHolder = accountHolder;
            _amount = 0;  
        }

      
        public void Deposit(double amount)
        {
            _amount += amount;
            LogTransaction($"Deposited {amount} into your account.");

            Console.WriteLine("Deposit successfully completed.");
        }

      
        private void LogTransaction(string message)
        {
            Console.WriteLine($"Transaction Log: {message}");
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {_accountHolder}");
            Console.WriteLine($"Current Balance: {_amount}");  
        }
    }

}
