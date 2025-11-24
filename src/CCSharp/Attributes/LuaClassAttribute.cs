using System;

namespace CCSharp.Attributes;

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