using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int clothesNumber = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < clothesNumber; i++)
            {
                string[] separators = new string[] { " -> ", "," };
                string[] command = Console.ReadLine()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 1; j < command.Length; j++)
                {
                    string color = command[0];
                    string curr = command[j];
                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                    }
                    if (!wardrobe[color].ContainsKey(curr))
                    {
                        wardrobe[color].Add(curr, 1);
                    }
                    else if (wardrobe[color].ContainsKey(curr))
                    {
                        wardrobe[color][curr] += 1;
                    }
                }
            }
            string[] targetCloth = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string targetColor = targetCloth[0];
            string targetItem = targetCloth[1];
            foreach (var cloth in wardrobe)
            {
                Console.WriteLine($"{cloth.Key} clothes:");


                foreach (var item in cloth.Value)
                {
                    string output = $"* {item.Key} - {item.Value}";
                    if (item.Key == targetItem&&cloth.Key == targetColor)
                    {
                        output += " (found!)";
                    }
                    Console.WriteLine(output);
                }
            }
        }
    }
}
