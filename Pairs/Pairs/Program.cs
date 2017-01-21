using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1;
            int p2;
            int MaxSum = int.MinValue ;
            int MinSum = int.MaxValue;
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                p1 = int.Parse(Console.ReadLine());
                p2 = int.Parse(Console.ReadLine());
                if((p1+p2) <= MinSum)
                {
                    MinSum = p1 + p2;
                }
                if((p1+p2) >= MaxSum)
                {
                    MaxSum = p1 + p2;
                }
            }
            if (MaxSum == MinSum)
            {
                Console.WriteLine("Yes, they are equal: " + MinSum);
            }
            else Console.WriteLine("No, they are not: " + (MaxSum - MinSum));
        }
    }
}
