using SemanticConventionLibraryGenerator.Code;
using SemanticConventionLibraryGenerator.OpenTelemetry;

namespace SemanticConventionLibraryGenerator.Tests;

public class YamlParserTests
{
    [Fact]
    public void ParsesHttpRequestMethod()
    {
        var model = CreateModel();

        Assert.True(model.TryGetAttribute("http.request.method", out var actual));

        Assert.Equal("string", actual.Type);
        Assert.Equal("required", actual.RequirementLevel.Level);
        Assert.Equal("HTTP request method.", actual.Brief);
        Assert.StartsWith("HTTP request method value SHOULD", actual.Note);
        Assert.EndsWith("` to the original value.", actual.Note);

        Assert.NotNull(actual.Examples);
        Assert.Collection(actual.Examples,
            e => Assert.Equal("GET", e),
            e => Assert.Equal("POST", e),
            e => Assert.Equal("HEAD", e)
        );
    }

    [Fact]
    public void ParsesHttpRoute()
    {
        var model = CreateModel();

        Assert.True(model.TryGetAttribute("http.route", out var actual));

        Assert.Equal("string", actual.Type);
        Assert.Equal("conditionally_required", actual.RequirementLevel.Level);
        Assert.Equal("If and only if it's available", actual.RequirementLevel.Text);
        Assert.Equal("The matched route (path template in the format used by the respective server framework). See note below", actual.Brief);
        Assert.StartsWith("MUST NOT be populated", actual.Note);
        Assert.EndsWith("if there is one.", actual.Note);

        Assert.NotNull(actual.Examples);
        Assert.Collection(actual.Examples,
            e => Assert.Equal("/users/:userID?", e),
            e => Assert.Equal("{controller}/{action}/{id?}", e)
        );
    }

    [Fact]
    public void ParsesProtocolReference()
    {
        var model = CreateModel();
        
        Assert.True(model.TryGetReference("http.network.protocol.name", out var reference));
        Assert.Collection(reference.Examples!,
            e => Assert.Equal("http", e),
            e => Assert.Equal("spdy", e));
    }

    private static Model? _model;

    private static Model CreateModel()
    {
        if (_model is not null) return _model;
        
        var model = new Model();
        foreach (var group in new YamlParser().Parse(Yamls.HttpCommon))
        {
            model.Add(group);
        }

        return _model = model;
    }
}

public class NamingTests
{
    [Fact]
    public void UnderscoreToPascalCase()
    {
        Assert.Equal("ClientId", Naming.SnakeToPascal("client_id"));
    }
}