namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Source
    {
        public const string Prefix = "source";

        /// <summary>
        /// The domain name of the source system.
        /// </summary>
        /// <remarks>
        /// This value may be a host name, a fully qualified domain name, or another host naming
        /// format.
        /// </remarks>
        /// <example>
        /// e.g. <c>foo.example.com</c>
        /// </example>
        public const string Domain = $"{Prefix}.domain";

        /// <summary>
        /// Source address, for example IP address or Unix socket name.
        /// </summary>
        /// <example>
        /// e.g. <c>10.5.3.2</c>
        /// </example>
        public const string Address = $"{Prefix}.address";

        /// <summary>
        /// Source port number
        /// </summary>
        /// <example>
        /// e.g. <c>3389</c>, <c>2888</c>
        /// </example>
        public const string Port = $"{Prefix}.port";
    }
}
