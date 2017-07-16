public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonic) : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonic;
        this.EnergyRequirement /= this.SonicFactor;
    }

    public int SonicFactor
    {
        get
        {
            return this.sonicFactor;
        }
        private set
        {
            this.sonicFactor = value;
        }
    }

    
}

  
        
    
