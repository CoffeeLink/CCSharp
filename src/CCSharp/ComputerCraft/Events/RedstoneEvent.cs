using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The redstone event is fired whenever any redstone inputs on the computer or relay change.
/// </summary>
[LuaImplicitTypeArgument("redstone")]
public class RedstoneEvent : CCEvent
{
    
}