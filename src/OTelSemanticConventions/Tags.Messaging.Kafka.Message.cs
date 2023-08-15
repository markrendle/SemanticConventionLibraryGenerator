namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Messaging
    {
        public static partial class Kafka
        {
            public static partial class Message
            {
                public const string Prefix = "messaging.kafka.message";

                /// <summary>
                /// Message keys in Kafka are used for grouping alike messages to ensure they're processed on the same partition. They differ from `messaging.message.id` in that they're not unique. If the key is `null`, the attribute MUST NOT be set.
                /// </summary>
                /// <remarks>
                /// If the key type is not string, it's string representation has to be supplied for
                /// the attribute. If the key has no unambiguous, canonical string form, don't include
                /// its value.
                /// </remarks>
                public const string Key = $"{Prefix}.message.key";

                /// <summary>
                /// The offset of a record in the corresponding Kafka partition.
                /// </summary>
                public const string Offset = $"{Prefix}.message.offset";

                /// <summary>
                /// A boolean that is true if the message is a tombstone.
                /// </summary>
                public const string Tombstone = $"{Prefix}.message.tombstone";
            }
        }
    }
}
