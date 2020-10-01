using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int firstSetSize = sizes[0];
            int secondSetSize = sizes[1];
            HashSet<string> firstSet = new HashSet<string>();
            HashSet<string> secondSet = new HashSet<string>();
            HashSet<string> result = new HashSet<string>();
            for (int i = 0; i < firstSetSize + secondSetSize; i++)
            {
                string currNumber = Console.ReadLine();
                if (i<=firstSetSize)
                {
                    firstSet.Add(currNumber);
                }
                else
                {
                    secondSet.Add(currNumber);
                }
            }
            if (firstSetSize>secondSetSize)
            {
                foreach (var number in firstSet)
                {
                    string curr = number;
                    foreach (var num in secondSet)
                    {
                        if (num==curr)
                        {
                            result.Add(num);
                        }
                    }
                }
                Console.Write(string.Join(" ", result));
            }
            else if (secondSetSize > firstSetSize)
            {
                foreach (var number in secondSet)
                {
                    string curr = number;
                    foreach (var num in firstSet)
                    {
                        if (num == curr)
                        {
                            result.Add(num);
                        }
                    }
                }
                Console.Write(string.Join(" ", result));
            }
        }
    }
}
