using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.HTTP;

public class WebSocket
{
    /// <summary>
    /// Wait for a message from the server.
    /// </summary>
    /// <returns>The received message or null if the websocket was closed while waiting, or if we timed out.</returns>
    [LuaMethod("receive")]
    public (string,bool) Receive() => default;
    
    /// <summary>
    /// Wait for a message from the server.
    /// </summary>
    /// <param name="timeout">The number of seconds to wait if no message is received.</param>
    /// <returns>The received message or null if the websocket was closed while waiting, or if we timed out.</returns>
    [LuaMethod("receive")]
    public (string,bool) Receive(int timeout) => default;
    
    /// <summary>
    /// Send a websocket message to the connected server.
    /// </summary>
    /// <param name="message">The message to send.</param>
    [LuaMethod("send")]
    public void Send(string message) { }
    
    /// <summary>
    /// Send a websocket message to the connected server.
    /// </summary>
    /// <param name="message">The message to send.</param>
    /// <param name="binary">Whether this message should be treated as a binary message.</param>
    [LuaMethod("send")]
    public void Send(string message, bool binary) { }
    
    /// <summary>
    /// Close this websocket. This will terminate the connection, meaning messages can no longer be sent or received along it.
    /// </summary>
    [LuaMethod("close")]
    public void Close() { }
}