using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// This event is fired when any key is pressed while the terminal is focused.
/// This event returns a numerical "key code" (for instance, F1 is 290). This value may vary between versions and so it is recommended to use the constants in the Keys API rather than hard coding numeric values.
/// If the button pressed represented a printable character, then the key event will be followed immediately by a char event. If you are consuming text input, use a char event instead!
/// </summary>
[LuaImplicitTypeArgument("key")]
public class KeyEvent : CCEvent
{
    /// <summary>
    /// The side of the modem that received the message.
    /// </summary>
    [LuaProperty(2)]
    public int Key { get; set; }
    /// <summary>
    /// Whether the key event was generated while holding the key (true), rather than pressing it the first time (false).
    /// </summary>
    [LuaProperty(3)]
    public bool Held { get; set; }
}