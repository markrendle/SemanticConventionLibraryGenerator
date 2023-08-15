namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Network
        {
            public const string Prefix = "db.network";

            /// <summary>
            /// [OSI Transport Layer](https://osi-model.com/transport-layer/) or [Inter-process Communication method](https://en.wikipedia.org/wiki/Inter-process_communication). The value SHOULD be normalized to lowercase.
            /// </summary>
            /// <example>
            /// e.g. <c>tcp</c>, <c>udp</c>
            /// </example>
            public const string Transport = $"{Prefix}.network.transport";

            /// <summary>
            /// [OSI Network Layer](https://osi-model.com/network-layer/) or non-OSI equivalent. The value SHOULD be normalized to lowercase.
            /// </summary>
            /// <example>
            /// e.g. <c>ipv4</c>, <c>ipv6</c>
            /// </example>
            public const string Type = $"{Prefix}.network.type";
        }
    }
}
