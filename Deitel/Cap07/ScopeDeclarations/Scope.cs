using System;

namespace Cap07.ScopeDeclarations
{
    public class Scope
    {
        private static int x =1;
        public static void Principal()
        {
            int x= 5;
            Console.WriteLine($"local x in method Principal is {x}");
            UseLocalVariable();
            UseStaticVariable();
            UseLocalVariable();
            UseStaticVariable();
            Console.WriteLine($"\nLocal x in method is {x}");
        }
        static void UseLocalVariable()
        {
            int x = 25;
            Console.WriteLine($"\nlocal x on entering method UseLocalVariable is {x}");
            ++x;
            Console.WriteLine($"local x before exiting method UseLocalVariable is {x}");
        }
        static void UseStaticVariable()
        {
            Console.WriteLine("\nStatic variable x on entering method "+ $"UseStaticVariable is {x}");
            x*=10;
            Console.WriteLine("static variable x before exiting "+$"method UseStatiVariable is {x}");
        }
    }
}