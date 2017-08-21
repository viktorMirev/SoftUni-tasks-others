using System;
using System.Linq;

namespace OOPadv
{
    public class Sorter<T>
        where T : IComparable<T>
    {
        public static ICustomList<T> Sort(ICustomList<T> elements)
        {

            var helper = elements.Items.OrderBy(a => a);

            return new CustomList<T>(helper);
        }
    }
}
