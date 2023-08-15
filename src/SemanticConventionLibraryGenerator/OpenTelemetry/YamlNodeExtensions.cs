using System.Diagnostics.CodeAnalysis;
using YamlDotNet.RepresentationModel;

namespace SemanticConventionLibraryGenerator.OpenTelemetry;

public static class YamlNodeExtensions
{
    public static bool TryGetMappingNode(this YamlNode node, string key,
        [NotNullWhen(true)] out YamlMappingNode? mappingNode)
    {
        if (node is YamlMappingNode mn) return TryGetMappingNode(mn, key, out mappingNode);

        mappingNode = null;
        return false;
    }

    public static bool TryGetMappingNode(this YamlMappingNode node, string key,
        [NotNullWhen(true)] out YamlMappingNode? mappingNode)
    {
        var keyNode = new YamlScalarNode(key);
        if (node.Children.TryGetValue(keyNode, out var found))
        {
            mappingNode = found as YamlMappingNode;
            return mappingNode != null;
        }

        mappingNode = null;
        return false;
    }

    public static bool TryGetString(this YamlMappingNode node, string key, [NotNullWhen(true)] out string? value)
    {
        var keyNode = new YamlScalarNode(key);
        if (node.Children.TryGetValue(keyNode, out var found))
        {
            if (found is YamlScalarNode { Value: not null } scalar)
            {
                value = scalar.Value;
                return true;
            }
        }

        value = null;
        return false;
    }

    public static bool TryGetStringArray(this YamlMappingNode node, string key, [NotNullWhen(true)] out string[]? array)
    {
        var keyNode = new YamlScalarNode(key);
        if (node.Children.TryGetValue(keyNode, out var found))
        {
            if (found is YamlSequenceNode { Children: { Count: > 0 } } sequence)
            {
                array = sequence.GetStrings().ToArray();
                return true;
            }
        }

        array = null;
        return false;
    }

    private static IEnumerable<string> GetStrings(this YamlSequenceNode sequence)
    {
        foreach (var child in sequence.Children.OfType<YamlScalarNode>())
        {
            if (child.Value is { Length: > 0 } str) yield return str.Trim();
        }
    }

    public static bool TryGetSequenceNode(this YamlNode node, string key,
        [NotNullWhen(true)] out YamlSequenceNode? sequenceNode)
    {
        if (node is YamlMappingNode mn)
        {
            var keyNode = new YamlScalarNode(key);
            if (mn.Children.TryGetValue(keyNode, out var found))
            {
                sequenceNode = found as YamlSequenceNode;
                return sequenceNode != null;
            }
        }

        sequenceNode = null;
        return false;
    }
}