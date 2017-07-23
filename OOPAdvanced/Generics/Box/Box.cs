using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Box<T>
{
    private List<T> data = new List<T>();
    public int Count => data.Count;

    public void Add(T obj)
    {
        data.Add(obj);
    }
    public T Remove()
    {
        var last = data[data.Count - 1];
        data.RemoveAt(data.Count - 1);
        return last;
    }
}
    
