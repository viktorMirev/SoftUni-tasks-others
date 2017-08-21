using System.Collections.Generic;

class BookComparator : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        var res = x.Title.CompareTo(y.Title);
        if (res == 0) res = y.Year.CompareTo(x.Year);
        return res;
    }
}

