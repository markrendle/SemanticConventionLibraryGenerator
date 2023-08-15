namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Http
    {
        public static partial class Network
        {
            public static partial class Protocol
            {
                public const string Prefix = "http.network.protocol";

                /// <summary>
                /// [OSI Application Layer](https://osi-model.com/application-layer/) or non-OSI equivalent. The value SHOULD be normalized to lowercase.
                /// </summary>
                /// <example>
                /// e.g. <c>amqp</c>, <c>http</c>, <c>mqtt</c>
                /// </example>
                public const string Name = $"{Prefix}.network.protocol.name";

                /// <summary>
                /// Version of the application layer protocol used. See note below.
                /// </summary>
                /// <remarks>
                /// `network.protocol.version` refers to the version of the protocol used and might be
                /// different from the protocol client's version. If the HTTP client used has a version
                /// of `0.27.2`, but sends HTTP version `1.1`, this attribute should be set to `1.1`.
                /// </remarks>
                public const string Version = $"{Prefix}.network.protocol.version";
            }
        }
    }
}
