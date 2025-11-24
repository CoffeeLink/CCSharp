using System;
using System.Collections.Generic;
using CCSharp.Attributes;
using CCSharp.Enums;
using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Nodes;
using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.RedIL.Resolving.Types;

public class ObjectResolverPack
{
    class GetTypeResolver : RedILMethodResolver
    {
        public override RedILNode Resolve(Context context, ExpressionNode caller, ExpressionNode[] arguments)
        {
            return new TableKeyAccessNode(new TableKeyAccessNode(caller, new ConstantValueNode(DataValueType.String, "_CSharpTypes"), DataValueType.Array), new ConstantValueNode(DataValueType.Integer, 1), DataValueType.String);
        }
    }
    class ObjectProxy
    {
        [LuaReturnCaller]
        public string ToString() => default;
        
        [RedILResolve(typeof(GetTypeResolver))]
        public Type GetType() => default;
    }
        
    public static Dictionary<Type, Type> GetMapToProxy()
    {
        return new Dictionary<Type, Type>()
        {
            { typeof(object), typeof(ObjectProxy) }
        };
    }
}