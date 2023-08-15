namespace SemanticConventionLibraryGenerator.OpenTelemetry;

public sealed class OTelAttribute : OTelEntityBase
{
    public string Id { get; set; }
    public string Type { get; set; }
    public override string FullyQualifiedId => Group?.Prefix is { Length: > 0 } prefix ? $"{prefix}.{Id}" : Id;
}