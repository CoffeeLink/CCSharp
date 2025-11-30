using System;
using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class LuaMethodAttribute : RedILResolve
{
    public LuaMethodAttribute(string method) : base(typeof(CallCustomMethodResolver), method) { }
    public LuaMethodAttribute(string method, CallMethodFlags flags) : base(typeof(CallCustomMethodResolver), method, flags) { }
}