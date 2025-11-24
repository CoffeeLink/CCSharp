using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Nodes;

namespace CCSharp.RedIL.Resolving.CommonResolvers;

class TableAccessMemberResolver : RedILMemberResolver
{
    public DataValueType DataType { get; set; }
        
    public object Key { get; set; }

    public TableAccessMemberResolver(DataValueType valueType, object arg2)
    {
        DataType = valueType;
        Key = arg2;
    }
        
    public override ExpressionNode Resolve(Context context, ExpressionNode caller)
    {
        return new TableKeyAccessNode(caller, new ConstantValueNode(DataType, Key), context.Compiler.ResolveExpressionType(context.CurrentExpression));
    }
}