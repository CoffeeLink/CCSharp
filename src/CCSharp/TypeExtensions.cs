using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CCSharp.Attributes;
using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Nodes;

namespace CCSharp;

internal static class TypeExtensions
{
    public static List<Type> GetAllBaseTypesAndInterfaces(this Type type)
    {
        if (type == null)
            throw new ArgumentNullException(nameof(type));

        List<Type> result = new List<Type>();

        // Get base class hierarchy
        Type baseType = type;
        while (baseType != null)
        {
            result.Add(baseType);
            baseType = baseType.BaseType;
        }

        // Get interfaces implemented by the target type and its base classes
        var interfaces = type.GetInterfaces();
        result.AddRange(interfaces);

        return result.Distinct().ToList(); // Remove duplicates if any
    }
    
    public static string GetLuaClassName(this Type type, LuaCompileFlags compileFlags, LuaClassAttribute attribute = null)
    {
        attribute ??= type.GetCustomAttribute<LuaClassAttribute>();
        string baseName = attribute?.Name ?? type.Name;
        if ((compileFlags & LuaCompileFlags.IncludeNamespaces) != 0 && type.Namespace != null)
            return $"{type.Namespace.Replace('.', '_')}_{baseName}";
        return baseName;
    }
    
    public static ConstantValueNode GetTypeValueNode(this Type type, LuaCompileFlags compileFlags)
    {
        if ((compileFlags & LuaCompileFlags.UseMetadataTokenForCSharpTypes) == 0)
            return new ConstantValueNode(DataValueType.String, type.GetLuaClassName(compileFlags));
        else
            return new ConstantValueNode(DataValueType.Integer, type.MetadataToken);
    }
}