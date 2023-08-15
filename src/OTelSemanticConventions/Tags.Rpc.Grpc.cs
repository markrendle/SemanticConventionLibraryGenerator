namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Rpc
    {
        public static partial class Grpc
        {
            public const string Prefix = "rpc.grpc";

            /// <summary>
            /// The [numeric status code](https://github.com/grpc/grpc/blob/v1.33.2/doc/statuscodes.md) of the gRPC request.
            /// </summary>
            public const string StatusCode = $"{Prefix}.status_code";
        }
    }
}
