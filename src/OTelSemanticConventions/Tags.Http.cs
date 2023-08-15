namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Http
    {
        public const string Prefix = "http";

        /// <summary>
        /// The matched route (path template in the format used by the respective server framework). See note below
        /// </summary>
        /// <remarks>
        /// MUST NOT be populated when this is not supported by the HTTP server framework as
        /// the route attribute should have low-cardinality and the URI path can NOT substitute
        /// it. SHOULD include the [application root](/docs/http/http-spans.md#http-server-definitions)
        /// if there is one.
        /// </remarks>
        /// <example>
        /// e.g. <c>/users/:userID?</c>, <c>{controller}/{action}/{id?}</c>
        /// </example>
        public const string Route = $"{Prefix}.route";

        /// <summary>
        /// The ordinal number of request resending attempt (for any reason, including redirects).
        /// </summary>
        /// <remarks>
        /// The resend count SHOULD be updated each time an HTTP request gets resent by the client,
        /// regardless of what was the cause of the resending (e.g. redirection, authorization
        /// failure, 503 Server Unavailable, network issues, or any other).
        /// </remarks>
        public const string ResendCount = $"{Prefix}.resend_count";

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
        /// Value of the [HTTP User-Agent](https://www.rfc-editor.org/rfc/rfc9110.html#field.user-agent) header sent by the client.
        /// </summary>
        /// <example>
        /// e.g. <c>CERN-LineMode/2.15 libwww/2.17b3</c>
        /// </example>
        public const string Original = $"{Prefix}.user_agent.original";

        /// <summary>
        /// Absolute URL describing a network resource according to [RFC3986](https://www.rfc-editor.org/rfc/rfc3986)
        /// </summary>
        /// <remarks>
        /// For network calls, URL usually has `scheme://host[:port][path][?query][#fragment]`
        /// format, where the fragment is not transmitted over HTTP, but if it is known, it should
        /// be included nevertheless. `url.full` MUST NOT contain credentials passed via URL
        /// in form of `https://username:password@www.example.com/`. In such case username and
        /// password should be redacted and attribute's value should be `https://REDACTED:REDACTED@www.example.com/`.
        /// `url.full` SHOULD capture the absolute URL when it is available (or can be reconstructed)
        /// and SHOULD NOT be validated or modified except for sanitizing purposes.
        /// </remarks>
        /// <example>
        /// e.g. <c>https://www.foo.bar/search?q=OpenTelemetry#SemConv</c>, <c>//localhost</c>
        /// </example>
        public const string Full = $"{Prefix}.url.full";

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

        /// <summary>
        /// The [URI path](https://www.rfc-editor.org/rfc/rfc3986#section-3.3) component
        /// </summary>
        /// <remarks>
        /// When missing, the value is assumed to be `/`
        /// </remarks>
        /// <example>
        /// e.g. <c>/search</c>
        /// </example>
        public const string Path = $"{Prefix}.url.path";

        /// <summary>
        /// The [URI query](https://www.rfc-editor.org/rfc/rfc3986#section-3.4) component
        /// </summary>
        /// <remarks>
        /// Sensitive content provided in query string SHOULD be scrubbed when instrumentations
        /// can identify it.
        /// </remarks>
        /// <example>
        /// e.g. <c>q=OpenTelemetry</c>
        /// </example>
        public const string Query = $"{Prefix}.url.query";
    }
}
