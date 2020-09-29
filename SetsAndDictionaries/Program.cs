using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedDictionary е гъвкаво и с къстъм комператори можем да му задаваме как да сортира(ще ги изучаваме по-нататък). SortedDictionary добавя доста по-бавно от Dictionary. Добавянето в Dictionary е много по - бързо.
            //SortedDictionary е имплементирано с red blask tree, което е балансирано! При Dictionary няма red blask tree! SortedDictionary е по-бързо отколкото да използваме нормално и накрая да го сортираме, но зависи не е при всички случаи!
            //ConteinsKey е много бързо, ConteinsValue е много бавно и не ни го препоръчва, ако се налага да го ползваме значи не ни е правилна структурата най-вероятно (но не става дума за еднократно ползване)!

            SortedDictionary<string, int> grades = new SortedDictionary<string, int>();
            grades.Add("Pesho", 6);
            grades.Add("Gosho", 6);
            grades.Add("Misho", 6);
            grades.Add("Sasho", 6);
            foreach (var item in grades)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
