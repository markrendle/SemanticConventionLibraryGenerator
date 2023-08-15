namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Rpc
    {
        public const string Prefix = "rpc";

        /// <summary>
        /// A string identifying the remoting system. See below for a list of well-known identifiers.
        /// </summary>
        public const string System = $"{Prefix}.system";

        /// <summary>
        /// The full (logical) name of the service being called, including its package name, if applicable.
        /// </summary>
        /// <remarks>
        /// This is the logical name of the service from the RPC interface perspective, which
        /// can be different from the name of any implementing class. The `code.namespace` attribute
        /// may be used to store the latter (despite the attribute name, it may include a class
        /// name; e.g., class with method actually executing the call on the server side, RPC
        /// client stub class on the client side).
        /// </remarks>
        public const string Service = $"{Prefix}.service";

        /// <summary>
        /// The name of the (logical) method being called, must be equal to the $method part in the span name.
        /// </summary>
        /// <remarks>
        /// This is the logical name of the method from the RPC interface perspective, which
        /// can be different from the name of any implementing method/function. The `code.function`
        /// attribute may be used to store the latter (e.g., method actually executing the call
        /// on the server side, RPC client stub method on the client side).
        /// </remarks>
        public const string Method = $"{Prefix}.method";

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
