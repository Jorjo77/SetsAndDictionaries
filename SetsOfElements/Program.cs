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
                if (i < firstSetSize)
                {
                    firstSet.Add(currNumber);
                }
                else
                {
                    secondSet.Add(currNumber);
                }
            }
            foreach (var number in firstSet)
            {
                string curr = number;
                foreach (var num in secondSet)
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
//namespace P09_SimpleTextEditor
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Text;

//    class P09_SimpleTextEditor
//    {
//        static void Main(string[] args)
//        {
//            int operationsCount = int.Parse(Console.ReadLine());

//            StringBuilder text = new StringBuilder();

//            Stack<string> history = new Stack<string>();

//            for (int i = 0; i < operationsCount; i++)
//            {


//                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
//                int command = int.Parse(tokens[0]);

//                switch (command)
//                {
//                    case 1:
//                        text = text.Append(tokens[1]);
//                        history.Push(text.ToString());
//                        break;
//                    case 2:
//                        int eraseCharsCount = int.Parse(tokens[1]);
//                        text = text.Remove(text.Length - eraseCharsCount, eraseCharsCount);
//                        history.Push(text.ToString());
//                        break;
//                    case 3:
//                        int charIndex = int.Parse(tokens[1]) - 1;
//                        Console.WriteLine(text.ToString().ToCharArray()[charIndex]);
//                        break;
//                    case 4:
//                        if (history.Count > 1)
//                        {
//                            history.Pop();
//                            text = text.Clear();
//                            text = text.Append(history.Peek());
//                        }
//                        else if (history.Count == 1)
//                        {
//                            history.Pop();
//                            text = text.Clear();
//                        }
//                        break;
//                }
//            }
//        }
//    }
//}
