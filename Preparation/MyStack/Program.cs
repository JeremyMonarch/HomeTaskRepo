using System;
using System.Collections.Generic;
namespace MyStack
{
    public class MyStackMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! You do THIS shiiiiit");

            MyStack arrayinteger = new MyStack();
            arrayinteger.Add(1);
            arrayinteger.Add(2);
            arrayinteger.Add(3);
            arrayinteger.Add(4);
            arrayinteger.Add(5);
            arrayinteger.Add(6);
            arrayinteger.PrintStack();
            arrayinteger.SeeLastInter();
            Console.WriteLine("-------------------");
            Console.WriteLine("Item has been deleted is: {0}", arrayinteger.Delete());
            arrayinteger.SeeLastInter();
            arrayinteger.PrintStack();
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