namespace assignment7
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
            Console.WriteLine("ENter a product name: ");
            string nameProduct = Console.ReadLine();

            Console.WriteLine("Enter a product price: ");
            double priceProduct = Convert.ToDouble(Console.ReadLine());

            Product product = new Product(nameProduct, priceProduct);

            Console.WriteLine("Product Details: ");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Price: {product.Price}");
        }
    }
}
