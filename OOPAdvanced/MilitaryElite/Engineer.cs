

using System.Collections.Generic;
using System.Text;

namespace OOPadv
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<Repair> repairs;


        public override string ToString()
        {
            var res = new StringBuilder(base.ToString());
            res.AppendLine();
            res.AppendLine($"Corps: {this.Corps}".Trim());
            res.AppendLine("Repairs:".Trim());
            foreach (var item in this.repairs)
            {
                res.AppendLine("  " + item.ToString());
            }
            return res.ToString().Trim();
        }

        public Engineer(string id, string fname, string lname, double salary,string corps, List<Repair> reps) : base(id, fname, lname, salary,corps)
        {
            this.Repairs = reps;
        }

        public List<Repair> Repairs
        {
            get => repairs;
            set => repairs = value;
        }
    }
}
