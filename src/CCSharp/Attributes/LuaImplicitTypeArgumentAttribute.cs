using System;

namespace CCSharp.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class LuaImplicitTypeArgumentAttribute : Attribute
{
    public string Argument { get; set; }

    public LuaImplicitTypeArgumentAttribute(string argument)
    {
        Argument = argument;
    }
}