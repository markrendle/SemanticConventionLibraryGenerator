namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Deployment
    {
        public const string Prefix = "deployment";

        /// <summary>
        /// Name of the [deployment environment](https://en.wikipedia.org/wiki/Deployment_environment) (aka deployment tier).
        /// </summary>
        /// <example>
        /// e.g. <c>staging</c>, <c>production</c>
        /// </example>
        public const string Environment = $"{Prefix}.environment";
    }
}
