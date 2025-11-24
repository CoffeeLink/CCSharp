using System;

namespace CCSharp.Lua;

class LuaCompilationException : Exception
{
    public LuaCompilationException(string message)
        : base(message)
    {
    }
}