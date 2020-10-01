using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkongLot = new HashSet<string>();
            string input = Console.ReadLine();

            while (input!="END")
            {
                string[] splitedInput = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string action = splitedInput[0];
                string number = splitedInput[1];
                if (action=="IN")
                {
                    parkongLot.Add(number);
                }
                else if (action == "OUT")
                {
                    parkongLot.Remove(number);
                }
                input = Console.ReadLine();
            }

            if (parkongLot.Count>0)
            {
                foreach (var num in parkongLot)
                {
                    Console.WriteLine(string.Join(" ", num));
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
