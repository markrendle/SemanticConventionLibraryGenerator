namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class K8s
    {
        public static partial class Replicaset
        {
            public const string Prefix = "k8s.replicaset";

            /// <summary>
            /// The UID of the ReplicaSet.
            /// </summary>
            /// <example>
            /// e.g. <c>275ecb36-5aa8-4c2a-9c47-d8bb681b9aff</c>
            /// </example>
            public const string Uid = $"{Prefix}.uid";

            /// <summary>
            /// The name of the ReplicaSet.
            /// </summary>
            /// <example>
            /// e.g. <c>opentelemetry</c>
            /// </example>
            public const string Name = $"{Prefix}.name";
        }
    }
}
