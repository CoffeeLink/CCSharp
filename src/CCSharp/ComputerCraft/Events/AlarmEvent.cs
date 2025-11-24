using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The alarm event is fired when an alarm started with OS.SetAlarm completes.
/// </summary>
[LuaImplicitTypeArgument("alarm")]
public class AlarmEvent : CCEvent
{
    /// <summary>
    /// The ID of the alarm that finished.
    /// </summary>
    [LuaProperty(2)]
    public int ID { get; set; }
}