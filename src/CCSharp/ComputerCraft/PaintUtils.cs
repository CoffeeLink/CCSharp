using CCSharp.Attributes;

namespace CCSharp.ComputerCraft;

public static class PaintUtils
{
    /// <summary>
    /// Parses an image from a multi-line string
    /// </summary>
    /// <param name="image">The string containing the raw-image data.</param>
    /// <returns>table The parsed image data, suitable for use with paintutils.drawImage.</returns>
    [LuaMethod("paintutils.parseImage")]
    public static int[][] ParseImage(string image) => default;
    
    /// <summary>
    /// Loads an image from a file.
    /// You can create a file suitable for being loaded using the paint program.
    /// </summary>
    /// <param name="path">The file to load.</param>
    /// <returns>table The parsed image data, suitable for use with paintutils.drawImage, or null if the file does not exist.</returns>
    [LuaMethod("paintutils.loadImage")]
    public static int[][] LoadImage(string path) => default;
    
    /// <summary>
    /// Draws a single pixel to the current term at the specified position using the background color.
    /// </summary>
    /// <param name="x">The x position to draw at, where 1 is the far left.</param>
    /// <param name="y">The y position to draw at, where 1 is the very top.</param>
    [LuaMethod("paintutils.drawPixel")]
    public static void DrawPixel(int x, int y) { }
    
    /// <summary>
    /// Draws a single pixel to the current term at the specified position.
    /// Be warned, this may change the position of the cursor and the current background colour. You should not expect either to be preserved.
    /// </summary>
    /// <param name="x">The x position to draw at, where 1 is the far left.</param>
    /// <param name="y">The y position to draw at, where 1 is the very top.</param>
    /// <param name="color">The color of this pixel.</param>
    [LuaMethod("paintutils.drawPixel")]
    public static void DrawPixel(int x, int y, int color) { }
    
    /// <summary>
    /// Draws a single pixel to the current term at the specified position using the background color.
    /// </summary>
    /// <param name="coords">A tuple containing the coords where 1,1 is in the upper left corner.</param>
    [LuaMethod("paintutils.drawPixel")]
    public static void DrawPixel((int,int) coords) { }
    
    /// <summary>
    /// Draws a single pixel to the current term at the specified position.
    /// Be warned, this may change the position of the cursor and the current background colour. You should not expect either to be preserved.
    /// </summary>
    /// <param name="coords">A tuple containing the coords where 1,1 is in the upper left corner.</param>
    /// <param name="color">The color of this pixel.</param>
    [LuaMethod("paintutils.drawPixel")]
    public static void DrawPixel((int,int) coords, int color) { }
    
    /// <summary>
    /// Draws a straight line from the start to end position using the background color.
    /// </summary>
    /// <param name="startX">The starting x position of the line.</param>
    /// <param name="startY">The starting y position of the line.</param>
    /// <param name="endX">The end x position of the line.</param>
    /// <param name="endY">The end y position of the line.</param>
    [LuaMethod("paintutils.drawLine")]
    public static void DrawLine(int startX, int startY, int endX, int endY) { }
    
    /// <summary>
    /// Draws a straight line from the start to end position.
    /// Be warned, this may change the position of the cursor and the current background colour. You should not expect either to be preserved.
    /// </summary>
    /// <param name="startX">The starting x position of the line.</param>
    /// <param name="startY">The starting y position of the line.</param>
    /// <param name="endX">The end x position of the line.</param>
    /// <param name="endY">The end y position of the line.</param>
    /// <param name="color">The color of this line.</param>
    [LuaMethod("paintutils.drawPixel")]
    public static void DrawLine(int startX, int startY, int endX, int endY, int color) { }
    
    /// <summary>
    /// Draws the outline of a box on the current term from the specified start position to the specified end position using the background color.
    /// </summary>
    /// <param name="startX">The starting x position of the box.</param>
    /// <param name="startY">The starting y position of the box.</param>
    /// <param name="endX">The end x position of the box.</param>
    /// <param name="endY">The end y position of the box.</param>
    [LuaMethod("paintutils.drawBox")]
    public static void DrawBox(int startX, int startY, int endX, int endY) { }
    
    /// <summary>
    /// Draws the outline of a box on the current term from the specified start position to the specified end position.
    /// Be warned, this may change the position of the cursor and the current background colour. You should not expect either to be preserved.
    /// </summary>
    /// <param name="startX">The starting x position of the box.</param>
    /// <param name="startY">The starting y position of the box.</param>
    /// <param name="endX">The end x position of the box.</param>
    /// <param name="endY">The end y position of the box.</param>
    /// <param name="color">The color of this line.</param>
    [LuaMethod("paintutils.drawBox")]
    public static void DrawBox(int startX, int startY, int endX, int endY, int color) { }
    
    /// <summary>
    /// Draws a filled box on the current term from the specified start position to the specified end position using the background color.
    /// </summary>
    /// <param name="startX">The starting x position of the box.</param>
    /// <param name="startY">The starting y position of the box.</param>
    /// <param name="endX">The end x position of the box.</param>
    /// <param name="endY">The end y position of the box.</param>
    [LuaMethod("paintutils.drawFilledBox")]
    public static void DrawFilledBox(int startX, int startY, int endX, int endY) { }
    
    /// <summary>
    /// Draws a filled box on the current term from the specified start position to the specified end position.
    /// Be warned, this may change the position of the cursor and the current background colour. You should not expect either to be preserved.
    /// </summary>
    /// <param name="startX">The starting x position of the box.</param>
    /// <param name="startY">The starting y position of the box.</param>
    /// <param name="endX">The end x position of the box.</param>
    /// <param name="endY">The end y position of the box.</param>
    /// <param name="color">The color of this line.</param>
    [LuaMethod("paintutils.drawFilledBox")]
    public static void DrawFilledBox(int startX, int startY, int endX, int endY, int color) { }
    
    /// <summary>
    /// Draw an image loaded by PaintUtils.ParseImage or PaintUtils.LoadImage.
    /// </summary>
    /// <param name="image">The parsed image data.</param>
    /// <param name="x">The x position to start drawing at.</param>
    /// <param name="y">The y position to start drawing at.</param>
    [LuaMethod("paintutils.drawImage")]
    public static void DrawImage(int[][] image, int x, int y) { }
    
    /// <summary>
    /// Draw an image loaded by PaintUtils.ParseImage or PaintUtils.LoadImage.
    /// </summary>
    /// <param name="image">The parsed image data.</param>
    /// <param name="coords">Tuple containing the x and y position to start drawing at.</param>
    [LuaMethod("paintutils.drawImage")]
    public static void DrawImage(int[][] image, (int,int) coords) { }
}