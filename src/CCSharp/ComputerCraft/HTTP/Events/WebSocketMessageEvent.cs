using CCSharp.Attributes;
using CCSharp.ComputerCraft.Events;

namespace CCSharp.ComputerCraft.HTTP.Events;
/// <summary>
/// The websocket_message event is fired when a message is received on an open WebSocket connection.
/// This event is normally handled by http.Websocket.receive, but it can also be pulled manually.
/// </summary>
[LuaImplicitTypeArgument("websocket_message")]
public class WebSocketMessageEvent : CCEvent
{
    /// <summary>
    /// The URL of the WebSocket.
    /// </summary>
    [LuaProperty(2)]
    public string URL { get; set; }
    /// <summary>
    /// The contents of the message.
    /// </summary>
    [LuaProperty(3)]
    public string Message { get; set; }
    /// <summary>
    /// Whether this is a binary message.
    /// </summary>
    [LuaProperty(4)]
    public bool IsBinary { get; set; }
}