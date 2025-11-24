using CCSharp.Attributes;
using CCSharp.ComputerCraft.Events;

namespace CCSharp.ComputerCraft.HTTP.Events;
/// <summary>
/// The websocket_closed event is fired when an open WebSocket connection is closed.
/// </summary>
[LuaImplicitTypeArgument("websocket_closed")]
public class WebSocketClosedEvent : CCEvent
{
    /// <summary>
    /// The URL of the WebSocket that was closed.
    /// </summary>
    [LuaProperty(2)]
    public string URL { get; set; }
    /// <summary>
    /// The server-provided reason the websocket was closed. This will be null if the connection was closed abnormally.
    /// </summary>
    [LuaProperty(3)]
    public string Reason { get; set; }
    /// <summary>
    /// The connection close code, indicating why the socket was closed. This will be null if the connection was closed abnormally.
    /// </summary>
    [LuaProperty(4)]
    public int? Code { get; set; }
}