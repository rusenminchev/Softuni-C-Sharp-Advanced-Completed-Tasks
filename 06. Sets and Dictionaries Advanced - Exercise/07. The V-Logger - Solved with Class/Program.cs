using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace V_Logger
{
    class Program
    {

        class Vlogger
        {
            public HashSet<string> Followers { get; set; }
            public HashSet<string> Following { get; set; }


        }
        static void Main(string[] args)
        {


            Dictionary<string, Vlogger> vloggerInfo = new Dictionary<string, Vlogger>();


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
                    HashSet<string> followers = new HashSet<string>();
                    HashSet<string> following = new HashSet<string>();

                    Vlogger vloggerActivity = new Vlogger() { Followers = followers, Following = following };

                    vloggerInfo.Add(vloggerName, vloggerActivity);

                }
                else if (commands.Contains("followed"))
                {

                    string vloggerName = commands[0];
                    string cmd = commands[1];
                    string vloggerToFollow = commands[2];

                    if (vloggerInfo.ContainsKey(vloggerName) && vloggerInfo.ContainsKey(vloggerToFollow) && vloggerToFollow != vloggerName)
                    {
                        if (!vloggerInfo[vloggerToFollow].Followers.Contains(vloggerName))
                        {
                            vloggerInfo[vloggerToFollow].Followers.Add(vloggerName);
                        }

                        if (!vloggerInfo[vloggerName].Following.Contains(vloggerToFollow))
                        {
                            vloggerInfo[vloggerName].Following.Add(vloggerToFollow);
                        }
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggerInfo.Count} vloggers in its logs.");

            string theVeryBesyVloggerName = string.Empty;

            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (var vlogger in vloggerInfo)
            {
                if (vlogger.Value.Followers.Count > max)
                {
                    max = vlogger.Value.Followers.Count;
                    theVeryBesyVloggerName = vlogger.Key;
                }
                if (vlogger.Value.Following.Count < min)
                {
                    min = vlogger.Value.Following.Count;
                    theVeryBesyVloggerName = vlogger.Key;
                }
            }

            int n = 0;

            if (vloggerInfo[theVeryBesyVloggerName].Followers.Count > 0)
            {
                n++;
                Console.WriteLine($"1. {theVeryBesyVloggerName} : {vloggerInfo[theVeryBesyVloggerName].Followers.Count} followers," +
                    $" {vloggerInfo[theVeryBesyVloggerName].Following.Count} following");

                foreach (var follower in vloggerInfo[theVeryBesyVloggerName].Followers.OrderBy(x => x))
                {
                    Console.WriteLine("*  " + follower);
                }
                vloggerInfo.Remove(theVeryBesyVloggerName);
            }


            foreach (var vlogger in vloggerInfo.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count))
            {
                n++;
                Console.WriteLine($"{n}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");
            }
        }
    }
}
