namespace CCSharp;

public static class FormatHelper
{
    public static string IndentLuaCode(string lua)
    {
        const string indent = "  ";
        return indent + lua.Replace("\n", $"\n{indent}");
    }
}