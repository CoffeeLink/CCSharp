using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The peripheral_detach event is fired when a peripheral is detached from a side or from a modem.
/// </summary>
[LuaImplicitTypeArgument("peripheral_detach")]
public class PeripheralDetachEvent : CCEvent
{
    /// <summary>
    /// The side or network ID of the peripheral that was detached.
    /// </summary>
    [LuaProperty(2)]
    public string Name { get; set; }
    /// <summary>
    /// The side of the peripheral that was detached.
    /// </summary>
    [LuaProperty(2)]
    public PeripheralSide Side { get; set; }
}