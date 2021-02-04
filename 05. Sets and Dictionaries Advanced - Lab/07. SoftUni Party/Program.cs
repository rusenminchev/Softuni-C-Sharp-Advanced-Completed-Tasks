using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, HashSet<string>> notAttendingList = new Dictionary<string, HashSet<string>>();


            string revNumber = Console.ReadLine();
            int counter = 0;

            while (revNumber != "PARTY")
            {
                if (char.IsDigit(revNumber[0]))
                {
                    if (!notAttendingList.ContainsKey("VIP"))
                    {
                        notAttendingList.Add("VIP", new HashSet<string>());
                        notAttendingList["VIP"].Add(revNumber);
                        counter++;
                    }
                    else
                    {
                        notAttendingList["VIP"].Add(revNumber);
                        counter++;
                    }
                }
                else
                {
                    if (!notAttendingList.ContainsKey("regular"))
                    {
                        notAttendingList.Add("regular", new HashSet<string>());
                        notAttendingList["regular"].Add(revNumber);
                        counter++;
                    }
                    else
                    {
                        notAttendingList["regular"].Add(revNumber);
                        counter++;
                    }
                }


                revNumber = Console.ReadLine();
            }

            string revNumberAttending = Console.ReadLine();

            while (revNumberAttending != "END")
            {
                if (notAttendingList.ContainsKey("VIP"))
                {
                    if (notAttendingList["VIP"].Contains(revNumberAttending))
                    {
                        notAttendingList["VIP"].Remove(revNumberAttending);
                        counter--;
                    }
                }
                if (notAttendingList.ContainsKey("regular"))
                {
                    if (notAttendingList["regular"].Contains(revNumberAttending))
                    {
                        notAttendingList["regular"].Remove(revNumberAttending);
                        counter--;
                    }
                }

                revNumberAttending = Console.ReadLine();
            }

            Console.WriteLine(counter);
            if (notAttendingList.Any())
            {
                if (notAttendingList.ContainsKey("VIP"))
                {
                    foreach (var guest in notAttendingList["VIP"])
                    {
                        Console.WriteLine(guest);
                    }
                }
                if (notAttendingList.ContainsKey("regular"))
                {
                    foreach (var guest in notAttendingList["regular"])
                    {
                        Console.WriteLine(guest);
                    }
                }
            }

        }
    }
}
