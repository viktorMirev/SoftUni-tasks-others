using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;


namespace ConsoleApplication6
{
   
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var total = 0.0;
            var print = new List<double>();
            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = double.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var cCount = int.Parse(Console.ReadLine());
                var Ndays = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var sum = Ndays * cCount * pricePerCapsule;
                print.Add(sum);
                total += Ndays * cCount * pricePerCapsule;
            }
            
            foreach (var item in print)
            {
                Console.WriteLine("The price for the coffee is: ${0:f2}",item);
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
