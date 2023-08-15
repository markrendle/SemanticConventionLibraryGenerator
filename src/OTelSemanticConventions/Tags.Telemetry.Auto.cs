namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Telemetry
    {
        public static partial class Auto
        {
            public const string Prefix = "telemetry.auto";

            /// <summary>
            /// The version string of the auto instrumentation agent, if used.
            /// </summary>
            /// <example>
            /// e.g. <c>1.2.3</c>
            /// </example>
            public const string Version = $"{Prefix}.auto.version";
        }
    }
}
