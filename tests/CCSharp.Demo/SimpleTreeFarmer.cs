using System;
using CCSharp.Attributes;
using CCSharp.ComputerCraft;
using CCSharp.ComputerCraft.Events;
using OperatingSystem = CCSharp.ComputerCraft.OS;

namespace CCSharp.Demo;

/// <summary>
/// A simple single tree farmer
/// For simplicity it uses the logs directly as fuel when it needs to
/// </summary>
[LuaProgram]
public class SimpleTreeFarmer
{
    [LuaMain]
    private static void Start()
    {
        ItemDetail itemDetail = Turtle.GetItemDetail(1, true);
        if (itemDetail == null || !itemDetail.Tags.ContainsKey("minecraft:saplings"))
        {
            Console.WriteLine("Please provide me saplings in my first slot to begin");
            while (itemDetail == null || !itemDetail.Tags.ContainsKey("minecraft:saplings"))
            {
                var inventoryEvent = OS.PullEvent<TurtleInventoryEvent>();
                itemDetail = Turtle.GetItemDetail(1, true);
            }
        }
        
        (bool initialBlockExists, BlockDetail initialBlockDetails) = Turtle.Inspect();
        if (initialBlockExists)
        {
            if (initialBlockDetails.Tags.ContainsKey("minecraft:logs"))
            {
                Console.WriteLine("Placed in front of existing tree, breaking that tree first");
                BreakTree();
            }
            else if (initialBlockDetails.Tags.ContainsKey("minecraft:saplings"))
            {
                Console.WriteLine("Placed in front of existing sapling, waiting for tree to grow");
                WaitForTree();
            }
        }
        PlantAndWait();
    }

    private static void PlantAndWait()
    {
        while (true)
        {
            ItemDetail itemDetail = Turtle.GetItemDetail(1, true);
            if (itemDetail == null || !itemDetail.Tags.ContainsKey("minecraft:saplings"))
            {
                Console.WriteLine("Ran out of saplings, please provide more");
                return;
            }
            Turtle.Select(1);
            if (!Turtle.Place())
            {
                Console.WriteLine("Unable to plant sapling, please clear space");
                return;
            }
            WaitForTree();
        }
    }

    private static void WaitForTree()
    {
        while (true)
        {
            (bool blockExists, BlockDetail blockDetails) = Turtle.Inspect();
            if (blockExists && blockDetails.Tags.ContainsKey("minecraft:logs"))
            {
                BreakTree();
                break;
            }
            OperatingSystem.Sleep(10);
        }
    }

    private static void BreakTree()
    {
        Turtle.Dig();
        while(!Turtle.Forward())
            AttemptRefuel();
        while (true)
        {
            (bool aboveExists, BlockDetail aboveDetails) = Turtle.InspectUp();
            if (!aboveExists || !aboveDetails.Tags.ContainsKey("minecraft:logs")) break;
            Turtle.DigUp();
            while(!Turtle.Up())
                AttemptRefuel();
        }
        while (true)
        {
            (bool downExists, BlockDetail downDetails) = Turtle.InspectDown();
            if (downExists)
            {
                if (!downDetails.Tags.ContainsKey("minecraft:logs")) break;
                Turtle.DigDown();
            }
            while(!Turtle.Down())
                AttemptRefuel();
        }
        while(!Turtle.Back())
            AttemptRefuel();
    }

    private static void AttemptRefuel()
    {
        Turtle.Select(2);
        Turtle.Refuel(1);
    }
}