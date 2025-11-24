using System;
using System.Collections.Generic;
using System.Linq;
using CCSharp.RedIL.Enums;
using CCSharp.Enums;
using CCSharp.RedIL.Extensions;

namespace CCSharp.RedIL.Nodes;

public class CallCustomMethodNode : ExpressionNode
{
    public ExpressionNode Caller { get; set; }
    public string Method { get; set; }
    public string SourceLuaClass { get; set; }
    public bool WrapAsTable { get; set; }

    public IList<ExpressionNode> Arguments { get; set; }

    public CallCustomMethodNode()
        : base(RedILNodeType.CallLuaMethod)
    {
        Arguments = new List<ExpressionNode>();
    }

    public CallCustomMethodNode(
        string method,
        ExpressionNode caller,
        string sourceLuaClass,
        bool wrapAsTable,
        IList<ExpressionNode> arguments)
        : base(RedILNodeType.CallLuaMethod)
    {
        Method = method;
        Caller = caller;
        SourceLuaClass = sourceLuaClass;
        Arguments = arguments;
        WrapAsTable = wrapAsTable;
    }

    public override TReturn AcceptVisitor<TReturn, TState>(IRedILVisitor<TReturn, TState> visitor, TState state)
        => visitor.VisitCallCustomMethodNode(this, state);

    public override bool Equals(ExpressionNode other)
    {
        if (!(other is CallCustomMethodNode)) return false;
        var callLuaMethod = (CallCustomMethodNode) other;
        return Method == callLuaMethod.Method && ((object)Caller == (object)callLuaMethod.Caller) && WrapAsTable == callLuaMethod.WrapAsTable && Arguments.AllEqual(callLuaMethod.Arguments);
    }

    public override ExpressionNode Simplify() => new CallCustomMethodNode(Method, Caller, SourceLuaClass, WrapAsTable, Arguments.Select(arg => arg.Simplify()).ToList());
}