If you cast a type to another type without type checking you will not get an error for an invalid cast
* * *
You will not get an index out of bounds error when accessing outside of a list/array instead you will receive back null/nil
* * *
You cannot have class members in your main [LuaProgram] with the same name as any [LuaClass] so
```csharp
public static Person Person { get; set; }
```
would be invalid unless you overwrite the name like so
```csharp
[LuaProperty("uniqueIdentifier")]
public static Person Person { get; set; }
```
or if you enable ```IncludeNamespaces``` on your [LuaProgram] it will prepend the namespace into the lua class name preventing this conflict
* * *
