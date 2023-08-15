namespace SemanticConventionLibraryGenerator.GitHub;

public class ModelFile
{
    public ModelFile(string path, Uri downloadUri)
    {
        Path = path;
        DownloadUri = downloadUri;
    }

    public string Path { get; }
    public Uri DownloadUri { get; }
}