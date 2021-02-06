using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<Person> sortedSetOfPeople = new SortedSet<Person>();
            HashSet<Person> hashSetOfPeople = new HashSet<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
               
                sortedSetOfPeople.Add(person);
                hashSetOfPeople.Add(person);

            }

            Console.WriteLine(sortedSetOfPeople.Count);
            Console.WriteLine(hashSetOfPeople.Count);
        }
    }
}
