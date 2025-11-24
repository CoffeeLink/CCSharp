using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.Attributes;

public class LuaReturnCallerAttribute : RedILResolve
{
    public LuaReturnCallerAttribute() : base(typeof(CallCustomMethodResolver), "") { }
}