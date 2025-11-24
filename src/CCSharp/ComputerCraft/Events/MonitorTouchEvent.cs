using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The monitor_touch event is fired when an adjacent or networked Advanced Monitor is right-clicked.
/// </summary>
[LuaImplicitTypeArgument("monitor_touch")]
public class MonitorTouchEvent : CCEvent
{
    /// <summary>
    /// The side or network ID of the monitor that was touched.
    /// </summary>
    [LuaProperty(2)]
    public string Name { get; set; }
    /// <summary>
    /// The side of the monitor that was touched.
    /// </summary>
    [LuaProperty(2)]
    public PeripheralSide Side { get; set; }
    /// <summary>
    /// The X coordinate of the touch, in characters.
    /// </summary>
    [LuaProperty(3)]
    public int X { get; set; }
    /// <summary>
    /// The Y coordinate of the touch, in characters.
    /// </summary>
    [LuaProperty(4)]
    public int Y { get; set; }
}