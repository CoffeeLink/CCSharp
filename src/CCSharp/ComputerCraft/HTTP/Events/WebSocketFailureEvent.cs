using CCSharp.Attributes;
using CCSharp.ComputerCraft.Events;

namespace CCSharp.ComputerCraft.HTTP.Events;
/// <summary>
/// The websocket_failure event is fired when a WebSocket connection request fails.
/// This event is normally handled inside HTTP.WebSocket, but it can still be seen when using http.websocketAsync.
/// </summary>
[LuaImplicitTypeArgument("websocket_failure")]
public class WebSocketFailureEvent : CCEvent
{
    /// <summary>
    /// The URL of the site requested.
    /// </summary>
    [LuaProperty(2)]
    public string URL { get; set; }
    /// <summary>
    /// An error describing the failure.
    /// </summary>
    [LuaProperty(3)]
    public string Error { get; set; }
}