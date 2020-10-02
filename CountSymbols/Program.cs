using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbolsCounter = new SortedDictionary<char, int>();
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char currSimbol = text[i];
                if (!symbolsCounter.ContainsKey(currSimbol))
                {
                    symbolsCounter.Add(currSimbol, 0);
                }
                symbolsCounter[currSimbol] += 1;
            }
            foreach (var symbol in symbolsCounter)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
