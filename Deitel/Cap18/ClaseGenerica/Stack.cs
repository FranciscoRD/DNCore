using System;

namespace Cap18.ClaseGenerica
{
    public class Stack<T>
    {
        private int top;
        private T[] elements;

        public Stack():this(10)
        {
        }
        public Stack(int stackSize)
        {
            if (stackSize <= 0)
            {
                throw new ArgumentException("Stack size must be positive");
            }
            elements = new T[stackSize];
            top = -1;
        }
        public void Push(T pushValue)
        {
            if (top == elements.Length -1)
            {
                throw new FullStackException($"Stack is full, cannot push  {pushValue}");
            }
            ++top;
            elements[top] = pushValue;
        }
        public T Pop()
        {
            if (top == -1)
            {
                throw new EmptyStackException("Stack is empty, cannot pop");
            }
            --top;
            return elements[top + 1];
        }
    }
}