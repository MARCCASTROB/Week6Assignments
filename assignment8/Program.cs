namespace assignment8
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
            Console.WriteLine("Enter your Account Number: ");
            int accNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your initial balance: ");
            decimal initialBalance = Convert.ToDecimal(Console.ReadLine());

            BankAcount bankAccount = new BankAcount(accNum, initialBalance);

            Console.WriteLine("Enter a deposit amount: ");
           decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

            bankAccount.Deposit(depositAmount);

            Console.WriteLine("Enter a withdrawal amount: ");
            decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());

            bankAccount.Withdraw(withdrawalAmount);
        }
    }
}
