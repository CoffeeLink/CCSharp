using System;

namespace CCSharp.Attributes;

public class RequireModuleAttribute : Attribute
{
    public string Module { get; set; }

    public RequireModuleAttribute(string module)
    {
        Module = module;
    }
}