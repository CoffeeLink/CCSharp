using System.Collections.Generic;
using CCSharp.Attributes;

namespace CCSharp.ComputerCraft;

[LuaEnum(typeof(FileMode))]
public enum FileMode
{
    /// <summary>
    /// Read mode.
    /// </summary>
    [LuaEnumValue("r")]
    Read,
    /// <summary>
    /// Write mode.
    /// </summary>
    [LuaEnumValue("w")]
    Write,
    /// <summary>
    /// Append mode.
    /// </summary>
    [LuaEnumValue("a")]
    Append,
    /// <summary>
    /// Update mode (allows reading and writing), all data is preserved.
    /// </summary>
    [LuaEnumValue("r+")]
    UpdateRead,
    /// <summary>
    /// Update mode, all data is erased.
    /// </summary>
    [LuaEnumValue("w+")]
    UpdateWrite,
    /// <summary>
    /// Read mode. (Binary)
    /// </summary>
    [LuaEnumValue("rb")]
    ReadBinary,
    /// <summary>
    /// Write mode. (Binary)
    /// </summary>
    [LuaEnumValue("wb")]
    WriteBinary,
    /// <summary>
    /// Append mode. (Binary)
    /// </summary>
    [LuaEnumValue("ab")]
    AppendBinary,
    /// <summary>
    /// Update mode (allows reading and writing), all data is preserved. (Binary)
    /// </summary>
    [LuaEnumValue("r+b")]
    UpdateReadBinary,
    /// <summary>
    /// Update mode, all data is erased. (Binary)
    /// </summary>
    [LuaEnumValue("w+b")]
    UpdateWriteBinary
}
/// <summary>
/// Interact with the computer's files and filesystem, allowing you to manipulate files, directories and paths. This includes:
/// - Reading and writing files
/// - Path manipulation
/// - Querying paths
/// - File and directory manipulation
/// </summary>
public static class FS
{
    /// <summary>
    /// Provides completion for a file or directory name, suitable for use with _G.read.
    /// </summary>
    /// <param name="path">The path to complete.</param>
    /// <param name="location">The location where paths are resolved from.</param>
    /// <returns>A list of possible completion candidates.</returns>
    [LuaMethod("fs.complete")]
    public static string[] Complete(string path, string location) { return default; }
    
    /// <summary>
    /// Provides completion for a file or directory name, suitable for use with _G.read.
    /// </summary>
    /// <param name="path">The path to complete.</param>
    /// <param name="location">The location where paths are resolved from.</param>
    /// <param name="includeFiles">When false, only directories will be included in the returned list.</param>
    /// <returns>A list of possible completion candidates.</returns>
    [LuaMethod("fs.complete")]
    public static string[] Complete(string path, string location, bool includeFiles) { return default; }
    
    /// <summary>
    /// Provides completion for a file or directory name, suitable for use with _G.read.
    /// </summary>
    /// <param name="path">The path to complete.</param>
    /// <param name="location">The location where paths are resolved from.</param>
    /// <param name="includeFiles">When false, only directories will be included in the returned list.</param>
    /// <param name="includeDirs">When false, "raw" directories will not be included in the returned list.</param>
    /// <returns>A list of possible completion candidates.</returns>
    [LuaMethod("fs.complete")]
    public static string[] Complete(string path, string location, bool includeFiles, bool includeDirs) { return default; }

    /// <summary>
    /// Searches for files matching a string with wildcards.
    /// </summary>
    /// <param name="path">The wildcard-qualified path to search for.</param>
    /// <returns>A list of paths that match the search string.</returns>
    [LuaMethod("fs.find")]
    public static string[] Find(string path) { return default; }

    /// <summary>
    /// Returns true if a path is mounted to the parent filesystem.
    /// The root filesystem "/" is considered a mount, along with disk folders and the rom folder.
    /// </summary>
    /// <param name="path">The path to check.</param>
    /// <returns>boolean If the path is mounted, rather than a normal file/folder.</returns>
    [LuaMethod("fs.isDriveRoot")]
    public static bool IsDriveRoot(string path) { return default; }

    /// <summary>
    /// Returns a list of files in a directory.
    /// </summary>
    /// <param name="path">The path to list.</param>
    /// <returns>A list of files in the directory.</returns>
    [LuaMethod("fs.list")]
    public static string[] List(string path) { return default; }

    /// <summary>
    /// Combines several parts of a path into one full path, adding separators as needed.
    /// </summary>
    /// <param name="path">The first part of the path.</param>
    /// <param name="parts">Additional parts of the path to combine.</param>
    /// <returns>string The new path, with separators added between parts as needed.</returns>
    [LuaMethod("fs.combine")]
    public static string Combine(string path, params string[] parts) { return default; }

