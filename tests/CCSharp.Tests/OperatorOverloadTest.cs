using System;
using CCSharp.Attributes;

namespace CCSharp.Tests;

[LuaProgram]
public static class OperatorOverloadTest
{
    [LuaClass]
    public class Vector3
    {
        public float X;
        public float Y;
        public float Z;

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Vector3 operator *(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }

        public static Vector3 operator -(Vector3 vector)
        {
            return new Vector3(-vector.X, -vector.Y, -vector.Z);
        }

        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ", " + Z + ")";
            //return $"({X}, {Y}, {Z})";
        }
    }

    [LuaMain]
    public static void Start()
    {
        Vector3 vectorA = new(10,10,10);
        Vector3 vectorB = new(0,0,5);
        Console.WriteLine(vectorA + vectorB);
        Console.WriteLine(vectorA * vectorB);
        Console.WriteLine(-vectorB);
        Console.WriteLine(vectorA == vectorB);
    }
}