using System;
using System.Linq;

namespace Cap09.QueryingArray
{
    public class LINQWithSimpleTypeArray
    {
        public static void Principal()
        {
            var values = new[] {2,9,5,0,3,7,1,4,8,5};

            Console.Write("Original array: ");
            foreach (var element in values)
            {
                Console.Write($" {element}");
            }

            var filtered =
                from value in values
                where value > 4
                select value;

            Console.Write("\nArray values greater than 4:");
            foreach (var element in filtered)
            {
                Console.Write($" {element}");
            }

            var sortered =
                from value in values
                orderby value
                select value;
            
            Console.Write("\nOriginal array, sorted:");
            foreach (var element in sortered)
            {
                Console.Write($" {element}");
            }

            var sortedFilteredResults =
                from value in filtered
                orderby value descending
                select value;

            Console.Write("\nValues greater than 4, descending order (two queries):");
            foreach (var element in sortedFilteredResults)
            {
                Console.Write($" {element}");
            }

            var sorteredAndFiltered =
                from value in values
                where value > 4
                orderby value descending
                select value;

            Console.Write("\nValues greather than 4, descending order (one query):");
            foreach (var element in sorteredAndFiltered)
            {
                Console.Write($" {element}");
            }

            Console.WriteLine();
        }
    }
}