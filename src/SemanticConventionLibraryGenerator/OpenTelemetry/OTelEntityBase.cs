namespace SemanticConventionLibraryGenerator.OpenTelemetry;

public abstract class OTelEntityBase
{
    public string[]? Examples { get; set; }
    public string? Brief { get; set; }
    public string? Note { get; set; }
    public RequirementLevel RequirementLevel { get; set; }
    public Group? Group { get; set; }
    public abstract string FullyQualifiedId { get; }
}