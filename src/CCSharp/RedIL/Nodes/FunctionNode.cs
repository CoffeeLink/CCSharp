using System.Collections.Generic;
using System.Linq;
using CCSharp.RedIL.Enums;

namespace CCSharp.RedIL.Nodes;

public class FunctionNode : ExpressionNode
{
    public string Name { get; set; }
    public IList<RedILNode> Parameters { get; set; }
    public RedILNode Body { get; set; }

    public FunctionNode(string name, IList<RedILNode> parameters, RedILNode body)
        : base(RedILNodeType.LuaFunction, DataValueType.Unknown)
    {
        Name = name;
        Parameters = parameters;
        Body = body;
    }

    public FunctionNode(IList<RedILNode> parameters, RedILNode body)
        : base(RedILNodeType.LuaFunction, DataValueType.Unknown)
    {
        Parameters = parameters;
        Body = body;
    }

    public override TReturn AcceptVisitor<TReturn, TState>(IRedILVisitor<TReturn, TState> visitor, TState state)
        => visitor.VisitFunctionNode(this, state);

    public override bool Equals(ExpressionNode other)
    {
        return other is FunctionNode node && node.Body.Equals(Body) && Parameters.SequenceEqual(Parameters);
    }

    public override ExpressionNode Simplify() => this;
}