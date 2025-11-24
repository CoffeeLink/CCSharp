using ICSharpCode.Decompiler.CSharp.Syntax;

namespace CCSharp;

public class DecompilationResult
{
    public AstNode Body { get; }

    public DecompilationResult(
        AstNode body)
    {
        Body = body;
    }
}