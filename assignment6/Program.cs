using System.Transactions;

namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.WriteLine("Enter an account holder's name: ");
            string accountHolderName = Console.ReadLine();

            Account account = new Account(accountHolderName);

            Console.WriteLine("Enter a deposit amount: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            account.Deposit(depositAmount);

            account.DisplayAccountInfo();
        }
    }


}

