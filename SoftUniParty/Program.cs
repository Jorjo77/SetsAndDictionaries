using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            Stack<string> lastCommand = new Stack<string>();
            lastCommand.Push("1");
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="END")
                {
                    break;
                }
                else if (command.Length==8&&lastCommand.Peek()!="PARTY")
                {
                    for (int i = 0; i < command.Length - (command.Length - 1); i++)
                    {
                        char firstSymbol = command[i];
                        if (char.IsDigit(firstSymbol))
                        {
                            vipGuests.Add(command);
                            lastCommand.Push(command);
                        }
                        else
                        {
                            regularGuests.Add(command);
                            lastCommand.Push(command);
                        }
                    }
                }
                else if (command=="PARTY")
                {
                    lastCommand.Push(command);
                }
                else if (command.Length == 8 && lastCommand.Peek() == "PARTY")
                {
                    if (vipGuests.Contains(command))
                    {
                        vipGuests.Remove(command);
                    }
                    else if (regularGuests.Contains(command))
                    {
                        regularGuests.Remove(command);
                    }
                }
            }
            int missingGuests = vipGuests.Count + regularGuests.Count;
            Console.WriteLine(missingGuests);
            foreach (var vipGuest in vipGuests)
            {
                Console.WriteLine(string.Join(" ", vipGuest));
            }
            foreach (var regularGuest in regularGuests)
            {
                Console.WriteLine(string.Join(" ", regularGuest));
            }
        }
    }
}
