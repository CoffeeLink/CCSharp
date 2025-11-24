using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using CCSharp.RedIL;
using CCSharp.RedIL.Nodes;
using ICSharpCode.Decompiler.CSharp;

namespace CCSharp;

public static class CompiledTypeCache
{
    public struct CompiledType
    {
        public List<Type> Dependencies;
        public RedILNode RootNode;
    }
    public static Dictionary<Type, RedILNode> CompiledTypes = new();

    public static RedILNode GetRootNode(Type type)
    {
        if (CompiledTypes.TryGetValue(type, out RedILNode node))
            return node;
        var decompiler = new CSharpDecompiler(type.Assembly.Location, LuaProgram.DecompilerSettings);
        var syntaxTree = decompiler.Decompile(new List<EntityHandle> { MetadataTokens.EntityHandle(type.GetTypeInfo().MetadataToken) });
        var compiler = new CSharpCompiler(LuaCompileFlags.None);
        node = compiler.CompileNode(new DecompilationResult(syntaxTree));
        CompiledTypes.Add(type, node);
        return node;
    }
}