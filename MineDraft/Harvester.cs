using System;
using System.Text;

public abstract class Harvester : Worker
{
    
    private double oreOutput;

    private double energyRequirement;

   

    

    public override string ToString()
    {
        var sb = new StringBuilder();
        var name = this.GetType().Name;
        sb.AppendLine($"{name.Substring(0, name.Length-9)} Harvester - {this.Id}");
        sb.AppendLine($"Ore Output: {this.oreOutput}");
        sb.Append($"Energy Requirement: {this.energyRequirement}");

        return sb.ToString().Trim();
    }

    public Harvester(string id, double oreOutput, double energyRequirement) : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;

    }


   

    public virtual double OreOutput
    {
        get => oreOutput;
        protected set
        {
            if (value < 0) throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            this.oreOutput = value;
        }
    }

    public virtual double EnergyRequirement
    {
        get => energyRequirement;
        set
        {
            if (value < 0) throw new ArgumentException($"Harvester is not registered, because of it's EnergyRequirement");
            if (value > 20000) throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            this.energyRequirement = value;
        }
        
    }

   
}

