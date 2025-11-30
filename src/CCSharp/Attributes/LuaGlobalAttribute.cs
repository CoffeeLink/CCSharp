using System;
using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class LuaGlobalAttribute : RedILResolve
{
    public LuaGlobalAttribute(string member) : base(typeof(CallCustomMemberResolver), member) { }
}