using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> grades = new Dictionary<double, int>();
            double[] input = Console.ReadLine()
                .Split().Select(double.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                double currNum = input[i];
                if (!grades.ContainsKey(currNum))
                {
                    grades.Add(currNum, 0);
                }
                grades[currNum] += 1;
            }
            foreach (var grade in grades)
            {
                Console.WriteLine($"{grade.Key} - {grade.Value} times");
            }
        }
    }
}
