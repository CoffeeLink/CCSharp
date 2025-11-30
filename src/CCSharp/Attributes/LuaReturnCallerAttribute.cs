using System;
using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class LuaReturnCallerAttribute : RedILResolve
{
    public LuaReturnCallerAttribute() : base(typeof(CallCustomMethodResolver), "") { }
}