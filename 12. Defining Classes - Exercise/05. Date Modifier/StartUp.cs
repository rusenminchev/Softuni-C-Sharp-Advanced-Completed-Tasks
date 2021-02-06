using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifire= new DateModifier();

            Console.WriteLine(dateModifire.GetDaysDiff(startDate, endDate));

        }
    }
}
