using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public class ListyIterator<T> : IListyIterator
    {
        private int itt;
        private readonly List<T> elements;


        public ListyIterator(List<T> els)
        {
            if (els.Count == 0)
            {
                this.elements = new List<T>();
            }
            else
            {
                this.elements = new List<T>(els);
            }
            this.itt = 0;
        }


        public bool Move()
        {
            if(this.HasNext())
            {
                itt++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return (this.itt + 1) < this.elements.Count; 
        }

        public void Print()
        {
            if (this.elements.Count == 0) throw new Exception("Invalid Operation!");

            Console.WriteLine(elements[this.itt]);
        }


    }
}
