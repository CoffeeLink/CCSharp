using System;

namespace CCSharp.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class LuaClassAttribute : Attribute
{
   public string Name { get; private set; }

   public LuaClassAttribute()
   {
      
   }

   public LuaClassAttribute(string name)
   {
      Name = name;
   }
}