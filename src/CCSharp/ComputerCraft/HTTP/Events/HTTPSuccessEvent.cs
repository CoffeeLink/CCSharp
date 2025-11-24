using CCSharp.Attributes;
using CCSharp.ComputerCraft.Events;

namespace CCSharp.ComputerCraft.HTTP.Events;
/// <summary>
/// The http_success event is fired when an HTTP request returns successfully.
/// This event is normally handled inside HTTP.Get and HTTP.Post, but it can still be seen when using HTTP.Request.
/// </summary>
[LuaImplicitTypeArgument("http_success")]
public class HTTPSuccessEvent : CCEvent
{
    /// <summary>
    /// The URL of the site requested.
    /// </summary>
    [LuaProperty(2)]
    public string URL { get; set; }
    /// <summary>
    /// The successful HTTP response.
    /// </summary>
    [LuaProperty(3)]
    public HTTPResponse Response { get; set; }
}