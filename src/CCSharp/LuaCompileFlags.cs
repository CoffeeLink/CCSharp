using System;

namespace CCSharp;

[Flags]
public enum LuaCompileFlags
{
    None = 0,
    /// <summary>
    /// This will prepend [LuaClass] names with their namespace,
    /// you only really need this if you have class name conflicts and you can resolve those in a better way
    /// by just passing in a custom class name to [LuaClass]
    /// </summary>
    IncludeNamespaces = 1 << 0,
    /// <summary>
    /// This will strip the _CSharpTypes array from all [LuaClass]
    /// You can do this to reduce code size if you don't use GetType(), or is/as expressions
    /// </summary>
    StripCSharpTypes = 1 << 1,
    /// <summary>
    /// This will replace the string name identifier type references with the classes MetadataToken
    /// </summary>
    UseMetadataTokenForCSharpTypes = 1 << 2
}