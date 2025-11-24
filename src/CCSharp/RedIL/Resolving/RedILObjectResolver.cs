using CCSharp.RedIL.Nodes;

namespace CCSharp.RedIL.Resolving;

public abstract class RedILObjectResolver
{
    public abstract ExpressionNode Resolve(Context context, ExpressionNode[] arguments, ExpressionNode[] elements);
}