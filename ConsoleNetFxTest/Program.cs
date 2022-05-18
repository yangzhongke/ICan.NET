﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleNetFxTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 3, 1, 4, 1, 5, 9 };
            foreach (var w in items.Window(2))
            {
                WriteLine(w);
            }
            Console.WriteLine("**********");
            foreach (var w in items.Window(5))
            {
                WriteLine(w);
            }
            Console.WriteLine("**********");
            foreach (var w in items.Window(6))
            {
                WriteLine(w);
            }
            Console.WriteLine("**********");

            List<int> items2 = new List<int> { 3, 1, 4, 1, 5, 9 };
            foreach (var w in items2.Window(2))
            {
                WriteLine(w);
            }
            Console.WriteLine("**********");
            foreach (var w in items2.Window(5))
            {
                WriteLine(w);
            }
            Console.WriteLine("**********");
            foreach (var w in items2.Window(6))
            {
                WriteLine(w);
            }

            Console.WriteLine("**********");

            IEnumerable<int> items3 = new List<int> { 3, 1, 4, 1, 5, 9 };
            foreach (var w in items3.Window(2))
            {
                WriteLine(w);
            }
            Console.WriteLine("**********");
            foreach (var w in items3.Window(5))
            {
                WriteLine(w);
            }
            Console.WriteLine("**********");
            foreach (var w in items3.Window(6))
            {
                WriteLine(w);
            }
            Console.ReadKey();
        }

        static void WriteLine<T>(T[] items)
        {
            foreach (var e in items)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
        }
    }
}