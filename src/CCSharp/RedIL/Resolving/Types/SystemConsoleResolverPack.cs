using System;
using System.Collections.Generic;
using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.RedIL.Resolving.Types;

class SystemConsoleResolverPack
{
    [RedILDataType(DataValueType.Unknown)]
    class ConsoleProxy
    {
        [RedILResolve(typeof(CallCustomMethodResolver), "print")]
        public static void WriteLine() {}
        
        [RedILResolve(typeof(CallCustomMethodResolver), "print")]
        public static void WriteLine(string str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "print")]
        public static void WriteLine(int str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "print")]
        public static void WriteLine(double str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "print")]
        public static void WriteLine(float str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "print")]
        public static void WriteLine(byte str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "print")]
        public static void WriteLine(short str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "print")]
        public static void WriteLine(bool str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "print")]
        public static void WriteLine(object str) {}
            
        [RedILResolve(typeof(CallCustomMethodResolver), "write")]
        public static void Write(string str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "write")]
        public static void Write(int str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "write")]
        public static void Write(double str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "write")]
        public static void Write(float str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "write")]
        public static void Write(byte str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "write")]
        public static void Write(short str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "write")]
        public static void Write(bool str) {}

        [RedILResolve(typeof(CallCustomMethodResolver), "write")]
        public static void Write(object str) {}
    }

    public static Dictionary<Type, Type> GetMapToProxy()
    {
        return new Dictionary<Type, Type>()
        {
            { typeof(Console), typeof(ConsoleProxy) }
        };
    }
}