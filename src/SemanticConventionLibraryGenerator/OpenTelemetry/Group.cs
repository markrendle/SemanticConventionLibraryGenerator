namespace SemanticConventionLibraryGenerator.OpenTelemetry;

public class Group : IEquatable<Group>
{
    public string Id { get; init; } = null!;
    public string? Type { get; init; }
    public string? Brief { get; init; }
    public string? Prefix { get; init; }
    public List<OTelAttribute> Attributes { get; } = new();
    public List<OTelReference> References { get; } = new();

    public bool Equals(Group? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Group)obj);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public static bool operator ==(Group? left, Group? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Group? left, Group? right)
    {
        return !Equals(left, right);
    }
}