using System;
using System.Collections.Generic;
using System.Globalization;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedDictionary е гъвкаво и с къстъм комператори можем да му задаваме как да сортира(ще ги изучаваме по-нататък). SortedDictionary добавя доста по-бавно от Dictionary. Добавянето в Dictionary е много по - бързо.
            //SortedDictionary е имплементирано с red blask tree, което е балансирано! При Dictionary няма red blask tree! SortedDictionary е по-бързо отколкото да използваме нормално и накрая да го сортираме, но зависи не е при всички случаи!
            //ConteinsKey е много бързо, ConteinsValue е много бавно и не ни го препоръчва, ако се налага да го ползваме значи не ни е правилна структурата най-вероятно (но не става дума за еднократно ползване)!
            //Multi-Dictionary e Dictionary<string, List<int>> ();

            //Conteins е бързо в Dictionary и Set, в лист, стек и кю е бавно

            //снипет за промяна на типа на променлива: Ctrl+F, стрелка надолу -> горе стар тип, долу нов -> отдолу Current Document -> отдясно бутоните - ляв ги променя едно по едно, дясния всички. 

            //Set и HashSet
            //Set - лист от неща без повторения! Прилича на лист, но не позволява добавянето на еднакъв елемент - винаги ст-стите му са уникални и НЯМА индексация, т. е. не знаем кой елемент къде се намира! set.Contains() - проверка дали даден елемент се намира в сета, true / false и е супер бързо! 
            // add/remove/search elements (има/няма - true / false)
            //когато имаш голяма база данни и трябва да провериш нещо дали го има със HashSet става най-бързо.

            //SortedDictionaryes
            //SortedDictionary<string, int> grades = new SortedDictionary<string, int>();
            //grades.Add("Pesho", 6);
            //grades.Add("Gosho", 6);
            //grades.Add("Misho", 6);
            //grades.Add("Sasho", 6);
            //foreach (var item in grades)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}

            //Sets
            // В С# всеки един сет е HashSet
            //итерира се само с foreach(като дикшанарито), for не работи поради липсата на индексация.
            //HashSet<int> nums = new HashSet<int>();
            //nums.Add(5);
            //nums.Add(6);
            //nums.Add(7);
            //nums.Add(1);
            //nums.Remove(7);
            //Console.WriteLine(nums.Contains(6));
            //Console.WriteLine(nums.Contains(66));
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            //когато говорим за кешове и кеширане имплементацията на сетовете ни е много важна, тя ни показва защо сета, дикшанарито и доста други структури са бързи
            //За add/contains няма по-бързо нещо от сета!
            // сета се използва много
            //

            //SortedSet
            //имплементацията отново е същата- използва самобалансиращо се бинарно дърво - red-black tree
            //по бавно е за много операции, но ги държи сортирани!
            // The elements are ordered incrementally!
            //един ден ако можем да имплементираме SortedSet значи сме програмисти от добро ниво, готови програмисти - синиър ;-). След структури от данни и алгуритми ще ни е доста по-ясно това!
            // В момента в СофтУни структури от данни и алгуритми са два курса!
            //Цел да имплементирам SortedSet някой ден!
            //Пример:
            //SortedSet<int> numbers = new SortedSet<int>();
            //int num = int.Parse(Console.ReadLine());
            //while (num!=-1)
            //{
            //    numbers.Add(num);
            //    num = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(string.Join(" ", numbers));

            //Bucket Sort - е на подобен принцип, но е само за числа. Set - а е за всички типове данни!
            //Dictionary работи ксто лист с индекси и е бързо като хешсет! В много езици Dictionary се казва HashTable!
            //Имплементиране на Set (от 01:33 от лекцията почва, бонус - първата или втора лекция от структури от данни):
            //Ако знаем броя на данните можем да направим перфектна хеш функция - която не прави колизии "perfekt Hash function", но трудно се прави. Хеш функцията приема ключ и връща число. 
            //SetsInside

            //C++ е много близък до C#, при нужда много лесно ще можем да го научим при стабилни познания по C#
            //cousera alguritms princeton препоръчва алгуритми са това, много полезни!
            //edx и mit са други много добри места за учене от най-добрите университети в света!  
            //geekforgeeks.org и hacherrank.com са супер яки сайтове за учене на програмиране
            //Learn you s haskell for GreatGood - много яка книга за функционално програмиране, която е добре някой ден да прочетем!
            //knuth alguritms - саита е: The Art of Computer Programing - друга много добра книга по програмиране 
            //puralsight - много добър сайт за учене
            //след като се научим е добре малко да минем на Linox да до познаваме от обща култура.
        }
    }
}
