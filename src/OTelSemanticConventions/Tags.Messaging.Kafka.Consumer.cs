namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Messaging
    {
        public static partial class Kafka
        {
            public static partial class Consumer
            {
                public const string Prefix = "messaging.kafka.consumer";

                /// <summary>
                /// Name of the Kafka Consumer Group that is handling the message. Only applies to consumers, not producers.
                /// </summary>
                public const string Group = $"{Prefix}.consumer.group";
            }
        }
    }
}
