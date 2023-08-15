namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Messaging
    {
        public static partial class Kafka
        {
            public static partial class Destination
            {
                public const string Prefix = "messaging.kafka.destination";

                /// <summary>
                /// Partition the message is sent to.
                /// </summary>
                public const string Partition = $"{Prefix}.destination.partition";
            }
        }
    }
}
