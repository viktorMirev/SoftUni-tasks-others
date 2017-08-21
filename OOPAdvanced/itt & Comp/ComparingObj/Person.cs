using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get { return this.name; } private set { this.name = value; } }
        public int Age { get { return this.age; } private set { this.age = value; } }
        public string Town { get { return this.town; } private set { this.town = value; } }

        public int CompareTo(Person other)
        {
            int res;
            res = this.name.CompareTo(other.name);
            if(res == 0)
            {
                res = this.age.CompareTo(other.age);
            }
            if(res == 0)
            {
                res = this.town.CompareTo(other.town);
            }
            return res;
        }
    }
}
