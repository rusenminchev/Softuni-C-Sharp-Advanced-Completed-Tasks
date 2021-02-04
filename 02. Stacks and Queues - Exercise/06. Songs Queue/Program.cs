using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songsQueue = new Queue<string>(songs);

            string command = Console.ReadLine();

            while (songsQueue.Count > 0)
            {


                if (command.Contains("Play"))
                {
                    
                    songsQueue.Dequeue();
                }
                else if (command.Contains("Add"))
                {

                    string songName = command.Substring(4, command.Length - 4);

                    if (songsQueue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(songName);
                    }

                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ", songsQueue));
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
