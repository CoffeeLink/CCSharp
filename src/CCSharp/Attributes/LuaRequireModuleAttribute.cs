using System;

namespace CCSharp.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class LuaRequireModuleAttribute : Attribute
{
    public string Module { get; set; }
    public string Variable { get; set; }

    public LuaRequireModuleAttribute(string module)
    {
        Module = module;
        Variable = module;
    }

    public LuaRequireModuleAttribute(string module, string variable)
    {
        Module = module;
        Variable = variable;
    }
}