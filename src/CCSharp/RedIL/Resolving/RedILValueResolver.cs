using CCSharp.RedIL.Nodes;

namespace CCSharp.RedIL.Resolving;

public abstract class RedILValueResolver
{
    public abstract ExpressionNode Resolve(Context context, object value);
}