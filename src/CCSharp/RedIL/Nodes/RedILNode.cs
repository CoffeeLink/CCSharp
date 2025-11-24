using CCSharp.RedIL.Enums;

namespace CCSharp.RedIL.Nodes;

public abstract class RedILNode
{
    public RedILNode Parent { get; set; }

    public RedILNodeType Type { get; }

    protected RedILNode(RedILNodeType type)
    {
        Type = type;
    }

    public abstract TReturn AcceptVisitor<TReturn, TState>(IRedILVisitor<TReturn, TState> visitor, TState state);
}