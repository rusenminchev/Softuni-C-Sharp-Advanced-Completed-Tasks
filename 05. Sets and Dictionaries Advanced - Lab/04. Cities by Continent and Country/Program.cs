using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> planetEarth = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!planetEarth.ContainsKey(continent))
                {

                    planetEarth.Add(continent, new Dictionary<string, List<string>>());
                    planetEarth[continent].Add(country, new List<string>());
                    planetEarth[continent][country].Add(city);
                    
                }
                else
                {
                    if (!planetEarth[continent].ContainsKey(country))
                    {
                        planetEarth[continent].Add(country, new List<string>());
                        if (!planetEarth[continent][country].Contains(city))
                        {
                            planetEarth[continent][country].Add(city);
                        }
                    }
                    else
                    {
                  
                            planetEarth[continent][country].Add(city);
                        
                    }
                }
            }

            foreach (var (continent, country) in planetEarth)
            {

                Console.WriteLine($"{continent}:");

                foreach (var (countries, cities) in country)
                {
                    Console.WriteLine($"{countries} -> {String.Join(", ", cities)}");
                }
            }
        }
    }
}
