namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Messaging
    {
        public static partial class Batch
        {
            public const string Prefix = "messaging.batch";

            /// <summary>
            /// The number of messages sent, received, or processed in the scope of the batching operation.
            /// </summary>
            /// <remarks>
            /// Instrumentations SHOULD NOT set `messaging.batch.message_count` on spans that operate
            /// with a single message. When a messaging client library supports both batch and single-message
            /// API for the same operation, instrumentations SHOULD use `messaging.batch.message_count`
            /// for batching APIs and SHOULD NOT use it for single-message APIs.
            /// </remarks>
            /// <example>
            /// e.g. <c>0</c>, <c>1</c>, <c>2</c>
            /// </example>
            public const string MessageCount = $"{Prefix}.batch.message_count";
        }
    }
}
