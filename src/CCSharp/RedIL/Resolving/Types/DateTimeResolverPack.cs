using System;
using System.Collections.Generic;
using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Resolving.Attributes;

namespace CCSharp.RedIL.Resolving.Types;

class DateTimeResolverPack
{
    [RedILDataType(DataValueType.Float)]
    class DateTimeProxy
    {
            
    }
        
    public static Dictionary<Type, Type> GetMapToProxy()
    {
        return new Dictionary<Type, Type>()
        {
            { typeof(DateTime), typeof(DateTimeProxy) }
        };
    }
}