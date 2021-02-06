using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    class Library : IEnumerable<Book>
    {

        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }


        public IEnumerator<Book> GetEnumerator()
        {
            this.books.ToImmutableSortedSet(new BookComparator());
            return new LibraryItarator(this.books);

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryItarator : IEnumerator<Book>
        {

            private List<Book> books;
            private int currentIndex;

            

            public LibraryItarator(List<Book> books)
            {
                this.Reset();
                this.books = books;
            }

            public bool MoveNext()
            {
                currentIndex++;
                return this.currentIndex < this.books.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }

            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => this.Current;


            public void Dispose()
            {

            }
        }
    }
}