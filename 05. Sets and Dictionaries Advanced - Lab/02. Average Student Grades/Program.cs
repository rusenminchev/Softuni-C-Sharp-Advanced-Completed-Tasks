using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        public static object Discti { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentInfo = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (studentInfo.ContainsKey(name))
                {
                    studentInfo[name].Add(grade);

                }
                else
                {
                    studentInfo.Add(name, new List<decimal>());
                    studentInfo[name].Add(grade);

                }
            }

            foreach (var (name, grade) in studentInfo)
            {

                Console.Write($"{name} -> ");

                foreach (var grades in grade)
                {
                    Console.Write($"{grades:f2} ");
                }

                Console.WriteLine($"(avg: {grade.Average():f2})");
            }
        }
    }
}
