using System;
using System.Threading;

namespace Sand_Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print();

            SandCLock();
        }
        static void SandCLock()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a size matrix: ");
            int x = int.Parse(Console.ReadLine());

            int[,] SandMatrix = new int[x,x];

            int smsize = x*x;

            for (int i = 0; i < (x + 1) / 2; i++)
            {
                for (int j = i; j < x - i; j++)
                {
                    SandMatrix[i, j] = a;
                    SandMatrix[x - i - 1, j] = a;
                }
            }
            for (int r = 0; r < x && r < x; r++)
            {
                for (int c = 0; c < x && c < x; c++)
                {
                    Console.Write("{0, 3}", SandMatrix[r, c]);
                }
                Console.WriteLine();
            }
        }

            static void Print()
            {
                Console.WriteLine("Sand Clock");
                Thread.Sleep(1500);
                Console.WriteLine("Stat Programm");
                Thread.Sleep(1000);
                Console.WriteLine("Enter value: ");
            }
    }
}
