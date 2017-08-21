using System;
using System.Collections;
using System.Collections.Generic;

class Library : IEnumerable<Book>
{
    private List<Book> books;

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
    }


   
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
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
            this.books = books;
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }

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


