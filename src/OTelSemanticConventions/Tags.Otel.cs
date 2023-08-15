namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Otel
    {
        public const string Prefix = "otel";

        /// <summary>
        /// Name of the code, either "OK" or "ERROR". MUST NOT be set if the status code is UNSET.
        /// </summary>
        public const string StatusCode = $"{Prefix}.status_code";

        /// <summary>
        /// Description of the Status if it has a value, otherwise not set.
        /// </summary>
        /// <example>
        /// e.g. <c>resource not found</c>
        /// </example>
        public const string StatusDescription = $"{Prefix}.status_description";
    }
}
