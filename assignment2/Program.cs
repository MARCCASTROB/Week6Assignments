using System.IO.Pipes;

namespace assignment2
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
            Console.WriteLine("Enter a book Title: ");
            string inputTitle = Console.ReadLine();

            Console.WriteLine("Enter an Author name: ");
            string inputAuthor = Console.ReadLine();    

            Book book = new Book (inputTitle, inputAuthor);

            Console.WriteLine("Book Details:");
            Console.WriteLine($"Title: {book.Author}");
            Console.WriteLine($"Author: {book.Title}");

        }
    }
}
