using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Peripherals;

[LuaImplicitTypeArgument("energy_storage")]
public class EnergyStorage : CCPeripheral
{
    /// <summary>
    /// Get the energy of this block.
    /// </summary>
    /// <returns>number The energy stored in this block, in FE.</returns>
    [LuaMethod("getEnergy")]
    public int GetEnergy() => default;
    
    /// <summary>
    /// Get the maximum amount of energy this block can store.
    /// </summary>
    /// <returns>number The energy capacity of this block.</returns>
    [LuaMethod("getEnergyCapacity")]
    public int GetEnergyCapacity() => default;
}