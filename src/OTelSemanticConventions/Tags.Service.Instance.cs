namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Service
    {
        public static partial class Instance
        {
            public const string Prefix = "service.instance";

            /// <summary>
            /// The string ID of the service instance.
            /// </summary>
            /// <remarks>
            /// MUST be unique for each instance of the same `service.namespace,service.name` pair
            /// (in other words `service.namespace,service.name,service.instance.id` triplet MUST
            /// be globally unique). The ID helps to distinguish instances of the same service that
            /// exist at the same time (e.g. instances of a horizontally scaled service). It is preferable
            /// for the ID to be persistent and stay the same for the lifetime of the service instance,
            /// however it is acceptable that the ID is ephemeral and changes during important lifetime
            /// events for the service (e.g. service restarts). If the service has no inherent unique
            /// ID that can be used as the value of this attribute it is recommended to generate
            /// a random Version 1 or Version 4 RFC 4122 UUID (services aiming for reproducible UUIDs
            /// may also use Version 5, see RFC 4122 for more recommendations).
            /// </remarks>
            /// <example>
            /// e.g. <c>my-k8s-pod-deployment-1</c>, <c>627cc493-f310-47de-96bd-71410b7dec09</c>
            /// </example>
            public const string Id = $"{Prefix}.instance.id";
        }
    }
}
