using System;
using System.Collections.Generic;
using System.Linq;
using CCSharp.Attributes;

namespace CCSharp.Tests;

[LuaProgram]
public static class LuaClassInheritanceTest
{
    [LuaClass]
    public class Animal
    {
        public string Name { get; set; }
        
        public Animal(string name)
        {
            Name = name;
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine(Name + " makes a noise!");
        }
    }

    [LuaClass]
    public class Human : Animal
    {
        public Human(string name) : base(name) { }
    }

    [LuaClass]
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void MakeNoise()
        {
            Console.WriteLine(Name + " goes woof!");
        }
    }

    [LuaClass]
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void MakeNoise()
        {
            Console.WriteLine(Name + " goes meow!");
        }
    }

    [LuaMain]
    public static void Start()
    {
        Human human = new("Bob");
        Dog dog = new("Charlie");
        Cat cat = new("Chowder");
        
        human.MakeNoise();
        dog.MakeNoise();
        cat.MakeNoise();
        
        //Test type checking from a generic type
        Animal animal = cat;
        if (animal is Cat asCat)
        {
            Console.WriteLine(asCat.Name + " is a cat");
        }

        if (animal is not Dog asDog)
        {
            Console.WriteLine(animal.Name + " is not a dog");
        }

        if (new List<Animal> { cat, dog }[0] is Cat)
        {
            Console.WriteLine("list starts with a cat");
        }
    }
}