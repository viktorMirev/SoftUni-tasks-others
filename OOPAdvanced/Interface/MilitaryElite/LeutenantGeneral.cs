using System;
using System.Collections.Generic;
using System.Text;

namespace OOPadv
{
   public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string fname, string lname, double salary, List<Private> pr) : base(id, fname, lname, salary)
        {
            this.Privates = pr;
        }

        public override string ToString()
        {
            var res = new StringBuilder(base.ToString());
            res.AppendLine();
            res.AppendLine("Privates:".Trim());
            foreach (var pr in this.privates)
            {
                res.AppendLine("  " + pr.ToString());
            }
            return res.ToString().Trim();
        }

        private List<Private> privates;

        public List<Private> Privates
        {
            get
            {
                return this.privates;
            }
            private set
            {
                this.privates = value;
            }
        }
    }
}
