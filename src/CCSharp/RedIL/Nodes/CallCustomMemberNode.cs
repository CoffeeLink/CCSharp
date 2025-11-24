using System.Collections.Generic;
using System.Linq;
using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Extensions;

namespace CCSharp.RedIL.Nodes;

public class CallCustomMemberNode : ExpressionNode
{
    public string Member { get; set; }

    public CallCustomMemberNode(
        string member)
        : base(RedILNodeType.CallLuaMethod)
    {
        Member = member;
    }

    public override TReturn AcceptVisitor<TReturn, TState>(IRedILVisitor<TReturn, TState> visitor, TState state)
        => visitor.VisitCallCustomMemberNode(this, state);

    public override bool Equals(ExpressionNode other)
    {
        if (!(other is CallCustomMemberNode)) return false;
        var callLuaMethod = (CallCustomMemberNode) other;
        return Member == callLuaMethod.Member;
    }

    public override ExpressionNode Simplify() => new CallCustomMemberNode(Member);
}