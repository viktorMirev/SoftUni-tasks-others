using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
class SoftUniAttribute : Attribute
{
    public string Name { get; set; }
    public SoftUniAttribute(string name)
    {
        this.Name = name;
    }
}

