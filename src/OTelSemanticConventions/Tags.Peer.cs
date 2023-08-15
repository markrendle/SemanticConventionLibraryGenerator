namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Peer
    {
        public const string Prefix = "peer";

        /// <summary>
        /// The [`service.name`](/docs/resource/README.md#service) of the remote service. SHOULD be equal to the actual `service.name` resource attribute of the remote service if any.
        /// </summary>
        public const string Service = $"{Prefix}.service";
    }
}
