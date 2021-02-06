using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Интересен начин за сравнени и сортиране между елементи в масив

            Array.Sort(numbers, (int x, int y) =>
             {
                 int sorter = 0;

                 if (x % 2 == 0 && y % 2 != 0)
                 {
                     sorter = -1;
                 }
                 else if (x % 2 != 0 && y % 2 == 0)
                 {
                     sorter = 1;
                 }
                 else
                 {
                     // sorter = x - y;
                     sorter = x.CompareTo(y);
                 }

                 return sorter;
             });


            // Съкратен начин на изписване с тернарен оператор? '?' представлява условие, при което се получава true или false, 
            // ако е true взема стойността след '?', ако е false продължава с следващното условие след ':', докато не стигне до края или до true.

            Array.Sort(numbers, (int x, int y) =>   
                (x % 2 == 0 && y % 2 != 0) ? -1 :
                (x % 2 != 0 && y % 2 == 0) ? 1 :
                x.CompareTo(y));

            Console.WriteLine(string.Join(' ', numbers));

            





            // Моето първоначално решение
            //Func<List<int>, List<int>> listSortFunc = numbers =>
            //{
            //    List<int> sortedList = new List<int>();

            //    foreach (var num in numbers.Where(x => Math.Abs(x) % 2 == 0))
            //    {
            //        sortedList.Add(num);
            //    }
            //    foreach (var num2 in numbers.Where(x => Math.Abs(x) % 2 == 1))
            //    {
            //        sortedList.Add(num2);
            //    }

            //    return sortedList;
            //};


            //Console.WriteLine(string.Join(' ', listSortFunc(numbers)));
        }

    }
}
