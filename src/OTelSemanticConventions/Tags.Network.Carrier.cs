namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Network
    {
        public static partial class Carrier
        {
            public const string Prefix = "network.carrier";

            /// <summary>
            /// The name of the mobile carrier.
            /// </summary>
            public const string Name = $"{Prefix}.carrier.name";

            /// <summary>
            /// The mobile carrier country code.
            /// </summary>
            public const string Mcc = $"{Prefix}.carrier.mcc";

            /// <summary>
            /// The mobile carrier network code.
            /// </summary>
            public const string Mnc = $"{Prefix}.carrier.mnc";

            /// <summary>
            /// The ISO 3166-1 alpha-2 2-character country code associated with the mobile carrier network.
            /// </summary>
            public const string Icc = $"{Prefix}.carrier.icc";
        }
    }
}
