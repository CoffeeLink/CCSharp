using System.Collections.Generic;
using CCSharp.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.ComputerCraft.HTTP;

public class HTTPResponse : FileHandle
{
    /// <summary>
    /// Returns the response code and response message returned by the server.
    /// </summary>
    /// <returns>HTTPResponseCode</returns>
    [LuaMethod("getResponseCode", CallMethodFlags.WrapAsTable)]
    public HTTPResponseCode GetResponseCode() => default;
    
    /// <summary>
    /// Get a table containing the response's headers, in a format similar to that required by http.request.
    /// If multiple headers are sent with the same name, they will be combined with a comma.
    /// </summary>
    /// <returns>The response's headers.</returns>
    [LuaMethod("getResponseHeaders")]
    public Dictionary<string,string> GetResponseHeaders() => default;
}

public class HTTPResponseCode
{
    /// <summary>
    /// The response code (i.e. 200)
    /// </summary>
    [LuaProperty(1)]
    public int Code { get; set; }
    
    /// <summary>
    /// The response message (i.e. "OK")
    /// </summary>
    [LuaProperty(2)]
    public string Message { get; set; }
}