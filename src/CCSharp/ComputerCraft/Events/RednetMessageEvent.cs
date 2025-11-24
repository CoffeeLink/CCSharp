using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The modem_message event is fired when a message is received on an open channel on any modem.
/// </summary>
[LuaImplicitTypeArgument("rednet_message")]
public class RednetMessageEvent : RednetMessageEvent<object> { }
/// <summary>
/// The rednet_message event is fired when a message is sent over rednet.
/// This event is usually handled by Rednet.Receive, but it can also be pulled manually.
/// rednet_message events are sent by Rednet.Run in the top-level coroutine in response to modem_message events. A rednet_message event is always preceded by a modem_message event. They are generated inside CraftOS rather than being sent by the ComputerCraft machine.
/// </summary>
[LuaImplicitTypeArgument("rednet_message")]
public class RednetMessageEvent<TMessage> : CCEvent
{
    /// <summary>
    /// The ID of the sending computer.
    /// </summary>
    [LuaProperty(2)]
    public int Sender { get; set; }
    /// <summary>
    /// The message sent.
    /// </summary>
    [LuaProperty(3)]
    public TMessage Message { get; set; }
    /// <summary>
    /// The protocol of the message, if provided.
    /// </summary>
    [LuaProperty(3)]
    public string Protocol { get; set; }
}