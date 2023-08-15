namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class K8s
    {
        public static partial class Daemonset
        {
            public const string Prefix = "k8s.daemonset";

            /// <summary>
            /// The UID of the DaemonSet.
            /// </summary>
            /// <example>
            /// e.g. <c>275ecb36-5aa8-4c2a-9c47-d8bb681b9aff</c>
            /// </example>
            public const string Uid = $"{Prefix}.uid";

            /// <summary>
            /// The name of the DaemonSet.
            /// </summary>
            /// <example>
            /// e.g. <c>opentelemetry</c>
            /// </example>
            public const string Name = $"{Prefix}.name";
        }
    }
}
