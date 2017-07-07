using System;

namespace OOPEx
{
    class Program
    {
        static void Main()
        {
            var studData = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var workData = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var student = new Student(studData[0], studData[1], studData[2]);
                var worker = new Worker(workData[0], workData[1], decimal.Parse(workData[2]), decimal.Parse(workData[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            


        }

    }
}
