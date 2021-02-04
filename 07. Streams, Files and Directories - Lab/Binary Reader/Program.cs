using Microsoft.VisualBasic;
using System;
using System.IO;

namespace Binary_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("binary.txt", FileMode.OpenOrCreate);

            using BinaryWriter binaryWriter = new BinaryWriter(stream);

            binaryWriter.Write(true);
            binaryWriter.Write(true);
            binaryWriter.Write(false);
            binaryWriter.Write(true);
            binaryWriter.Write(false);

            binaryWriter.Close(); 

            using BinaryReader binaryReader = new BinaryReader(stream);


            var first = binaryReader.ReadBoolean();
            var second = binaryReader.ReadBoolean();

            
        }
    }
}
