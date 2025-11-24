using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The peripheral event is fired when a peripheral is attached on a side or to a modem.
/// </summary>
[LuaImplicitTypeArgument("peripheral")]
public class PeripheralEvent : CCEvent
{
    /// <summary>
    /// The side or network ID of the peripheral that was attached.
    /// </summary>
    [LuaProperty(2)]
    public string Name { get; set; }
    /// <summary>
    /// The side of the peripheral that was attached.
    /// </summary>
    [LuaProperty(2)]
    public PeripheralSide Side { get; set; }
}