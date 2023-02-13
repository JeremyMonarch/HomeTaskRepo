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
            arrayinteger.PrintStack();
            arrayinteger.SeeLastInter();
            Console.WriteLine("-------------------");
            Console.WriteLine("Item has been deleted is: {0}", arrayinteger.Delete());
            arrayinteger.SeeLastInter();
            arrayinteger.PrintStack();


            Console.WriteLine("\n/---------------------/");

            Stack<int> egstack = new Stack<int>();
            egstack.Push(1);
            egstack.Push(2);
            egstack.Push(3);
            egstack.Push(4);
            egstack.Push(5);
            PrintStack(egstack);
            Console.WriteLine("Delete item in stack is: {0}", egstack.Pop());
            Console.WriteLine("Top item is stack is: {0}", egstack.Peek());
            PrintStack(egstack);

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