using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class AbstractHero : IHero, IComparable<AbstractHero>
{
    private string name;
    private IInventory inventory;
    private long strength;
    private long agility;
    private long intelligence;
    private long hitPoints;
    private long damage;

    protected AbstractHero(string name, int strength, int agility, int intelligence, int hitPoints, int damage)
    {
        this.Name = name;
        this.strength = strength;
        this.agility = agility;
        this.intelligence = intelligence;
        this.hitPoints = hitPoints;
        this.damage = damage;
        this.inventory = new HeroInventory();
    }

    public string Name { get => name; set => name = value; }

    public long Strength
    {
        get { return this.strength + this.inventory.TotalStrengthBonus; }
        set { this.strength = value; }
    }

    public long Agility
    {
        get { return this.agility + this.inventory.TotalAgilityBonus; }
        set { this.agility = value; }
    }

    public long Intelligence
    {
        get { return this.intelligence + this.inventory.TotalIntelligenceBonus; }
        set { this.intelligence = value; }
    }

    public long HitPoints
    {
        get { return this.hitPoints + this.inventory.TotalHitPointsBonus; }
        set { this.hitPoints = value; }
    }

    public long Damage
    {
        get { return this.damage + this.inventory.TotalDamageBonus; }
        set { this.damage = value; }
    }

    public long PrimaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    public long SecondaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    //REFLECTION
    public ICollection<IItem> Items
    {
        get
        {
            Type absHeroType = typeof(HeroInventory);

            FieldInfo[] allFields = absHeroType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo currField = allFields.First(f => f.GetCustomAttributes(true).First().GetType() == typeof(ItemAttribute));

             var res = (Dictionary<string, IItem>)currField.GetValue(this.inventory);

            IList<IItem> result = new List<IItem>();

            foreach (var item in res)
            {
                result.Add(item.Value);
            }

            return (ICollection<IItem>) result;
        }
    }


    public void AddRecipe(IRecipe recipe)
    {
        this.inventory.AddRecipeItem(recipe);
    }

    public void AddItem(IItem item)
    {
        this.inventory.AddCommonItem(item);
    }


    public int CompareTo(AbstractHero other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if (ReferenceEquals(null, other))
        {
            return 1;
        }
        var primary = this.PrimaryStats.CompareTo(other.PrimaryStats);
        if (primary != 0)
        {
            return primary;
        }
        return this.SecondaryStats.CompareTo(other.SecondaryStats);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Hero: {this.name}, Class: {this.GetType().Name}");
        sb.AppendLine($"HitPoints: {this.HitPoints}, Damage: {this.Damage}");
        sb.AppendLine($"Strength: {this.Strength}");
        sb.AppendLine($"Agility: {this.Agility}");
        sb.AppendLine($"Intelligence: {this.Intelligence}");
        if (this.Items.Count == 0) sb.AppendLine("Items: None");
        else
        {
            sb.AppendLine("Items:");
            foreach (var item in this.Items)
            {
                sb.AppendLine($"###Item: {item.Name}");
                sb.AppendLine($"###+{item.StrengthBonus} Strength");
                sb.AppendLine($"###+{item.AgilityBonus} Agility");
                sb.AppendLine($"###+{item.IntelligenceBonus} Intelligence");
                sb.AppendLine($"###+{item.HitPointsBonus} HitPoints");
                sb.AppendLine($"###+{item.DamageBonus} Damage");
            }
        }

        return sb.ToString().Trim();

    }
}