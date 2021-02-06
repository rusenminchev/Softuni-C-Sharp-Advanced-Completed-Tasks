using System;
using System.Dynamic;
using System.Linq;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            string firstNameLastName = $"{input[0]} {input[1]}";
            string address = input[2];
            string town = string.Empty;

            for (int i = 3; i < input.Length; i++)
            {
                town += $" {input[i]}";
            }

            Threeuple<string, string, string> myTuple = new Threeuple<string, string, string>(firstNameLastName, address, town);

            Console.WriteLine(myTuple);

            input = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .ToArray();

            string name = input[0];
            int litersOFBeer = int.Parse(input[1]);
            bool drunkOrNot = false;

            if (input[2] == "drunk")
            {
                drunkOrNot = true;
            }

            Threeuple<string, int, bool> mySecondTuple = new Threeuple<string, int, bool>(name, litersOFBeer, drunkOrNot);
            
            Console.WriteLine(mySecondTuple);

            input = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .ToArray();

            name = input[0];
            double accountBalance = double.Parse(input[1]);
            string bankName = input[2];

            Threeuple<string, double, string> myThirdTuple = new Threeuple<string, double, string>(name, accountBalance, bankName);

            Console.WriteLine(myThirdTuple);

        }
    }
}
