using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialNummer
{
    class Program
    {
        static void Main(string[] args)
        {
            int one;
            int two;
            int three;
            int four;
            int n = int.Parse(Console.ReadLine());
            for( int i = 1111; i<=9999; i++)
            {
                four = i % 10;
                three = (i / 10) % 10;
                two = (i / 100) % 10;
                one = (i / 1000);
                if(one!=0 && two!=0 && three!=0 && four != 0)
                {
                    if (n % four == 0 && n % three == 0 && n % two == 0 && n % one == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                

            }
        }
    }
}
