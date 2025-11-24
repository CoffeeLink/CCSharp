using System.Collections.Generic;
using System.Linq;
using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Extensions;

namespace CCSharp.RedIL.Nodes;

public class ChainedModuleMethodNode : ExpressionNode
{
    public string Method { get; set; }
    public string Wrapping { get; set; }
    public ExpressionNode Caller { get; set; }
    public IList<ExpressionNode> Arguments { get; set; }

    public ChainedModuleMethodNode(
        string method,
        string wrapping,
        ExpressionNode caller, IList<ExpressionNode> arguments)
        : base(RedILNodeType.CallLuaMethod)
    {
        Method = method;
        Caller = caller;
        Wrapping = wrapping;
        Arguments = arguments;
    }

    public override TReturn AcceptVisitor<TReturn, TState>(IRedILVisitor<TReturn, TState> visitor, TState state)
        => visitor.VisitChainedModuleMethodNode(this, state);

    public override bool Equals(ExpressionNode other)
    {
        if (!(other is ChainedModuleMethodNode)) return false;
        var otherNode = (ChainedModuleMethodNode) other;
        return Method == otherNode.Method && Wrapping == otherNode.Wrapping && Caller.Equals(otherNode.Caller) && Arguments.AllEqual(otherNode.Arguments);
    }

    public override ExpressionNode Simplify() => new ChainedModuleMethodNode(Method, Wrapping, Caller, Arguments.Select(arg => arg.Simplify()).ToList());
}