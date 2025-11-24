using System.Collections.Generic;
using CCSharp.Attributes;

namespace CCSharp.ComputerCraft;

[LuaTable]
public class ItemDetail
{
    /// <summary>
    /// Minecraft item id ex: minecraft:crafting_table
    /// </summary>
    [LuaProperty("name")]
    public string Name { get; set; }

    [LuaProperty("displayName")]
    public string DisplayName { get; set; }
        
    [LuaProperty("count")]
    public int Count { get; set; }
        
    [LuaProperty("maxCount")]
    public int MaxCount { get; set; }

    [LuaProperty("nbt")]
    public string NBT { get; set; }

    [LuaProperty("durability")]
    public int Durability { get; set; }

    [LuaProperty("damage")]
    public int Damage { get; set; }

    [LuaProperty("maxDamage")]
    public int MaxDamage { get; set; }

    [LuaProperty("tags")]
    public Dictionary<string,object> Tags { get; set; }

    [LuaProperty("itemGroups")]
    public Dictionary<string,object> ItemGroups { get; set; }
}