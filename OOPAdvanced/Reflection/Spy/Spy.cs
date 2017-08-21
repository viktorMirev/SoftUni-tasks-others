using System;
using System.Linq;
using System.Reflection;
using System.Text;

class Spy
{
    public string StealFieldInfo(string className, params string[] namesOfFields)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Class under investigation: {className}");
        Type classType = Type.GetType(className);

        FieldInfo[] fields = classType.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (FieldInfo field in fields)
        {
            if(namesOfFields.Any(a => a == field.Name))
            {
                object instance = Activator.CreateInstance(classType);
                sb.AppendLine($"{field.Name} = {field.GetValue(instance)}");
            }
        }
        return sb.ToString();
    }

    internal string CollectGettersAndSetters(string className)
    {
        StringBuilder sb = new StringBuilder();
        Type classType = Type.GetType(className);       

        MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public |BindingFlags.NonPublic);
        foreach (var method in methods.Where(a => a.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} will return {method.ReturnType}");
        }

        foreach (MethodInfo method in methods.Where(a => a.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }
        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        StringBuilder sb = new StringBuilder();
        Type classType = Type.GetType(className);
        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (MethodInfo method in methods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();
        Type classType = Type.GetType(className);
        FieldInfo[] fields = classType.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);
        foreach (FieldInfo field in fields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (var method in privateMethods.Where(a => a.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }

        MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);
        foreach (MethodInfo method in publicMethods.Where(a => a.Name.StartsWith("set"))) 
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }
        return sb.ToString().Trim();
    }
}

