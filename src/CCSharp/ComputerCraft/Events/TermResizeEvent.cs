using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The term_resize event is fired when the main terminal is resized. For instance:
/// When a the tab bar is shown or hidden in multishell.
/// When the terminal is redirected to a monitor via the "monitor" program and the monitor is resized.
/// When this event fires, some parts of the terminal may have been moved or deleted. Simple terminal programs (those not using term.setCursorPos) can ignore this event, but more complex GUI programs should redraw the entire screen.
/// </summary>
[LuaImplicitTypeArgument("term_resize")]
public class TermResizeEvent : CCEvent
{
    
}