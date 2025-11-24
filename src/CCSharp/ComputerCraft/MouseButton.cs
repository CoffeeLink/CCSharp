using CCSharp.Attributes;

namespace CCSharp.ComputerCraft;

[LuaEnum(typeof(MouseButton))]
public enum MouseButton
{
    [LuaEnumValue(1)]
    Left,
    [LuaEnumValue(2)]
    Right,
    [LuaEnumValue(3)]
    Middle
}