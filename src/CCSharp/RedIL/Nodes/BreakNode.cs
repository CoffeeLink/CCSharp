using CCSharp.RedIL.Enums;

namespace CCSharp.RedIL.Nodes;

public class BreakNode : RedILNode
{
    public BreakNode()
        : base(RedILNodeType.Break)
    { }

    public override TReturn AcceptVisitor<TReturn, TState>(IRedILVisitor<TReturn, TState> visitor, TState state)
        => visitor.VisitBreakNode(this, state);
}