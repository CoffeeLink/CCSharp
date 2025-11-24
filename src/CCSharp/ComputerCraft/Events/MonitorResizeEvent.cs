using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The monitor_resize event is fired when an adjacent or networked monitor's size is changed.
/// </summary>
[LuaImplicitTypeArgument("monitor_resize")]
public class MonitorResizeEvent : CCEvent
{
    /// <summary>
    /// The side or network ID of the monitor that was resized.
    /// </summary>
    [LuaProperty(2)]
    public string Name { get; set; }
    /// <summary>
    /// The side of the monitor that was resized.
    /// </summary>
    [LuaProperty(2)]
    public PeripheralSide Side { get; set; }
}