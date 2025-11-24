using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.Attributes;

public class LuaConstructorAttribute : RedILResolve
{
    public LuaConstructorAttribute(string name) : base(typeof(LuaClassConstructorResolver), name) { }
}