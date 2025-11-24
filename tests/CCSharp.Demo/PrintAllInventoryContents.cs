using System;
using System.Linq;
using CCSharp.Attributes;
using CCSharp.ComputerCraft;
using CCSharp.ComputerCraft.Peripherals;

namespace CCSharp.Demo;

/// <summary>
/// This will print out all the items in every inventory connected to this computer
/// It will group up and sum stacks of the same item using linq
/// </summary>
[LuaProgram]
public static class PrintAllInventoryContents
{
    [LuaMain]
    public static void Start()
    {
        Inventory[] inventories = Peripheral.FindAll<Inventory>();
        foreach (Inventory inventory in inventories)
        {
            Console.WriteLine("Contents of: " + Peripheral.GetName(inventory));
            Console.WriteLine("------------------");
            foreach (var groupedItems in inventory.List().GroupBy(x => x.Name).ToArray())
            {
                string name = groupedItems.First().Name;
                Console.WriteLine(name + ": " + groupedItems.Sum(x => x.Count));
            }
            Console.WriteLine();
        }
    }
}