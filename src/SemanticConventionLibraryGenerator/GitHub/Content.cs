using System.Text.Json.Serialization;

namespace SemanticConventionLibraryGenerator.GitHub;

// ReSharper disable once ClassNeverInstantiated.Global
public class Content
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("path")]
    public string Path { get; set; }
    
    [JsonPropertyName("size")]
    public long Size { get; set; }
    
    [JsonPropertyName("url")]
    public string Url { get; set; }
    
    [JsonPropertyName("download_url")]
    public string DownloadUrl { get; set; }
    
    [JsonPropertyName("type")]
    public string Type { get; set; }
}