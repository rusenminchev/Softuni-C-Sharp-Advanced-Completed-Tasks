using System;

namespace Workshop___Create_Custom_Data_Structures
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();

            Console.WriteLine("Let`s add some elements");

            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            Console.WriteLine("Let`s see what we have just added");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine("Let`s remove something");

            var result = myList.RemoveAt(5);


            Console.WriteLine($"We removed this elements: {result}");

            result = myList.RemoveAt(6);

            Console.WriteLine($"We removed this elements: {result}");

            Console.WriteLine("Let`s see what`s up in our list");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine("Let`s check is it contains some different elements");

            Console.WriteLine(myList.Contains(11));
            Console.WriteLine(myList.Contains(5));
            Console.WriteLine(myList.Contains(3));

            Console.WriteLine("It`s time to try out Swap method");

            myList.Swap(0, 3);


            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[3]);

            Console.WriteLine("Yeah! It works!");

            Console.WriteLine("Let`s insert the element 33 at index 3");

            myList.InsertAt(3, 33);

            Console.WriteLine("Let`s see what`s happening");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine("Let`s remove most of the elements to test the Shrink() method");

            myList.RemoveAt(0);
            myList.RemoveAt(0);
            myList.RemoveAt(0);
            myList.RemoveAt(0);
            myList.RemoveAt(0);
            myList.RemoveAt(0);
            myList.RemoveAt(0);
            myList.RemoveAt(0);

            Console.WriteLine($"Final count is: {myList.Count}");

        }
    }
}
