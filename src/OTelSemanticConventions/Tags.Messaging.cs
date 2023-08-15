namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Messaging
    {
        public const string Prefix = "messaging";

        /// <summary>
        /// A string identifying the messaging system.
        /// </summary>
        /// <example>
        /// e.g. <c>kafka</c>, <c>rabbitmq</c>, <c>rocketmq</c>, <c>activemq</c>, <c>AmazonSQS</c>
        /// </example>
        public const string System = $"{Prefix}.system";

        /// <summary>
        /// A string identifying the kind of messaging operation as defined in the [Operation names](#operation-names) section above.
        /// </summary>
        /// <remarks>
        /// If a custom value is used, it MUST be of low cardinality.
        /// </remarks>
        public const string Operation = $"{Prefix}.operation";

        /// <summary>
        /// A unique identifier for the client that consumes or produces a message.
        /// </summary>
        /// <example>
        /// e.g. <c>client-5</c>, <c>myhost@8742@s8083jm</c>
        /// </example>
        public const string ClientId = $"{Prefix}.client_id";

        /// <summary>
        /// The message destination name
        /// </summary>
        /// <remarks>
        /// Destination name SHOULD uniquely identify a specific queue, topic or other entity
        /// within the broker. If the broker does not have such notion, the destination name
        /// SHOULD uniquely identify the broker.
        /// </remarks>
        /// <example>
        /// e.g. <c>MyQueue</c>, <c>MyTopic</c>
        /// </example>
        public const string Name = $"{Prefix}.messaging.destination.name";

        /// <summary>
        /// Low cardinality representation of the messaging destination name
        /// </summary>
        /// <remarks>
        /// Destination names could be constructed from templates. An example would be a destination
        /// name involving a user name or product id. Although the destination name in this case
        /// is of high cardinality, the underlying template is of low cardinality and can be
        /// effectively used for grouping and aggregation.
        /// </remarks>
        /// <example>
        /// e.g. <c>/customers/{customerId}</c>
        /// </example>
        public const string Template = $"{Prefix}.messaging.destination.template";

        /// <summary>
        /// A boolean that is true if the message destination is temporary and might not exist anymore after messages are processed.
        /// </summary>
        public const string Temporary = $"{Prefix}.messaging.destination.temporary";

        /// <summary>
        /// A boolean that is true if the message destination is anonymous (could be unnamed or have auto-generated name).
        /// </summary>
        public const string Anonymous = $"{Prefix}.messaging.destination.anonymous";

        /// <summary>
        /// [OSI Transport Layer](https://osi-model.com/transport-layer/) or [Inter-process Communication method](https://en.wikipedia.org/wiki/Inter-process_communication). The value SHOULD be normalized to lowercase.
        /// </summary>
        /// <example>
        /// e.g. <c>tcp</c>, <c>udp</c>
        /// </example>
        public const string Transport = $"{Prefix}.network.transport";

        /// <summary>
        /// [OSI Network Layer](https://osi-model.com/network-layer/) or non-OSI equivalent. The value SHOULD be normalized to lowercase.
        /// </summary>
        /// <example>
        /// e.g. <c>ipv4</c>, <c>ipv6</c>
        /// </example>
        public const string Type = $"{Prefix}.network.type";
    }
}
