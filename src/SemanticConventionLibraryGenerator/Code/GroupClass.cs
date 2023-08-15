namespace SemanticConventionLibraryGenerator.Code;

public class GroupClass
{
    public GroupClass(string name, string prefix)
    {
        Name = name;
        Prefix = prefix;
    }

    public string Name { get; }
    public string Prefix { get; set; }

    public List<Field> Fields { get; } = new();
}