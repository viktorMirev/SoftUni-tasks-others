using System;
using RecyclingStation.Logic.Contracts;
using RecyclingStation.WasteDisposal.Interfaces;
using RecyclingStation.Logic.Factories;

namespace RecyclingStation.Logic.Core
{
    public class RecyclingManager : IRecyclingStation
    {
        private IGarbageProcessor garbageProcessor;
        private GarbageFactory garbageFactory;
        private double energyBalance;
        private double capitalBalance;

        private double minimumEnergyBalance;
        private double minimumCapitalBalance;
        private string typeOfGarbage;

        private bool requirementsAreSet = false;
        
        public RecyclingManager(IGarbageProcessor garbageProcessor, GarbageFactory garbageFactory)
        {
            this.energyBalance = 0;
            this.capitalBalance = 0;
            this.garbageProcessor = garbageProcessor;
            this.garbageFactory = garbageFactory;
        }


        public string ChangeManagementRequirement(double minimumEnergyBalance, double minimumCapitalBalance, string typeOfGarbage)
        {
            this.requirementsAreSet = true;
            this.minimumEnergyBalance = minimumEnergyBalance;
            this.minimumCapitalBalance = minimumCapitalBalance;
            this.typeOfGarbage = typeOfGarbage;
            return "Management requirement changed!";
        }

        public string ProcessGarbage(string name, double weight, double volumePerKg, string type)
        {
            IWaste currGarbage = null;
            currGarbage = this.garbageFactory.GetGarbage(name, weight, volumePerKg, type);
            if(type == this.typeOfGarbage)
            {
                if(this.minimumEnergyBalance>this.energyBalance || this.minimumCapitalBalance > this.capitalBalance)
                {
                    return "Processing Denied!";
                }
            }
            IProcessingData myData = this.garbageProcessor.ProcessWaste(currGarbage);
            this.energyBalance += myData.EnergyBalance;
            this.capitalBalance += myData.CapitalBalance;

            return $"{weight:f2} kg of {name} successfully processed!";
        }

        public string Status()
        {
            return $"Energy: {this.energyBalance:f2} Capital: {this.capitalBalance:f2}";
        }
    }
}
