namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Network
    {
        public static partial class Connection
        {
            public const string Prefix = "network.connection";

            /// <summary>
            /// The internet connection type.
            /// </summary>
            public const string Type = $"{Prefix}.connection.type";

            /// <summary>
            /// This describes more details regarding the connection.type. It may be the type of cell technology connection, but it could be used for describing details about a wifi connection.
            /// </summary>
            public const string Subtype = $"{Prefix}.connection.subtype";
        }
    }
}
