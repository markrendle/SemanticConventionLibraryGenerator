namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Http
    {
        public static partial class Request
        {
            public const string Prefix = "http.request";

            /// <summary>
            /// Original HTTP method sent by the client in the request line.
            /// </summary>
            /// <example>
            /// e.g. <c>GeT</c>, <c>ACL</c>, <c>foo</c>
            /// </example>
            public const string MethodOriginal = $"{Prefix}.request.method_original";
        }
    }
}
