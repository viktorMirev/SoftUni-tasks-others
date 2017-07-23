using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string fname, string lname, double salary, string corps) : base(id, fname, lname, salary)
        {
            this.Corps = corps;
        }

        private string corps;

        public string Corps
        {
            get
            {
                return this.corps;
            }
            private set
            {
                if(value!= "Marines" && value != "Airforces")
                {
                    throw new Exception("Invalid corps");
                }
                this.corps = value;
            }
        }
    }
}
