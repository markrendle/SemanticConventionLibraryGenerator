namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class K8s
    {
        public static partial class Namespace
        {
            public const string Prefix = "k8s.namespace";

            /// <summary>
            /// The name of the namespace that the pod is running in.
            /// </summary>
            /// <example>
            /// e.g. <c>default</c>
            /// </example>
            public const string Name = $"{Prefix}.name";
        }
    }
}
