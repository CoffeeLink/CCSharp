using CCSharp.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.ComputerCraft;

[LuaEnum(typeof(TurtleSide))]
public enum TurtleSide
{
    [LuaEnumValue("left")]
    Left,
    [LuaEnumValue("right")]
    Right
}
public static class Turtle {
    /// <summary>
    /// Move the turtle forward one block.
    /// </summary>
    /// <returns>boolean Whether the turtle could successfully move.</returns>
    [LuaMethod("turtle.forward")]
    public static bool Forward() => default;

    /// <summary>
    /// Move the turtle backwards one block.
    /// </summary>
    /// <returns>boolean Whether the turtle could successfully move.</returns>
    [LuaMethod("turtle.back")]
    public static bool Back() => default;

    /// <summary>
    /// Move the turtle up one block.
    /// </summary>
    /// <returns>boolean Whether the turtle could successfully move.</returns>
    [LuaMethod("turtle.up")]
    public static bool Up() => default;

    /// <summary>
    /// Move the turtle down one block.
    /// </summary>
    /// <returns>boolean Whether the turtle could successfully move.</returns>
    [LuaMethod("turtle.down")]
    public static bool Down() => default;

    /// <summary>
    /// Rotate the turtle 90 degrees to the left.
    /// </summary>
    /// <returns>boolean Whether the turtle could successfully turn.</returns>
    [LuaMethod("turtle.turnLeft")]
    public static bool TurnLeft() => default;

    /// <summary>
    /// Rotate the turtle 90 degrees to the right.
    /// </summary>
    /// <returns>boolean Whether the turtle could successfully turn.</returns>
    [LuaMethod("turtle.turnRight")]
    public static bool TurnRight() => default;
        
    /// <summary>
    /// Attempt to break the block in front of the turtle.
    /// This requires a turtle tool capable of breaking the block. Diamond pickaxes (mining turtles) can break any vanilla block, but other tools (such as axes) are more limited.
    /// </summary>
    /// <returns>boolean Whether a block was broken.</returns>
    [LuaMethod("turtle.dig")]
    public static bool Dig() => default;
        
    /// <summary>
    /// Attempt to break the block in front of the turtle.
    /// This requires a turtle tool capable of breaking the block. Diamond pickaxes (mining turtles) can break any vanilla block, but other tools (such as axes) are more limited.
    /// </summary>
    /// <param name="side">The specific tool to use.</param>
    /// <returns>boolean Whether a block was broken.</returns>
    [LuaMethod("turtle.dig")]
    public static bool Dig(TurtleSide side) => default;
        
    /// <summary>
    /// Attempt to break the block above the turtle.
    /// This requires a turtle tool capable of breaking the block. Diamond pickaxes (mining turtles) can break any vanilla block, but other tools (such as axes) are more limited.
    /// </summary>
    /// <returns>boolean Whether a block was broken.</returns>
    [LuaMethod("turtle.digUp")]
    public static bool DigUp() => default;
        
    /// <summary>
    /// Attempt to break the block above the turtle.
    /// This requires a turtle tool capable of breaking the block. Diamond pickaxes (mining turtles) can break any vanilla block, but other tools (such as axes) are more limited.
    /// </summary>
    /// <param name="side">The specific tool to use.</param>
    /// <returns>boolean Whether a block was broken.</returns>
    [LuaMethod("turtle.digUp")]
    public static bool DigUp(TurtleSide side) => default;
        
    /// <summary>
    /// Attempt to break the block below the turtle.
    /// This requires a turtle tool capable of breaking the block. Diamond pickaxes (mining turtles) can break any vanilla block, but other tools (such as axes) are more limited.
    /// </summary>
    /// <returns>boolean Whether a block was broken.</returns>
    [LuaMethod("turtle.digDown")]
    public static bool DigDown() => default;
        
