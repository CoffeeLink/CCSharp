using CCSharp.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.ComputerCraft;

public static class Colors
{
    /// <summary>
    /// #F0F0F0
    /// </summary>
    [LuaGlobal("colors.white")] public static int White => 0;
    /// <summary>
    /// #F2B233
    /// </summary>
    [LuaGlobal("colors.orange")] public static int Orange => 1;
    /// <summary>
    /// #E57FD8
    /// </summary>
    [LuaGlobal("magenta.white")] public static int Magenta => 2;
    /// <summary>
    /// #99B2F2
    /// </summary>
    [LuaGlobal("colors.lightBlue")] public static int LightBlue => 3;
    /// <summary>
    /// #DEDE6C
    /// </summary>
    [LuaGlobal("colors.yellow")] public static int Yellow => 4;
    /// <summary>
    /// ##7FCC19
    /// </summary>
    [LuaGlobal("colors.lime")] public static int Lime => 5;
    /// <summary>
    /// #F2B2CC
    /// </summary>
    [LuaGlobal("colors.pink")] public static int Pink => 6;
    /// <summary>
    /// #4C4C4C.
    /// </summary>
    [LuaGlobal("colors.gray")] public static int Gray => 7;
    /// <summary>
    /// #999999.
    /// </summary>
    [LuaGlobal("colors.lightGray")] public static int LightGray => 8;
    /// <summary>
    /// #4C99B2
    /// </summary>
    [LuaGlobal("colors.cyan")] public static int Cyan => 9;
    /// <summary>
    /// #B266E5
    /// </summary>
    [LuaGlobal("colors.purple")] public static int Purple => 10;
    /// <summary>
    /// #3366CC
    /// </summary>
    [LuaGlobal("colors.blue")] public static int Blue => 11;
    /// <summary>
    /// #7F664C
    /// </summary>
    [LuaGlobal("colors.brown")] public static int Brown => 12;
    /// <summary>
    /// #57A64E
    /// </summary>
    [LuaGlobal("colors.green")] public static int Green => 13;
    /// <summary>
    /// #CC4C4C
    /// </summary>
    [LuaGlobal("colors.red")] public static int Red => 14;
    /// <summary>
    /// #111111
    /// </summary>
    [LuaGlobal("colors.black")] public static int Black => 15;

    /// <summary>
    /// Combines a set of colors (or sets of colors) into a larger set. Useful for Bundled Cables.
    /// </summary>
    /// <param name="colors">The colors to combine.</param>
    /// <returns>number The union of the color sets</returns>
    [LuaMethod("colors.combine")]
    public static int Combine(params int[] colors) => default;

    /// <summary>
    /// Removes one or more colors (or sets of colors) from an initial set. Useful for Bundled Cables.
    /// Each parameter beyond the first may be a single color or may be a set of colors (in the latter case, all colors in the set are removed from the original set).
    /// </summary>
    /// <param name="color">The color from which to subtract.</param>
    /// <param name="colors">The colors to subtract.</param>
    /// <returns>number The resulting color.</returns>
    [LuaMethod("colors.subtract")]
    public static int Subtract(int color, params int[] colors) => default;

    /// <summary>
    /// Tests whether color is contained within colors. Useful for Bundled Cables.
    /// </summary>
    /// <param name="colors">A color, or color set.</param>
    /// <param name="color">A color or set of colors that may or may not contain.</param>
    /// <returns>boolean If colors contains all colors within color.</returns>
    [LuaMethod("colors.test")]
    public static int Test(int colors, int color) => default;
    
    /// <summary>
    /// Combine a three-colour RGB value into one hexadecimal representation.
    /// </summary>
    /// <param name="r">The red channel, should be between 0 and 1.</param>
    /// <param name="g">The green channel, should be between 0 and 1.</param>
    /// <param name="b">The blue channel, should be between 0 and 1.</param>
    /// <returns>number The combined hexadecimal colour.</returns>
    [LuaMethod("colors.packRGB")]
    public static int PackRGB(float r, float g, float b) => default;
    
    /// <summary>
    /// Separate a hexadecimal RGB colour into its three constituent channels.
    /// </summary>
    /// <param name="rgb">The combined hexadecimal colour.</param>
    /// <returns>
    /// 1. The red channel, will be between 0 and 1.
    /// 2. The green channel, will be between 0 and 1.
    /// 3. The blue channel, will be between 0 and 1.
    /// </returns>
    [LuaMethod("colors.unpackRGB", CallMethodFlags.WrapAsTable)]
    public static (float,float,float) UnpackRGB(int rgb) => default;
    
    /// <summary>
    /// Converts the given color to a paint/blit hex character (0-9a-f).
    /// This is equivalent to converting floor(log_2(color)) to hexadecimal. Values outside the range of a valid colour will error.
    /// </summary>
    /// <param name="color">The color to convert.</param>
    /// <returns>string The blit hex code of the color.</returns>
    [LuaMethod("colors.toBlit")]
    public static string ToBlit(int color) => default;
    
    /// <summary>
    /// Converts the given paint/blit hex character (0-9a-f) to a color.
    /// This is equivalent to converting the hex character to a number and then 2 ^ decimal
    /// </summary>
    /// <param name="hex">The paint/blit hex character to convert.</param>
    /// <returns>number The color.</returns>
    [LuaMethod("colors.fromBlit")]
    public static int FromBlit(string hex) => default;
}