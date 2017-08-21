
using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class StartUp
{
    public static void Main()
    {
        Type blackBox = typeof(BlackBoxInt);

        ConstructorInfo ctor = blackBox.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { },null);
        BlackBoxInt myBlacBox = (BlackBoxInt)ctor.Invoke(new object[]{ });

        string line;
        while((line = Console.ReadLine())!= "END")
        {
            var tokens = line.Split('_');
            var name = tokens[0];
            int value = int.Parse(tokens[1]);

            MethodInfo curMethod = blackBox.GetMethod(name, BindingFlags.Instance | BindingFlags.NonPublic);
            curMethod.Invoke(myBlacBox, new object[] { value});

            FieldInfo[] fields = blackBox.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            var currField = fields.First();

            Console.WriteLine(currField.GetValue(myBlacBox));
        }

    }
}