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
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Assert.Equal(4, myStack.Count());
            Assert.Equal(4, myStack.Last());
        }
        [Fact]
        public void Peek_ReturnsLastPushedElementsInTheCollectionTest()
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(20);
            myStack.Push(30);

            int result = myStack.Peek();

            Assert.Equal(30, result);
            Assert.Equal(3, myStack.Count());
        }
        [Fact]
        public void Pop_RemoveTopElementInTheCollectionTest()
        {
            MyStack<int> myStack = new MyStack<int>();
            
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            int result = myStack.Pop();

            Assert.Equal(3, result);
            Assert.Equal(2, myStack.Count());
        }
        [Fact]
        public void Pop_TryingRemoveElementInEmptyCollection()
        {
            MyStack<int> myStack = new MyStack<int>();

            myStack.Push(1);

            int result = myStack.Pop();

            Assert.Equal(1, result);
            Assert.Throws<InvalidOperationException>(() => myStack.Pop());
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