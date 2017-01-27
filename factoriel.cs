using System;
using System.Numerics;

namespace HomeWo
{
    class Program
    {
       public static void Main()
        {
            Factoriel(int.Parse(Console.ReadLine()));
        }

        private static void Factoriel(int n)
        {
            if (n == 0) Console.WriteLine("1");
            BigInteger prev = 1;
            for (int    curr=1; curr<=n; curr++)
            {
                prev = prev*curr;
            }
            Console.WriteLine(prev);
        }
    }
}