    /// <summary>
    /// Attempt to break the block below the turtle.
    /// This requires a turtle tool capable of breaking the block. Diamond pickaxes (mining turtles) can break any vanilla block, but other tools (such as axes) are more limited.
    /// </summary>
    /// <param name="side">The specific tool to use.</param>
    /// <returns>boolean Whether a block was broken.</returns>
    [LuaMethod("turtle.digDown")]
    public static bool DigDown(TurtleSide side) => default;
        
    /// <summary>
    /// Place a block or item into the world in front of the turtle.
    /// "Placing" an item allows it to interact with blocks and entities in front of the turtle. For instance, buckets can pick up and place down fluids, and wheat can be used to breed cows. However, you cannot use place to perform arbitrary block interactions, such as clicking buttons or flipping levers.
    /// </summary>
    /// <returns>boolean Whether the block could be placed.</returns>
    [LuaMethod("turtle.place")]
    public static bool Place() => default;
        
    /// <summary>
    /// Place a block or item into the world above the turtle.
    /// "Placing" an item allows it to interact with blocks and entities in front of the turtle. For instance, buckets can pick up and place down fluids, and wheat can be used to breed cows. However, you cannot use place to perform arbitrary block interactions, such as clicking buttons or flipping levers.
    /// </summary>
    /// <returns>boolean Whether the block could be placed.</returns>
    [LuaMethod("turtle.placeUp")]
    public static bool PlaceUp() => default;
        
    /// <summary>
    /// Place a block or item into the world below the turtle.
    /// "Placing" an item allows it to interact with blocks and entities in front of the turtle. For instance, buckets can pick up and place down fluids, and wheat can be used to breed cows. However, you cannot use place to perform arbitrary block interactions, such as clicking buttons or flipping levers.
    /// </summary>
    /// <returns>boolean Whether the block could be placed.</returns>
    [LuaMethod("turtle.placeDown")]
    public static bool PlaceDown() => default;
        
    /// <summary>
    /// Place a sign in front of the turtle.
    /// </summary>
    /// <param name="text">The text for the placed sign.</param>
    /// <returns>boolean Whether the sign could be placed.</returns>
    [LuaMethod("turtle.place")]
    public static bool PlaceSign(string text) => default;
        
    /// <summary>
    /// Place a sign above the turtle.
    /// </summary>
    /// <param name="text">The text for the placed sign.</param>
    /// <returns>boolean Whether the sign could be placed.</returns>
    [LuaMethod("turtle.placeUp")]
    public static bool PlaceSignUp(string text) => default;
        
    /// <summary>
    /// Place a sign below the turtle.
    /// </summary>
    /// <param name="text">The text for the placed sign.</param>
    /// <returns>boolean Whether the sign could be placed.</returns>
    [LuaMethod("turtle.placeDown")]
    public static bool PlaceSignDown(string text) => default;
        
    /// <summary>
    /// Drop the currently selected stack into the inventory in front of the turtle, or as an item into the world if there is no inventory.
    /// </summary>
    /// <returns>boolean Whether items were dropped.</returns>
    [LuaMethod("turtle.drop")]
    public static bool Drop() => default;
        
    /// <summary>
    /// Drop the currently selected stack into the inventory in front of the turtle, or as an item into the world if there is no inventory.
    /// </summary>
    /// <param name="count">number The number of items to drop. If not given, the entire stack will be dropped.</param>
    /// <returns>boolean Whether items were dropped.</returns>
    [LuaMethod("turtle.drop")]
    public static bool Drop(int count) => default;
        
    /// <summary>
    /// Drop the currently selected stack into the inventory above the turtle, or as an item into the world if there is no inventory.
    /// </summary>
    /// <returns>boolean Whether items were dropped.</returns>
    [LuaMethod("turtle.dropUp")]
    public static bool DropUp() => default;
        
    /// <summary>
    /// Drop the currently selected stack into the inventory above the turtle, or as an item into the world if there is no inventory.
    /// </summary>
    /// <param name="count">number The number of items to drop. If not given, the entire stack will be dropped.</param>
    /// <returns>boolean Whether items were dropped.</returns>
    [LuaMethod("turtle.dropUp")]
    public static bool DropUp(int count) => default;
        
