using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// This event is fired every time the mouse is moved while a mouse button is being held.
/// </summary>
[LuaImplicitTypeArgument("mouse_drag")]
public class MouseDragEvent : CCEvent
{
    /// <summary>
    /// The mouse button that is being pressed.
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