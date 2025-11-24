using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The computer_command event is fired when the /computercraft queue command is run for the current computer.
/// </summary>
[LuaImplicitTypeArgument("computer_command")]
public class ComputerCommandEvent : CCEvent
{
    /// <summary>
    /// The arguments passed to the command.
    /// </summary>
    [LuaProperty(2)]
    public string[] Arguments { get; set; }
}