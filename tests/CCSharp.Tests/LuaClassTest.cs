using System;
using CCSharp.Attributes;

namespace CCSharp.Tests;

[LuaClass]
public class Person
{
    public string Name { get; }

    public Person(string firstName)
    {
        Name = firstName;
    }
        
    public Person(string firstName, string lastName)
    {
        Name = firstName + " " + lastName;
    }

    public void Greet(string greeting)
    {
        Console.WriteLine(greeting + " " + Name + "!");
    }
}
[LuaProgram]
public static class LuaClassTest
{
    [LuaProperty("uniqueIdentifier")]
    public static Person Person { get; set; }

    [LuaMain]
    public static void Start()
    {
        Person = new Person("gh");
        Person bob = new("Bob");
        bob.Greet("Hi");
        Person boberson = new("Bob", "Boberson");
        boberson.Greet("Hola");
    }
}