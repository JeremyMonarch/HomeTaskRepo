using System;
using System.Collections;
using System.Data;

namespace MyStack
{
    public class MyStack : IEnumerable
    {
        public static int count = 1;
        public int topstack;
        public int[] arrayint = new int[count];

        public bool Push(int add)
        {
            if (count >= arrayint.Length)
            {
                Array.Resize(ref arrayint, arrayint.Length + 1);
            }
            count++;
            arrayint[++topstack] = add;
            return true;
        }

        public void Peek()
        {
            if (topstack < 0)
            {
                Console.WriteLine("Stack is null");
            }
            Console.WriteLine($"Top element is  {topstack}");
        }

        public int Pop()
        {
            if (topstack < 0)
            {
                Console.WriteLine("Stack is null");
            }
            int value = arrayint[topstack--];
            Array.Resize(ref arrayint, arrayint.Length - 1);
            return 1;
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

        public IEnumerator GetEnumerator()
        {
            return arrayint.GetEnumerator();
        }
    }
}