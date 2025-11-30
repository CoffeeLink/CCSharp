using System;
using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.Attributes;

[AttributeUsage(AttributeTargets.Enum)]
public class LuaEnumAttribute : RedILResolve
{
    public LuaEnumAttribute(Type enumType) : base(typeof(EnumValueResolver), enumType) { }
}