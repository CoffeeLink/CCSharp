using System.Collections.Generic;
using CCSharp.RedIL.Enums;

namespace CCSharp.RedIL.Nodes;

public class IfNode : RedILNode
{
    public IList<KeyValuePair<ExpressionNode, RedILNode>> Ifs { get; set; }

    public RedILNode IfElse { get; set; }

    public IfNode() : base(RedILNodeType.If)
    {
        Ifs = new List<KeyValuePair<ExpressionNode, RedILNode>>();
    }

    public IfNode(
        IList<KeyValuePair<ExpressionNode, RedILNode>> ifs,
        RedILNode ifElse)
        : base(RedILNodeType.If)
    {
        Ifs = ifs;
        IfElse = ifElse;
    }

    public override TReturn AcceptVisitor<TReturn, TState>(IRedILVisitor<TReturn, TState> visitor, TState state)
        => visitor.VisitIfNode(this, state);
}