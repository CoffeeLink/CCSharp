using System.Collections.Generic;
using CCSharp.Attributes;

namespace CCSharp.ComputerCraft;

[LuaTable]
public class BlockDetail
{
    /// <summary>
    /// Minecraft item id ex: minecraft:crafting_table
    /// </summary>
    [LuaProperty("name")]
    public string Name { get; set; }

    [LuaProperty("state")]
    public Dictionary<string,object> State { get; set; } //TODO State class with common/vanilla properties

    [LuaProperty("tags")]
    public Dictionary<string,object> Tags { get; set; }
}