    /// <summary>
    /// Drop the currently selected stack into the inventory below the turtle, or as an item into the world if there is no inventory.
    /// </summary>
    /// <returns>boolean Whether items were dropped.</returns>
    [LuaMethod("turtle.dropDown")]
    public static bool DropDown() => default;
        
    /// <summary>
    /// Drop the currently selected stack into the inventory below the turtle, or as an item into the world if there is no inventory.
    /// </summary>
    /// <param name="count">number The number of items to drop. If not given, the entire stack will be dropped.</param>
    /// <returns>boolean Whether items were dropped.</returns>
    [LuaMethod("turtle.dropDown")]
    public static bool DropDown(int count) => default;
        
    /// <summary>
    /// Change the currently selected slot.
    /// The selected slot is determines what slot actions like drop or getItemCount act on.
    /// </summary>
    /// <param name="slot">number The slot to select.</param>
    /// <returns>true When the slot has been selected.</returns>
    [LuaMethod("turtle.select")]
    public static bool Select(int slot) => default;
        
    /// <summary>
    /// Get the number of items in the selected slot.
    /// </summary>
    /// <returns>number The number of items in the selected slot.</returns>
    [LuaMethod("turtle.getItemCount")]
    public static int GetItemCount() => default;
        
    /// <summary>
    /// Get the number of items in the given slot.
    /// </summary>
    /// <param name="slot">number The slot we wish to check</param>
    /// <returns>number The number of items in this slot.</returns>
    [LuaMethod("turtle.getItemCount")]
    public static int GetItemCount(int slot) => default;
        
    /// <summary>
    /// Get the remaining number of items which may be stored in the selected slot.
    /// For instance, if a slot contains 13 blocks of dirt, it has room for another 51.
    /// </summary>
    /// <returns>number The space left in the selected slot.</returns>
    [LuaMethod("turtle.getItemSpace")]
    public static int GetItemSpace() => default;
        
    /// <summary>
    /// Get the remaining number of items which may be stored in this stack.
    /// For instance, if a slot contains 13 blocks of dirt, it has room for another 51.
    /// </summary>
    /// <param name="slot">number The slot we wish to check</param>
    /// <returns>number The space left in this slot.</returns>
    [LuaMethod("turtle.getItemSpace")]
    public static int GetItemSpace(int slot) => default;
        
    /// <summary>
    /// Check if there is a solid block in front of the turtle. In this case, solid refers to any non-air or liquid block.
    /// </summary>
    /// <returns>boolean If there is a solid block in front.</returns>
    [LuaMethod("turtle.detect")]
    public static bool Detect() => default;
        
    /// <summary>
    /// Check if there is a solid block above the turtle. In this case, solid refers to any non-air or liquid block.
    /// </summary>
    /// <returns>boolean If there is a solid block above.</returns>
    [LuaMethod("turtle.detectUp")]
    public static bool DetectUp() => default;
        
    /// <summary>
    /// Check if there is a solid block below the turtle. In this case, solid refers to any non-air or liquid block.
    /// </summary>
    /// <returns>boolean If there is a solid block below.</returns>
    [LuaMethod("turtle.detectDown")]
    public static bool DetectDown() => default;
        
    /// <summary>
    /// Check if the block in front of the turtle is equal to the item in the currently selected slot.
    /// </summary>
    /// <returns>boolean If the block and item are equal.</returns>
    [LuaMethod("turtle.compare")]
    public static bool Compare() => default;

    /// <summary>
    /// Check if the block above the turtle is equal to the item in the currently selected slot.
    /// </summary>
    /// <returns>boolean If the block and item are equal.</returns>
    [LuaMethod("turtle.compareUp")]
    public static bool CompareUp() => default;

    /// <summary>
    /// Check if the block below the turtle is equal to the item in the currently selected slot.
    /// </summary>
    /// <returns>boolean If the block and item are equal.</returns>
    [LuaMethod("turtle.compareDown")]
    public static bool CompareDown() => default;
        
