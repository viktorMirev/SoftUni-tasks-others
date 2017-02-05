using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 1 2 3 4 5 6 примерна структура 
            // 5 2 3 6 1 7 2
            // 1 1 2 3 1 4 2
            // 0 1 1 2 4 3 4
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); //четем числата разделени с " "
            var lis = new int[num.Count]; // пазим максималната дължина на увеличаваща се подчаст 
            lis[0] = 1;
            var PrevList = new int[num.Count];// пазим за всеки елемент индекса водещ към предния от редицата
            PrevList[0] = 0;
            var maxCount = 0;
            int maxInd = 1;
            int lastInd = 1;
            bool has = false;
            for (int i = 1; i < num.Count; i++)         // 5 2 3 6 1 7 2
            {
                for (int j = 0; j < i; j++)
                {

                    if (num[j] < num[i] && lis[j] > maxCount)
                    {
                        lastInd = j;
                        has = true;
                        maxCount = lis[j];
                    }

                }
                if (has)
                {
                    PrevList[i] = lastInd;
                    lis[i] = lis[lastInd] + 1;
                    has = false;
                }
                else
                { PrevList[i] = i; lis[i] = 1; }


                    maxCount = 0;
                
          

            }

           for (int k = 0; k < lis.Length; k++)
            {
                if (lis[k] == lis.Max())
                {
                    maxInd = k;
                    break;
                }
                
            }
            int currInd = maxInd;
           
            //int help;
            var result = new List<int>();
            for(int i = 0; i < lis.Max(); i++)
            {
                result.Add(num[currInd]);
              
                currInd = PrevList[currInd];
            }
           
            
            result.Reverse();
            Console.WriteLine(String.Join(" ", result));
             
        }
    }
}
