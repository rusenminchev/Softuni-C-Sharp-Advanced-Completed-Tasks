using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> people = new List<Person>();

            int peopleCounter = 1;

            while (input != "END")
            {
                var inputArgs = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = inputArgs[0];
                int age = int.Parse(inputArgs[1]);
                string town = inputArgs[2];

                Person person = new Person(name, age, town);
                people.Add(person);
                peopleCounter++;

                input = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());
            Person personToCompare = people[n-1];


            int matchesCounter = 0;
            int notEqualCounter = 0;

            foreach (var person in people)
            {
               int result = personToCompare.CompareTo(person);

                if (result == 0)
                {
                    matchesCounter++;
                }
                else
                {
                    notEqualCounter++;
                }
            }

            if (matchesCounter <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matchesCounter} {notEqualCounter} {people.Count}");
            }
        }
    }
}
