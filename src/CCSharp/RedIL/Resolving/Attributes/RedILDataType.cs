using System;
using CCSharp.RedIL.Enums;

namespace CCSharp.RedIL.Resolving.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
class RedILDataType : Attribute
{
    public DataValueType Type { get; }

    public RedILDataType(DataValueType type)
    {
        Type = type;
    }
}