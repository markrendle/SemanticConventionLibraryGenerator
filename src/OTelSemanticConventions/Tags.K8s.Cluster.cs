namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class K8s
    {
        public static partial class Cluster
        {
            public const string Prefix = "k8s.cluster";

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            /// <example>
            /// e.g. <c>opentelemetry-cluster</c>
            /// </example>
            public const string Name = $"{Prefix}.name";

            /// <summary>
            /// A pseudo-ID for the cluster, set to the UID of the `kube-system` namespace.
            /// </summary>
            /// <remarks>
            /// K8s does not have support for obtaining a cluster ID. If this is ever added, we will
            /// recommend collecting the `k8s.cluster.uid` through the official APIs. In the meantime,
            /// we are able to use the `uid` of the `kube-system` namespace as a proxy for cluster
            /// ID. Read on for the rationale. Every object created in a K8s cluster is assigned
            /// a distinct UID. The `kube-system` namespace is used by Kubernetes itself and will
            /// exist for the lifetime of the cluster. Using the `uid` of the `kube-system` namespace
            /// is a reasonable proxy for the K8s ClusterID as it will only change if the cluster
            /// is rebuilt. Furthermore, Kubernetes UIDs are UUIDs as standardized by [ISO/IEC 9834-8
            /// and ITU-T X.667](https://www.itu.int/ITU-T/studygroups/com17/oid.html). Which states:
            /// > If generated according to one of the mechanisms defined in Rec. ITU-T X.667 | ISO/IEC
            /// 9834-8, a UUID is either guaranteed to be different from all other UUIDs generated
            /// before 3603 A.D., or is extremely likely to be different (depending on the mechanism
            /// chosen). Therefore, UIDs between clusters should be extremely unlikely to conflict.
            /// </remarks>
            /// <example>
            /// e.g. <c>218fc5a9-a5f1-4b54-aa05-46717d0ab26d</c>
            /// </example>
            public const string Uid = $"{Prefix}.uid";
        }
    }
}
