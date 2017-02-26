

namespace PracticalExamFundamentals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;




    class Program
    {
        static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            decimal distancePer1k = decimal.Parse(Console.ReadLine());
            int enduranceFlapsNum = int.Parse(Console.ReadLine());
            int restTime = 5;
            decimal flapsPerSecond = 100;
            decimal distance = (wingFlaps/1000)*distancePer1k;
            Console.WriteLine("{0:f2} m.", distance);
            decimal time = wingFlaps / flapsPerSecond + wingFlaps / enduranceFlapsNum * restTime;
            Console.WriteLine(time + " s.");
        }
    }
}
