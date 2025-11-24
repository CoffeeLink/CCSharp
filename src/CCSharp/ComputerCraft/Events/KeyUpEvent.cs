using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// Fired whenever a key is released (or the terminal is closed while a key was being pressed).
/// This event returns a numerical "key code" (for instance, F1 is 290). This value may vary between versions and so it is recommended to use the constants in the Keys API rather than hard coding numeric values.
/// </summary>
[LuaImplicitTypeArgument("key_up")]
public class KeyUpEvent : CCEvent
{
    /// <summary>
    /// The numerical key value of the key pressed.
    /// </summary>
    [LuaProperty(2)]
    public int Key { get; set; }
}