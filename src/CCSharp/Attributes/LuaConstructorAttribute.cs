using System;
using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.Attributes;

[AttributeUsage(AttributeTargets.Constructor)]
public class LuaConstructorAttribute : RedILResolve
{
    public LuaConstructorAttribute(string name) : base(typeof(LuaClassConstructorResolver), name) { }
}