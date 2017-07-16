using System;
using System.Text;

public abstract class Provider
{
    private string id;

    private double energyOutput;

    public override string ToString()
    {
        var sb = new StringBuilder();
        var name = this.GetType().Name;
        sb.AppendLine($"{name.Substring(0, name.Length - 8)} Provider - {this.id}");
        sb.Append($"Energy Output: {this.energyOutput}");
        return sb.ToString().Trim();

    }


    public Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    public string Id
    {
        get => id;
        protected set
        {
            this.id = value;
        }
    }

    public virtual double EnergyOutput
    {
        get => energyOutput;
        protected set
        {
            if (value <= 0) throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            if (value >= 10000) throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            this.energyOutput = value;
        }
    }

}

