using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            while (input!= "Revision")
            {
                var splitedInput = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = splitedInput[0];
                string product = splitedInput[1];
                double price = double.Parse(splitedInput[2]);
                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }
                input = Console.ReadLine();
            }

            var sortedShops = shops.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);
            foreach (var shop in sortedShops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
