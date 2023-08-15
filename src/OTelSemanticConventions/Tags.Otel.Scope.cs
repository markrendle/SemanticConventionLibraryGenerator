namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Otel
    {
        public static partial class Scope
        {
            public const string Prefix = "otel.scope";

            /// <summary>
            /// The name of the instrumentation scope - (`InstrumentationScope.Name` in OTLP).
            /// </summary>
            /// <example>
            /// e.g. <c>io.opentelemetry.contrib.mongodb</c>
            /// </example>
            public const string Name = $"{Prefix}.name";

            /// <summary>
            /// The version of the instrumentation scope - (`InstrumentationScope.Version` in OTLP).
            /// </summary>
            /// <example>
            /// e.g. <c>1.0.0</c>
            /// </example>
            public const string Version = $"{Prefix}.version";
        }
    }
}
