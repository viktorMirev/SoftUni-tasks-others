using System;
using System.Collections.Generic;
using System.Text;

public class DraftManager
{
    private double totalEnergyStored;
    private double totalMinedOre;

    private string mode;

    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;

    public DraftManager()
    {
        this.totalMinedOre = 0;
        this.totalEnergyStored = 0;
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.mode = "Full";
    }



    public string RegisterHarvester(List<string> arguments)
    {
        
       if (arguments[0] == "Sonic")
       {
            try
            {
                this.harvesters.Add(arguments[1], new SonicHarvester(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3]), int.Parse(arguments[4])));
                return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";
            }
            catch(Exception e)
            {
                return e.Message;
            }
       }
       else
       {

            try
            {
                this.harvesters.Add(arguments[1], new HammerHarvester(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3])));
                return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";
            }
            catch(Exception e)
            {
                return e.Message;
            }
            
       }
          
        
        
        
    }
    public string RegisterProvider(List<string> arguments)
    {
        if (arguments[0] == "Pressure")
        {
            try
            {
                this.providers.Add(arguments[1], new PressureProvider(arguments[1], double.Parse(arguments[2])));
                return $"Successfully registered {arguments[0]} Provider - {arguments[1]}";
            }
            catch(Exception e)
            {
                return e.Message;
            }

        }
        else
        {
            try
            {
                this.providers.Add(arguments[1], new SolarProvider(arguments[1], double.Parse(arguments[2])));
                return $"Successfully registered {arguments[0]} Provider - {arguments[1]}";
            }
            catch(Exception e)
            {
                return e.Message;
            }

        }
       
    }
    public string Day()
    {
        double currEnergyProduced = 0;
        foreach(var prov in providers)
        {
            currEnergyProduced += prov.Value.EnergyOutput;
        }
        totalEnergyStored += currEnergyProduced;
        if(this.mode == "Energy")
        {
            var sbE = new StringBuilder();
            sbE.AppendLine("A day has passed.");
            sbE.AppendLine($"Energy Provided: {currEnergyProduced}");
            sbE.AppendLine($"Plumbus Ore Mined: 0");

            return sbE.ToString().Trim();
        }
        double currEnergyNeed = 0;
        double currOreMined = 0;
        if (this.mode == "Half")
        {
            foreach(var harv in harvesters)
            {

                currEnergyNeed += 0.6 * harv.Value.EnergyRequirement;
            }
            if (currEnergyNeed <= totalEnergyStored)
            {
                foreach (var harv in harvesters)
                {

                    currOreMined += 0.5* harv.Value.OreOutput;
                }
                totalMinedOre += currOreMined;
                totalEnergyStored -= currEnergyNeed;
            }
        }
        if(this.mode == "Full")
        {
            foreach (var harv in harvesters)
            {

                currEnergyNeed += harv.Value.EnergyRequirement;
            }
            if (currEnergyNeed <= totalEnergyStored)
            {
                foreach (var harv in harvesters)
                {

                    currOreMined += harv.Value.OreOutput;
                }
                totalMinedOre += currOreMined;
                totalEnergyStored -= currEnergyNeed;
            }
        }

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {currEnergyProduced}");
        sb.AppendLine($"Plumbus Ore Mined: {currOreMined}");

        return sb.ToString().Trim();
    }
    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }
    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        if (providers.ContainsKey(id))
        {
            return providers[id].ToString();
        }
        else if (harvesters.ContainsKey(id))
        {
            return harvesters[id].ToString();
        }
        else
        {
            return $"No element found with id - {id}";
        }
    }
    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {totalEnergyStored}");
        sb.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");
        return sb.ToString().Trim();
    }

}
