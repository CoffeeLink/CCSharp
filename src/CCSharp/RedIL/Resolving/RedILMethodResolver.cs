using CCSharp.RedIL.Nodes;

namespace CCSharp.RedIL.Resolving;

public abstract class RedILMethodResolver
{
    public abstract RedILNode Resolve(Context context, ExpressionNode caller, ExpressionNode[] arguments);
}