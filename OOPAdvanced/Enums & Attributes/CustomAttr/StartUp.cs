using OOPadv;
using System;

public class StartUp
{
    public static void Main()
    {
        // Engine engine = new Engine();
        // engine.Run();

        var type = typeof(Weapon);
        var tokens = type.GetCustomAttributes(false);
        WeaponAttribute myAttr = (WeaponAttribute)tokens[0];

        var line = Console.ReadLine();
        while (line != "END")
        {
            switch (line)
            {
                case "Author":
                    Console.WriteLine(myAttr.Author());
                    break;
                case "Revision":
                    Console.WriteLine(myAttr.Revision());
                    break;
                case "Description":
                    Console.WriteLine(myAttr.Description());
                    break;
                case "Reviewers":
                    Console.WriteLine(myAttr.Rewiewers());
                    break;
            }
            line = Console.ReadLine();
        }
    }
}