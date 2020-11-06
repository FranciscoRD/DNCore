using System;

namespace Cap13.ExceptionProperties
{
    public class Properties
    {
        public static void Principal()
        {
            try
            {
                Method1();
            }
            catch (Exception exceptionParameter)
            {
                Console.WriteLine("exceptionParameter.ToString: \n" +
                    exceptionParameter);
                Console.WriteLine("\nexceptionParameter.Message: \n" +
                    exceptionParameter.Message);
                Console.WriteLine("\nexceptionParameter.StackTarce: \n" +
                    exceptionParameter.StackTrace);
                Console.WriteLine("\nexceptionParameter.InnerException: \n" +
                    exceptionParameter.InnerException);
            }
        }
        static void Method1()
        {
            Method2();
        }
        static void Method2()
        {
            Method3();
        }
        static void Method3()
        {
            try
            {
                int.Parse("Not an Integer");
            }
            catch (FormatException formatExceptionParameter)
            {
                throw new Exception("Exception occured in Method3",
                    formatExceptionParameter);
            }
        }
    }
}