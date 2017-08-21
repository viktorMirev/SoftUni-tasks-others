using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.Logic.Data
{
    public class ProcessingData : IProcessingData
    {
        public double EnergyBalance { get; private set; }

        public double CapitalBalance { get; private set; }

        public ProcessingData(double engBalance, double cptBalance)
        {
            this.EnergyBalance = engBalance;
            this.CapitalBalance = cptBalance;
        }
    }
}
