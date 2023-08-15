namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Telemetry
    {
        public static partial class Sdk
        {
            public const string Prefix = "telemetry.sdk";

            /// <summary>
            /// The name of the telemetry SDK as defined above.
            /// </summary>
            /// <remarks>
            /// The OpenTelemetry SDK MUST set the `telemetry.sdk.name` attribute to `opentelemetry`.
            /// If another SDK, like a fork or a vendor-provided implementation, is used, this SDK
            /// MUST set the `telemetry.sdk.name` attribute to the fully-qualified class or module
            /// name of this SDK's main entry point or another suitable identifier depending on the
            /// language. The identifier `opentelemetry` is reserved and MUST NOT be used in this
            /// case. All custom identifiers SHOULD be stable across different versions of an implementation.
            /// </remarks>
            /// <example>
            /// e.g. <c>opentelemetry</c>
            /// </example>
            public const string Name = $"{Prefix}.sdk.name";

            /// <summary>
            /// The language of the telemetry SDK.
            /// </summary>
            public const string Language = $"{Prefix}.sdk.language";

            /// <summary>
            /// The version string of the telemetry SDK.
            /// </summary>
            /// <example>
            /// e.g. <c>1.2.3</c>
            /// </example>
            public const string Version = $"{Prefix}.sdk.version";
        }
    }
}
