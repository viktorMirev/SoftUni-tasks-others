﻿using System;
using System.Collections.Generic;

public interface IManager
{
    Dictionary<string, IHero> Heroes { get; }

    string AddHero(IList<string> arguments);

    string AddItemToHero(IList<string> arguments);

    string AddRecipeToHero(IList<string> arguments);

    string Inspect(IList<string> arguments);

    string Quit(IList<string> arguments);

}