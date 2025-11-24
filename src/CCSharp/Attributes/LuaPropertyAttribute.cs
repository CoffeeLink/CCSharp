using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.Attributes;

public class LuaPropertyAttribute : RedILResolve
{
    public LuaPropertyAttribute(string key) : base(typeof(TableAccessMemberResolver), DataValueType.String, key) { }
    public LuaPropertyAttribute(int index) : base(typeof(TableAccessMemberResolver), DataValueType.Integer, index) { }
}