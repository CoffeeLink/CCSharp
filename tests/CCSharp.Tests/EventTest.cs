using System;
using CCSharp.Attributes;
using CCSharp.ComputerCraft;
using CCSharp.ComputerCraft.Events;

namespace CCSharp.Tests;

[LuaProgram]
public static class EventTest
{
    [LuaMain]
    public static void Start()
    {
        while (true)
        {
            CCEvent someEvent = OS.PullAnyEvent();
            switch (someEvent)
            {
                case MouseClickEvent mouseClick:
                    Console.WriteLine("Mouse Click on button " + mouseClick.Button + " at " + mouseClick.X + ", " + mouseClick.Y);
                    break;
                case MouseDragEvent mouseDrag:
                    Console.WriteLine("Mouse Drag on button " + mouseDrag.Button + " at " + mouseDrag.X + ", " + mouseDrag.Y);
                    break;
                default:
                    Console.WriteLine("Unhandled event: " + someEvent.EventName);
                    break;
            }
        }
    }
}