namespace _03.Detail_Printer
{
    using System;
    using System.Collections.Generic;

    public class DetailsPrinter
    {
        private IList<IEmployee> employees;

        public DetailsPrinter(IList<IEmployee> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (IEmployee employee in this.employees)
            {
                if (employee is Manager)
                {
                    this.PrintManager((Manager) employee);
                }
                else
                {
                    this.PrintEmployee(employee);
                }
            }
        }

        private void PrintEmployee(IEmployee employee)
        {
            Console.WriteLine(employee.Name);
        }

        private void PrintManager(Manager manager)
        {
            Console.WriteLine(manager.Name);
            Console.WriteLine(string.Join(Environment.NewLine, manager.Documents));
        }
    }
}