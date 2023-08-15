namespace SemanticConventionLibraryGenerator.OpenTelemetry;

public sealed class OTelReference : OTelEntityBase
{
    public OTelReference(string reference)
    {
        Reference = reference;
    }

    public string Reference { get; }
    public override string FullyQualifiedId => Group?.Prefix is { Length: > 0 } prefix ? $"{prefix}.{Reference}" : Reference;
}