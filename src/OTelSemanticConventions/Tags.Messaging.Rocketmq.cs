namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Messaging
    {
        public static partial class Rocketmq
        {
            public const string Prefix = "messaging.rocketmq";

            /// <summary>
            /// Namespace of RocketMQ resources, resources in different namespaces are individual.
            /// </summary>
            public const string Namespace = $"{Prefix}.namespace";

            /// <summary>
            /// Name of the RocketMQ producer/consumer group that is handling the message. The client type is identified by the SpanKind.
            /// </summary>
            public const string ClientGroup = $"{Prefix}.client_group";

            /// <summary>
            /// Model of message consumption. This only applies to consumer spans.
            /// </summary>
            public const string ConsumptionModel = $"{Prefix}.consumption_model";
        }
    }
}
