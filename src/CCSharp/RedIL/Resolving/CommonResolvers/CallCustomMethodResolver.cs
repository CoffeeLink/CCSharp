using System;
using System.Collections.Generic;
using CCSharp.RedIL.Nodes;

namespace CCSharp.RedIL.Resolving.CommonResolvers;

[Flags]
public enum CallMethodFlags
{
    None,
    WrapAsTable = 1 << 0,
    ImplicitReturnTypeArgument = 1 << 1,
    UnwrapTableIntoArguments = 1 << 2,
}
class CallCustomMethodResolver : RedILMethodResolver
{
    public string Method { get; set; }
    public CallMethodFlags Flags { get; set; }
    public string SourceLuaClass { get; set; }

    public CallCustomMethodResolver(string method)
    {
        Method = method;
        Flags = CallMethodFlags.None;
    }

    public CallCustomMethodResolver(string method, bool wrapAsTable)
    {
        Method = method;
        Flags = wrapAsTable ? CallMethodFlags.WrapAsTable : CallMethodFlags.None;
    }

    public CallCustomMethodResolver(string method, CallMethodFlags flags)
    {
        Method = method;
        Flags = flags;
    }
    
    public override RedILNode Resolve(Context context, ExpressionNode caller, ExpressionNode[] arguments)
    {
        if ((Flags & CallMethodFlags.UnwrapTableIntoArguments) != 0) //TODO Decide if I want this to apply to the first or last argument, for now only used in cases where there is a single arg
            arguments[0] = new CallCustomMethodNode("table.unpack", null, null, false, new List<ExpressionNode> { arguments[0] });
        return new CallCustomMethodNode(Method, caller, SourceLuaClass, (Flags & CallMethodFlags.WrapAsTable) != 0, arguments);
    }
}