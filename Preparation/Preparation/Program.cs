using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Preperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print();
            
            string input = Console.ReadLine();
            int m = 0;
            int n = 0;

            while(!IsValidInput(input, out m, out n))
            {
                Console.WriteLine("Wrong input!");
                input = Console.ReadLine();
            }
            int[,] matrix = new int[m, n];
            string direction = "right";
            int matrixSize = m * n;

            int x = 0; //row
            int y = 0; //col

            for(int i = 1; i <= matrixSize; i++)
            {
                if(direction == "right" && (y > n - 1 || x > m - 1 || matrix[x, y] != 0))
                {
                    direction = "down";
                    y--;
                    x++;
                }
                if(direction == "down" && (x > m - 1 || y > n - 1 || matrix[x, y] != 0))
                {
                    direction = "left";
                    x--;
                    y--;
                }
                if(direction == "left" && (y < 0 || x < 0 || matrix[x, y] != 0))
                {
                    direction = "up";
                    y++;
                    x--;
                }
                if(direction == "up" && (x < 0 || y < 0 || matrix[x, y] != 0))
                {
                    direction = "right";
                    x++;
                    y++;
                }
                
                matrix[x, y] = i;
               
                if(direction == "right")
                {
                    y++;
                }
                if(direction == "down")
                {
                    x++;
                }
                if(direction == "left")
                {
                    y--;
                }
                if(direction == "up")
                {
                    x--;
                }
            }
            for(int i = 0; i < n + (m -  n) & i < m; i++) //x
            {
                for(int j = 0; j < n & j < m + (n - m); j++) //y
                {
                    
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Print()
        {
            Console.WriteLine("Spiral array: ");
            Console.Write("\nInput two numbers (one by one with the space. E.g.: (5 5)) for create spiral array: ");
        }

        static bool IsValidInput(string input, out int m, out int n)
        {
            n = 0;
            m = 0;
            if(string.IsNullOrEmpty(input))
            {
                return false;
            }
            var split = input.Split(' ');
            return int.TryParse(split[0], out m) && int.TryParse(split[1], out n);
        }
    }
}
