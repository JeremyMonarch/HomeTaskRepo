using System;

namespace MyStack
{
    public static class StackExtensionMethods
    {
        public static void ForEach<T>(this MyStack<T> stack, Action<T> action)
        {
            while(!stack.IsEmpty())
            {
                action(stack.Pop());
            }
        }
    }
}
