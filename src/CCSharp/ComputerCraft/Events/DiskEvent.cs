using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The disk event is fired when a disk is inserted into an adjacent or networked disk drive.
/// </summary>
[LuaImplicitTypeArgument("disk")]
public class DiskEvent : CCEvent
{
    /// <summary>
    /// The side of the disk drive that had a disk inserted or the name of the networked disk drive.
    /// </summary>
    [LuaProperty(2)]
    public string Name { get; set; }
    /// <summary>
    /// The side of the disk drive that had a disk inserted.
    /// </summary>
    [LuaProperty(2)]
    public PeripheralSide Side { get; set; }
}