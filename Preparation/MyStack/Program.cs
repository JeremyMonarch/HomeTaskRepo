using System;
using System.Collections.Generic;
using System.Linq;

namespace MyStack
{
    public class MyStackMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! You do THIS shiiiiit");

            MyStack arrayinteger = new MyStack();
            arrayinteger.Push(1);
            arrayinteger.Push(2);
            arrayinteger.Push(3);
            arrayinteger.Push(4);
            arrayinteger.Push(5);
            arrayinteger.Push(6);
            arrayinteger.PrintStack();
            arrayinteger.Peek();
            Console.WriteLine("-------------------");
            Console.WriteLine("Item has been deleted is: {0}", arrayinteger.Pop());
            arrayinteger.Peek();
            arrayinteger.PrintStack();
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Last element is: {arrayinteger.arrayint.GetValue(arrayinteger.arrayint.Last())}");
            Console.WriteLine("-------------------");

            foreach (var e in arrayinteger)
            {
                Console.WriteLine(e);
            }
        }
        static void PrintStack(Stack<int> stack)
        {
            foreach (var s in stack)
            {
                Console.WriteLine(s);
            }
        }
    }
}