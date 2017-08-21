using System.Collections.Generic;

namespace OOPadv
{
    class PersonNameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var res = x.Name.Length.CompareTo(y.Name.Length);
            if (res==0)
            {
                char one = x.Name.ToLower()[0];
                char two = y.Name.ToLower()[0];
                res = one.CompareTo(two);
            }
            return res;
        }
    }
}
