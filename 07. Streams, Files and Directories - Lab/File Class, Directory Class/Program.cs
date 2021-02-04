using System;
using System.IO;
using System.Security.Cryptography;

namespace File_Class__Directory_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Чрез class File, можем автоматично да пишем/четем и други. Лесно и бързо.

            var text = File.ReadAllText("TextFile1.txt");


            File.WriteAllText("Output.txt", text);

            ----

            Directory.CreateDirectory("Test Directory");

            Directory.Delete("Test Directory, true);
            Directory.Move("Test", "New Directory");

            Directory.GetFiles();

            string[] fileInDirectory = Directory.GetFiles("Test Directory");

            Directory.GetDirectories();
            string[] subDirectories = Directory.GetFiles("Test Directory");
        }
    }
}
