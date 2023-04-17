using System;

namespace MyStack
{
    public class MyStackMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! You do THIS shiiiiit");

            MyStack<int> arrayinteger = new MyStack<int>();
            arrayinteger.Push(1);
            arrayinteger.Push(2);
            arrayinteger.Push(3); 
            arrayinteger.Push(4);
            arrayinteger.Push(5);
            arrayinteger.Push(6);
            arrayinteger.PrintStack();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Item has been deleted is: {0}", arrayinteger.Peek());
            arrayinteger.Pop();
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Now last element is: {arrayinteger.Peek()}");
            arrayinteger.PrintStack();
            Console.WriteLine("-----------------------------");

            while(!arrayinteger.IsEmpty())
            {
                Console.WriteLine(arrayinteger.Pop());
            }
        }
    }
}   