using CCSharp.Attributes;

namespace CCSharp.ComputerCraft;

public static class Keys
{
    #region Symbols & Punctuation
    [LuaGlobal("keys.space")] public static int Space => 32;
    [LuaGlobal("keys.apostrophe")] public static int Apostrophe => 39;
    [LuaGlobal("keys.comma")] public static int Comma => 44;
    [LuaGlobal("keys.minus")] public static int Minus => 45;
    [LuaGlobal("keys.period")] public static int Period => 46;
    [LuaGlobal("keys.slash")] public static int Slash => 47;
    [LuaGlobal("keys.semicolon")] public static int Semicolon => 59;
    [LuaGlobal("keys.equals")] public static int Equals => 61;
    [LuaGlobal("keys.leftBracket")] public static int LeftBracket => 91;
    [LuaGlobal("keys.backslash")] public static int Backslash => 92;
    [LuaGlobal("keys.rightBracket")] public static int RightBracket => 93;
    [LuaGlobal("keys.grave")] public static int Grave => 96;
    #endregion
    #region Letters
    [LuaGlobal("keys.a")] public static int A => 65;
    [LuaGlobal("keys.b")] public static int B => 66;
    [LuaGlobal("keys.c")] public static int C => 67;
    [LuaGlobal("keys.d")] public static int D => 68;
    [LuaGlobal("keys.e")] public static int E => 69;
    [LuaGlobal("keys.f")] public static int F => 70;
    [LuaGlobal("keys.g")] public static int G => 71;
    [LuaGlobal("keys.h")] public static int H => 72;
    [LuaGlobal("keys.i")] public static int I => 73;
    [LuaGlobal("keys.j")] public static int J => 74;
    [LuaGlobal("keys.k")] public static int K => 75;
    [LuaGlobal("keys.l")] public static int L => 76;
    [LuaGlobal("keys.m")] public static int M => 77;
    [LuaGlobal("keys.n")] public static int N => 78;
    [LuaGlobal("keys.o")] public static int O => 79;
    [LuaGlobal("keys.p")] public static int P => 80;
    [LuaGlobal("keys.q")] public static int Q => 81;
    [LuaGlobal("keys.r")] public static int R => 82;
    [LuaGlobal("keys.s")] public static int S => 83;
    [LuaGlobal("keys.t")] public static int T => 84;
    [LuaGlobal("keys.u")] public static int U => 85;
    [LuaGlobal("keys.v")] public static int V => 86;
    [LuaGlobal("keys.w")] public static int W => 87;
    [LuaGlobal("keys.x")] public static int X => 88;
    [LuaGlobal("keys.y")] public static int Y => 89;
    [LuaGlobal("keys.z")] public static int Z => 90;
    #endregion
    #region Number Keys
    [LuaGlobal("keys.zero")] public static int Zero => 48;
    [LuaGlobal("keys.one")] public static int One => 49;
    [LuaGlobal("keys.two")] public static int Two => 50;
    [LuaGlobal("keys.three")] public static int Three => 51;
    [LuaGlobal("keys.four")] public static int Four => 52;
    [LuaGlobal("keys.five")] public static int Five => 53;
    [LuaGlobal("keys.six")] public static int Six => 54;
    [LuaGlobal("keys.seven")] public static int Seven => 55;
    [LuaGlobal("keys.eight")] public static int Eight => 56;
    [LuaGlobal("keys.nine")] public static int Nine => 57;
    #endregion
    #region Arrow & Navigation Keys
    [LuaGlobal("keys.up")] public static int Up => 265;
    [LuaGlobal("keys.down")] public static int Down => 264;
    [LuaGlobal("keys.left")] public static int Left => 263;
    [LuaGlobal("keys.right")] public static int Right => 262;
    [LuaGlobal("keys.home")] public static int Home => 268;
    [LuaGlobal("keys.end")] public static int End => 269;
    [LuaGlobal("keys.pageUp")] public static int PageUp => 266;
    [LuaGlobal("keys.pageDown")] public static int PageDown => 267;
    [LuaGlobal("keys.insert")] public static int Insert => 260;
    [LuaGlobal("keys.delete")] public static int Delete => 261;
    #endregion
    #region System & Control Keys
    [LuaGlobal("keys.tab")] public static int Tab => 258;
    [LuaGlobal("keys.enter")] public static int Enter => 257;
    [LuaGlobal("keys.return")] public static int Return => 257;
    [LuaGlobal("keys.backspace")] public static int Backspace => 259;
    [LuaGlobal("keys.capsLock")] public static int CapsLock => 280;
    [LuaGlobal("keys.scrollLock")] public static int ScrollLock => 281;
    [LuaGlobal("keys.numLock")] public static int NumLock => 282;
    [LuaGlobal("keys.printScreen")] public static int PrintScreen => 283;
    [LuaGlobal("keys.pause")] public static int Pause => 284;
    #endregion
    #region Function Keys
    [LuaGlobal("keys.f1")] public static int F1 => 290;
    [LuaGlobal("keys.f2")] public static int F2 => 291;
    [LuaGlobal("keys.f3")] public static int F3 => 292;
    [LuaGlobal("keys.f4")] public static int F4 => 293;
    [LuaGlobal("keys.f5")] public static int F5 => 294;
    [LuaGlobal("keys.f6")] public static int F6 => 295;
    [LuaGlobal("keys.f7")] public static int F7 => 296;
    [LuaGlobal("keys.f8")] public static int F8 => 297;
    [LuaGlobal("keys.f9")] public static int F9 => 298;
    [LuaGlobal("keys.f10")] public static int F10 => 299;
    [LuaGlobal("keys.f11")] public static int F11 => 300;
    [LuaGlobal("keys.f12")] public static int F12 => 301;
    [LuaGlobal("keys.f13")] public static int F13 => 302;
    [LuaGlobal("keys.f14")] public static int F14 => 303;
    [LuaGlobal("keys.f15")] public static int F15 => 304;
    [LuaGlobal("keys.f16")] public static int F16 => 305;
    [LuaGlobal("keys.f17")] public static int F17 => 306;
    [LuaGlobal("keys.f18")] public static int F18 => 307;
    [LuaGlobal("keys.f19")] public static int F19 => 308;
    [LuaGlobal("keys.f20")] public static int F20 => 309;
    [LuaGlobal("keys.f21")] public static int F21 => 310;
    [LuaGlobal("keys.f22")] public static int F22 => 311;
    [LuaGlobal("keys.f23")] public static int F23 => 312;
    [LuaGlobal("keys.f24")] public static int F24 => 313;
    [LuaGlobal("keys.f25")] public static int F25 => 314;
    #endregion
    #region Numpad Keys
    [LuaGlobal("keys.numPad0")] public static int NumPad0 => 320;
    [LuaGlobal("keys.numPad1")] public static int NumPad1 => 321;
    [LuaGlobal("keys.numPad2")] public static int NumPad2 => 322;
    [LuaGlobal("keys.numPad3")] public static int NumPad3 => 323;
    [LuaGlobal("keys.numPad4")] public static int NumPad4 => 324;
    [LuaGlobal("keys.numPad5")] public static int NumPad5 => 325;
    [LuaGlobal("keys.numPad6")] public static int NumPad6 => 326;
    [LuaGlobal("keys.numPad7")] public static int NumPad7 => 327;
    [LuaGlobal("keys.numPad8")] public static int NumPad8 => 328;
    [LuaGlobal("keys.numPad9")] public static int NumPad9 => 329;
    [LuaGlobal("keys.numPadDecimal")] public static int NumPadDecimal => 330;
    [LuaGlobal("keys.numPadDivide")] public static int NumPadDivide => 331;
    [LuaGlobal("keys.numPadMultiply")] public static int NumPadMultiply => 332;
    [LuaGlobal("keys.numPadSubtract")] public static int NumPadSubtract => 333;
    [LuaGlobal("keys.numPadAdd")] public static int NumPadAdd => 334;
    [LuaGlobal("keys.numPadEnter")] public static int NumPadEnter => 335;
    [LuaGlobal("keys.numPadEqual")] public static int NumPadEqual => 336;
    #endregion
    #region Modifiers
    [LuaGlobal("keys.leftShift")] public static int LeftShift => 340;
    [LuaGlobal("keys.rightShift")] public static int RightShift => 344;
    [LuaGlobal("keys.leftCtrl")] public static int LeftCtrl => 341;
    [LuaGlobal("keys.rightCtrl")] public static int RightCtrl => 345;
    [LuaGlobal("keys.leftAlt")] public static int LeftAlt => 342;
    [LuaGlobal("keys.rightAlt")] public static int RightAlt => 346;
    [LuaGlobal("keys.leftSuper")] public static int LeftSuper => 343;
    [LuaGlobal("keys.menu")] public static int Menu => 348;
    #endregion
    

    
    /// <summary>
    /// Translates a numerical key code to a human-readable name. The human-readable name is one of the constants in the keys API.
    /// </summary>
    /// <param name="code">The key code to look up.</param>
    /// <returns>string The name of the key, or null if not a valid key code.</returns>
    [LuaMethod("keys.getName")]
    public static string GetName(int code) => default;
}