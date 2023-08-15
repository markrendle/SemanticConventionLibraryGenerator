namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Rpc
    {
        public static partial class Client
        {
            public const string Prefix = "rpc.client";

            /// <summary>
            /// Client address - unix domain socket name, IPv4 or IPv6 address.
            /// </summary>
            /// <remarks>
            /// When observed from the server side, and when communicating through an intermediary,
            /// `client.address` SHOULD represent client address behind any intermediaries (e.g.
            /// proxies) if it's available.
            /// </remarks>
            /// <example>
            /// e.g. <c>/tmp/my.sock</c>, <c>10.1.2.80</c>
            /// </example>
            public const string Address = $"{Prefix}.client.address";

            /// <summary>
            /// Client port number
            /// </summary>
            /// <remarks>
            /// When observed from the server side, and when communicating through an intermediary,
            /// `client.port` SHOULD represent client port behind any intermediaries (e.g. proxies)
            /// if it's available.
            /// </remarks>
            /// <example>
            /// e.g. <c>65123</c>
            /// </example>
            public const string Port = $"{Prefix}.client.port";
        }
    }
}
