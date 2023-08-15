namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Messaging
    {
        public static partial class DestinationPublish
        {
            public const string Prefix = "messaging.destination_publish";

            /// <summary>
            /// The name of the original destination the message was published to
            /// </summary>
            /// <remarks>
            /// The name SHOULD uniquely identify a specific queue, topic, or other entity within
            /// the broker. If the broker does not have such notion, the original destination name
            /// SHOULD uniquely identify the broker.
            /// </remarks>
            /// <example>
            /// e.g. <c>MyQueue</c>, <c>MyTopic</c>
            /// </example>
            public const string Name = $"{Prefix}.name";

            /// <summary>
            /// A boolean that is true if the publish message destination is anonymous (could be unnamed or have auto-generated name).
            /// </summary>
            public const string Anonymous = $"{Prefix}.anonymous";
        }
    }
}
