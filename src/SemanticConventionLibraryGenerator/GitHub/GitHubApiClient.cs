using System.Net.Http.Json;

namespace SemanticConventionLibraryGenerator.GitHub;

public class GitHubApiClient
{
    private const string RootModelUrl = "https://api.github.com/repos/open-telemetry/semantic-conventions/contents/model?ref=main";
    private readonly HttpClient _httpClient = new()
    {
        DefaultRequestHeaders = {
        {
            "user-agent", "otelsclg/1.0.0"
        } }
    };
    
    public async Task<ModelFile[]> GetFiles()
    {
        var list = new List<ModelFile>();

        await GetFiles(RootModelUrl, list);

        return list.ToArray();
    }

    public async Task<string> GetYaml(Uri uri)
    {
        return await _httpClient.GetStringAsync(uri);
    }

    private async Task GetFiles(string url, List<ModelFile> list)
    {
        var contents = await _httpClient.GetFromJsonAsync<Content[]>(url);

        if (contents is not { Length: > 0 }) return;

        foreach (var content in contents)
        {
            switch (content.Type)
            {
                case "file":
                {
                    if (!content.Name.EndsWith(".yaml")) continue;
                    
                    if (Uri.TryCreate(content.DownloadUrl, UriKind.Absolute, out var downloadUri))
                    {
                        list.Add(new ModelFile(content.Path, downloadUri));
                    }

                    break;
                }
                case "dir":
                    await GetFiles(content.Url, list);
                    break;
            }
        }
    }
}