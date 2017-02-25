using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LongNumMultiplier
{
    class Program
    {
        
        static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();
            int rightIndx;
            int leftIndx;

            while (true)
            {
                leftIndx = text.IndexOf(pattern);
                rightIndx = text.LastIndexOf(pattern);
                if(leftIndx == rightIndx || leftIndx<0 || rightIndx < 0 || text == "")
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                else
                {
                    
                    if (pattern == string.Empty)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Shaked it.");
                        text = text.Remove(leftIndx, pattern.Length);
                        rightIndx = text.LastIndexOf(pattern);
                        text = text.Remove(rightIndx, pattern.Length);
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                    }
                }
            }
            Console.WriteLine(text);
        }
       
    }
}
