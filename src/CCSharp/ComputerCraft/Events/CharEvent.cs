using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The char event is fired when a character is typed on the keyboard.
/// The char event is different to a key press. Sometimes multiple key presses may result in one character being typed (for instance, on some European keyboards). Similarly, some keys (e.g. Ctrl) do not have any corresponding character. The key should be used if you want to listen to key presses themselves.
/// </summary>
[LuaImplicitTypeArgument("char")]
public class CharEvent : CCEvent
{
    /// <summary>
    /// The string representing the character that was pressed.
    /// </summary>
    [LuaProperty(2)]
    public string Key { get; set; }
}