using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The modem_message event is fired when a message is received on an open channel on any modem.
/// </summary>
[LuaImplicitTypeArgument("modem_message")]
public class ModemMessageEvent : ModemMessageEvent<object> { }
/// <summary>
/// The modem_message event is fired when a message is received on an open channel on any modem.
/// </summary>
[LuaImplicitTypeArgument("modem_message")]
public class ModemMessageEvent<TMessage> : CCEvent
{
    /// <summary>
    /// The side or name of the modem that received the message.
    /// </summary>
    [LuaProperty(2)]
    public string Name { get; set; }
    /// <summary>
    /// The side of the modem that received the message.
    /// </summary>
    [LuaProperty(2)]
    public PeripheralSide Side { get; set; }
    /// <summary>
    /// The channel that the message was sent on.
    /// </summary>
    [LuaProperty(3)]
    public int Channel { get; set; }
    /// <summary>
    /// The reply channel set by the sender.
    /// </summary>
    [LuaProperty(4)]
    public int ReplyChannel { get; set; }
    /// <summary>
    /// The message as sent by the sender.
    /// </summary>
    [LuaProperty(5)]
    public TMessage Message { get; set; }
    /// <summary>
    /// The distance between the sender and the receiver in blocks, or null if the message was sent between dimensions.
    /// </summary>
    [LuaProperty(6)]
    public float? Distance { get; set; }
}