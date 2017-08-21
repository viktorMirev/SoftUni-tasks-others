using System;
using System.Collections.Generic;

namespace OOPadv
{
    [Weapon("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", new string[]{ "Pesho", "Svetlio" })]
    public class Weapon
    {
        private WeaponType type;
        private WeaponMin minDamage;
        private WeaponMax maxDamage;
        private Rarity rarity;
        private List<MagicStone> stones;

        public string Name { get; private set; }

        public Weapon(string name, string type, string rarity)
        {
            this.Name = name;
            Enum.TryParse<WeaponType>(type, out this.type);
            Enum.TryParse<WeaponMin>(type, out this.minDamage);
            Enum.TryParse<WeaponMax>(type, out this.maxDamage);
            Enum.TryParse<Rarity>(rarity, out this.rarity);

            stones = new List<MagicStone>((int)this.type);
            for (int i = 0; i < (int)this.type; i++)
            {
                stones.Add(null);
            }
        }

        public void AddStone(MagicStone currStone, int index)
        {
            if (index >= 0 && index < (int)this.type)
            {
                stones[index] = currStone;
            }
        }

        public void RemoveStone(int index)
        {
            if (index >= 0 && index < (int)this.type)
            {
                stones[index] = null;
            }
        }


        public void Print()
        {
            var currMinDamage = (int)this.minDamage * (int)this.rarity;
            var currMaxDamage = (int)this.maxDamage * (int)this.rarity;

            int overallMaxDamageBonus = 0;
            int overallMinDamageBonus = 0;
            int Strenght = 0;
            int Agility = 0;
            int Vitality = 0;

            foreach (var stone in stones)
            {
                if (stone != null)
                {
                    Strenght += stone.Strenght();
                    Agility += stone.Agility();
                    Vitality += stone.Vitality();
                }
            }
            overallMinDamageBonus += 2 * Strenght;
            overallMaxDamageBonus += 3 * Strenght;

            overallMinDamageBonus += Agility;
            overallMaxDamageBonus += 4 * Agility;

            currMinDamage += overallMinDamageBonus;
            currMaxDamage += overallMaxDamageBonus;

            Console.WriteLine($"{this.Name}: {currMinDamage}-{currMaxDamage} Damage, +{Strenght} Strength, +{Agility} Agility, +{Vitality} Vitality");
        }

    }
}
