using System;
using System.Collections.Generic;
using System.Linq;
using CCSharp.Attributes;
using CCSharp.RedIL.Enums;
using CCSharp.RedIL.Nodes;
using CCSharp.RedIL.Resolving.Attributes;

namespace CCSharp.RedIL.Resolving.Types;

class LinqResolverPack
{
        
    class LinqStatementResolver : RedILMethodResolver
    {
        private string _method;

        public LinqStatementResolver(string arg)
        {
            _method = arg;
        }
            
        public override RedILNode Resolve(Context context, ExpressionNode caller, ExpressionNode[] arguments)
        {
            string wrapping = null;
            if (caller is not ChainedModuleMethodNode)
            {
                wrapping = "linq.from";
            }
            return new ChainedModuleMethodNode(_method, wrapping, caller, arguments);
        }
    }
        
    [RedILDataType(DataValueType.Unknown)]
    [RequireModule("linq")]
    class EnumerableProxy
    {
        [RedILResolve(typeof(LinqStatementResolver), "toTable")]
        public TSource[] ToArray<TSource>(IEnumerable<TSource> enumerable) => default;
        [RedILResolve(typeof(LinqStatementResolver), "toTable")]
        public List<TSource> ToList<TSource>(IEnumerable<TSource> enumerable) => default;
        [RedILResolve(typeof(LinqStatementResolver), "groupBy")]
        public IGrouping<TKey, TSource> GroupBy<TSource, TKey>(IEnumerable<TSource> enumerable, Func<TSource, TKey> keySelector) => default;
        [RedILResolve(typeof(LinqStatementResolver), "orderBy")]
        public IEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> enumerable, Func<TSource, TKey> keySelector) => default;
        [RedILResolve(typeof(LinqStatementResolver), "orderByDescending")]
        public IEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> enumerable, Func<TSource, TKey> keySelector) => default;
        [RedILResolve(typeof(LinqStatementResolver), "where")]
        public IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> enumerable, Func<TSource, bool> keySelector) => default;
        [RedILResolve(typeof(LinqStatementResolver), "select")]
        public IEnumerable<TSource> Select<TSource, TResult>(IEnumerable<TSource> enumerable, Func<TSource, TResult> keySelector) => default;
        [RedILResolve(typeof(LinqStatementResolver), "distinct")]
        public IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> enumerable) => default;
        [RedILResolve(typeof(LinqStatementResolver), "take")]
        public IEnumerable<TSource> Take<TSource>(IEnumerable<TSource> enumerable, int n) => default;
        [RedILResolve(typeof(LinqStatementResolver), "first")]
        public TSource First<TSource>(IEnumerable<TSource> enumerable) => default;
        [RedILResolve(typeof(LinqStatementResolver), "firstOrDefault")]
        public TSource FirstOrDefault<TSource>(IEnumerable<TSource> enumerable, TSource defaultValue) => default;
        [RedILResolve(typeof(LinqStatementResolver), "firstOrDefault")]
        public TSource FirstOrDefault<TSource>(IEnumerable<TSource> enumerable) => default;
        [RedILResolve(typeof(LinqStatementResolver), "count")]
        public int Count<TSource>(IEnumerable<TSource> enumerable) => default;
        [RedILResolve(typeof(LinqStatementResolver), "count")]
        public long LongCount<TSource>(IEnumerable<TSource> enumerable) => default;
        [RedILResolve(typeof(LinqStatementResolver), "any")]
        public bool Any<TSource>(IEnumerable<TSource> enumerable, Func<TSource, bool> predicate) => default;
        [RedILResolve(typeof(LinqStatementResolver), "sum")]
        public TSumType Sum<TSource, TSumType>(IEnumerable<TSource> enumerable, Func<TSource, TSumType> predicate) => default;
    }

    public static Dictionary<Type, Type> GetMapToProxy()
    {
        return new Dictionary<Type, Type>()
        {
            { typeof(Enumerable), typeof(EnumerableProxy) }
        };
    }
}