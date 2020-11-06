using System;

namespace Cap18.ClaseGenerica
{
    public class StackTest
    {
        private static double[] doubleElements = {1.1,2.2,3.3,4.4,5.5,6.6};
        private static int[] intElements = {1,2,3,4,5,6,7,8,9,10,11};

        private static Stack<double> doubleStack;
        private static Stack<int> intStack;
        public static void Principal()
        {
            doubleStack = new Stack<double>(5);
            intStack = new Stack<int>(10);

            TestPushDouble();
            TestPopDouble();

            TestPushInt();
            TestPopInt();
        }
        static void TestPushDouble()
        {
            try
            {
                Console.WriteLine("\nPushing elements onto doubleStack");
                foreach (var element in doubleElements)
                {
                    Console.Write($"{element:F1} ");
                    doubleStack.Push(element);
                }
            }
            catch (FullStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
        }
        static void TestPopDouble()
        {
            try
            {
                Console.WriteLine("\nPopping elements from doubleStack");
                double popValue;
                while (true)
                {
                    popValue = doubleStack.Pop();
                    Console.Write($"{popValue:F1} ");
                }
            }
            catch (EmptyStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
        }
        static void TestPushInt()
        {
            try
            {
                Console.WriteLine("\nPushing elements onto intStack");
                foreach (var element in intElements)
                {
                    Console.Write($"{element} ");
                    intStack.Push(element);
                }
            }
            catch (FullStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
        }
        static void TestPopInt()
        {
            try
            {
                Console.WriteLine("\nPopping elements from intStack");
                int popValue;
                while (true)
                {
                    popValue = intStack.Pop();
                    Console.Write($"{popValue:F1} ");
                }
            }
            catch (EmptyStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
        }
    }
}