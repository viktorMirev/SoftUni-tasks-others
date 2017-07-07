using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    class Frog : Animal
    {
        public Frog(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }


        public override void ProduceSound()
        {
            Console.WriteLine("Frogggg");
        }
    }
}
