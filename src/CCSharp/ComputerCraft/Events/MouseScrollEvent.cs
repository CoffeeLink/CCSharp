using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;

[LuaEnum(typeof(ScrollDirection))]
public enum ScrollDirection
{
    [LuaEnumValue(-1)]
    Up = -1,
    [LuaEnumValue(1)]
    Down = 1
}
/// <summary>
/// This event is fired when a mouse wheel is scrolled in the terminal.
/// </summary>
[LuaImplicitTypeArgument("mouse_scroll")]
public class MouseScrollEvent : CCEvent
{
    /// <summary>
    /// The direction of the scroll. (-1 = up, 1 = down)
    /// </summary>
    [LuaProperty(2)]
    public ScrollDirection Direction { get; set; }
    /// <summary>
    /// The X-coordinate of the mouse.
    /// </summary>
    [LuaProperty(3)]
    public int X { get; set; }
    /// <summary>
    /// The Y-coordinate of the mouse.
    /// </summary>
    [LuaProperty(4)]
    public int Y { get; set; }
}