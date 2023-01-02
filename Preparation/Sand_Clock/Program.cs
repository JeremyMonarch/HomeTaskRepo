using System;

namespace Sand_Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print();
            string x = Console.ReadLine();
            string y = Console.ReadLine();

            
        }

        static void Print()
        {
            Console.WriteLine("Sand Clock");
            TimeSpan.FromSeconds(10);
            Console.WriteLine("Enter value: ");
        }
    }
}
