using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

      

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value[0] < 'A' || value[0] > 'Z') throw new ArgumentException("Expected upper case letter! Argument: lastName");
                if (value.Length <= 2) throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                this.lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value[0] < 'A' || value[0] > 'Z') throw new ArgumentException("Expected upper case letter! Argument: firstName");
                if (value.Length <= 3) throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                this.firstName = value;
            }

        }
    }
}
