﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public class Repair
    {
        public string PartName { get; set; }
        public int HoursWorked { get; set; }

        public Repair(string name, int hours)
        {
            this.PartName = name;
            this.HoursWorked = hours;
        }
        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }


}
