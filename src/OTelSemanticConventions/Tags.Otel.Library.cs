namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Otel
    {
        public static partial class Library
        {
            public const string Prefix = "otel.library";

            /// <summary>
            /// Deprecated, use the `otel.scope.name` attribute.
            /// </summary>
            /// <example>
            /// e.g. <c>io.opentelemetry.contrib.mongodb</c>
            /// </example>
            public const string Name = $"{Prefix}.name";

            /// <summary>
            /// Deprecated, use the `otel.scope.version` attribute.
            /// </summary>
            /// <example>
            /// e.g. <c>1.0.0</c>
            /// </example>
            public const string Version = $"{Prefix}.version";
        }
    }
}
