using System.Collections;

namespace MyStack
{
    public class MyStack
    {
        public static readonly int maxsize = 10;
        public int topstack;
        public int[] arrayint = new int[maxsize];

        public MyStack()
        {
            topstack = 0;
        }

        public bool Add(int add)
        {
            if (topstack >= maxsize)
            {
                Console.WriteLine("Stack Overfllow");
                return false;
            }
            else
            {
                arrayint[++topstack] = add;
                return true;
            }
        }

        public void SeeLastInter()
        {
            if (topstack < 0)
            {
                Console.WriteLine("Stack is null");
            }
            Console.WriteLine($"Top element is  {topstack}");
        }

        public int Delete()
        {
            if (topstack < 0)
            {
                Console.WriteLine("Stack is null");
            }

            int value = arrayint[topstack--];
            return value;
        }

        public void PrintStack()
        {
            if (topstack < 0)
            {
                Console.WriteLine("Stack is null");
            }
            Console.WriteLine("Your stack is ");
            for (int i = topstack; i > 0; i--)
            {
                Console.WriteLine(arrayint[i]);
            }
        }
    }
}