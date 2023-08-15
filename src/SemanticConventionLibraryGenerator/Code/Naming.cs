namespace SemanticConventionLibraryGenerator.Code;

public static class Naming
{
    public static string SnakeToPascal(ReadOnlySpan<char> snake)
    {
        Span<char> pascal = stackalloc char[snake.Length];
        int index = 0;
        bool upper = true;
        foreach (var ch in snake)
        {
            if (ch == '_')
            {
                upper = true;
            }
            else
            {
                pascal[index++] = upper ? char.ToUpperInvariant(ch) : ch;
                upper = false;
            }
        }

        return new string(pascal.Slice(0, index));
    }
}