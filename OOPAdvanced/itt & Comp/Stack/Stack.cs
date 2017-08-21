using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOPadv
{
    public class Stack<T> : IEnumerable<T>,IStack<T>
    {
        private readonly List<T> elements;

        public Stack()
        {
            this.elements = new List<T>();
        }

        public void Push(IEnumerable<T> els)
        {
            foreach (var item in els)
            {
                this.elements.Add(item);
            }
        }

        public T Pop()
        {
            if (this.elements.Count == 0) throw new ArgumentException("No elements");
            var res = this.elements.Last();
            elements.RemoveAt(this.elements.Count - 1);
            return res;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new StackIterator<T>(elements);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class StackIterator<T> : IEnumerator<T>
        {
            private readonly List<T> elements;

            private int itt;

            public StackIterator(List<T> elements)
            {
                this.elements = elements;
                this.Reset();
            }

            public T Current => this.elements[itt];

            object IEnumerator.Current => this.Current;

            public void Dispose() { }
           

            public bool MoveNext()
            {
                if (this.itt > 0)
                {
                    this.itt--;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                this.itt = this.elements.Count;
            }
        }
    }
}
