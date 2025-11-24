using CCSharp.RedIL.Nodes;
using ICSharpCode.Decompiler.Util;

namespace CCSharp.RedIL;

public interface IRedILVisitor<TReturn, TState>
{
    TReturn VisitRootNode(RootNode node, TState state);
    TReturn VisitAssignNode(AssignNode node, TState state);
    TReturn VisitBinaryExpressionNode(BinaryExpressionNode node, TState state);
    TReturn VisitBlockNode(BlockNode node, TState state);
    TReturn VisitBreakNode(BreakNode node, TState state);
    TReturn VisitCastNode(CastNode node, TState state);
    TReturn VisitConditionalExpressionNode(ConditionalExpressionNode node, TState state);
    TReturn VisitConstantValueNode(ConstantValueNode node, TState state);
    TReturn VisitDoWhileNode(DoWhileNode node, TState state);
    TReturn VisitEmptyNode(EmptyNode node, TState state);
    TReturn VisitIdentifierNode(IdentifierNode node, TState state);
    TReturn VisitTemporaryIdentifierNode(TemporaryIdentifierNode node, TState state);
    TReturn VisitIfNode(IfNode node, TState state);
    TReturn VisitNilNode(NilNode node, TState state);
    TReturn VisitReturnNode(ReturnNode node, TState state);
    TReturn VisitStatusNode(StatusNode node, TState state);
    TReturn VisitTableAccessNode(TableKeyAccessNode node, TState state);
    TReturn VisitUnaryExpressionNode(UnaryExpressionNode node, TState state);
    TReturn VisitUniformOperatorNode(UniformOperatorNode node, TState state);
    TReturn VisitVariableDeclareNode(VariableDeclareNode node, TState state);
    TReturn VisitWhileNode(WhileNode node, TState state);
    TReturn VisitCallBuiltinLuaMethodNode(CallBuiltinLuaMethodNode node, TState state);
    TReturn VisitCallCustomMethodNode(CallCustomMethodNode node, TState state);
    TReturn VisitCallCustomMemberNode(CallCustomMemberNode node, TState state);
    TReturn VisitChainedModuleMethodNode(ChainedModuleMethodNode node, TState state);
    TReturn VisitCallLuaFunctionNode(CallLuaFunctionNode node, TState state);
    TReturn VisitArrayTableDefinitionNode(ArrayTableDefinitionNode node, TState state);
    TReturn VisitDictionaryTableDefinition(DictionaryTableDefinitionNode node, TState state);
    TReturn VisitIteratorLoopNode(IteratorLoopNode node, TState state);
    TReturn VisitFunctionNode(FunctionNode node, TState state);
}