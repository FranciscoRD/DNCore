using System;
using System.Linq;
using System.Collections.Generic;

namespace Cap09.Colecciones
{
    public class LINQWithListCollection
    {
        public static void Principal()
        {
            // var items = new List<string> {"aQua","Rust","yElLow","rEd"};
            var items = new List<string>();
            items.Add("aQua");
            items.Add("Rust");
            items.Add("yElLow");
            items.Add("rEd");

            Console.Write("items contains:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();

            var startsWithR =
                from item in items
                let uppercasString = item.ToUpper()
                where uppercasString.StartsWith("R")
                orderby uppercasString
                select uppercasString;

            Console.Write("results of query starstWithR:");
            foreach (var item in startsWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            items.Add("rUbY");
            items.Add("SaFfRon");

            Console.Write("items contains:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            Console.Write("results of query startsWithR");
            foreach (var item in startsWithR)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
        }
    }
}