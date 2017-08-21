using System;
using System.Collections.Generic;

namespace OOPadv
{
    class Engine
    {
        public void Run()
        {
            var weapons = new Dictionary<string, Weapon>();
            var line = Console.ReadLine();
            while (line != "END")
            {
                var tokens = line.Split(';');
                string name;
                string[] data;
                int index;
                switch (tokens[0])
                {
                    case "Create":
                        data = tokens[1].Split();
                        var rarity = data[0];
                        var type = data[1];
                        name = tokens[2];
                        weapons.Add(name, new Weapon(name, type, rarity));
                        break;
                    case "Add":
                        name = tokens[1];
                        index = int.Parse(tokens[2]);
                        data = tokens[3].Split();
                        var clarity = data[0];
                        var stType = data[1];
                        weapons[name].AddStone(new MagicStone(stType, clarity), index);
                        break;
                    case "Remove":
                        name = tokens[1];
                        index = int.Parse(tokens[2]);
                        weapons[name].RemoveStone(index);
                        break;
                    case "Print":
                        name = tokens[1];
                        weapons[name].Print();
                        break;

                }

                line = Console.ReadLine();
            }
        }
    }
}
