using System.Collections.Generic;
using CCSharp.Enums;
using CCSharp.RedIL.Nodes;

namespace CCSharp.RedIL.Resolving.CommonResolvers;

class CallLuaBuiltinMemberResolver : RedILMemberResolver
{
    private LuaBuiltinMethod _method;

    public CallLuaBuiltinMemberResolver(object arg)
    {
        _method = (LuaBuiltinMethod) arg;
    }
        
    public override ExpressionNode Resolve(Context context, ExpressionNode caller)
    {
        return new CallBuiltinLuaMethodNode(_method, new List<ExpressionNode>() {caller});
    }
}