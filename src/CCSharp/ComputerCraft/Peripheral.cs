using System;
using CCSharp.Attributes;
using CCSharp.ComputerCraft.Peripherals;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.ComputerCraft;

[LuaEnum(typeof(PeripheralSide))]
public enum PeripheralSide
{
    [LuaEnumValue("left")] Left,
    [LuaEnumValue("right")] Right,
    [LuaEnumValue("front")] Front,
    [LuaEnumValue("back")] Back,
    [LuaEnumValue("top")] Top,
    [LuaEnumValue("bottom")] Bottom
}
public static class Peripheral
{
    /// <summary>
    /// Provides a list of all peripherals available.
    /// If a device is located directly next to the system, then its name will be listed as the side it is attached to. If a device is attached via a Wired Modem, then it'll be reported according to its name on the wired network.
    /// </summary>
    /// <returns>A list of the names of all attached peripherals.</returns>
    [LuaMethod("peripheral.getNames")]
    public static string[] GetNames() => default;
    
    /// <summary>
    /// Determines if a peripheral is present with the given name.
    /// </summary>
    /// <param name="name">The side or network name that you want to check.</param>
    /// <returns>boolean If a peripheral is present with the given name.</returns>
    [LuaMethod("peripheral.isPresent")]
    public static bool IsPresent(string name) => default;
    
    /// <summary>
    /// Determines if a peripheral is present on the given side.
    /// </summary>
    /// <param name="side">The side that you want to check.</param>
    /// <returns>boolean If a peripheral is present on the given side.</returns>
    [LuaMethod("peripheral.isPresent")]
    public static bool IsPresent(PeripheralSide side) => default;
    
    /// <summary>
    /// Get the types of a named peripheral.
    /// </summary>
    /// <param name="name">The name of the peripheral to find.</param>
    /// <returns>string[] The peripheral's types, or null if it is not present.</returns>
    [LuaMethod("peripheral.getType", CallMethodFlags.WrapAsTable)]
    public static string[] GetType(string name) => default;
    
    /// <summary>
    /// Get the types of a peripheral.
    /// </summary>
    /// <param name="side">The side of the peripheral to find.</param>
    /// <returns>string[] The peripheral's types, or null if it is not present.</returns>
    [LuaMethod("peripheral.getType", CallMethodFlags.WrapAsTable)]
    public static string[] GetType(PeripheralSide side) => default;
    
    /// <summary>
    /// Get the types of a wrapped peripheral.
    /// </summary>
    /// <param name="peripheral">The wrapped peripheral.</param>
    /// <returns>string[] The peripheral's types.</returns>
    [LuaMethod("peripheral.getType", CallMethodFlags.WrapAsTable)]
    public static string[] GetType(CCPeripheral peripheral) => default;
    
    /// <summary>
    /// Check if a peripheral is of a particular type.
    /// </summary>
    /// <param name="name">The name of the peripheral.</param>
    /// <param name="type">The type to check.</param>
    /// <returns>boolean If the peripheral has a particular type, or null if it is not present.</returns>
    [LuaMethod("peripheral.hasType")]
    public static bool? HasType(string name, string type) => default;
    
    /// <summary>
    /// Check if a peripheral is of a particular type.
    /// </summary>
    /// <param name="side">The side of the peripheral.</param>
    /// <param name="type">The type to check.</param>
    /// <returns>boolean If the peripheral has a particular type, or null if it is not present.</returns>
    [LuaMethod("peripheral.hasType")]
    public static bool? HasType(PeripheralSide side, string type) => default;
    
    /// <summary>
    /// Check if a peripheral is of a particular type.
    /// </summary>
    /// <param name="peripheral">The wrapped peripheral.</param>
    /// <param name="type">The type to check.</param>
    /// <returns>boolean If the peripheral has a particular type.</returns>
    [LuaMethod("peripheral.hasType")]
    public static bool HasType(CCPeripheral peripheral, string type) => default;
    
    /// <summary>
    /// Get all available methods for the peripheral with the given name.
    /// </summary>
    /// <param name="name">The name of the peripheral to find.</param>
    /// <returns>string... The peripheral's types, or null if it is not present.</returns>
    [LuaMethod("peripheral.getMethods")]
    public static string[] GetMethods(string name) => default;
    
    /// <summary>
    /// Get all available methods for the peripheral with the given name.
    /// </summary>
    /// <param name="side">The side of the peripheral to find.</param>
    /// <returns>string... A list of methods provided by this peripheral, or null if it is not present.</returns>
    [LuaMethod("peripheral.getMethods")]
    public static string[] GetMethods(PeripheralSide side) => default;
    
    /// <summary>
    /// Get the name of a peripheral wrapped with peripheral.wrap.
    /// </summary>
    /// <param name="peripheral">The peripheral to get the name of.</param>
    /// <returns>string The name of the given peripheral.</returns>
    [LuaMethod("peripheral.getName")]
    public static string GetName(CCPeripheral peripheral) => default;
    
    /// <summary>
    /// Call a method on the peripheral with the given name.
    /// </summary>
    /// <param name="name">The name of the peripheral to invoke the method on.</param>
    /// <param name="method">The name of the method.</param>
    /// <param name="args">Additional arguments to pass to the method.</param>
    /// <returns>The return values of the peripheral method.</returns>
    [LuaMethod("peripheral.call")]
    public static T Call<T>(string name, string method, params object[] args) => default;
    
    /// <summary>
    /// Call a method on the peripheral on the given side.
    /// </summary>
    /// <param name="side">The side of the peripheral to invoke the method on.</param>
    /// <param name="method">The name of the method.</param>
    /// <param name="args">Additional arguments to pass to the method.</param>
    /// <returns>The return values of the peripheral method.</returns>
    [LuaMethod("peripheral.call")]
    public static TResult Call<TResult>(PeripheralSide side, string method, params object[] args) => default;
    
