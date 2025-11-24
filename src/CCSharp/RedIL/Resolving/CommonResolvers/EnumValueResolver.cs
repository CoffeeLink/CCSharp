using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CCSharp.RedIL.Nodes;
using CCSharp.RedIL.Resolving.Attributes;

namespace CCSharp.RedIL.Resolving.CommonResolvers;

class EnumValueResolver : RedILValueResolver
{
    private Dictionary<Enum, object> valueTable;

    public object DefaultValue { get; set; }
        
    public EnumValueResolver(Type enumType)
    {
        valueTable = Enum.GetValues(enumType).Cast<Enum>()
            .ToDictionary(
                item => item,
                item =>
                {
                    var memberInfo = item.GetType().GetMember(item.ToString()).FirstOrDefault();
                    var attribute = memberInfo?.GetCustomAttribute<RedILResolve>();
                    return attribute?.Arguments.First();
                });
        DefaultValue = valueTable[(Enum)Activator.CreateInstance(enumType)];
    }
    public override ExpressionNode Resolve(Context context, object value)
    {
        if (valueTable.TryGetValue(value as Enum, out object actualValue))
            return (ConstantValueNode) actualValue;
        throw new Exception($"Could not locate enum value for '{value}'");
    }
}
    
class EnumResolver : RedILMemberResolver
{
    private ConstantValueNode _res;

    public EnumResolver(object arg)
    {
        if(arg is int intArg) 
            _res = (ConstantValueNode) intArg;
        else if(arg is string strArg) 
            _res = (ConstantValueNode) strArg;
        else
            _res = (ConstantValueNode) arg;
    }
            
    public override ExpressionNode Resolve(Context context, ExpressionNode caller)
    {
        return _res;
    }
}