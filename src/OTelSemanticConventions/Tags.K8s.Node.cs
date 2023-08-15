namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class K8s
    {
        public static partial class Node
        {
            public const string Prefix = "k8s.node";

            /// <summary>
            /// The name of the Node.
            /// </summary>
            /// <example>
            /// e.g. <c>node-1</c>
            /// </example>
            public const string Name = $"{Prefix}.name";

            /// <summary>
            /// The UID of the Node.
            /// </summary>
            /// <example>
            /// e.g. <c>1eb3a0c6-0477-4080-a9cb-0cb7db65c6a2</c>
            /// </example>
            public const string Uid = $"{Prefix}.uid";
        }
    }
}
