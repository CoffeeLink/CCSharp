using System.Collections.Generic;
using System.Linq;
using CCSharp.Enums;
using CCSharp.RedIL.Nodes;

namespace CCSharp.RedIL.Resolving.CommonResolvers;

class CallLuaBuiltinStaticMethodResolver : RedILMethodResolver
{
    private LuaBuiltinMethod _method;

    public CallLuaBuiltinStaticMethodResolver(object arg)
    {
        _method = (LuaBuiltinMethod) arg;
    }
        
    public override RedILNode Resolve(Context context, ExpressionNode caller, ExpressionNode[] arguments)
    {
        return new CallBuiltinLuaMethodNode(_method, arguments);
    }
}