namespace SemanticConventionLibraryGenerator;

public static class CommandLine
{
    public static CommandBase GetCommand(string[] args)
    {
        if (args.Length == 0) throw new InvalidOperationException("No args");
        if (args[0].ToLowerInvariant() == "download")
        {
            if (args.Length < 3) throw new InvalidOperationException("Invalid args");
            if (args[1] is "-o" or "--output")
            {
                return new DownloadCommand(args[2]);
            }
        }

        if (args[0].ToLowerInvariant() == "generate")
        {
            if (args.Length < 5) throw new InvalidOperationException("Invalid args");
            string? input = null;
            string? output = null;
            for (int i = 1; i < args.Length; i++)
            {
                if (args[i] is "-o" or "--output")
                {
                    output = args[++i];
                }
                else if (args[i] is "-i" or "--input")
                {
                    input = args[++i];
                }
            }

            if (input is { Length: > 0 } && output is { Length: > 0 })
            {
                return new GenerateCommand(input, output);
            }
        }

        throw new InvalidOperationException("Invalid args");
    }
}

public abstract class CommandBase
{
    
}

public class DownloadCommand : CommandBase
{
    public DownloadCommand(string output)
    {
        Output = output;
    }

    public string Output { get; }
}

public class GenerateCommand : CommandBase
{
    public GenerateCommand(string input, string output)
    {
        Input = input;
        Output = output;
    }

    public string Input { get; }
    public string Output { get; }
}
