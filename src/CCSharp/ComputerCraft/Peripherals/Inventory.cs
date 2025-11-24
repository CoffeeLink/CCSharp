using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Peripherals;

[LuaImplicitTypeArgument("inventory")]
public class Inventory : CCPeripheral
{
    /// <summary>
    /// Get the size of this inventory.
    /// </summary>
    /// <returns>number The number of slots in this inventory.</returns>
    [LuaMethod("size")]
    public int Size() => default;
    
    /// <summary>
    /// List all items in this inventory. This returns a table, with an entry for each slot.
    /// </summary>
    /// <returns>Contents of the inventory</returns>
    [LuaMethod("list")]
    public SimpleItemDetail[] List() => default;
    
    /// <summary>
    /// Get detailed information about an item.
    /// </summary>
    /// <param name="slot">The slot to get information about.</param>
    /// <returns>Item details for the given slot or null if the slot is empty</returns>
    [LuaMethod("getItemDetail")]
    public ItemDetail GetItemDetail(int slot) => default;
    
    /// <summary>
    /// Get the maximum number of items which can be stored in this slot.
    /// Typically this will be limited to 64 items. However, some inventories (such as barrels or caches) can store hundreds or thousands of items in one slot.
    /// </summary>
    /// <param name="slot">The slot.</param>
    /// <returns>number The maximum number of items in this slot.</returns>
    [LuaMethod("getItemLimit")]
    public int GetItemLimit(int slot) => default;
    
    /// <summary>
    /// Push items from one inventory to another connected one.
    /// </summary>
    /// <param name="toName">The name of the peripheral/inventory to push to. This is the string given to peripheral.wrap, and displayed by the wired modem.</param>
    /// <param name="fromSlot">The slot in the current inventory to move items to.</param>
    /// <returns>number The number of transferred items.</returns>
    [LuaMethod("pushItems")]
    public int PushItems(string toName, int fromSlot) => default;
    
    /// <summary>
    /// Push items from one inventory to another connected one.
    /// </summary>
    /// <param name="toName">The name of the peripheral/inventory to push to. This is the string given to peripheral.wrap, and displayed by the wired modem.</param>
    /// <param name="fromSlot">The slot in the current inventory to move items to.</param>
    /// <param name="limit">The maximum number of items to move.</param>
    /// <returns>number The number of transferred items.</returns>
    [LuaMethod("pushItems")]
    public int PushItems(string toName, int fromSlot, int limit) => default;
    
    /// <summary>
    /// Push items from one inventory to another connected one.
    /// </summary>
    /// <param name="toName">The name of the peripheral/inventory to push to. This is the string given to peripheral.wrap, and displayed by the wired modem.</param>
    /// <param name="fromSlot">The slot in the current inventory to move items to.</param>
    /// <param name="limit">The maximum number of items to move.</param>
    /// <param name="toSlot">The slot in the target inventory to move to.</param>
    /// <returns>number The number of transferred items.</returns>
    [LuaMethod("pushItems")]
    public int PushItems(string toName, int fromSlot, int limit, int toSlot) => default;
    
    /// <summary>
    /// Push items from one inventory to another connected one.
    /// </summary>
    /// <param name="fromName">The name of the peripheral/inventory to pull from. This is the string given to peripheral.wrap, and displayed by the wired modem.</param>
    /// <param name="fromSlot">The slot in the source inventory to move items from.</param>
    /// <returns>number The number of transferred items.</returns>
    [LuaMethod("pullItems")]
    public int PullItems(string fromName, int fromSlot) => default;
    
    /// <summary>
    /// Push items from one inventory to another connected one.
    /// </summary>
    /// <param name="fromName">The name of the peripheral/inventory to pull from. This is the string given to peripheral.wrap, and displayed by the wired modem.</param>
    /// <param name="fromSlot">The slot in the source inventory to move items from.</param>
    /// <param name="limit">The maximum number of items to move.</param>
    /// <returns>number The number of transferred items.</returns>
    [LuaMethod("pullItems")]
    public int PullItems(string fromName, int fromSlot, int limit) => default;
    
    /// <summary>
    /// Push items from one inventory to another connected one.
    /// </summary>
    /// <param name="fromName">The name of the peripheral/inventory to pull from. This is the string given to peripheral.wrap, and displayed by the wired modem.</param>
    /// <param name="fromSlot">The slot in the source inventory to move items from.</param>
    /// <param name="limit">The maximum number of items to move.</param>
    /// <param name="toSlot">The slot in current inventory to move to.</param>
    /// <returns>number The number of transferred items.</returns>
    [LuaMethod("pullItems")]
    public int PullItems(string fromName, int fromSlot, int limit, int toSlot) => default;
}