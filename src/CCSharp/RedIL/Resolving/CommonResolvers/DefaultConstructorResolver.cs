using System.Collections.Generic;
using System.Linq;
using CCSharp.RedIL.Nodes;

namespace CCSharp.RedIL.Resolving.CommonResolvers;

class DefaultConstructorResolver : RedILObjectResolver
{
    public override ExpressionNode Resolve(Context context, ExpressionNode[] arguments, ExpressionNode[] elements)
    {
        return new DictionaryTableDefinitionNode(elements.Select(e => e as ArrayTableDefinitionNode)
            .Select(e => new KeyValuePair<ExpressionNode, ExpressionNode>(e.Elements[0], e.Elements[1]))
            .ToList());
    }
}