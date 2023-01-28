using System;
using System.Linq;

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
            var split = input.Split(' ');

            while(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong insert! Please, try again");
                input = Console.ReadLine();
            }

            while(!int.TryParse(split[0], out m))
            {
                Console.WriteLine("Wrong insert! Please, try again");
                input = Console.ReadLine();
                split = input.Split(' ');
            }

            while(!int.TryParse(split[1], out n))
            {
                Console.WriteLine("Wrong insert! Please, try again");
                input = Console.ReadLine();
                split = input.Split(' ');
            }

            int[,] matrix = new int[m, n];
            string direction = "right";
            int matrixSize = m * n;

            int x = 0; //row
            int y = 0; //col

            for(int i = 1; i <= matrixSize; i++)
            {
                if((direction == "right") && (y > n - 1 || x > m - 1 || matrix[x, y] != 0))
                {
                    direction = "down";
                    y--;
                    x++;
                }
                if((direction == "down") && (x > m - 1 || y > n - 1 || matrix[x, y] != 0))
                {
                    direction = "left";
                    x--;
                    y--;
                }
                if((direction == "left") && (y < 0 || x < 0 || matrix[x, y] != 0))
                {
                    direction = "up";
                    y++;
                    x--;
                }
                if((direction == "up") && (x < 0 || y < 0 || matrix[x, y] != 0))
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
                    
                    Console.Write("{0, 3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Print()
        {
            Console.WriteLine("Spiral array: ");
            Console.Write("\nInput two numbers (one by one with the space. E.g.: (5 5)) for create spiral array: ");
        }
    }
}
