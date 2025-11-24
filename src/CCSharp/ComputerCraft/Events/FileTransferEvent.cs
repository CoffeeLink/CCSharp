using System.Collections.Generic;
using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;
/// <summary>
/// The file_transfer event is queued when a user drags-and-drops a file on an open computer.
/// This event contains a single argument of type TransferredFiles, which can be used to get the files to be transferred. Each file returned is a binary file handle with an additional getName method.
/// </summary>
[LuaImplicitTypeArgument("file_transfer")]
public class FileTransferEvent : CCEvent
{
    /// <summary>
    /// All the files that are being transferred to this computer.
    /// </summary>
    [LuaProperty(2)]
    public TransferredFiles Files { get; set; }
}

public class TransferredFiles
{
    /// <returns>All the files that are being transferred to this computer.</returns>
    [LuaMethod("getFiles")]
    public List<TransferredFile> GetFiles() => default;
}

public class TransferredFile : FileHandle
{
    /// <returns>The name of the file being transferred.</returns>
    [LuaMethod("getName")]
    public string GetName() => default;
}