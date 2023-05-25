using System;
using System.Collections;
using System.Collections.Generic;

namespace MyStack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private int _count = -1;
        private T[] _underliyngArray = new T[5];

        public event Action<int, bool> ItemAddOrDelete;

        public void Push(T add)
        {
            if (_count == _underliyngArray.Length - 1)
            {
                Array.Resize(ref _underliyngArray, _underliyngArray.Length * 2);
            }
            _count++;
            _underliyngArray[_count] = add;

            ItemAddOrDelete?.Invoke(_count + 1, true);
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
            
            ItemAddOrDelete?.Invoke(_count + 1, false);

            return _underliyngArray[_count--];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyStackEnumerator<T>(_underliyngArray, _count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class MyStackEnumerator<T> : IEnumerator<T>
    {
        private T[] _underlineArray;
        private int _index;
        private int _count;

        public MyStackEnumerator(T[] underlineArray, int count)
        {
            _underlineArray = underlineArray;
            _count = count;
            Reset();
        }

        public T Current => _underlineArray[_index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public void Reset()
        {
            _index = -1;
        }

        public bool MoveNext()
        {
            return _index++ < _count;
        }
    }
}