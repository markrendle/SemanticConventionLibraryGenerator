namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Container
    {
        public static partial class Image
        {
            public const string Prefix = "container.image";

            /// <summary>
            /// Name of the image the container was built on.
            /// </summary>
            /// <example>
            /// e.g. <c>gcr.io/opentelemetry/operator</c>
            /// </example>
            public const string Name = $"{Prefix}.image.name";

            /// <summary>
            /// Container image tag.
            /// </summary>
            /// <example>
            /// e.g. <c>0.1</c>
            /// </example>
            public const string Tag = $"{Prefix}.image.tag";

            /// <summary>
            /// Runtime specific image identifier. Usually a hash algorithm followed by a UUID.
            /// </summary>
            /// <remarks>
            /// Docker defines a sha256 of the image id; `container.image.id` corresponds to the
            /// `Image` field from the Docker container inspect [API](https://docs.docker.com/engine/api/v1.43/#tag/Container/operation/ContainerInspect)
            /// endpoint. K8s defines a link to the container registry repository with digest `"imageID":
            /// "registry.azurecr.io /namespace/service/dockerfile@sha256:bdeabd40c3a8a492eaf9e8e44d0ebbb84bac7ee25ac0cf8a7159d25f62555625"`.
            /// OCI defines a digest of manifest.
            /// </remarks>
            /// <example>
            /// e.g. <c>sha256:19c92d0a00d1b66d897bceaa7319bee0dd38a10a851c60bcec9474aa3f01e50f</c>
            /// </example>
            public const string Id = $"{Prefix}.image.id";
        }
    }
}