    /// <summary>
    /// Returns the file name portion of a path.
    /// </summary>
    /// <param name="path">The path to get the name from.</param>
    /// <returns>string The final part of the path (the file name).</returns>
    [LuaMethod("fs.getName")]
    public static string GetName(string path) { return default; }

    /// <summary>
    /// Returns the parent directory portion of a path.
    /// </summary>
    /// <param name="path">The path to get the directory from.</param>
    /// <returns>string The path with the final part removed (the parent directory).</returns>
    [LuaMethod("fs.getDir")]
    public static string GetDir(string path) { return default; }

    /// <summary>
    /// Returns the size of the specified file.
    /// </summary>
    /// <param name="path">The file to get the file size of.</param>
    /// <returns>number The size of the file, in bytes.</returns>
    [LuaMethod("fs.getSize")]
    public static long GetSize(string path) { return default; }

    /// <summary>
    /// Returns whether the specified path exists.
    /// </summary>
    /// <param name="path">The path to check the existence of.</param>
    /// <returns>boolean Whether the path exists.</returns>
    [LuaMethod("fs.exists")]
    public static bool Exists(string path) { return default; }

    /// <summary>
    /// Returns whether the specified path is a directory.
    /// </summary>
    /// <param name="path">The path to check.</param>
    /// <returns>boolean Whether the path is a directory.</returns>
    [LuaMethod("fs.isDir")]
    public static bool IsDir(string path) { return default; }

    /// <summary>
    /// Returns whether a path is read-only.
    /// </summary>
    /// <param name="path">The path to check.</param>
    /// <returns>boolean Whether the path cannot be written to.</returns>
    [LuaMethod("fs.isReadOnly")]
    public static bool IsReadOnly(string path) { return default; }

    /// <summary>
    /// Creates a directory, and any missing parents, at the specified path.
    /// </summary>
    /// <param name="path">The directory path to create.</param>
    [LuaMethod("fs.makeDir")]
    public static void MakeDir(string path) { }

    /// <summary>
    /// Moves a file or directory from one path to another.
    /// Any parent directories are created as needed.
    /// </summary>
    /// <param name="path">The current file or directory to move from.</param>
    /// <param name="dest">The destination path for the file or directory.</param>
    [LuaMethod("fs.move")]
    public static void Move(string path, string dest) { }

    /// <summary>
    /// Copies a file or directory to a new path.
    /// Any parent directories are created as needed.
    /// </summary>
    /// <param name="path">The file or directory to copy.</param>
    /// <param name="dest">The path to the destination file or directory.</param>
    [LuaMethod("fs.copy")]
    public static void Copy(string path, string dest) { }

    /// <summary>
    /// Deletes a file or directory.
    /// If the path points to a directory, all of the enclosed files and subdirectories are also deleted.
    /// </summary>
    /// <param name="path">The path to the file or directory to delete.</param>
    [LuaMethod("fs.delete")]
    public static void Delete(string path) { }
    
    /// <summary>
    /// Opens a file for reading or writing at a path.
    /// </summary>
    /// <param name="path">The path to the file to open.</param>
    /// <param name="mode">The mode to open the file with.</param>
    /// <returns>A file handle object for the file or null if could not be opened.</returns>
    [LuaMethod("fs.open")]
    public static FileHandle Open(string path, FileMode mode) => default;

    /// <summary>
    /// Returns the name of the mount that the specified path is located on.
    /// </summary>
    /// <param name="path">The path to get the drive of.</param>
    /// <returns>The name of the drive that the file is on or null if it does not exist</returns>
    [LuaMethod("fs.getDrive")]
    public static string GetDrive(string path) { return default; }

    /// <summary>
    /// Returns the amount of free space available on the drive the path is located on.
    /// </summary>
    /// <param name="path">The path to check the free space for.</param>
    /// <returns>The free space in bytes.</returns>
    [LuaMethod("fs.getFreeSpace")]
    public static long GetFreeSpace(string path) { return default; }

    /// <summary>
    /// Returns the capacity of the drive the path is located on.
    /// </summary>
    /// <param name="path">The path of the drive to get.</param>
    /// <returns>The drive capacity in bytes.</returns>
    [LuaMethod("fs.getCapacity")]
    public static long GetCapacity(string path) { return default; }

    /// <summary>
    /// Get attributes about a specific file or folder.
    /// </summary>
    /// <param name="path">The path to query.</param>
    /// <returns>A dictionary of file or folder attributes.</returns>
    [LuaMethod("fs.attributes")]
    public static Dictionary<string,object> Attributes(string path) { return default; }
}