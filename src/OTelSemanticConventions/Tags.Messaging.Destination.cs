namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Messaging
    {
        public static partial class Destination
        {
            public const string Prefix = "messaging.destination";

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
            public const string Name = $"{Prefix}.name";

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
            public const string Template = $"{Prefix}.template";

            /// <summary>
            /// A boolean that is true if the message destination is temporary and might not exist anymore after messages are processed.
            /// </summary>
            public const string Temporary = $"{Prefix}.temporary";

            /// <summary>
            /// A boolean that is true if the message destination is anonymous (could be unnamed or have auto-generated name).
            /// </summary>
            public const string Anonymous = $"{Prefix}.anonymous";
        }
    }
}
