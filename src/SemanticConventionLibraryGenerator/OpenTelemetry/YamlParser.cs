using YamlDotNet.RepresentationModel;

namespace SemanticConventionLibraryGenerator.OpenTelemetry;

public class YamlParser
{
    public IEnumerable<Group> Parse(string yaml)
    {
        var stream = new YamlStream();
        stream.Load(new StringReader(yaml));

        foreach (var document in stream.Documents)
        {
            if (document.RootNode.TryGetSequenceNode("groups", out var groups))
            {
                foreach (var node in groups.OfType<YamlMappingNode>())
                {
                    if (!node.TryGetString("id", out var groupId)) continue;
                    if (!node.TryGetSequenceNode("attributes", out var attributes)) continue;
                    
                    node.TryGetString("brief", out var brief);
                    node.TryGetString("prefix", out var prefix);
                    node.TryGetString("type", out var groupType);

                    var group = new Group
                    {
                        Id = groupId,
                        Brief = brief,
                        Prefix = prefix,
                        Type = groupType
                    };

                    foreach (var attribute in attributes.OfType<YamlMappingNode>())
                    {
                        TryParseEntity(group, attribute);
                    }

                    yield return group;
                }
            }
        }
    }

    private static void TryParseEntity(Group group, YamlMappingNode node)
    {
        if (node.TryGetString("id", out var id))
        {
            var attribute = new OTelAttribute
            {
                Id = id,
                Group = group,
            };
            PopulateAttribute(attribute, node);
            group.Attributes.Add(attribute);
            return;
        }

        if (!node.TryGetString("ref", out var r)) return;
        
        var reference = new OTelReference(r)
        {
            Group = group,
        };
        PopulateEntity(reference, node);
        group.References.Add(reference);
    }

    private static void PopulateAttribute(OTelAttribute attribute, YamlMappingNode node)
    {
        if (node.TryGetString("type", out var str)) attribute.Type = str.Trim();
        PopulateEntity(attribute, node);
    }

    private static void PopulateEntity(OTelEntityBase entity, YamlMappingNode node)
    {
        if (node.TryGetString("brief", out var str)) entity.Brief = str.Trim();
        if (node.TryGetString("note", out str)) entity.Note = str.Trim();

        if (TryGetRequirementLevel(node, out var requirementLevel)) entity.RequirementLevel = requirementLevel;

        if (node.TryGetStringArray("examples", out var examples)) entity.Examples = examples;
    }

    private static bool TryGetRequirementLevel(YamlMappingNode node, out RequirementLevel requirementLevel)
    {
        if (node.TryGetString("requirement_level", out var str))
        {
            requirementLevel = new RequirementLevel(str);
            return true;
        }

        if (node.TryGetMappingNode("requirement_level", out var rlNode))
        {
            var child = rlNode.Children.FirstOrDefault();
            if (child.Key is YamlScalarNode { Value: { Length: > 0 } level })
            {
                if (child.Value is YamlScalarNode { Value: { Length: > 0 } text })
                {
                    requirementLevel = new RequirementLevel(level.Trim(), text.Trim());
                    return true;
                }
            }
        }

        requirementLevel = default;
        return false;
    }
}

public readonly struct RequirementLevel
{
    public RequirementLevel(string level, string? text = null)
    {
        Level = level;
        Text = text;
    }

    public string Level { get; }
    public string? Text { get; }
}