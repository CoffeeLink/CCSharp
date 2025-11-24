using CCSharp.Attributes;
using CCSharp.ComputerCraft.Events;

namespace CCSharp.ComputerCraft.HTTP.Events;
/// <summary>
/// The http_check event is fired when a URL check finishes.
/// This event is normally handled inside HTTP.CheckURL, but it can still be seen when using HTTP.CheckURLAsync.
/// </summary>
[LuaImplicitTypeArgument("http_check")]
public class HTTPCheckEvent : CCEvent
{
    /// <summary>
    /// The URL requested to be checked.
    /// </summary>
    [LuaProperty(2)]
    public string URL { get; set; }
    /// <summary>
    /// Whether the check succeeded.
    /// </summary>
    [LuaProperty(3)]
    public bool Success { get; set; }
    /// <summary>
    /// If the check failed, a reason explaining why the check failed, null otherwise.
    /// </summary>
    [LuaProperty(4)]
    public string FailReason { get; set; }
}