using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The terminate event is fired when Ctrl-T is held down.
/// This event is normally handled by OS.PullEvent, and will not be returned. However, OS.PullEventRaw will return this event when fired.
/// terminate will be sent even when a filter is provided to os.pullEventRaw. When using OS.PullEventRaw with a filter, make sure to check that the event is not terminate.
/// </summary>
[LuaImplicitTypeArgument("terminate")]
public class TerminateEvent : CCEvent
{
    
}