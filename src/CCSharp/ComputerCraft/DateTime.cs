using CCSharp.Attributes;

namespace CCSharp.ComputerCraft;

[LuaImplicitTypeArgument("!*t")]
public class DateTime
{
    //Date
    [LuaProperty("year")]
    public int Year { get; set; }
    [LuaProperty("month")]
    public int Month { get; set; }
    [LuaProperty("day")]
    public int Day { get; set; }
    [LuaProperty("yday")]
    public int YearDay { get; set; }
    [LuaProperty("wday")]
    public int WeekDay { get; set; }
    //Time
    [LuaProperty("hour")]
    public int Hour { get; set; }
    [LuaProperty("min")]
    public int Min { get; set; }
    [LuaProperty("sec")]
    public int Sec { get; set; }
    [LuaProperty("isdst")]
    public bool IsDaylightSavings { get; set; }
}