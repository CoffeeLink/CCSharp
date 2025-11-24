Here is a sample csproj you can use a base, this requires you to have cloned the repo into a folder called CCSharp next to the folder your project is in. Eventually I'll upload this as a nuget package but for now this is simplest
```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net9.0</TargetFramework>
    <LangVersion>latest</LangVersion>
    <RootNamespace>YourRootNamespace</RootNamespace>
  </PropertyGroup>
    
  <ItemGroup>
    <ProjectReference Include="..\CCSharp\src\CCSharp\CCSharp.csproj" OutputItemType="Analyzer" ReferenceOutputAssembly="true"/>
  </ItemGroup>
</Project>
```
The important things there are that your project OutputType is Exe and that CCSharp is included as an analyzer with RefrenceOutputAssembly="true"

This is because the way this works is your project will result in an executable that when run decompiles itself and outputs lua files in the same directory that it's in. Your project will not have a Main entry function as that will be created by the source generator. You can have as many classes as you want with the [LuaProgram] attribute which will get included in the output.

## Attributes
If you ever want to overwrite the generated lua names of anything like classes, fields, properties, methods, etc in the generated lua that can be done by passing a string to their respective attributes. 

### [LuaProgram]
These will generate an executable lua file

Generally you should put [LuaProgram] on static classes, though not explicitly required

There are several optional compile flags but generally you will want the defaults.
#### [LuaMain]
This attribute is just for classes with [LuaProgram], Whatever method you put the [LuaMain] on will be your program entry function.

### [LuaClass]
You will generally be putting this on all the classes you create that you use in your [LuaProgram], inheritance and type checking fully works with these classes. It adds type information in the generated lua to ensure that you can still use interfaces as well.

### [LuaTable]
if you would like to create a class to represent a lua table without generating a class for it you can use [LuaTable]. This class should just have fields and properties, no methods or constructors or anything. Creating instances of these tables will even properly initialize default values for you when it's not passed in through an object initializer.

### [LuaProperty]
Though not explicitly required, you can use this attribute on fields and properties to overwrite their generated lua name. Additionally, you can use this to adapt lua tables with array indexers by passing an integer instead.

### [LuaMethod]
This can be used to overwrite the generated lua name of a method, when using this you need to be careful of name conflicts with overloads. Normally this is handled for you automatically but you will need to resolve it on your own if you overwrite the names. This also has additional compile flags for the method that are only used when adapting an existing lua api.

You'll find the adapter classes for the ComputerCraft api the ComputerCraft namespace, some overloads/names are different in the C# api to account for different outputs, or using types instead of type strings in parameters, etc.