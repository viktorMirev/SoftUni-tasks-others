using System;
using System.Collections;
using System.Collections.Generic;

class Library : IEnumerable<Book>
{
    private readonly List<Book> books;

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
        IComparer<Book> sorter = new BookComparator();
        this.books.Sort(sorter);
    }


   
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.books);
    }




    private class LibraryIterator : IEnumerator<Book>
    {
        private int index;
        private readonly List<Book> books;

        public LibraryIterator(List<Book> books)
        {
            this.books = new List<Book> (books);
            this.Reset();
        }

        public Book Current
        {
            get
            {
                return this.books[index];
            }
        }

        object IEnumerator.Current => this.Current;

        public void Dispose() { }
     

        public bool MoveNext()
        {
            return (this.index += 1) < this.books.Count;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }

}


