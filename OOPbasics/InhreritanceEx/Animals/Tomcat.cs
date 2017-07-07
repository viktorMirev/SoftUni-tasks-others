using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    class Tomcat : Cat
    {
        public override void ProduceSound()
        {
            Console.WriteLine("Give me one million b***h");
        }
        public Tomcat(string name, int age) : base(name, age, "Male")
        {
           
        }
    }
}
