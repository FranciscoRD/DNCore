using System;

namespace Cap18.ClaseGenerica
{
    public class EmptyStackException :Exception
    {
        public EmptyStackException()
        {

        }
        public EmptyStackException(string exception) : base(exception)
        {

        }
        public EmptyStackException(string exception, Exception inner)
            : base(exception,inner)
        {

        }
    }
}