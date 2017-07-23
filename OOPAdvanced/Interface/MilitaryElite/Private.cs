using System;


namespace OOPadv
{
   public  class Private : Soldier, IPrivate
    {
        public override string ToString()
        {

            return base.ToString().Trim() + $" Salary: {this.salary:f2}";
        }

        private double salary;

        public double Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                this.salary = value;
            }
        }

        public Private(string id, string fname, string lname, double salary) : base(id, fname, lname)
        {
            this.Salary = salary;
        }
    }
}
