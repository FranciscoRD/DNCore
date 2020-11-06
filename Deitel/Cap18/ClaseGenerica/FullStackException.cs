using System;

namespace Cap18.ClaseGenerica
{
    public class FullStackException : Exception
    {
        public FullStackException():base("Stack is Full")
        {

        }
        public FullStackException(string exception) : base(exception)
        {

        }
        public FullStackException(string exception, Exception inner)
            :base(exception,inner)
        {

        }
    }
}