using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public class Spy : Soldier, ISpy
    {
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Code Number: {this.codeNumber}";
        }

        private int codeNumber;

        public int CodeNumber
        {
            get
            {
                return this.codeNumber;
            }
            private set
            {
                this.codeNumber = value;
            }
        }
        
        public Spy(string id, string fname, string lname, int codeNumber) : base(id, fname, lname)
        {
            this.CodeNumber = codeNumber;
        }
    }
}
