using System;
using System.Collections;
using System.Collections.Generic;

namespace MyStack
{
    public sealed class MyStack<T>
    {
        private int _count = -1;
        private T[] _underliyngArray = new T[5];

        public void Push(T add)
        {
            if (_count == _underliyngArray.Length - 1)
            {
                Array.Resize(ref _underliyngArray, _underliyngArray.Length * 2);
            }
            _count++;
            _underliyngArray[_count] = add;
        }

        public T Peek()
        {
            if (_count < 0)
            {
                Console.WriteLine("Stack is null");
            }
            return _underliyngArray[_count];
        }

        public bool IsEmpty()
        {
            return _count < 0;
        }


        public T Pop()
        {
            if (_count < 0)
            {
                Console.WriteLine("Stack is null");
            }
            return _underliyngArray[_count--];
        }

        public void PrintStack()
        {
            if (_count < 0)
            {
                Console.WriteLine("Stack is null");
            }
            Console.WriteLine("Your stack is");
            for (int i = _count; i >= 0; i--)
            {
                Console.WriteLine(_underliyngArray[i]);
            }
        }
        public void ForEach(Action<T> action)
        {
            for (int i = _count; i >= 0; i--)
            {
                action(_underliyngArray[i]);
            }
        }
    }
}