using System.Collections.Generic;

namespace OOPadv
{
    public interface IStack<T> : IEnumerable<T>
    {
        void Push(IEnumerable<T> els);
        T Pop();
    }
}
