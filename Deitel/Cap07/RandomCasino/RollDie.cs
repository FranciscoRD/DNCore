using System;

namespace Cap07.RandomCasino
{
    public class RollDie
    {
        public static void Principal()
        {
            Random randomNumbers = new Random();
            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;
            int valor4 = 0;
            int valor5 = 0;
            int valor6 = 0;

            for (int lanzamiento = 0; lanzamiento < 1000; lanzamiento++)
            {
                int face = randomNumbers.Next(1,7);
                switch (face)
                {
                    case 1 : 
                        ++valor1;
                        break;
                    case 2 : 
                        ++valor2;
                        break;
                    case 3 : 
                        ++valor3;
                        break;
                    case 4 : 
                        ++valor4;
                        break;
                    case 5 : 
                        ++valor5;
                        break;
                    case 6 : 
                        ++valor6;
                        break;
                }
            }
            Console.WriteLine("Face\tFrequency");
            Console.WriteLine($"1:\t{valor1}\n2:\t{valor2}");
            Console.WriteLine($"3:\t{valor3}\n4:\t{valor4}");
            Console.WriteLine($"5:\t{valor5}\n6:\t{valor6}");
        }
    }
}