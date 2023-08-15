namespace SemanticConventionLibraryGenerator.OpenTelemetry;

public static class ModelBuilder
{
    public static async Task<Model?> Build(string input)
    {
        var parser = new YamlParser();
        var model = new Model();
        var modelPath = Path.Combine(input, "model");
        if (!Directory.Exists(modelPath))
        {
            Console.Error.WriteLine($"{modelPath} not found");
            return null;
        }

        foreach (var file in Directory.EnumerateFiles(modelPath, "*.yaml", SearchOption.AllDirectories))
        {
            if (ShouldIgnore(file)) continue;
            
            Console.WriteLine(file);
            using var reader = File.OpenText(file);
            var yaml = await reader.ReadToEndAsync();
            foreach (var group in parser.Parse(yaml))
            {
                model.Add(group);
            }
        }

        return model;
    }

    private static bool ShouldIgnore(string filePath)
    {
        return filePath.Contains("deprecated", StringComparison.OrdinalIgnoreCase)
               || filePath.Contains("-jvm-", StringComparison.OrdinalIgnoreCase)
               || filePath.Contains(@"\aws\", StringComparison.OrdinalIgnoreCase)
               || filePath.Contains(@"\gcp\", StringComparison.OrdinalIgnoreCase)
               || filePath.Contains(@"heroku", StringComparison.OrdinalIgnoreCase);
    }
}