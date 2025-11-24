using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// This event is fired when a mouse button is released or a held mouse leaves the computer's terminal.
/// </summary>
[LuaImplicitTypeArgument("mouse_up")]
public class MouseUpEvent : CCEvent
{
    /// <summary>
    /// The mouse button that was released.
    /// </summary>
    [LuaProperty(2)]
    public MouseButton Button { get; set; }
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