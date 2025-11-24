using CCSharp.Attributes;

namespace CCSharp.ComputerCraft;

[LuaEnum(typeof(SeekPosition))]
public enum SeekPosition
{
    /// <summary>
    /// Relative to the beginning of the file.
    /// </summary>
    [LuaEnumValue("set")]
    Start,
    /// <summary>
    /// Relative to the current position.
    /// </summary>
    [LuaEnumValue("cur")]
    Current,
    /// <summary>
    /// Relative to the end of the file.
    /// </summary>
    [LuaEnumValue("end")]
    End,
}
public class FileHandle
{
    /// <summary>
    /// Read a byte from this file.
    /// </summary>
    /// <returns>number The value of the byte read. This is returned if the file is opened in binary mode and count is absent.</returns>
    [LuaMethod("read")]
    public byte Read() => default;

    /// <summary>
    /// Read a number bytes from this file.
    /// </summary>
    /// <param name="count">The number of bytes to read. This may be 0 to determine we are at the end of the file</param>
    /// <returns>string The bytes read as a string.</returns>
    [LuaMethod("read")]
    public string Read(int count) => default;
    
    /// <summary>
    /// Read the remainder of the file.
    /// </summary>
    /// <returns>string The remaining contents of the file, or null in the event of an error.</returns>
    [LuaMethod("readAll")]
    public string ReadAll() => default;
    
    /// <summary>
    /// Read a line from the file.
    /// </summary>
    /// <returns>string The read line or null if at the end of the file.</returns>
    [LuaMethod("readLine")]
    public string ReadLine() => default;
    
    /// <summary>
    /// Read a line from the file.
    /// </summary>
    /// <param name="withTrailing">Whether to include the newline characters with the returned string. Defaults to false.</param>
    /// <returns>string The read line or null if at the end of the file.</returns>
    [LuaMethod("readLine")]
    public string ReadLine(bool withTrailing) => default;
    
    /// <summary>
    /// Seek to a new position within the file, changing where bytes are written to.
    /// </summary>
    /// <param name="whence">Where the offset is relative to.</param>
    /// <param name="offset">The offset to seek to.</param>
    /// <returns>number The new position.</returns>
    [LuaMethod("seek")]
    public int Seek(SeekPosition whence, int offset) => default;
    
    /// <summary>
    /// Write a string to the file.
    /// </summary>
    /// <param name="contents">The string to write.</param>
    [LuaMethod("write")]
    public void Write(string contents) { }
    
    /// <summary>
    /// Write a byte to the file.
    /// </summary>
    /// <param name="charCode">The byte to write, if the file was opened in binary mode.</param>
    [LuaMethod("write")]
    public void Write(byte charCode) { }
    
    /// <summary>
    /// Write a string of characters to the file, following them with a new line character.
    /// </summary>
    /// <param name="text">The text to write to the file.</param>
    [LuaMethod("writeLine")]
    public void WriteLine(string text) { }
    
    /// <summary>
    /// Save the current file without closing it.
    /// </summary>
    [LuaMethod("flush")]
    public void Flush() { }
    
    /// <summary>
    /// Close this file, freeing any resources it uses.
    /// Once a file is closed it may no longer be read or written to.
    /// </summary>
    [LuaMethod("close")]
    public void Close() { }
}