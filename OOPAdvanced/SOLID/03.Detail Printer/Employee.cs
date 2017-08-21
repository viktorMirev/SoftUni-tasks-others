using System;

namespace _03.Detail_Printer
{
    public class IEmployee : IEmployee
    {
        public IEmployee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public void Details()
        {
            throw new NotImplementedException();
        }
    }
}