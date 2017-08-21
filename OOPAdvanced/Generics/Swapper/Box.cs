using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public class Box<T>
    {
        private T el;
        public Box(T element)
        {
            this.el = element;
        }

        public override string ToString()
        {
            return $"{this.el.GetType().FullName}: {this.el}";
        }
    }
}
