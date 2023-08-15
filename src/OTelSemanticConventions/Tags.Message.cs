namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Message
    {
        public const string Prefix = "message";

        /// <summary>
        /// Whether this is a received or sent message.
        /// </summary>
        public const string Type = $"{Prefix}.type";

        /// <summary>
        /// MUST be calculated as two different counters starting from `1` one for sent messages and one for received message.
        /// </summary>
        /// <remarks>
        /// This way we guarantee that the values will be consistent between different implementations.
        /// </remarks>
        public const string Id = $"{Prefix}.id";

        /// <summary>
        /// Compressed size of the message in bytes.
        /// </summary>
        public const string CompressedSize = $"{Prefix}.compressed_size";

        /// <summary>
        /// Uncompressed size of the message in bytes.
        /// </summary>
        public const string UncompressedSize = $"{Prefix}.uncompressed_size";
    }
}
