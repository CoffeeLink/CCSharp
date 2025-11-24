using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;

[LuaTableTypeCheck(TableAccessor = 1)]
public class CCEvent
{
    /// <summary>
    /// The event name.
    /// </summary>
    [LuaProperty(1)]
    public string EventName { get; set; }
}