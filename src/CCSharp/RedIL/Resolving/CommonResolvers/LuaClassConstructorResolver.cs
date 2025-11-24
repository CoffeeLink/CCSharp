using System.Collections.Generic;
using System.Linq;
using CCSharp.RedIL.Nodes;

namespace CCSharp.RedIL.Resolving.CommonResolvers;

class LuaClassConstructorResolver : RedILObjectResolver
{
    public string Name { get; set; }
    public string SourceLuaClass { get; set; }

    public LuaClassConstructorResolver(string name)
    {
        Name = name;
    }
    
    public override ExpressionNode Resolve(Context context, ExpressionNode[] arguments, ExpressionNode[] elements)
    {
        if (elements != null && elements.Length > 0)
        {
            //Adds initializer argument if there are initializer elements
            arguments = arguments.Append(new DictionaryTableDefinitionNode(elements
                .Select(e => e as ArrayTableDefinitionNode)
                .Select(e => new KeyValuePair<ExpressionNode, ExpressionNode>(e.Elements[0], e.Elements[1]))
                .ToList())).ToArray();
        }
        return new CallCustomMethodNode(Name, null, SourceLuaClass, false, arguments);
    }
}