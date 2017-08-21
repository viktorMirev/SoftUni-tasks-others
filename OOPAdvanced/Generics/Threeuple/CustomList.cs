using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public class CustomList<T> : ICustomList<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        private readonly List<T> items;

        public List<T> Items
        {
            get
            {
                return this.items;
            }

        }

        public CustomList()
        {
            this.items = new List<T>();
        }

        public CustomList(IEnumerable<T> a)
        {
            this.items = new List<T>(a);
        }

        public T Current => throw new NotImplementedException();

       

        public void Add(T element)
        {
            this.items.Add(element);
        }

        public bool Contains(T element)
        {
            if (this.items.Contains(element)) return true;
            return false;
        }

        public int CountGreaterThan(T element)
        {
            return this.items.Count(a => a.CompareTo(element) > 0);
        }

        public T Max()
        {
            return this.items.Max();
        }

        public T Min()
        {
            return this.items.Min();
        }

        
        public T Remove(int index)
        {
            var h = this.items[index];
            this.items.RemoveAt(index);
            return h;
        }

       
        public void Swap(int index1, int index2)
        {
            var swapVar = this.items[index1];
            this.items[index1] = this.items[index2];
            this.items[index2] = swapVar;
        }

       

        public void Print()
        {
            foreach (var item in this.items)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)Items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)Items).GetEnumerator();
        }
    }
}
