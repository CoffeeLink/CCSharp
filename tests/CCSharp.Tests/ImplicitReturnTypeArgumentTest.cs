using CCSharp.Attributes;
using CCSharp.ComputerCraft;
using CCSharp.ComputerCraft.Events;
using CCSharp.ComputerCraft.Peripherals;

namespace CCSharp.Tests;

[LuaProgram]
public static class ImplicitReturnTypeArgumentTest
{
    [LuaMain]
    public static void Start()
    {
        Inventory a = Peripheral.Find<Inventory>();
        KeyEvent b = OS.PullEvent<KeyEvent>();
        DateTime time = OS.GetDateTime();
    }
}