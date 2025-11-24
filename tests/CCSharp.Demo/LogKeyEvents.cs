using System;
using CCSharp.Attributes;
using CCSharp.ComputerCraft;
using CCSharp.ComputerCraft.Events;

namespace CCSharp.Demo;

[LuaProgram]
public static class LogKeyEvents
{
    [LuaMain]
    public static void Start()
    {
        while (true)
        {
            KeyEvent keyEvent = OS.PullEvent<KeyEvent>();
            Console.WriteLine(Keys.GetName(keyEvent.Key) + " held=" + keyEvent.Held);
        }
    }
}