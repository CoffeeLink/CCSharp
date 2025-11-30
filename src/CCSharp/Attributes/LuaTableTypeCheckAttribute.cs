using System;

namespace CCSharp.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class LuaTableTypeCheckAttribute : Attribute
{
    public string Method { get; set; }
    public object TableAccessor { get; set; }
}