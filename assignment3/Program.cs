namespace assignment3
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
            Console.WriteLine("Enter a car Make: ");
            string inputMake = Console.ReadLine();

            Console.WriteLine("Enter a car Model: ");
            string inputModel = Console.ReadLine();

            Console.WriteLine("Enter a car Year: ");
            int inputYear = Convert.ToInt32(Console.ReadLine());

            Car car = new Car (inputMake, inputModel, inputYear);

            Console.WriteLine("Car Details: ");
            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");
        }
    }
}
