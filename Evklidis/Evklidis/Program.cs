using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evklidis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int rest=1;

            if (a < b)
            {
                rest = a;
                a = b;
                b = rest;
            }
            while (rest != 0)
            {
                rest = a % b;
                a = b;
                b = rest;
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
