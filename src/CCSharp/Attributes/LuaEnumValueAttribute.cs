using System;
using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public class LuaEnumValueAttribute : RedILResolve
{
    public LuaEnumValueAttribute(string value) : base(typeof(EnumResolver), value) { }
    public LuaEnumValueAttribute(int value) : base(typeof(EnumResolver), value) { }
    public LuaEnumValueAttribute(object value) : base(typeof(EnumResolver), value) { }
}