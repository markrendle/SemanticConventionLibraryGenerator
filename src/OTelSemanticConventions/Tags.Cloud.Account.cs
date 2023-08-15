namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Cloud
    {
        public static partial class Account
        {
            public const string Prefix = "cloud.account";

            /// <summary>
            /// The cloud account ID the resource is assigned to.
            /// </summary>
            /// <example>
            /// e.g. <c>111111111111</c>, <c>opentelemetry</c>
            /// </example>
            public const string Id = $"{Prefix}.account.id";
        }
    }
}
