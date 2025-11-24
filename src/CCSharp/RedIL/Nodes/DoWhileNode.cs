using CCSharp.RedIL.Enums;

namespace CCSharp.RedIL.Nodes;

public class DoWhileNode : RedILNode
{
    public ExpressionNode Condition { get; set; }

    public BlockNode Body { get; set; }

    public DoWhileNode()
        : base(RedILNodeType.DoWhile)
    {
    }

    public DoWhileNode(ExpressionNode condition, BlockNode body)
        : base(RedILNodeType.DoWhile)
    {
        Condition = condition;
        Body = body;
    }

    public override TReturn AcceptVisitor<TReturn, TState>(IRedILVisitor<TReturn, TState> visitor, TState state)
        => visitor.VisitDoWhileNode(this, state);
}