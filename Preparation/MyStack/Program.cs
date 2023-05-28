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

            MyStack<int> arrayinteger = new MyStack<int>();
            
            arrayinteger.ItemAdd += HandleItemAdd;
            arrayinteger.ItemDelete += HandleItemDelete;

            arrayinteger.Push(1);
            arrayinteger.Push(2);
            arrayinteger.Push(3);
            arrayinteger.Push(4);
            arrayinteger.Push(5);
            arrayinteger.Push(6);
            foreach (var item in arrayinteger.Reverse())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Item has been deleted is: {0}", arrayinteger.Peek());
            arrayinteger.Pop();
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Now last element is: {arrayinteger.Peek()}");
            foreach (var item in arrayinteger.Reverse())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");
            foreach (var i in arrayinteger)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------");
        }

        private static void HandleItemAdd(int item, bool added)
        {
            Console.WriteLine("EVENT: Element is added: " + item);
        }
        private static void HandleItemDelete(int item, bool delete)
        {
            Console.WriteLine("EVENT: Element is deleted: " + item);
        }
    }
}