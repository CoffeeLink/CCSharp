using System;

namespace CCSharp.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class LuaTableTypeCheckAttribute : Attribute
{
    public string Method { get; set; }
    public object TableAccessor { get; set; }
}