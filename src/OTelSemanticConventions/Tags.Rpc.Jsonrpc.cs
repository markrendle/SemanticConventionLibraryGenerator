namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Rpc
    {
        public static partial class Jsonrpc
        {
            public const string Prefix = "rpc.jsonrpc";

            /// <summary>
            /// Protocol version as in `jsonrpc` property of request/response. Since JSON-RPC 1.0 does not specify this, the value can be omitted.
            /// </summary>
            /// <example>
            /// e.g. <c>2.0</c>, <c>1.0</c>
            /// </example>
            public const string Version = $"{Prefix}.version";

            /// <summary>
            /// `id` property of request or response. Since protocol allows id to be int, string, `null` or missing (for notifications), value is expected to be cast to string for simplicity. Use empty string in case of `null` value. Omit entirely if this is a notification.
            /// </summary>
            /// <example>
            /// e.g. <c>10</c>, <c>request-7</c>
            /// </example>
            public const string RequestId = $"{Prefix}.request_id";

            /// <summary>
            /// `error.code` property of response if it is an error response.
            /// </summary>
            /// <example>
            /// e.g. <c>-32700</c>, <c>100</c>
            /// </example>
            public const string ErrorCode = $"{Prefix}.error_code";

            /// <summary>
            /// `error.message` property of response if it is an error response.
            /// </summary>
            /// <example>
            /// e.g. <c>Parse error</c>, <c>User already exists</c>
            /// </example>
            public const string ErrorMessage = $"{Prefix}.error_message";

            /// <summary>
            /// The name of the (logical) method being called, must be equal to the $method part in the span name.
            /// </summary>
            /// <remarks>
            /// This is the logical name of the method from the RPC interface perspective, which
            /// can be different from the name of any implementing method/function. The `code.function`
            /// attribute may be used to store the latter (e.g., method actually executing the call
            /// on the server side, RPC client stub method on the client side).
            /// </remarks>
            public const string Method = $"{Prefix}.rpc.method";
        }
    }
}
