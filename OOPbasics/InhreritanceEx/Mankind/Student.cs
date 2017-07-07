using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOPEx
{
   public class Student :Human
    {
        private string facultyNumber;

        public Student(string fName, string lName, string facNum) : base(fName, lName)
        {
            this.FacultyNumber = facNum; 
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("First Name: ").AppendLine(base.FirstName)
                .Append("Last Name: ").AppendLine(base.LastName)
                .Append("Faculty number: ").AppendLine(this.facultyNumber);
               

            return sb.ToString();

        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
                
            private set
            {
                var r = new Regex(@"[A-z0-9]+");
                var m = r.Match(value);
                if (m.Value.Length != value.Length || value.Length < 5 || value.Length > 10) throw new ArgumentException("Invalid faculty number!");
                this.facultyNumber = value;
            }
        }
    }
}
