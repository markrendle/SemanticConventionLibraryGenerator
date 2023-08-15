// See https://aka.ms/new-console-template for more information

using SemanticConventionLibraryGenerator;
using SemanticConventionLibraryGenerator.Code;
using SemanticConventionLibraryGenerator.GitHub;
using SemanticConventionLibraryGenerator.OpenTelemetry;

var command = CommandLine.GetCommand(args);

if (command is DownloadCommand download)
{
    var gitHubApiClient = new GitHubApiClient();

    var modelFiles = await gitHubApiClient.GetFiles();

    foreach (var modelFile in modelFiles)
    {
        Console.WriteLine($"{modelFile.Path} - {modelFile.DownloadUri}");
        var yaml = await gitHubApiClient.GetYaml(modelFile.DownloadUri);
        var path = Path.Combine(download.Output, modelFile.Path);
        var directory = Path.GetDirectoryName(path);
        Directory.CreateDirectory(directory!);
        await using var file = File.CreateText(path);
        await file.WriteAsync(yaml);
    }

    return;
}

if (command is GenerateCommand generate)
{
    
    var model = await ModelBuilder.Build(generate.Input);

    if (model is null) return;

    var generator = new Generator(model, generate.Output);
    await generator.Generate();
}

// var model = new Model();
//
// foreach (var group in new YamlParser().Parse(yaml))
// {
//     model.Add(group);
// }
