using CCSharp.Attributes;
using CCSharp.ComputerCraft.Events;

namespace CCSharp.ComputerCraft.HTTP.Events;
/// <summary>
/// The http_failure event is fired when an HTTP request fails.
/// This event is normally handled inside HTTP.Get and HTTP.Post, but it can still be seen when using HTTP.Request.
/// </summary>
[LuaImplicitTypeArgument("http_failure")]
public class HTTPFailureEvent : CCEvent
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
    /// <summary>
    /// A response handle if the connection succeeded, but the server's response indicated failure.
    /// </summary>
    [LuaProperty(4)]
    public HTTPResponse Response { get; set; }
}