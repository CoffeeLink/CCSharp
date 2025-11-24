using System;
using System.Collections.Generic;
using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Nodes;
using ICSharpCode.Decompiler.CSharp.Syntax;

namespace CCSharp.RedIL.Resolving.CommonResolvers;

class CallCustomMethodWithParametersInStringResolver : RedILMethodResolver
{
    private string _method;
    private bool _wrapAsTable;
    private string _parameterString;

    public CallCustomMethodWithParametersInStringResolver(string method, string parameterString)
    {
        _method = method;
        _wrapAsTable = false;
        _parameterString = parameterString;
    }

    public CallCustomMethodWithParametersInStringResolver(string method, string parameterString, bool wrapAsTable)
    {
        _method = method;
        _wrapAsTable = wrapAsTable;
        _parameterString = parameterString;
    }
        
    public override RedILNode Resolve(Context context, ExpressionNode caller, ExpressionNode[] arguments)
    {
        string remainingString = _parameterString;
        ExpressionNode currentExpression = ExpressionNode.Nil;
        bool needsInitialExpression = true;
        //ExpressionNode currentExpression = new ConstantValueNode(DataValueType.String, _parameterString);
        while (true)
        {
            int nextReplaceIndex = remainingString.IndexOf("$ARG");
            if (nextReplaceIndex < 0) break;
            string leftSide = remainingString.Substring(0, nextReplaceIndex);
            string rightSide = remainingString.Substring(nextReplaceIndex+4);
            int indexEnd = rightSide.IndexOf('_');
            int index = int.Parse(rightSide.Substring(0, indexEnd));
            rightSide = rightSide.Substring(indexEnd+1);
            if (rightSide.StartsWith("VAR") )
            {
                if(arguments[index] is IdentifierNode identifierNode) 
                    remainingString = remainingString.Replace($"$ARG{index}_VAR", identifierNode.Name);
                else
                    remainingString = remainingString.Replace($"$ARG{index}_VAR", arguments[index].ToString());
                continue;
            }
            if (rightSide.StartsWith("VAL"))
            {
                rightSide = rightSide.Substring(3);
                ExpressionNode addLeftWithVal = new BinaryExpressionNode(DataValueType.String,
                    BinaryExpressionOperator.StringConcat, new ConstantValueNode(DataValueType.String, leftSide),
                    arguments[index]);
                if (needsInitialExpression)
                    currentExpression = addLeftWithVal;
                else
                    currentExpression = new BinaryExpressionNode(DataValueType.String, BinaryExpressionOperator.StringConcat, currentExpression, addLeftWithVal);
                needsInitialExpression = false;
                remainingString = rightSide;
            }
        }
        ExpressionNode remainingStringExpression = new ConstantValueNode(DataValueType.String, remainingString);
        if (needsInitialExpression)
            currentExpression = remainingStringExpression;
        else
            currentExpression = new BinaryExpressionNode(DataValueType.String, BinaryExpressionOperator.StringConcat, currentExpression, remainingStringExpression);
        return new CallCustomMethodNode(_method, caller, null, _wrapAsTable, new List<ExpressionNode> { currentExpression });
    }
}