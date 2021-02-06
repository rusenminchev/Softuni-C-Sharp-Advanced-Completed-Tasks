using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;

namespace Exercise_10._Predicate_Party_
{

    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            if (!guestList.Any())
            {
                return;
            }

            string command = Console.ReadLine();

            List<string> goingToThePartyList = new List<string>(guestList);

            Func<string, string, bool> StartWithFunc = (x, y) => x.StartsWith(y);
            Func<string, string, bool> EndsWithFunc = (x, y) => x.EndsWith(y);
            Func<string, string, bool> equalLength = (x, y) => x.Length == int.Parse(y);
            Func<string, string, bool> ContainsFunc = (x, y) => x.Contains(y);

            Dictionary<string, List<string>> filters = new Dictionary<string, List<string>>();

            while (true)
            {

                string[] cmdArgs = command.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string filterCommand = cmdArgs[0];

                if (filterCommand == "Add filter")
                {
                    string filterType = cmdArgs[1];
                    string filterParams = cmdArgs[2];
                    if (!filters.ContainsKey(filterType))
                    {
                        filters.Add(filterType, new List<string>());
                    }
                    
                        filters[filterType].Add(filterParams);
                    
                    
                }
                else if (filterCommand == "Remove filter")
                {
                    string filterType = cmdArgs[1];
                    string filterParams = cmdArgs[2];
                    if (filters[filterType].Contains(filterParams))
                    {
                        filters[filterType].Remove(filterParams);
                    }
                }
                else if (command.Contains("Print"))
                {
                    foreach (var (filterType, filterParams) in filters)
                    {
                        foreach (var guest in guestList)
                        {
                            if (filterType == "Starts with")
                            {
                                foreach (var param in filterParams)
                                {
                                    if (StartWithFunc(guest, param))
                                    {
                                        goingToThePartyList.Remove(guest);
                                    }
                                }
                            }
                            else if (filterType == "Ends with")
                            {
                                foreach (var param in filterParams)
                                {
                                    if (EndsWithFunc(guest, param))
                                    {
                                        goingToThePartyList.Remove(guest);
                                    }
                                }
                            }
                            else if (filterType == "Length")
                            {
                                foreach (var param in filterParams)
                                {
                                    if (equalLength(guest, param))
                                    {
                                        goingToThePartyList.Remove(guest);
                                    }
                                }
                            }
                            else if (filterType == "Contains")
                            {
                                foreach (var param in filterParams)
                                {
                                    if (ContainsFunc(guest, param))
                                    {
                                        goingToThePartyList.Remove(guest);
                                    }
                                }
                            }
                        }

                        guestList.Clear();
                        guestList.AddRange(goingToThePartyList);

                    }

                    Console.WriteLine(String.Join(' ', goingToThePartyList));
                    break;
                }
                command = Console.ReadLine();
            }
        }
    }
}

