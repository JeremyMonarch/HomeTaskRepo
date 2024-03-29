using MyStack;
using System;
using System.Data;
using System.Linq;
using Xunit;

namespace Preperation.Tests
{
    public class MyStackInterTest
    {
        [Fact]
        public void Push_AddsOneElementToTheCollection()
        {
            MyStack<int> myStack = new MyStack<int>();

            myStack.Push(1);

            Assert.Single(myStack);
        }
        [Fact]
        public void Push_IncreasesCountByOne()
        {
            MyStack<int> myStack = new MyStack<int>();

            myStack.Push(1);

            int countBeforePush = myStack.Count();
            myStack.Push(2);
            int countAfterPush = myStack.Count();

            Assert.Equal(countBeforePush + 1, countAfterPush);
        }
        [Fact]
        public void Peek_ReturnsLastPushedElement()
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(20);

            int result = myStack.Peek();

            Assert.Equal(20, result);
        }
        [Fact]
        public void Peek_ThrowsInvalidOperationException_WhenStackIsEmpty()
        {
            MyStack<int> myStack = new MyStack<int>();

            Assert.Throws<InvalidOperationException>(() => myStack.Peek());
        }
        [Fact]
        public void Peek_DoesNotChangeCount()
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(2);

            int countBeforePeek = myStack.Count();
            myStack.Peek();
            int countAfterPeek = myStack.Count();

            Assert.Equal(countBeforePeek, countAfterPeek);
        }
        [Fact]
        public void Pop_ReturnsLastPushedElement()
        {
            MyStack<int> myStack = new MyStack<int>();

            myStack.Push(1);
            myStack.Push(2);

            int result = myStack.Pop();

            Assert.Equal(2, result);
        }
        [Fact]
        public void Pop_DecreasesCountByOneElement()
        {
            MyStack<int> myStack = new MyStack<int>();

            myStack.Push(1);
            myStack.Push(2);

            int countBeforePop = myStack.Count();
            myStack.Pop();
            int countAfterPop = myStack.Count();

            Assert.Equal(countBeforePop - 1, countAfterPop);
        }
        [Fact]
        public void Pop_ThrowsInvalidOperationException_WhenStackIsEmpty()
        {
            MyStack<int> myStack = new MyStack<int>();

            Assert.Throws<InvalidOperationException>(() => myStack.Pop());
        }
    }
}