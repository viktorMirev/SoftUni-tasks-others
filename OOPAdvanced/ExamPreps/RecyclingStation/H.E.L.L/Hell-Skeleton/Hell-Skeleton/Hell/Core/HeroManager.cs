using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class HeroManager : IManager
{

    private Dictionary<string, IHero> heroes;


    public Dictionary<string, IHero> Heroes { get => heroes; set => heroes = value; }

    public HeroManager()
    {
        this.Heroes = new Dictionary<string, IHero>();
    }

    public string AddHero(IList<string> arguments)
    {
        string result = null;

        string heroName = arguments[0];
        string heroType = arguments[1];

        try
        {
            Type clazz = Type.GetType(heroType);
            var constructors = clazz.GetConstructors();
            IHero hero = (IHero) constructors[0].Invoke(new object[] {heroName});
            this.heroes.Add(hero.Name, hero);

            result = string.Format($"Created {heroType} - {hero.Name}");
        }
        catch (Exception e)
        {
            return e.Message;
        }
       

        return result;
    }

    public string AddItemToHero(IList<string> arguments)
    {
        string result = null;

        //Ма те много бе!
        string itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);

        CommonItem newItem = new CommonItem(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus,
            damageBonus);

        this.heroes[heroName].AddItem(newItem);

        result = string.Format(Constants.ItemCreateMessage, newItem.Name, heroName);
        return result;
    }

    public string AddRecipeToHero(IList<string> arguments)
    {
        string result = null;

        //Ма те много бе!
        string itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);
        List<string> requiredItems = new List<string>();
        for (int i = 7; i < arguments.Count; i++)
        {
            requiredItems.Add(arguments[i]);
        }

        IRecipe newRecipe = new Recipe(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus,
            damageBonus,requiredItems);

        this.heroes[heroName].AddRecipe(newRecipe);

        result = string.Format(Constants.RecipeCreatedMessage, newRecipe.Name, heroName);
        return result;
    }

    public string Quit(IList<string> arguments)
    {
        StringBuilder sb = new StringBuilder();
        int count = 1;
        foreach (var item in this.heroes.OrderByDescending(h =>( h.Value.Strength + h.Value.Agility + h.Value.Intelligence)).ThenByDescending(h =>(h.Value.HitPoints + h.Value.Damage)))
        {
            sb.AppendLine($"{count}. {item.Value.GetType().Name}: {item.Value.Name}");
            sb.AppendLine($"###HitPoints: {item.Value.HitPoints}");
            sb.AppendLine($"###Damage: {item.Value.Damage}");
            sb.AppendLine($"###Strength: {item.Value.Strength}");
            sb.AppendLine($"###Agility: {item.Value.Agility}");
            sb.AppendLine($"###Intelligence: {item.Value.Intelligence}");
            if (item.Value.Items.Count == 0)
            {
                sb.AppendLine($"###Items: None");

            }
            else sb.AppendLine($"###Items: {string.Join(", ",item.Value.Items)}");

            count++;
        }
        return sb.ToString().Trim();
    }

    public string Inspect(IList<string> arguments)
    {
        string heroName = arguments[0];

        return this.heroes[heroName].ToString();
    }

    //Само Батман знае как работи това
    public void GenerateResult()
    {
        const string PropName = "_connectionString";

        var type = typeof(HeroCommand);

        FieldInfo fieldInfo = null;
        PropertyInfo propertyInfo = null;
        while (fieldInfo == null && propertyInfo == null && type != null)
        {
            fieldInfo = type.GetField(PropName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo == null)
            {
                propertyInfo = type.GetProperty(PropName,
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            }

            type = type.BaseType;
        }
    }

   /* public static void DontTouchThisMethod()
    {
        //това не трябва да го пипаме, че ако го махнем ще ни счупи цялата логика
        var l = new List<string>();
        var m = new Manager();
        HeroCommand cmd = new HeroCommand(l, m);
        var str = "Execute";
        Console.WriteLine(str);
    }*/
}