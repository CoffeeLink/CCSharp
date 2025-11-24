using CCSharp.Attributes;
using CCSharp.ComputerCraft.Events;

namespace CCSharp.ComputerCraft.HTTP.Events;
/// <summary>
/// The websocket_success event is fired when a WebSocket connection request returns successfully.
/// This event is normally handled inside HTTP.WebSocket, but it can still be seen when using HTTP.WebSocketAsync.
/// </summary>
[LuaImplicitTypeArgument("websocket_success")]
public class WebSocketSuccessEvent : CCEvent
{
    /// <summary>
    /// The URL of the site.
    /// </summary>
    [LuaProperty(2)]
    public string URL { get; set; }
    /// <summary>
    /// The handle for the WebSocket.
    /// </summary>
    [LuaProperty(3)]
    public WebSocket WebSocket { get; set; }
}