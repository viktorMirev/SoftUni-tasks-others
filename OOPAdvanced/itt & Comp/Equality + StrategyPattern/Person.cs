using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;



        public override bool Equals(object other)
        {
            var h = other as Person;
            return this.Name == h.Name && this.Age == h.Age;
        }

        public override int GetHashCode()
        {
            int res = 0;
            res += this.age.GetHashCode();
            res += this.name.GetHashCode();
            
            return res;
        }

        public override string ToString()
        {
            return $"{this.name} {this.age}";
        }

        public int CompareTo(Person other)
        {
            return this.name.CompareTo(other.name);
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get { return this.name; } private set { this.name = value; } }
        public int Age { get { return this.age; } private set { this.age = value; } }
    }
}
