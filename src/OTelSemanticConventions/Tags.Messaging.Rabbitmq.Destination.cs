namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Messaging
    {
        public static partial class Rabbitmq
        {
            public static partial class Destination
            {
                public const string Prefix = "messaging.rabbitmq.destination";

                /// <summary>
                /// RabbitMQ message routing key.
                /// </summary>
                public const string RoutingKey = $"{Prefix}.destination.routing_key";
            }
        }
    }
}
