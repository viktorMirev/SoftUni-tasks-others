public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement ) : base(id, oreOutput, energyRequirement)
    {
    }

    public override double EnergyRequirement
    {
        get => base.EnergyRequirement;
        set => base.EnergyRequirement = value * 2;
    }

    public override double OreOutput
    {
        get => base.OreOutput;
        protected set => base.OreOutput = value * 3;
    }
}

