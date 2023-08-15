namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Messaging
    {
        public static partial class Rocketmq
        {
            public static partial class Message
            {
                public const string Prefix = "messaging.rocketmq.message";

                /// <summary>
                /// The timestamp in milliseconds that the delay message is expected to be delivered to consumer.
                /// </summary>
                public const string DeliveryTimestamp = $"{Prefix}.message.delivery_timestamp";

                /// <summary>
                /// The delay time level for delay message, which determines the message delay time.
                /// </summary>
                public const string DelayTimeLevel = $"{Prefix}.message.delay_time_level";

                /// <summary>
                /// It is essential for FIFO message. Messages that belong to the same message group are always processed one by one within the same consumer group.
                /// </summary>
                public const string Group = $"{Prefix}.message.group";

                /// <summary>
                /// Type of message.
                /// </summary>
                public const string Type = $"{Prefix}.message.type";

                /// <summary>
                /// The secondary classifier of message besides topic.
                /// </summary>
                public const string Tag = $"{Prefix}.message.tag";

                /// <summary>
                /// Key(s) of message, another way to mark message besides message id.
                /// </summary>
                /// <example>
                /// e.g. <c>keyA</c>, <c>keyB</c>
                /// </example>
                public const string Keys = $"{Prefix}.message.keys";
            }
        }
    }
}
