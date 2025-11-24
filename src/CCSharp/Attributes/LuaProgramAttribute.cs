using System;

namespace CCSharp.Attributes;

public class LuaProgramAttribute : Attribute
{
    public string Filename;
    public LuaCompileFlags Flags;

    public LuaProgramAttribute(string filename, LuaCompileFlags flags = LuaCompileFlags.None)
    {
        Filename = filename;
        Flags = flags;
    }

    public LuaProgramAttribute(LuaCompileFlags flags = LuaCompileFlags.None)
    {
        Flags = flags;
    }
}