    /// <summary>
    /// Wrap all functions available on a peripheral into an implementation class
    /// </summary>
    /// <param name="name">The name of the peripheral to wrap.</param>
    /// <typeparam name="TPeripheral">Peripheral implementation class.</typeparam>
    /// <returns>Wrapped peripheral object, or null if there is no peripheral present with the given name.</returns>
    [LuaMethod("peripheral.wrap")]
    public static TPeripheral Wrap<TPeripheral>(string name) where TPeripheral : CCPeripheral => default;
    
    /// <summary>
    /// Wrap all functions available on a peripheral into an implementation class
    /// </summary>
    /// <param name="side">The side of the peripheral to wrap.</param>
    /// <typeparam name="TPeripheral">Peripheral implementation class.</typeparam>
    /// <returns>Wrapped peripheral object, or null if there is no peripheral present with the given name.</returns>
    [LuaMethod("peripheral.wrap")]
    public static TPeripheral Wrap<TPeripheral>(PeripheralSide side) where TPeripheral : CCPeripheral => default;
    
    /// <summary>
    /// Find all peripherals of a specific type.
    /// </summary>
    /// <param name="type">The type of peripheral to look for.</param>
    /// <typeparam name="TPeripheral">Peripheral implementation class.</typeparam>
    /// <returns>0 or more peripherals.</returns>
    [LuaMethod("peripheral.find", CallMethodFlags.WrapAsTable)]
    public static TPeripheral[] FindAll<TPeripheral>(string type) where TPeripheral : CCPeripheral => default;
    
    /// <summary>
    /// Find all peripherals of a specific type.
    /// </summary>
    /// <param name="type">The type of peripheral to look for.</param>
    /// <param name="filter">A filter function, which takes the peripheral's name and the peripheral itself and returns if it should be included in the result.</param>
    /// <typeparam name="TPeripheral">Peripheral implementation class.</typeparam>
    /// <returns>0 or more peripherals matching the given filters.</returns>
    [LuaMethod("peripheral.find", CallMethodFlags.WrapAsTable)]
    public static TPeripheral[] FindAll<TPeripheral>(string type, Func<string, TPeripheral, bool> filter) where TPeripheral : CCPeripheral => default;
    
    /// <summary>
    /// Find all peripherals of a specific type.
    /// </summary>
    /// <param name="type">The type of peripheral to look for.</param>
    /// <typeparam name="TPeripheral">Peripheral implementation class.</typeparam>
    /// <returns>Peripheral matching the given type</returns>
    [LuaMethod("peripheral.find")]
    public static TPeripheral Find<TPeripheral>(string type) where TPeripheral : CCPeripheral => default;
    
    /// <summary>
    /// Find a peripheral of a specific type given a filter.
    /// </summary>
    /// <param name="type">The type of peripheral to look for.</param>
    /// <param name="filter">A filter function, which takes the peripheral's name and the peripheral itself and returns if it should be included in the result.</param>
    /// <typeparam name="TPeripheral">Peripheral implementation class.</typeparam>
    /// <returns>Peripheral matching the given type and filter.</returns>
    /// 
    [LuaMethod("peripheral.find")]
    public static TPeripheral Find<TPeripheral>(string type, Func<string, TPeripheral, bool> filter) where TPeripheral : CCPeripheral => default;
    
    /// <summary>
    /// Find all peripherals of a specific type.
    /// </summary>
    /// <typeparam name="TPeripheral">Peripheral implementation class.</typeparam>
    /// <returns>0 or more peripherals.</returns>
    [LuaMethod("peripheral.find", CallMethodFlags.WrapAsTable | CallMethodFlags.ImplicitReturnTypeArgument)]
    public static TPeripheral[] FindAll<TPeripheral>() where TPeripheral : CCPeripheral => default;
    
    /// <summary>
    /// Find all peripherals of a specific type.
    /// </summary>
    /// <param name="filter">A filter function, which takes the peripheral's name and the peripheral itself and returns if it should be included in the result.</param>
    /// <typeparam name="TPeripheral">Peripheral implementation class.</typeparam>
    /// <returns>0 or more peripherals matching the given filters.</returns>
    [LuaMethod("peripheral.find", CallMethodFlags.WrapAsTable | CallMethodFlags.ImplicitReturnTypeArgument)]
    public static TPeripheral[] FindAll<TPeripheral>(Func<string, TPeripheral, bool> filter) where TPeripheral : CCPeripheral => default;
    
    /// <summary>
    /// Find all peripherals of a specific type.
    /// </summary>
    /// <typeparam name="TPeripheral">Peripheral implementation class.</typeparam>
    /// <returns>Peripheral matching the given type</returns>
    [LuaMethod("peripheral.find", CallMethodFlags.ImplicitReturnTypeArgument)]
    public static TPeripheral Find<TPeripheral>() where TPeripheral : CCPeripheral => default;
    
    /// <summary>
    /// Find a peripheral of a specific type given a filter.
    /// </summary>
    /// <param name="filter">A filter function, which takes the peripheral's name and the peripheral itself and returns if it should be included in the result.</param>
    /// <typeparam name="TPeripheral">Peripheral implementation class.</typeparam>
    /// <returns>Peripheral matching the given type and filter.</returns>
    /// 
    [LuaMethod("peripheral.find", CallMethodFlags.ImplicitReturnTypeArgument)]
    public static TPeripheral Find<TPeripheral>(Func<string, TPeripheral, bool> filter) where TPeripheral : CCPeripheral => default;
}