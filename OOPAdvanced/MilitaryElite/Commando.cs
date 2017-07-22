using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string fname, string lname, double salary, string corps, List<Mission> miss) : base(id, fname, lname, salary, corps)
        {
            this.Missions = miss;
        }

        public override string ToString()
        {
            var res = new StringBuilder(base.ToString());
            res.AppendLine();
            res.AppendLine($"Corps: {this.Corps}");
            res.AppendLine($"Missions: ".Trim());
            foreach (var item in this.missions)
            {
                res.AppendLine("  " + item.ToString().Trim());
            }

            return res.ToString().Trim();
        }

        private List<Mission> missions;

        public List<Mission> Missions
        {
            get
            {
                return this.missions;
            }
            private set
            {
                this.missions = value;
            }
        }
    }
}
