using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();
            int studentsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsNumber; i++)
            {
                string[] input = Console.ReadLine().Split();
                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades.Add(studentName, new List<decimal>());
                }
                studentGrades[studentName].Add(grade);
            }
            foreach (var pair in studentGrades)
            {
                var name = pair.Key;
                var studentGrade = pair.Value;
                var average = studentGrade.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrade)
                    Console.Write($"{grade:f2} ");
                Console.WriteLine($"(avg: {average:f2})");
            }
            //втори вариант за печат
            //foreach (var student in studentGrades)
            //{
            //    StringBuilder allGrades = new StringBuilder();
            //    for (int i = 0; i < student.Value.Count; i++)
            //    {
            //        allGrades.Append($"{student.Value[i]:f2} ");
            //    }
            //    Console.WriteLine($"{student.Key} -> {allGrades.ToString()}(avg: {student.Value.Average()})");
            //}
        }
    }
}
