using CCSharp.RedIL.Enums;

namespace CCSharp.RedIL.Nodes;

public class IteratorLoopNode : RedILNode
{
    public DataValueType CursorType { get; set; }

    public string CursorName { get; set; }

    public (string,string) KeyValueNames { get; set; }

    public ExpressionNode Over { get; set; }

    public BlockNode Body { get; set; }

    public IteratorLoopNode()
        : base(RedILNodeType.IteratorLoop)
    {
    }

    public IteratorLoopNode(
        string cursorName,
        ExpressionNode over,
        BlockNode body)
        : base(RedILNodeType.IteratorLoop)
    {
        CursorName = cursorName;
        Over = over;
        Body = body;
    }

    public IteratorLoopNode(
        (string,string) keyValueNames,
        ExpressionNode over,
        BlockNode body)
        : base(RedILNodeType.IteratorLoop)
    {
        KeyValueNames = keyValueNames;
        Over = over;
        Body = body;
    }

    public override TReturn AcceptVisitor<TReturn, TState>(IRedILVisitor<TReturn, TState> visitor, TState state)
        => visitor.VisitIteratorLoopNode(this, state);
}