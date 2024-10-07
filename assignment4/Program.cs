namespace assignment4
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
            Console.WriteLine("Enter Radius: ");
            double inputRadius = Convert.ToInt32(Console.ReadLine());

            Circle circle = new Circle(inputRadius);

            circle.DisplayInfo();
        }

    }
}
