using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < inputNumber; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < input.Length; j++)
                {
                    elements.Add(input[j]);
                }
            }
            Console.Write(string.Join(" ", elements));
            //foreach (var element in elements)
            //{
            //    Console.Write (element + " ");
            //}
        }
    }
}
