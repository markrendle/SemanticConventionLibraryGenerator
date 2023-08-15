namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Http
    {
        public static partial class Url
        {
            public const string Prefix = "http.url";

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
}
