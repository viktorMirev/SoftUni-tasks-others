using System;
using System.Numerics;

namespace HomeWo
{
  
    class Program
    {
         static int count=0;
       public static void Main()
        {
            TrZeros(Factoriel(int.Parse(Console.ReadLine())));
        }
       
        private static void TrZeros(BigInteger bigInteger)
        {
            if (bigInteger % 10 == 0) { count++; bigInteger = bigInteger / 10; TrZeros(bigInteger); }
            else Console.WriteLine(count);

        }
            
        private static BigInteger Factoriel(int n)
        {
            if (n == 0) Console.WriteLine("1");
            BigInteger prev = 1;
            for (int    curr=1; curr<=n; curr++)
            {
                prev = prev*curr;
            }
            //Console.WriteLine(prev);
            return prev;
        }
    }
}
