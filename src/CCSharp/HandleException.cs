using System;

namespace CCSharp;

public class HandleException : Exception
{
    public HandleException(string message)
        : base(message)
    {
    }
}