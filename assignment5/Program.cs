namespace assignment5
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
            int originalValue = 10;

            Console.WriteLine("Original Value:" + originalValue);
            ModifyByValue(originalValue);
            Console.WriteLine("Value After ModifyByValue: " + originalValue);
            
            ModifyByReference(ref originalValue);
            Console.WriteLine("Value After ModifyByValue: " + originalValue);
        }

        void ModifyByValue (int value) //technically this only changes the value inside the method, doesn't outside of it 
        {
            value = 20;
        }

        void ModifyByReference (ref int reference) // changes the value by passing it by reference, it basically affects the original value too.
        {
            reference = 20;
        }
    }
}

