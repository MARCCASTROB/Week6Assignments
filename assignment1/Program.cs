using System.Security.Cryptography.X509Certificates;

namespace assignment1
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
            Console.Write(" Enter your name: ");
            string inputName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int inputAge = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(inputName, inputAge);

            Console.WriteLine($"Name: {inputName }");
            Console.WriteLine($"Age: {inputAge}");
        }
    }
}
