using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length <= n).ToList()
                .ForEach(Console.WriteLine);

            //names = names.Where(x => x.Length <= 0).ToList();


            //Func<List<string>, List<string>> isItTheRightLenghtFunc = names =>
            //{
            //    List<string> theRightLenghtList = new List<string>();

            //    foreach (var name in names)
            //    {
            //        if (name.Length <= n)
            //        {
            //            theRightLenghtList.Add(name);
            //        }
            //    }

            //    return theRightLenghtList;
            //};

            //Console.WriteLine(String.Join(Environment.NewLine, isItTheRightLenghtFunc(names)));    

        }
    }
}
