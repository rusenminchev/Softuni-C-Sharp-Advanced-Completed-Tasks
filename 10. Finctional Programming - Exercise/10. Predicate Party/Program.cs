using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_10._Predicate_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestsList = Console.ReadLine()
                .Split(' ')
                .ToList();


            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] cmdArgs = command.Split(' ').ToArray();
                string cmdType = cmdArgs[0];
                string[] predicateArgs = cmdArgs
                    .Skip(1)
                    .ToArray();

                Predicate<string> predicate = MyPredicate(predicateArgs);

                if (cmdType == "Remove")
                {
                    guestsList.RemoveAll(predicate);
                }
                else if (cmdType == "Double")
                {
                    for (int i = 0; i < guestsList.Count; i++)
                    {
                        if (predicate(guestsList[i]))
                        {
                            guestsList.Insert(i + 1, guestsList[i]);
                        }
                        i++;
                    }
                }

                command = Console.ReadLine();
            }

            if (guestsList.Count != 0)
            {
                Console.WriteLine($"{String.Join(", ", guestsList)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> MyPredicate(string[] PredicateArgs)
        {

            string prType = PredicateArgs[0];
            string prArgs = PredicateArgs[1];
            Predicate<string> predicate = null;


            if (prType == "StartsWith")
            {

                predicate = new Predicate<string>((name) =>
                {
                    return name.StartsWith(prArgs);
                });

            }
            else if (prType == "EndsWith")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.EndsWith(prArgs);
                });
            }
            else if (prType == "Length")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.Length == int.Parse(prArgs);
                });
            }

            return predicate;
        }
    }
}