    /// <summary>
    /// Attack the entity in front of the turtle.
    /// </summary>
    /// <returns>boolean Whether an entity was attacked.</returns>
    [LuaMethod("turtle.attack")]
    public static bool Attack() => default;
        
    /// <summary>
    /// Attack the entity in front of the turtle.
    /// </summary>
    /// <param name="side">The specific tool to use.</param>
    /// <returns>boolean Whether an entity was attacked.</returns>
    [LuaMethod("turtle.attack")]
    public static bool Attack(TurtleSide side) => default;
        
    /// <summary>
    /// Attack the entity above the turtle.
    /// </summary>
    /// <returns>boolean Whether an entity was attacked.</returns>
    [LuaMethod("turtle.attackUp")]
    public static bool AttackUp() => default;
        
    /// <summary>
    /// Attack the entity above the turtle.
    /// </summary>
    /// <param name="side">The specific tool to use.</param>
    /// <returns>boolean Whether an entity was attacked.</returns>
    [LuaMethod("turtle.attackUp")]
    public static bool AttackUp(TurtleSide side) => default;
        
    /// <summary>
    /// Attack the entity below the turtle.
    /// </summary>
    /// <returns>boolean Whether an entity was attacked.</returns>
    [LuaMethod("turtle.attackDown")]
    public static bool AttackDown() => default;
        
    /// <summary>
    /// Attack the entity below the turtle.
    /// </summary>
    /// <param name="side">The specific tool to use.</param>
    /// <returns>boolean Whether an entity was attacked.</returns>
    [LuaMethod("turtle.attackDown")]
    public static bool AttackDown(TurtleSide side) => default;
        
    /// <summary>
    /// Suck an item from the inventory in front of the turtle, or from an item floating in the world.
    /// This will pull items into the first acceptable slot, starting at the currently selected one.
    /// </summary>
    /// <returns>boolean Whether items were picked up.</returns>
    [LuaMethod("turtle.suck")]
    public static bool Suck() => default;
        
    /// <summary>
    /// Suck an item from the inventory in front of the turtle, or from an item floating in the world.
    /// This will pull items into the first acceptable slot, starting at the currently selected one.
    /// </summary>
    /// <param name="count">number The number of items to suck. If not given, up to a stack of items will be picked up.</param>
    /// <returns>boolean Whether items were picked up.</returns>
    [LuaMethod("turtle.suck")]
    public static bool Suck(int count) => default;
        
    /// <summary>
    /// Suck an item from the inventory above the turtle, or from an item floating in the world.
    /// This will pull items into the first acceptable slot, starting at the currently selected one.
    /// </summary>
    /// <returns>boolean Whether items were picked up.</returns>
    [LuaMethod("turtle.suckUp")]
    public static bool SuckUp() => default;
        
    /// <summary>
    /// Suck an item from the inventory above the turtle, or from an item floating in the world.
    /// This will pull items into the first acceptable slot, starting at the currently selected one.
    /// </summary>
    /// <param name="count">number The number of items to suck. If not given, up to a stack of items will be picked up.</param>
    /// <returns>boolean Whether items were picked up.</returns>
    [LuaMethod("turtle.suckUp")]
    public static bool SuckUp(int count) => default;
        
    /// <summary>
    /// Suck an item from the inventory below the turtle, or from an item floating in the world.
    /// This will pull items into the first acceptable slot, starting at the currently selected one.
    /// </summary>
    /// <returns>boolean Whether items were picked up.</returns>
    [LuaMethod("turtle.suckDown")]
    public static bool SuckDown() => default;
        
    /// <summary>
    /// Suck an item from the inventory below the turtle, or from an item floating in the world.
    /// This will pull items into the first acceptable slot, starting at the currently selected one.
    /// </summary>
    /// <param name="count">number The number of items to suck. If not given, up to a stack of items will be picked up.</param>
    /// <returns>boolean Whether items were picked up.</returns>
    [LuaMethod("turtle.suckDown")]
    public static bool SuckDown(int count) => default;
        
