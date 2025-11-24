using System;
using System.Collections.Generic;
using CCSharp.Enums;
using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.RedIL.Resolving.Types;

class ArrayResolverPacks
{
    [RedILDataType(DataValueType.Array)]
    class ArrayProxy
    {
        [RedILResolve(typeof(CallLuaBuiltinMemberResolver), LuaBuiltinMethod.TableGetN)]
        public int Length { get; }
    }

    public static Dictionary<Type, Type> GetMapToProxy()
    {
        return new Dictionary<Type, Type>()
        {
            { typeof(Array), typeof(ArrayProxy) }
        };
    }
}