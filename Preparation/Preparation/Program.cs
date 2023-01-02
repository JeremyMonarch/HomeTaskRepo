using System;

namespace Preperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print();
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[m, n];
            string direction = "right";

            int x = 0; //row
            int y = 0; //col

            int matrixSize = m * n;

            for (int i = 1; i <= matrixSize; i++)
            {
                if ((direction == "right") && (y > n - 1 || x > m - 1 || matrix[x, y] != 0))
                {
                    direction = "down";
                    y--;
                    x++;
                }
                if ((direction == "down") && (x > m - 1 || y > n - 1 || matrix[x, y] != 0))
                {
                    direction = "left";
                    x--;
                    y--;
                }
                if ((direction == "left") && (y < 0 || x < 0 || matrix[x, y] != 0))
                {
                    direction = "up";
                    y++;
                    x--;
                }
                if ((direction == "up") && (x < 0 || y < 0 || matrix[x, y] != 0))
                {
                    direction = "right";
                    x++;
                    y++;
                }
                matrix[x, y] = i;
                if (direction == "right")
                {
                    y++;
                }
                if (direction == "down")
                {
                    x++;
                }
                if (direction == "left")
                {
                    y--;
                }
                if (direction == "up")
                {
                    x--;
                }
            }
            for (int r = 0; r < n && r < m; r++)
            {
                for (int c = 0; c < n && c < m; c++)
                {
                    Console.Write("{0, 3}", matrix[r, c]);
                }
                Console.WriteLine();
            }

        }

        static void Print()
        {
            Console.WriteLine("Array: ");
            Console.Write("Entry array size: ");
        }
    }
}
