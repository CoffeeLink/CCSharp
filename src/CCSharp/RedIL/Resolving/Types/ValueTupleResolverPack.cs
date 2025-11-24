using System;
using System.Collections.Generic;
using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Resolving.Attributes;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.RedIL.Resolving.Types;

class ValueTupleResolverPack
{
    class ValueTupleProxy<T1, T2>
    {
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 1)]
        public T1 Item1 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 2)]
        public T2 Item2 { get; set; }
    }
    class ValueTupleProxy<T1, T2, T3>
    {
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 1)]
        public T1 Item1 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 2)]
        public T2 Item2 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 3)]
        public T3 Item3 { get; set; }
    }
    class ValueTupleProxy<T1, T2, T3, T4>
    {
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 1)]
        public T1 Item1 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 2)]
        public T2 Item2 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 3)]
        public T3 Item3 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 4)]
        public T3 Item4 { get; set; }
    }
    class ValueTupleProxy<T1, T2, T3, T4, T5>
    {
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 1)]
        public T1 Item1 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 2)]
        public T2 Item2 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 3)]
        public T3 Item3 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 4)]
        public T4 Item4 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 5)]
        public T5 Item5 { get; set; }
    }
    class ValueTupleProxy<T1, T2, T3, T4, T5, T6>
    {
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 1)]
        public T1 Item1 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 2)]
        public T2 Item2 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 3)]
        public T3 Item3 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 4)]
        public T4 Item4 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 5)]
        public T5 Item5 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 6)]
        public T6 Item6 { get; set; }
    }
    class ValueTupleProxy<T1, T2, T3, T4, T5, T6, T7>
    {
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 1)]
        public T1 Item1 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 2)]
        public T2 Item2 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 3)]
        public T3 Item3 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 4)]
        public T4 Item4 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 5)]
        public T5 Item5 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 6)]
        public T6 Item6 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 7)]
        public T7 Item7 { get; set; }
    }
    class ValueTupleProxy<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 1)]
        public T1 Item1 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 2)]
        public T2 Item2 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 3)]
        public T3 Item3 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 4)]
        public T4 Item4 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 5)]
        public T5 Item5 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 6)]
        public T6 Item6 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 7)]
        public T7 Item7 { get; set; }
        [RedILResolve(typeof(TableAccessMemberResolver), DataValueType.Integer, 8)]
        public T8 Item8 { get; set; }
    }
    
    public static Dictionary<Type, Type> GetMapToProxy()
    {
        return new Dictionary<Type, Type>()
        {
            { typeof(ValueTuple<,>), typeof(ValueTupleProxy<,>) },
            { typeof(ValueTuple<,,>), typeof(ValueTupleProxy<,,>) },
            { typeof(ValueTuple<,,,>), typeof(ValueTupleProxy<,,,>) },
            { typeof(ValueTuple<,,,,>), typeof(ValueTupleProxy<,,,,>) },
            { typeof(ValueTuple<,,,,,>), typeof(ValueTupleProxy<,,,,,>) },
            { typeof(ValueTuple<,,,,,,>), typeof(ValueTupleProxy<,,,,,,>) },
            { typeof(ValueTuple<,,,,,,,>), typeof(ValueTupleProxy<,,,,,,,>) },
        };
    }
}