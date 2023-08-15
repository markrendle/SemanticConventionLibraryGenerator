using System.Diagnostics.CodeAnalysis;

namespace SemanticConventionLibraryGenerator.OpenTelemetry;

public class Model
{
    private readonly Dictionary<string, OTelEntityBase> _entities = new();

    public bool TryGetAttribute(string id, [NotNullWhen(true)] out OTelAttribute? attribute)
    {
        if (_entities.TryGetValue(id, out var entity) && entity is OTelAttribute a)
        {
            attribute = a;
            return true;
        }

        attribute = null;
        return false;
    }

    public IEnumerable<OTelAttribute> Attributes => _entities.Values.OfType<OTelAttribute>();
    public IEnumerable<OTelReference> References => _entities.Values.OfType<OTelReference>();

    public bool TryGetReference(string id, [NotNullWhen(true)] out OTelReference? reference)
    {
        if (_entities.TryGetValue(id, out var entity) && entity is OTelReference r)
        {
            reference = r;
            return true;
        }

        reference = null;
        return false;
    }

    public void Add(OTelEntityBase oTelEntity)
    {
        _entities[oTelEntity.FullyQualifiedId] = oTelEntity;
    }

    public void Add(Group group)
    {
        foreach (var attribute in group.Attributes)
        {
            Add(attribute);
        }

        foreach (var reference in group.References)
        {
            Add(reference);
        }
    }
}