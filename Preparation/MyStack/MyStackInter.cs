using System;
using System.Collections;
using System.Collections.Generic;

namespace MyStack
{
    public class MyStack<T> : IEnumerable<T>
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
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return _underliyngArray[_count];
        }

        public bool IsEmpty()
        {
            return _count < 0;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return _underliyngArray[_count--];
        }

        public void PrintStack()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            Console.WriteLine("Your stack is");
            for (int i = _count; i >= 0; i--)
            {
                Console.WriteLine(_underliyngArray[i]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _underliyngArray.Length; i++)
            {
                yield return _underliyngArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}