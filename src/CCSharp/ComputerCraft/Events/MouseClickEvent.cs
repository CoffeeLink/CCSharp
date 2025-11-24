using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// This event is fired when the terminal is clicked with a mouse. This event is only fired on advanced computers (including advanced turtles and pocket computers).
/// </summary>
[LuaImplicitTypeArgument("mouse_click")]
public class MouseClickEvent : CCEvent
{
    /// <summary>
    /// The mouse button that was clicked.
    /// </summary>
    [LuaProperty(2)]
    public MouseButton Button { get; set; }
    /// <summary>
    /// The X-coordinate of the click.
    /// </summary>
    [LuaProperty(3)]
    public int X { get; set; }
    /// <summary>
    /// The Y-coordinate of the click.
    /// </summary>
    [LuaProperty(4)]
    public int Y { get; set; }
}