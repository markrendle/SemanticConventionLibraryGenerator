namespace SemanticConventionLibraryGenerator.Code;

public class Field
{
    public Field(string name, string value, string? brief, string? note, string[]? examples)
    {
        Name = name;
        Value = value;
        Brief = brief;
        Note = note;
        Examples = examples;
    }

    public string Name { get; }
    public string Value { get; }
    public string? Brief { get; }
    public string? Note { get; }
    public string[]? Examples { get; }
}