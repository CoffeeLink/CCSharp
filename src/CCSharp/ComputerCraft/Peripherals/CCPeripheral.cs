using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Peripherals;

[LuaTableTypeCheck(Method = "peripheral.hasType")]
public abstract class CCPeripheral
{
    /// <summary>
    /// For converting this wrapped peripheral to a different type, in lua this does nothing.
    /// This is required because a peripheral can be multiple types but we are representing them as classes.
    /// </summary>
    /// <typeparam name="TPeripheral">Peripheral implementation class</typeparam>
    /// <returns>Self as another peripheral</returns>
    [LuaReturnCaller]
    public TPeripheral As<TPeripheral>() => default;
}