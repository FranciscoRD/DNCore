using System;
class Increment
{
    static void Main()
    {
        int c = 5;
        Console.WriteLine($"c before postincrement : {c}");
        Console.WriteLine($"       postincrement c : {c++}");
        Console.WriteLine($" c after postincrement : {c}");

        Console.WriteLine();

        c=5;
        Console.WriteLine($" c before preincrement : {c}");
        Console.WriteLine($"        preincrement c : {++c}");
        Console.WriteLine($"  c after preincrement : {c}");
    }
}