using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shopInfo = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input.Contains("Revision"))
                {
                    break;
                }

                string shopName = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shopInfo.ContainsKey(shopName))
                {
                    

                    shopInfo.Add(shopName, new Dictionary<string, double>());
                    shopInfo[shopName].Add(product, price);
                }
                else
                {

                    shopInfo[shopName].Add(product, price);
                }
                
            }

            foreach (var (shop , product) in shopInfo.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{shop}->");
                foreach (var (products, price) in product)
                {

                    Console.WriteLine($"Product: {products}, Price: {price}");

                }
            }
        }
    }
}
