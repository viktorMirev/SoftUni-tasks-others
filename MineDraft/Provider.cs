using System;
using System.Text;

public abstract class Provider : Worker
{
   

    private double energyOutput;

    public override string ToString()
    {
        var sb = new StringBuilder();
        var name = this.GetType().Name;
        sb.AppendLine($"{name.Substring(0, name.Length - 8)} Provider - {base.Id}");
        sb.Append($"Energy Output: {this.energyOutput}");
        return sb.ToString().Trim();

    }


    public Provider(string id, double energyOutput) : base(id)
    {
        this.EnergyOutput = energyOutput;
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

