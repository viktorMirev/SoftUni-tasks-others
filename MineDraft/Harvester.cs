using System;
using System.Text;

public abstract class Harvester
{
    private string id;

    private double oreOutput;

    private double energyRequirement;

    private string type;

    

    public override string ToString()
    {
        var sb = new StringBuilder();
        var name = this.GetType().Name;
        sb.AppendLine($"{name.Substring(0, name.Length-9)} Harvester - {this.id}");
        sb.AppendLine($"Ore Output: {this.oreOutput}");
        sb.Append($"Energy Requirement: {this.energyRequirement}");

        return sb.ToString().Trim();
    }

    public Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;

    }


    public string Id
    {
        get => id;
        protected set
        {
            this.id = value;
        }
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

    public string Type { get => type; set => type = value; }
}

