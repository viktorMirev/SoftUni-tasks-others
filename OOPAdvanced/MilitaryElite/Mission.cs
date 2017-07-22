using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public class Mission
    {
        public string CodeName { get; private set; }
        private string state;
        public string State
        {
            get
            {
                return this.state;
            }
            private set
            {
                if(value != "inProgress" && value != "Finished")
                {
                    throw new Exception("Invalid mission");
                }
                this.state = value;
            }
        }

        public Mission(string code, string state)
        {
            this.CodeName = code;
            this.State = state;
        }

        public void CompleteMission()
        {
            this.state = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.state}";
        }
    }
}
