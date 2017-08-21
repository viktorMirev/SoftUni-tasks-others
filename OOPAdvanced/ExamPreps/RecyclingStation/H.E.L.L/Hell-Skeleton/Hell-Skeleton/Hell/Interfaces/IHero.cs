﻿using System.Collections.Generic;

public interface IHero
{
    string Name { get; }
    ICollection<IItem> Items { get; }
    long Strength { get; }
    long Agility { get; }
    long Intelligence { get; }
    long HitPoints { get; }
    long Damage { get; }
    void AddRecipe(IRecipe recipe);
    void AddItem(IItem item);



}
