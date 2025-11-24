using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The task_complete event is fired when an asynchronous task completes. This is usually handled inside the function call that queued the task; however, functions such as commands.execAsync return immediately so the user can wait for completion.
/// </summary>
[LuaImplicitTypeArgument("task_complete")]
public class TaskCompleteEvent : CCEvent
{
    /// <summary>
    /// The ID of the task that completed.
    /// </summary>
    [LuaProperty(2)]
    public int ID { get; set; }
    /// <summary>
    /// Whether the command succeeded.
    /// </summary>
    [LuaProperty(3)]
    public bool Succeeded { get; set; }
    /// <summary>
    /// If the command failed, an error message explaining the failure. (This is not present if the command succeeded.)
    /// </summary>
    [LuaProperty(4)]
    public string FailMessage { get; set; }
    /// <summary>
    /// Any parameters returned from the command.
    /// </summary>
    [LuaProperty(4)]
    public object Parameters { get; set; } //TODO Sort out type for parameters or have a generic method that gets the parameters with a strong type?
}