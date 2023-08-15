namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Client
    {
        public static partial class Socket
        {
            public const string Prefix = "client.socket";

            /// <summary>
            /// Immediate client peer address - unix domain socket name, IPv4 or IPv6 address.
            /// </summary>
            /// <example>
            /// e.g. <c>/tmp/my.sock</c>, <c>127.0.0.1</c>
            /// </example>
            public const string Address = $"{Prefix}.socket.address";

            /// <summary>
            /// Immediate client peer port number
            /// </summary>
            /// <example>
            /// e.g. <c>35555</c>
            /// </example>
            public const string Port = $"{Prefix}.socket.port";
        }
    }
}
