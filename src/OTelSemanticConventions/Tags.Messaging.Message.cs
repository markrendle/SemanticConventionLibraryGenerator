namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Messaging
    {
        public static partial class Message
        {
            public const string Prefix = "messaging.message";

            /// <summary>
            /// A value used by the messaging system as an identifier for the message, represented as a string.
            /// </summary>
            public const string Id = $"{Prefix}.message.id";

            /// <summary>
            /// The [conversation ID](#conversations) identifying the conversation to which the message belongs, represented as a string. Sometimes called "Correlation ID".
            /// </summary>
            public const string ConversationId = $"{Prefix}.message.conversation_id";

            /// <summary>
            /// The (uncompressed) size of the message payload in bytes. Also use this attribute if it is unknown whether the compressed or uncompressed payload size is reported.
            /// </summary>
            public const string PayloadSizeBytes = $"{Prefix}.message.payload_size_bytes";

            /// <summary>
            /// The compressed size of the message payload in bytes.
            /// </summary>
            public const string PayloadCompressedSizeBytes = $"{Prefix}.message.payload_compressed_size_bytes";
        }
    }
}
