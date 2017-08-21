
using System;

public class CommonItem : IItem
{
    private string name;
    private long strenghtBonus;
    private long agilityBonus;
    private long intelligenceBonus;
    private long hitPointsBonus;
    private long damageBonus;

    public CommonItem(string name, long strenghtBonus,long agilityBonus, long intelBonus,long hPointsBonus, long damageB )
    {
        this.Name = name;
        this.StrengthBonus = strenghtBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelBonus;
        this.HitPointsBonus = hPointsBonus;
        this.DamageBonus = damageB;
    }

    public string Name { get => name; set => name = value; }

    public long StrengthBonus { get => strenghtBonus; set => strenghtBonus = value; }

    public long AgilityBonus { get => agilityBonus; set => agilityBonus = value; }

    public long IntelligenceBonus { get => intelligenceBonus; set => intelligenceBonus = value; }

    public long HitPointsBonus { get => hitPointsBonus; set => hitPointsBonus = value; }

    public long DamageBonus { get => damageBonus; set => damageBonus = value; }

    public override string ToString()
    {
        return this.name;
    }

}

