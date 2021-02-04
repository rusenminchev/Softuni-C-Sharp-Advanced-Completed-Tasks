using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {

            var words = File.ReadAllText("words.txt");

            var splittedWords = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            var input = File.ReadAllText("Input.txt");

            var splittedInput = input.Split(new[] { ' ', '-','.',',' }, StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> matchingStrings = new Dictionary<string, int>();

            foreach (var word in splittedWords)
            {

                foreach (var wordToMatch in splittedInput)
                {

                    if (word.ToLower() == wordToMatch.ToLower())
                    {

                        if (!matchingStrings.ContainsKey(word))
                        {
                            matchingStrings.Add(word, 1);
                        }
                        else
                        {
                            matchingStrings[word]++;
                        }
                    }
                }
            }

            List<string> output = new List<string>();

            foreach (var word in matchingStrings.OrderByDescending(x => x.Value))
            {
                string currentLine = $"{word.Key} - {word.Value}";
                output.Add(currentLine);
            }
            

            File.WriteAllLines(@"C:\Users\Rusen\source\repos\CS Advanced - Streams, Files and Directories\3. Word Count\Output.txt", output);



        }
    }
}
