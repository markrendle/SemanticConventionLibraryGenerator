using System.CodeDom.Compiler;
using System.Text;
using System.Text.RegularExpressions;
using SemanticConventionLibraryGenerator.GitHub;
using SemanticConventionLibraryGenerator.OpenTelemetry;

namespace SemanticConventionLibraryGenerator.Code;

public class Generator
{
    private readonly Model _model;
    private readonly string _output;
    private readonly Dictionary<string, GroupClass> _classes = new();

    public Generator(Model model, string output)
    {
        _model = model;
        _output = output;
    }

    public async Task Generate()
    {
        GenerateClasses();

        Directory.CreateDirectory(_output);

        foreach (var cls in _classes.Values)
        {
            var filePath = cls.Name is { Length: > 0 }
                ? Path.Combine(_output, $"Tags.{cls.Name}.cs")
                : Path.Combine(_output, "Tags.cs");
            await using var streamWriter = File.CreateText(filePath);
            await using var writer = new IndentedTextWriter(streamWriter);

            await writer.WriteLineAsync($"namespace NewDay.Platform.Telemetry;");
            await writer.WriteLineAsync();

            await writer.WriteLineAsync($"public static partial class Tags");
            await writer.WriteLineAsync("{");
            writer.Indent++;

            foreach (var className in cls.Name.Split('.'))
            {
                if (className is { Length: > 0 })
                {
                    await writer.WriteLineAsync($"public static partial class {className}");
                    await writer.WriteLineAsync("{");
                    writer.Indent++;
                }
            }

            await writer.WriteLineAsync($"public const string Prefix = \"{cls.Prefix}\";");

            var done = new HashSet<string>();

            foreach (var field in cls.Fields)
            {
                if (!done.Add(field.Name)) continue;
                
                await writer.WriteLineNoTabsAsync("");

                await writer.WriteLineAsync("/// <summary>");
                await writer.WriteLineAsync($"/// {field.Brief}");
                await writer.WriteLineAsync("/// </summary>");

                if (field.Note is { Length: > 0 })
                {
                    await writer.WriteLineAsync("/// <remarks>");
                    foreach (var noteLine in WordWrap(field.Note))
                    {
                        await writer.WriteLineAsync($"/// {noteLine}");
                    }
                    await writer.WriteLineAsync("/// </remarks>");
                }

                if (field.Examples is { Length: > 0 })
                {
                    await writer.WriteLineAsync("/// <example>");
                    await writer.WriteAsync($"/// e.g. <c>{field.Examples[0]}</c>");
                    if (field.Examples.Length > 1)
                    {
                        for (int i = 1; i < field.Examples.Length; i++)
                        {
                            await writer.WriteAsync($", <c>{field.Examples[i]}</c>");
                        }
                    }

                    await writer.WriteLineAsync();
                    await writer.WriteLineAsync("/// </example>");
                }

                var name = Naming.SnakeToPascal(field.Name);
                await writer.WriteLineAsync($"public const string {name} = $\"{{Prefix}}.{field.Value}\";");
            }

            while (writer.Indent > 0)
            {
                writer.Indent--;
                await writer.WriteLineAsync("}");
            }

            Console.WriteLine(filePath);
        }
    }

    private static readonly Regex Whitespace = new(@"\s", RegexOptions.Compiled);

    private static IEnumerable<string> WordWrap(string source)
    {
        var builder = new StringBuilder();
        foreach (var noteWord in Whitespace.Split(source))
        {
            if (string.IsNullOrWhiteSpace(noteWord)) continue;
            builder.Append($" {noteWord}");
            if (builder.Length > 80)
            {
                yield return builder.ToString().Trim();
                builder.Clear();
            }
        }

        if (builder.Length > 0)
        {
            yield return builder.ToString().Trim();
        }
    }

    private void GenerateClasses()
    {
        foreach (var attribute in _model.Attributes)
        {
            var id = attribute.FullyQualifiedId.Split('.');
            var fieldName = id.Last();
            var prefix = string.Join('.', id.Take(id.Length - 1));

            var className = string.Join('.', id.Take(id.Length - 1).Select(n => Naming.SnakeToPascal(n)));

            if (!_classes.TryGetValue(className, out var cls))
            {
                cls = new GroupClass(Naming.SnakeToPascal(className), prefix);

                _classes[className] = cls;
            }

            cls.Fields.Add(new Field(fieldName, attribute.Id, attribute.Brief, attribute.Note, attribute.Examples));
        }

        foreach (var reference in _model.References)
        {
            var attribute = _model.Attributes.FirstOrDefault(a => a.FullyQualifiedId == reference.Reference);
            if (attribute is null) continue;

            var fullyQualifiedId = reference.Group?.Prefix + '.' + attribute.Id;

            var id = fullyQualifiedId.Split('.');
            var fieldName = id.Last();
            var prefix = string.Join('.', id.Take(id.Length - 1));

            var className = string.Join('.', id.Take(id.Length - 1).Select(n => Naming.SnakeToPascal(n)));

            if (!_classes.TryGetValue(className, out var cls))
            {
                cls = new GroupClass(Naming.SnakeToPascal(className), prefix);

                _classes[className] = cls;
            }

            cls.Fields.Add(new Field(fieldName, reference.Reference, attribute.Brief, attribute.Note,
                attribute.Examples));
        }
    }
}