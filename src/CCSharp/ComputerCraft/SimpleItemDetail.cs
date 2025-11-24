using CCSharp.Attributes;

namespace CCSharp.ComputerCraft;

[LuaTable]
public class SimpleItemDetail
{
    /// <summary>
    /// Minecraft item id ex: minecraft:crafting_table
    /// </summary>
    [LuaProperty("name")]
    public string Name { get; set; }
        
    [LuaProperty("count")]
    public int Count { get; set; }
        
    [LuaProperty("nbt")]
    public string NBT { get; set; }
}