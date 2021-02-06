using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercise___02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = Console.ReadLine().Split().ToList();
            // names.Select(x => $"Sir {x}");
            names = mySelect(names, x => $"Sir {x}");

            Action<List<string>> printNames = x => Console.WriteLine(String.Join(Environment.NewLine, x));
            printNames(names);
        }

        static List<string> mySelect(List<string> list, Func<string, string> myFunc)
        {

            List<string> newList = new List<string>();


            foreach (var item in list)
            {

                string newItem = myFunc(item);
                newList.Add(newItem);

            }

            return newList;
        }
    }
}
