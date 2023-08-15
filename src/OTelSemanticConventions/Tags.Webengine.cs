namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Webengine
    {
        public const string Prefix = "webengine";

        /// <summary>
        /// The name of the web engine.
        /// </summary>
        /// <example>
        /// e.g. <c>WildFly</c>
        /// </example>
        public const string Name = $"{Prefix}.name";

        /// <summary>
        /// The version of the web engine.
        /// </summary>
        /// <example>
        /// e.g. <c>21.0.0</c>
        /// </example>
        public const string Version = $"{Prefix}.version";

        /// <summary>
        /// Additional description of the web engine (e.g. detailed version and edition information).
        /// </summary>
        /// <example>
        /// e.g. <c>WildFly Full 21.0.0.Final (WildFly Core 13.0.1.Final) - 2.2.2.Final</c>
        /// </example>
        public const string Description = $"{Prefix}.description";
    }
}
