using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            Dictionary<int, int> evenNumbersCounter = new Dictionary<int, int>();
            for (int i = 0; i < inputNumber; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (!evenNumbersCounter.ContainsKey(currNum))
                {
                    evenNumbersCounter.Add(currNum, 0);
                }
                evenNumbersCounter[currNum] += 1;
            }
            foreach (var number in evenNumbersCounter)
            {
                if (number.Value%2==0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
