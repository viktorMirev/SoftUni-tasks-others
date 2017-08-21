
using System;
using System.Collections.Generic;

public class Recipe : IRecipe
{
    
    private string name;
    private long strenghtBonus;
    private long agilityBonus;
    private long intelligenceBonus;
    private long hitPointsBonus;
    private long damageBonus;
    private IList<string> requiredItems;


    public Recipe(string name, long strenghtBonus, long agilityBonus, long intelBonus, long hPointsBonus, long damageB, IList<string> requiredItems)
    {
        this.Name = name;
        this.StrengthBonus = strenghtBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelBonus;
        this.HitPointsBonus = hPointsBonus;
        this.DamageBonus = damageB;
        this.RequiredItems = requiredItems;
    }

    public string Name { get => name; set => name = value; }

    public long StrengthBonus { get => strenghtBonus; set => strenghtBonus = value; }

    public long AgilityBonus { get => agilityBonus; set => agilityBonus = value; }

    public long IntelligenceBonus { get => intelligenceBonus; set => intelligenceBonus = value; }

    public long HitPointsBonus { get => hitPointsBonus; set => hitPointsBonus = value; }

    public long DamageBonus { get => damageBonus; set => damageBonus = value; }

    public IList<string> RequiredItems { get => requiredItems; set => requiredItems = value; }

    public override string ToString()
    {
        return this.name;
    }
}

