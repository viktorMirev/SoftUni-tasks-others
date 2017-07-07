using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
   public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHpDay;

        public Worker(string fName, string lName, decimal weekS, decimal workHperDay) : base(fName, lName)
        {
            this.WeekSalary = weekS;
            this.WorkHpDay = workHperDay;
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("First Name: ").AppendLine(base.FirstName)
                .Append("Last Name: ").AppendLine(base.LastName)
                .Append("Week Salary: ").AppendLine($"{this.weekSalary:f2}")
                .Append("Hours per day: ").AppendLine($"{this.workHpDay:f2}")
                .Append("Salary per hour: ").AppendLine($"{this.SalaryPerHour():f2}");



            return sb.ToString();

        }



        public decimal SalaryPerHour()
        {
            var totHours = 5 * this.workHpDay;
            return weekSalary / totHours;
        }


        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value <= 10) throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                this.weekSalary = value;
            }
        }
        public decimal WorkHpDay
        {
            get
            {
                return this.workHpDay;
            }
            private set
            {
                if (value < 1 || value > 12) throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                this.workHpDay = value;
            }
        }
    }
}
