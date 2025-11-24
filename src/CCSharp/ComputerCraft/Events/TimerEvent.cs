using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The timer event is fired when a timer started with os.startTimer completes.
/// </summary>
[LuaImplicitTypeArgument("timer")]
public class TimerEvent : CCEvent
{
    /// <summary>
    /// The ID of the timer that finished.
    /// </summary>
    [LuaProperty(2)]
    public int ID { get; set; }
}