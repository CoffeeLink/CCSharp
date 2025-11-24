using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The turtle_inventory event is fired when a turtle's inventory is changed.
/// </summary>
[LuaImplicitTypeArgument("turtle_inventory")]
public class TurtleInventoryEvent : CCEvent
{
    
}