    /// <summary>
    /// Get the maximum amount of fuel this turtle currently holds.
    /// </summary>
    /// <returns>number The current amount of fuel a turtle this turtle has.</returns>
    [LuaMethod("turtle.getFuelLevel")]
    public static int GetFuelLevel() => default;
        
    /// <summary>
    /// Refuel this turtle.
    /// While most actions a turtle can perform (such as digging or placing blocks) are free, moving consumes fuel from the turtle's internal buffer. If a turtle has no fuel, it will not move.
    /// refuel refuels the turtle, consuming fuel items (such as coal or lava buckets) from the currently selected slot and converting them into energy. This finishes once the turtle is fully refuelled or all items have been consumed.
    /// </summary>
    /// <returns>boolean Whether or not the turtle was refueled.</returns>
    [LuaMethod("turtle.refuel")]
    public static bool Refuel() => default;
        
    /// <summary>
    /// Refuel this turtle.
    /// While most actions a turtle can perform (such as digging or placing blocks) are free, moving consumes fuel from the turtle's internal buffer. If a turtle has no fuel, it will not move.
    /// refuel refuels the turtle, consuming fuel items (such as coal or lava buckets) from the currently selected slot and converting them into energy. This finishes once the turtle is fully refuelled or all items have been consumed.
    /// </summary>
    /// <param name="count">number The maximum number of items to consume. One can pass 0 to check if an item is combustable or not.</param>
    /// <returns>boolean Whether or not the turtle was refueled.</returns>
    [LuaMethod("turtle.refuel")]
    public static bool Refuel(int count) => default;
        
    /// <summary>
    /// Compare the item in the currently selected slot to the item in another slot.
    /// </summary>
    /// <param name="slot">number The slot to compare to.</param>
    /// <returns>boolean If the two items are equal.</returns>
    [LuaMethod("turtle.compareTo")]
    public static bool CompareTo(int slot) => default;
        
    /// <summary>
    /// Move an item from the selected slot to another one.
    /// </summary>
    /// <param name="slot">number The slot to move this item to.</param>
    /// <returns>boolean If some items were successfully moved.</returns>
    [LuaMethod("turtle.transferTo")]
    public static bool TransferTo(int slot) => default;
        
    /// <summary>
    /// Move an item from the selected slot to another one.
    /// </summary>
    /// <param name="slot">number The slot to move this item to.</param>
    /// <param name="count">number The maximum number of items to move.</param>
    /// <returns>boolean If some items were successfully moved.</returns>
    [LuaMethod("turtle.transferTo")]
    public static bool TransferTo(int slot, int count) => default;
        
    /// <summary>
    /// Get the currently selected slot.
    /// </summary>
    /// <returns>number The current slot.</returns>
    [LuaMethod("turtle.getSelectedSlot")]
    public static int GetSelectedSlot() => default;
        
    /// <summary>
    /// Get the maximum amount of fuel this turtle can hold.
    /// By default, normal turtles have a limit of 20,000 and advanced turtles of 100,000.
    /// </summary>
    /// <returns>number The maximum amount of fuel a turtle can hold.</returns>
    [LuaMethod("turtle.getFuelLimit")]
    public static int GetFuelLimit() => default;
        
    /// <summary>
    /// Equip (or unequip) an item on the left side of this turtle.
    /// This finds the item in the currently selected slot and attempts to equip it to the left side of the turtle. The previous upgrade is removed and placed into the turtle's inventory. If there is no item in the slot, the previous upgrade is removed, but no new one is equipped.
    /// </summary>
    /// <returns>boolean Whether or not the item was equipped.</returns>
    [LuaMethod("turtle.equipLeft")]
    public static bool EquipLeft() => default;
        
    /// <summary>
    /// Equip (or unequip) an item on the right side of this turtle.
    /// This finds the item in the currently selected slot and attempts to equip it to the left side of the turtle. The previous upgrade is removed and placed into the turtle's inventory. If there is no item in the slot, the previous upgrade is removed, but no new one is equipped.
    /// </summary>
    /// <returns>boolean Whether or not the item was equipped.</returns>
    [LuaMethod("turtle.equipRight")]
    public static bool EquipRight() => default;
        
