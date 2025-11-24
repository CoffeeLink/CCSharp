using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace CCSharp
{
    [Generator]
    public class LuaSourceGenerator : IIncrementalGenerator
    {
        // This will hold a list of classes that need to be processed.
        private readonly List<ClassDeclarationSyntax> _classDeclarations = new List<ClassDeclarationSyntax>();

        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var classesWithAttributes = context.SyntaxProvider
                .CreateSyntaxProvider(
                    predicate: static (syntaxNode, _) => IsClassWithAttribute(syntaxNode),
                    transform: static (context, _) => (ClassDeclarationSyntax)context.Node
                )
                .Where(static classDeclaration => classDeclaration != null);

            context.RegisterSourceOutput(classesWithAttributes, (context, classDeclaration) =>
            {
                // Store each class for later processing
                _classDeclarations.Add(classDeclaration);

                // Generate code for each class that includes the GenerateFile method
                var generatedCode = GenerateClassCode(classDeclaration);

                // Write the generated code to a .cs file
                var csFileName = $"{classDeclaration.Identifier.Text}LuaGenerator.cs";
                context.AddSource(csFileName, SourceText.From(generatedCode, Encoding.UTF8));
            });

            // After all classes are processed, generate a Main method to run them
            context.RegisterSourceOutput(classesWithAttributes.Collect(), (context, _) =>
            {
                var mainCode = GenerateMainMethodCode();
                context.AddSource("GenerateLuaFiles.cs", SourceText.From(mainCode, Encoding.UTF8));
            });
        }

        private static string GenerateClassCode(ClassDeclarationSyntax classDeclaration)
        {
            var className = classDeclaration.Identifier.Text;
            var namespaceName = GetNamespace(classDeclaration);
            string namespaceUsing = string.IsNullOrEmpty(namespaceName) ? "" : $"using {namespaceName};";
            var code = $@"using System;
using System.IO;
using CCSharp;
{namespaceUsing}

namespace CCSharpGenerated
{{
    public class {className}LuaGenerator
    {{
        public static void GenerateFile()
        {{
            Console.WriteLine(""Generating {className}.lua..."");
            LuaProgram.FromType(typeof({className})).Export();
        }}
    }}
}}";
            return code;
        }

        private string GenerateMainMethodCode()
        {
            List<string> classNames = _classDeclarations.Select(c => c.Identifier.Text).ToList();
            var methodCalls = string.Join(Environment.NewLine, classNames.Select(name => $"{name}LuaGenerator.GenerateFile();"));

            var mainCode = $@"
using System;

namespace CCSharpGenerated
{{
    public class GenerateLuaFiles
    {{
        public static void Main(string[] args)
        {{
            {methodCalls}
        }}
    }}
}}";

            return mainCode;
        }

        private static string? GetNamespace(ClassDeclarationSyntax classDeclaration)
        {
            SyntaxNode? current = classDeclaration;
            while (current != null)
            {
                if (current is BaseNamespaceDeclarationSyntax ns)
                {
                    return ns.Name.ToString();
                }
                current = current.Parent;
            }
            return null;
        }

        private static bool IsClassWithAttribute(SyntaxNode syntaxNode)
        {
            if (syntaxNode is ClassDeclarationSyntax classDeclaration)
            {
                return classDeclaration.AttributeLists
                    .Any(attributeList => attributeList.Attributes
                        .Any(attribute => attribute.Name.ToString() == "LuaProgram"));
            }
            return false;
        }
    }
}
