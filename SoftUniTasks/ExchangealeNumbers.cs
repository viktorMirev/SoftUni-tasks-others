using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace StringExcercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var result = new List<int>();
            int rest=0;
            
            for (int i = 0; i < Math.Max(first.Length, second.Length); i++)
            {
                if (i>=first.Length)
                {
                    int currSum = rest + second[i] - '0';
                    if (currSum>9)
                    {
                        rest = currSum / 10;
                        result.Add(currSum - 10);
                    }
                    else
                    {
                        result.Add(currSum); rest = 0; 
                    }
                }
                else if (i >= second.Length)
                {
                    int currSum = rest + first[i] - '0';
                    if (currSum > 9)
                    {
                        rest = currSum / 10;
                        result.Add(currSum - 10);
                    }
                    else
                    {
                        result.Add(currSum); rest = 0;
                    }
                }
                else
                {
                    int currSum = first[first.Length - 1 - i] - '0' + second[second.Length - 1 - i] - '0' + rest;
                    if (currSum > 9)
                    {
                        rest = currSum / 10;
                        result.Add(currSum - 10);
                    }
                    else { result.Add(currSum); rest = 0; }
                }
                
            }


            if (rest != 0) result.Add(rest);

            for (int i = result.Count-1; i >=0 ; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }

       
    }
}
