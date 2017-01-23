using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
           // If there is more than one appropriate data type, print each one on its own line and order them by size
           //(sbyte < byte < short < ushort < int < uint < long).

            string Num = Console.ReadLine();
            bool ifFit = false;
            string listOfValues = "";
            try
            {
                sbyte.Parse(Num);
                listOfValues += "* sbyte\n";
                ifFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                byte.Parse(Num);
                listOfValues += "* byte\n";
                ifFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                short.Parse(Num);
                listOfValues += "* short\n";
                ifFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                ushort.Parse(Num);
                listOfValues += "* ushort\n";
                ifFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                int.Parse(Num);
                listOfValues += "* int\n";
                ifFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                uint.Parse(Num);
                listOfValues += "* uint\n";
                ifFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                long.Parse(Num);
                listOfValues += "* long\n";
                ifFit = true;
            }
            catch (Exception)
            {

            }
            if (ifFit)
            {
                Console.WriteLine($"{Num} can fit in:");
                Console.WriteLine(listOfValues);
            }
            else Console.WriteLine($"{Num} can't fit in any type");
        }
    }
}
