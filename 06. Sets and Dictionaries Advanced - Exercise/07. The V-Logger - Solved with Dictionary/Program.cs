using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Vlogger_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggerInfo = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while (true)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commands.Contains("Statistics"))
                {
                    break;
                }

                if (commands.Contains("joined"))
                {
                    string vloggerName = commands[0];
                    if (vloggerInfo.ContainsKey(vloggerName))
                    {
                        continue;
                    }

                    vloggerInfo.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                    vloggerInfo[vloggerName].Add("followers", new HashSet<string>());
                    vloggerInfo[vloggerName].Add("following", new HashSet<string>());
                }
                else if (commands.Contains("followed"))
                {

                    string vloggerName = commands[0];
                    string cmd = commands[1];
                    string vloggerToFollow = commands[2];

                    if (!vloggerInfo.ContainsKey(vloggerName) || !vloggerInfo.ContainsKey(vloggerToFollow))
                    {
                        continue;
                    }

                    if (vloggerName == vloggerToFollow)
                    {
                        continue;
                    }

                    if (vloggerInfo[vloggerName]["following"].Contains(vloggerToFollow))
                    {
                        continue;
                    }


                    vloggerInfo[vloggerName]["following"].Add(vloggerToFollow);
                    vloggerInfo[vloggerToFollow]["followers"].Add(vloggerName);

                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggerInfo.Count} vloggers in its logs.");

            string theVeryBesyVloggerName = string.Empty;

            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (var vlogger in vloggerInfo)
            {
                if (vlogger.Value["followers"].Count > max)
                {
                    max = vlogger.Value["followers"].Count;
                    theVeryBesyVloggerName = vlogger.Key;
                }
                if (vlogger.Value["following"].Count < min)
                {
                    min = vlogger.Value["following"].Count;
                    theVeryBesyVloggerName = vlogger.Key;
                }
            }

            int n = 0;

            if (vloggerInfo[theVeryBesyVloggerName]["followers"].Count > 0)
            {
                n++;
                Console.WriteLine($"1. {theVeryBesyVloggerName} : {vloggerInfo[theVeryBesyVloggerName]["followers"].Count} followers," +
                    $" {vloggerInfo[theVeryBesyVloggerName]["following"].Count} following");

                foreach (var follower in vloggerInfo[theVeryBesyVloggerName]["followers"].OrderBy(x => x))
                {
                    Console.WriteLine("*  " + follower);
                }
                vloggerInfo.Remove(theVeryBesyVloggerName);
            }


            foreach (var vlogger in vloggerInfo.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
            {
                n++;
                Console.WriteLine($"{n}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
            }
        }
    }
}
