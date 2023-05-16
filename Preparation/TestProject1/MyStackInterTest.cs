using MyStack;
using Xunit;

namespace Preperation.Tests
{
    public class MyStackInterTest
    {
        [Fact]
        public void PushTest()
        {
            MyStack<int> myStack = new MyStack<int>();

            myStack.Push(1);

            Assert.Equal(1, myStack.Peek());
        }
        [Fact]
        public void PeekTest()
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            int result = myStack.Peek();

            Assert.Equal(3, result);
        }
        [Fact]
        public void PopTest()
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(2);

            int result = myStack.Pop();

            Assert.Equal(2, result);
        }
        [Fact]
        public void IsEmptyTrueTest()
        {
            MyStack<int> myStack = new MyStack<int>();

            bool isEmpty = myStack.IsEmpty();

            Assert.True(isEmpty);
        }
        public void IsEmptyFalseTest()
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(5);

            bool isEmpty = myStack.IsEmpty();

            Assert.False(isEmpty);
        }
    }
}