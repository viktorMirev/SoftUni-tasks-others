using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace RecyclingStation.Logic.Factories
{
    public class GarbageFactory
    { 
        private const string  suffix = "Garbage";
        private string fullName;


        public IWaste GetGarbage(string name, double weight, double volumePerKg, string type)
        {
            this.fullName = type + suffix;
            Type currGarbage = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Name == this.fullName).First();
            return (IWaste)Activator.CreateInstance(currGarbage, new object[] { name,volumePerKg,weight});
        }
    }
}
