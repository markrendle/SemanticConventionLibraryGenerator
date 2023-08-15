namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Rpc
    {
        public static partial class Jsonrpc
        {
            public static partial class Rpc
            {
                public const string Prefix = "rpc.jsonrpc.rpc";

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
}
