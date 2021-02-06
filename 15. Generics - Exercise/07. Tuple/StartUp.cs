using System;
using System.Dynamic;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAndAddress = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            string firstNameLastName = $"{nameAndAddress[0]} {nameAndAddress[1]}";
            string address = nameAndAddress[2];

            Tuple<string, string> myFirstTuple = new Tuple<string, string>(firstNameLastName, address);

            Console.WriteLine(myFirstTuple);

            string[] nameAndBeer = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .ToArray();

           string name = nameAndBeer[0];
           int litersOFBeer = int.Parse(nameAndBeer[1]);

            Tuple<string, int> mySecondTuple = new Tuple<string, int>(name, litersOFBeer);

            Console.WriteLine(mySecondTuple);

           string[] intAndDouble = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .ToArray();

            int firstItem = int.Parse(intAndDouble[0]);
            double secondItem = double.Parse(intAndDouble[1]);

            Tuple<int, double> myThirdTuple = new Tuple<int, double>(firstItem, secondItem);

            Console.WriteLine(myThirdTuple);

        }
    }
}
