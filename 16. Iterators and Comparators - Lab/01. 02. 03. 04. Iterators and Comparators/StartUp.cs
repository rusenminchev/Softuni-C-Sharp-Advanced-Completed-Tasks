﻿using System;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            Book bookFour = new Book("Harry Potter", 1930);



            Library library = new Library(bookOne, bookTwo, bookThree, bookFour);

            foreach (var book in library)
            {
                Console.WriteLine(book);
            }

        }
    }
}