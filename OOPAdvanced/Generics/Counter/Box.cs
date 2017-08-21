using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public class Box<T> : IComparable<Box<T>>
        where T : IComparable<T>
        
    {
        private T el;
        public Box(T element)
        {
            this.el = element;
        }

      
        public T El
        {
            get
            {
                return this.el;
            }
        }

        public int CompareTo(Box<T> other)
        {
            return this.el.CompareTo(other.El);
        }

        public override string ToString()
        {
            return $"{this.el.GetType().FullName}: {this.el}";
        }
    }
}
