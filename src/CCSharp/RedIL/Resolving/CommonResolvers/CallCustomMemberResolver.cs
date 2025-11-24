using CCSharp.RedIL.Nodes;
using NotImplementedException = System.NotImplementedException;

namespace CCSharp.RedIL.Resolving.CommonResolvers;

class CallCustomMemberResolver : RedILMemberResolver
{
    private string _member;

    public CallCustomMemberResolver(string arg)
    {
        _member = arg;
    }
    
    public override ExpressionNode Resolve(Context context, ExpressionNode caller)
    {
        return new CallCustomMemberNode(_member);
    }
}