using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The paste event is fired when text is pasted into the computer through Ctrl-V (or ⌘V on Mac).
/// </summary>
[LuaImplicitTypeArgument("paste")]
public class PasteEvent : CCEvent
{
    /// <summary>
    /// The text that was pasted.
    /// </summary>
    [LuaProperty(2)]
    public string Text { get; set; }
}