    /// <summary>
    /// Get the upgrade currently equipped on the left of the turtle.
    /// </summary>
    /// <returns>Information about the currently equipped item, or null if no upgrade is equipped.</returns>
    [LuaMethod("turtle.getEquippedLeft")]
    public static ItemDetail GetEquippedLeft() => default;
        
    /// <summary>
    /// Get the upgrade currently equipped on the right of the turtle.
    /// </summary>
    /// <returns>Information about the currently equipped item, or null if no upgrade is equipped.</returns>
    [LuaMethod("turtle.getEquippedRight")]
    public static ItemDetail GetEquippedRight() => default;
        
    /// <summary>
    /// Get information about the block in front of the turtle.
    /// </summary>
    /// <returns>
    /// A tuple containing:
    /// - A boolean indicating whether a block was found.
    /// - The details of the item if a block was found.
    /// </returns>
    [LuaMethod("turtle.inspect", CallMethodFlags.WrapAsTable)]
    public static (bool, BlockDetail) Inspect() => default;
        
    /// <summary>
    /// Get information about the block above the turtle.
    /// </summary>
    /// <returns>
    /// A tuple containing:
    /// - A boolean indicating whether a block was found.
    /// - The details of the item if a block was found.
    /// </returns>
    [LuaMethod("turtle.inspectUp", CallMethodFlags.WrapAsTable)]
    public static (bool, BlockDetail) InspectUp() => default;
        
    /// <summary>
    /// Get information about the block below the turtle.
    /// </summary>
    /// <returns>
    /// A tuple containing:
    /// - A boolean indicating whether a block was found.
    /// - The details of the item if a block was found.
    /// </returns>
    [LuaMethod("turtle.inspectDown", CallMethodFlags.WrapAsTable)]
    public static (bool, BlockDetail) InspectDown() => default;
        
    /// <summary>
    /// Get information about the items in the selected slot.
    /// </summary>
    /// <returns>Information about the item in this slot, or null if it is empty.</returns>
    [LuaMethod("turtle.getItemDetail")]
    public static SimpleItemDetail GetItemDetail() => default;
        
    /// <summary>
    /// Get information about the items in the given slot.
    /// </summary>
    /// <param name="slot">number The slot to get information about.</param>
    /// <returns>Information about the item in this slot, or null if it is empty.</returns>
    [LuaMethod("turtle.getItemDetail")]
    public static SimpleItemDetail GetItemDetail(int slot) => default;
        
    /// <summary>
    /// Get detailed information about the items in the given slot.
    /// </summary>
    /// <param name="slot">number The slot to get information about.</param>
    /// <param name="detailed">boolean Whether to include "detailed" information. When true the method will contain much more information about the item at the cost of taking longer to run.</param>
    /// <returns>Information about the item in this slot, or null if it is empty.</returns>
    [LuaMethod("turtle.getItemDetail")]
    public static ItemDetail GetItemDetail(int slot, bool detailed) => default;
        
    /// <summary>
    /// Craft a recipe based on the turtle's inventory. The turtle's inventory should set up like a crafting grid. For instance, to craft sticks, slots 1 and 5 should contain planks. All other slots should be empty, including those outside the crafting "grid".
    /// </summary>
    /// <returns>boolean Whether or not the item was crafted.</returns>
    [LuaMethod("turtle.craft")]
    public static bool Craft() => default;
        
    /// <summary>
    /// Craft a recipe based on the turtle's inventory. The turtle's inventory should set up like a crafting grid. For instance, to craft sticks, slots 1 and 5 should contain planks. All other slots should be empty, including those outside the crafting "grid".
    /// </summary>
    /// <param name="limit">The maximum number of crafting steps to run, must be at least 1 not greater than 64.</param>
    /// <returns>boolean Whether or not the item was crafted.</returns>
    [LuaMethod("turtle.craft")]
    public static bool Craft(int limit) => default;
}