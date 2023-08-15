namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Rpc
    {
        public static partial class ConnectRpc
        {
            public const string Prefix = "rpc.connect_rpc";

            /// <summary>
            /// The [error codes](https://connect.build/docs/protocol/#error-codes) of the Connect request. Error codes are always string values.
            /// </summary>
            public const string ErrorCode = $"{Prefix}.error_code";
        }
    }
}
