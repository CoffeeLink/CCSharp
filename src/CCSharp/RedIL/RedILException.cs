using System;
using ICSharpCode.Decompiler.CSharp.Syntax;
using CCSharp.RedIL.Nodes;

namespace CCSharp.RedIL;

class RedILException : Exception
{
    public RedILException(string message)
        : base(message)
    {
    }
}